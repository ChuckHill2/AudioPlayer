//--------------------------------------------------------------------------
// <summary>
//   
// </summary>
// <copyright file="MainPlayer.cs" company="Chuck Hill">
// Copyright (c) 2020 Chuck Hill.
//
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public License
// as published by the Free Software Foundation; either version 2.1
// of the License, or (at your option) any later version.
//
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// The GNU Lesser General Public License can be viewed at
// http://www.opensource.org/licenses/lgpl-license.php. If
// you unfamiliar with this license or have questions about
// it, here is an http://www.gnu.org/licenses/gpl-faq.html.
//
// All code and executables are provided "as is" with no warranty
// either express or implied. The author accepts no liability for
// any damage or loss of business that this product may cause.
// </copyright>
// <repository>https://github.com/ChuckHill2/AudioPlayer</repository>
// <author>Chuck Hill</author>
//--------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ChuckHill2.Forms;

// Note: My variable naming convention for controls consists of m_xxxName where xxx is a 2-3 letter identifier for the type of control followed 
// with the name for the control. For example: m_lblFilename, m_txtFilename, and m_btnFilename all refer to entering a filename, where
//    • m_lblXXX refers to the Lable describing the filename.
//    • m_txtXXX is the actual textbox containing the filename
//    • m_btnXXX is button for popping up a selection dialog for the filename..
// This distinguishes controls from other methods and making it much easier to use with Intellisense. Naming conventions for other methods
// and variables mostly follow the usual naming conventions.

namespace MP3player
{
    public partial class FormMain : Form
    {
        AudioPlayer pl = null; //The thing we're demoing.
        Action Looper = null;
        Point MouseButtonPos; //Required for Listbox m_lbPlayList context menu.
        TrackBarTooltip TrackbarScrollTip;
        TimerEx PlayTimer;
        string CurrentPositionLableSuffix = " / 0";
        int AudioLength = 0;

        public FormMain()
        {
            InitializeComponent();

            pl = new AudioPlayer(this);
            pl.PlayStateChanged += Pl_PlayStateChanged;
            pl.VolumeChanged += Pl_VolumeChanged; //adjust the sliders
            //pl.Error += (s, e) => { /*get error code and error message*/ };

            TrackbarScrollTip = new TrackBarTooltip(this); 

            PlayTimer = new TimerEx(this.components); //Extend Timer to add EnabledChanged event
            PlayTimer.Enabled = false;
            PlayTimer.Interval = 10;
            PlayTimer.Tick += (s, e) => SetPlayTrackBarPosition(pl.Position);
            PlayTimer.EnabledChanged += (s, e) => Debug.WriteLine($"PlayTimer.Enabled = {PlayTimer.Enabled}");

            #region TrackBar Initialization
            m_tbLeftVolume.Minimum = AudioPlayer.VolumeMinValue;
            m_tbLeftVolume.Maximum = AudioPlayer.VolumeMaxValue;
            m_tbLeftVolume.LargeChange = (AudioPlayer.VolumeMaxValue - AudioPlayer.VolumeMinValue) / 10;
            m_tbLeftVolume.Value = pl.LeftVolume;
            m_tbLeftVolume.MouseUp += (s, e) => { if (e.Button == MouseButtons.Left) TrackbarScrollTip.Hide(); };
            m_tbLeftVolume.Scroll += (s, e) => TrackbarScrollTip.Show(m_tbLeftVolume, m_tbLeftVolume.Value);
            m_tbLeftVolume.Scroll += (s, e) => pl.LeftVolume = m_tbLeftVolume.Value;
            m_tbLeftVolume.Leave += (s, e) => TrackbarScrollTip.Hide();
            m_chkMuteLeftVolume.Click += (s, e) => pl.MuteLeft = m_chkMuteLeftVolume.Checked; //Don't use event CheckChanged as it triggers a cascade in the VolumeChanged event.

            m_tbRightVolume.Minimum = AudioPlayer.VolumeMinValue;
            m_tbRightVolume.Maximum = AudioPlayer.VolumeMaxValue;
            m_tbRightVolume.LargeChange = (AudioPlayer.VolumeMaxValue - AudioPlayer.VolumeMinValue) / 10;
            m_tbRightVolume.Value = pl.RightVolume;
            m_tbRightVolume.MouseUp += (s, e) => { if (e.Button == MouseButtons.Left) TrackbarScrollTip.Hide(); };
            m_tbRightVolume.Scroll += (s, e) => TrackbarScrollTip.Show(m_tbRightVolume, m_tbRightVolume.Value);
            m_tbRightVolume.Scroll += (s, e) => pl.RightVolume = m_tbRightVolume.Value;
            m_tbRightVolume.Leave += (s, e) => TrackbarScrollTip.Hide();
            m_chkMuteRightVolume.Click += (s, e) => pl.MuteRight = m_chkMuteRightVolume.Checked; //Don't use event CheckChanged as it triggers a cascade in the VolumeChanged event.

            m_tbBalance.Minimum = AudioPlayer.BalanceMinValue;
            m_tbBalance.Maximum = AudioPlayer.BalanceMaxValue;
            m_tbBalance.LargeChange = (AudioPlayer.BalanceMaxValue - AudioPlayer.BalanceMinValue) / 10;
            m_tbBalance.Value = pl.StereoBalance;
            m_tbBalance.MouseUp += (s, e) => { if (e.Button == MouseButtons.Left) TrackbarScrollTip.Hide(); };
            m_tbBalance.Scroll += (s, e) => TrackbarScrollTip.Show(m_tbBalance, m_tbBalance.Value);
            m_tbBalance.Scroll += (s, e) => pl.StereoBalance = m_tbBalance.Value;
            m_tbBalance.Leave += (s, e) => TrackbarScrollTip.Hide();
            m_btnBalanceCenter.Click += (s, e) => { m_tbBalance.Value = AudioPlayer.BalanceCentered; pl.StereoBalance = m_tbBalance.Value; };

            m_tbMasterVolume.Minimum = AudioPlayer.VolumeMinValue;
            m_tbMasterVolume.Maximum = AudioPlayer.VolumeMaxValue;
            m_tbMasterVolume.LargeChange = (AudioPlayer.VolumeMaxValue - AudioPlayer.VolumeMinValue) / 10;
            m_tbMasterVolume.Value = pl.MasterVolume;
            m_tbMasterVolume.MouseUp += (s, e) => { if (e.Button == MouseButtons.Left) TrackbarScrollTip.Hide(); };
            m_tbMasterVolume.Scroll += (s, e) => TrackbarScrollTip.Show(m_tbMasterVolume, m_tbMasterVolume.Value);
            m_tbMasterVolume.Scroll += (s, e) => pl.MasterVolume = m_tbMasterVolume.Value;
            m_tbMasterVolume.Leave += (s, e) => TrackbarScrollTip.Hide();
            m_chkMuteMasterVolume.Click += (s, e) => pl.Mute = m_chkMuteMasterVolume.Checked; //Don't use event CheckChanged as it triggers a cascade in the VolumeChanged event.

            // Don't know why all the other public code regarding mciSendString media type MPEGVideo 
            // implements Bass and Treble when in fact, it is not supported! However, if you really want to 
            // try it out, add the conditional compilation symbol HAS_BASS_TREBLE to the project build.
#if HAS_BASS_TREBLE
            m_tbBassEffect.Minimum = AudioPlayer.VolumeMinValue;
            m_tbBassEffect.Maximum = AudioPlayer.VolumeMaxValue;
            m_tbBassEffect.LargeChange = (AudioPlayer.VolumeMaxValue - AudioPlayer.VolumeMinValue) / 10;
            m_tbBassEffect.Value = pl.Bass;
            m_tbBassEffect.MouseUp += (s, e) => { if (e.Button == MouseButtons.Left) TrackbarScrollTip.Hide(); };
            m_tbBassEffect.Scroll += (s, e) => TrackbarScrollTip.Show(m_tbBassEffect, m_tbBassEffect.Value);
            m_tbBassEffect.Scroll += (s, e) => pl.Bass = m_tbBassEffect.Value;
            m_tbBassEffect.Leave += (s, e) => TrackbarScrollTip.Hide();

            m_tbTrebleEffect.Minimum = AudioPlayer.VolumeMinValue;
            m_tbTrebleEffect.Maximum = AudioPlayer.VolumeMaxValue;
            m_tbTrebleEffect.LargeChange = (AudioPlayer.VolumeMaxValue - AudioPlayer.VolumeMinValue) / 10;
            m_tbTrebleEffect.Value = pl.Treble;
            m_tbTrebleEffect.MouseUp += (s, e) => { if (e.Button == MouseButtons.Left) TrackbarScrollTip.Hide(); };
            m_tbTrebleEffect.Scroll += (s, e) => TrackbarScrollTip.Show(m_tbTrebleEffect, m_tbTrebleEffect.Value);
            m_tbTrebleEffect.Scroll += (s, e) => pl.Treble = m_tbTrebleEffect.Value;
            m_tbTrebleEffect.Leave += (s, e) => TrackbarScrollTip.Hide();
            m_lblBassTrebleDisabled.Visible = false;
#else
            m_tbBassEffect.Enabled = false;
            m_lblBassEffect.Enabled = false;
            m_tbTrebleEffect.Enabled = false;
            m_lblTrebleEffect.Enabled = false;
#endif
            m_tbPlaySpeed.Minimum = AudioPlayer.SpeedMinValue;
            m_tbPlaySpeed.Maximum = AudioPlayer.SpeedMaxValue;
            m_tbPlaySpeed.LargeChange = (AudioPlayer.SpeedMaxValue - AudioPlayer.SpeedMinValue) / 10;
            m_tbPlaySpeed.Value = AudioPlayer.SpeedNormal;
            m_tbPlaySpeed.MouseUp += (s, e) => { if (e.Button == MouseButtons.Left) TrackbarScrollTip.Hide(); };
            m_tbPlaySpeed.Scroll += (s, e) => TrackbarScrollTip.Show(m_tbPlaySpeed, m_tbPlaySpeed.Value);
            m_tbPlaySpeed.Scroll += (s, e) => pl.PlaySpeed = m_tbPlaySpeed.Value;
            m_tbPlaySpeed.Leave += (s, e) => TrackbarScrollTip.Hide();
            m_btnPlaySpeedNormal.Click += (s, e) => { m_tbPlaySpeed.Value = AudioPlayer.SpeedNormal; pl.PlaySpeed = m_tbPlaySpeed.Value; };

            m_tbPlayPosition.Value = 0;
            m_tbPlayPosition.MouseUp += (s, e) => { if (e.Button == MouseButtons.Left) TrackbarScrollTip.Hide(); };
            m_tbPlayPosition.Scroll += (s, e) => TrackbarScrollTip.Show(m_tbPlayPosition, (int)(m_tbPlayPosition.Value/1000.0+0.5));
            m_tbPlayPosition.MouseDown += (s, e) => { if (e.Button == MouseButtons.Left) PlayTimer.Stop(); };
            m_tbPlayPosition.MouseUp += (s, e) =>
            {
                if (e.Button != MouseButtons.Left) return;
                pl.Position = m_tbPlayPosition.Value;
                PlayTimer.Start();
            };
            m_tbPlayPosition.Leave += (s, e) => TrackbarScrollTip.Hide();
#endregion TrackBar Initialization

            m_lbPlayList.MouseDown += (s, e) => MouseButtonPos = e.Location; //Required for context menu.

#region Debug Playlist Prefill
#if DEBUG
            //Assume exe is running from bin\Debug folder
            m_lbPlayList.Items.Add(Path.GetFullPath(@"..\..\Resources\Sounds\CoinWAV.wav"));
            m_lbPlayList.Items.Add(Path.GetFullPath(@"..\..\Resources\Sounds\ElectronicSoundsMP3.mp3"));
            m_lbPlayList.Items.Add(Path.GetFullPath(@"..\..\Resources\Sounds\LightSaberMP3.mp3"));

            m_lbPlayList.SelectedIndex = 0;
            EnablePlayButtons();
#endif
#endregion Debug Playlist Prefill
        }

        private void SetPlayTrackBarPosition(int ms)
        {
            var sec = (int)(ms / 1000.0 + 0.5); // ms to seconds
            m_lblPlayPosition.Text = sec + CurrentPositionLableSuffix;
            m_lblPlayPosition.Invalidate();
            m_tbPlayPosition.Value = ms > m_tbPlayPosition.Maximum ? m_tbPlayPosition.Maximum : ms;
            m_tbPlayPosition.Invalidate();
        }

        private void Pl_PlayStateChanged(AudioPlayer sender, AudioPlayer.NotificationEventArgs e)
        {
            Debug.WriteLine($"Pl_PlayStateChanged: Status={e.Status}, State={e.State}, Looper={Looper != null}");

            // User pressed the stop button aka pl.Close() while clip playing.
            if (e.Status == MCINotify.Aborted && e.State == MCIState.Closed)
            {
                PlayTimer.Stop();
                //Set final position which may be 0 if the state is closed.
                SetPlayTrackBarPosition(pl.Position);
                return;
            }

            // Interrupted a playing clip by playing a new clip.
            if (e.Status == MCINotify.Aborted && e.State == MCIState.Playing)
            {
                //Nothing to do as the new clip is already playing.
                return;
            }

            // Clip played to completion.
            if (e.Status == MCINotify.Successful)
            {
                PlayTimer.Stop();
                //Set final position which may be 0 if the state is closed.
                SetPlayTrackBarPosition(pl.Position);
                if (Looper != null) Looper();
                return;
            }
        }

        private void Pl_VolumeChanged(AudioPlayer sender, AudioPlayer.VolumeChangedEventArgs e)
        {
            Debug.WriteLine($"Pl_VolumeChanged:" +
                $" LV={sender.LeftVolume} RV={sender.RightVolume} MV={sender.MasterVolume} SB={sender.StereoBalance}" +
                $" M={sender.Mute} LM={sender.MuteLeft} RM={sender.MuteRight}");

            if (e.LeftVolume != null) m_tbLeftVolume.Value = (int)e.LeftVolume;
            if (e.RightVolume != null) m_tbRightVolume.Value = (int)e.RightVolume;
            if (e.MasterVolume != null) m_tbMasterVolume.Value = (int)e.MasterVolume;
            if (e.StereoBalance != null) m_tbBalance.Value = (int)e.StereoBalance;
            if (e.Mute != null) VolumeChanged_MuteChanged(m_chkMuteMasterVolume, (bool)e.Mute);
            if (e.MuteLeft != null) VolumeChanged_MuteChanged(m_chkMuteLeftVolume, (bool)e.MuteLeft);
            if (e.MuteRight != null) VolumeChanged_MuteChanged(m_chkMuteRightVolume, (bool)e.MuteRight);
        }
        private static void VolumeChanged_MuteChanged(CheckBox chk, bool state)
        {
            chk.Checked = state;
            chk.Text = state ? "Muted" : "Mute";
            chk.BackgroundImage = state ? global::MP3player.Properties.Resources.Cross39x15 : null;
        }

        private void m_btnOpen_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Title = "Append Multiple Playlists and Audio files to Existing List";
                //var audioFilesFilter = "|All Audio Files|*" + string.Join(";*", AudioPlayer.SupportedTypes().Where(ext=>ext!=".m3u"));
                dlg.Filter = "Playlists|*.wpl;*.m3u" +
                    "|All Audio Files|*.aac;*.adt;*.adts;*.aif;*.aifc;*.aiff;*.au;*.flac;*.m4a;*.mka;*.mp2;*.mp3;*.snd;*.wav;*.wax;*.wma" +
                    "|All Files|*.*";
                dlg.FilterIndex = 2;
                dlg.Multiselect = true;
                if (dlg.ShowDialog(this) != DialogResult.OK) return;
                foreach(var f in ValidateFiles(dlg.FileNames))
                {
                    m_lbPlayList.Items.AddRange(ReadPlaylist.Makeplaylist(f));
                }
                if (m_lbPlayList.Items.Count > 0 && m_lbPlayList.SelectedIndex == -1) m_lbPlayList.SelectedIndex = 0;
                EnablePlayButtons();
            }
        }

        private void m_btnClear_Click(object sender, EventArgs e)
        {
            m_lbPlayList.Items.Clear();
            EnablePlayButtons();
        }

        private void m_lbPlayList_DoubleClick(object sender, System.EventArgs e)
        {
            Looper = null;
            m_btnPlay_Click(m_lbPlayList, EventArgs.Empty);
         }

        private void m_btnPrevious_Click(object sender, EventArgs e)
        {
            Looper = null;
            int kount = m_lbPlayList.Items.Count;
            if (kount == 0) return;
            int i = m_lbPlayList.SelectedIndex;
            if (i == -1) m_lbPlayList.SelectedIndex = 0;
            else m_lbPlayList.SelectedIndex = --i < 0 ? kount - 1 : i;
            m_btnPlay_Click(m_btnPrevious, EventArgs.Empty);
        }

        private void m_btnPlay_Click(object sender, EventArgs e)
        {
            if (m_lbPlayList.Items.Count == 0) return;
            int i = m_lbPlayList.SelectedIndex;
            if (i == -1) m_lbPlayList.SelectedIndex = 0;

            Debug.WriteLine($"Command: {((Control)sender).Name}");
            if (pl.Open(m_lbPlayList.SelectedItem.ToString())) PlayClip();
            else MessageBox.Show(this, pl.LastError, "Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void m_btnLoop_Click(object sender, EventArgs e)
        {
            Looper = () => m_btnNext_Click(m_btnLoop, EventArgs.Empty);
            m_btnPlay_Click(sender, EventArgs.Empty); //play the first one
        }

        private void m_btnRandom_Click(object sender, EventArgs e)
        {
            Looper = () => RandomPlay(m_btnRandom, EventArgs.Empty);
            m_btnPlay_Click(sender, EventArgs.Empty); //play the first one
        }
        Random rand = new Random(Environment.TickCount);
        private void RandomPlay(object sender, EventArgs e)
        {
            int kount = m_lbPlayList.Items.Count;
            if (kount == 0) return;
            var ii = m_lbPlayList.SelectedIndex;
            int i = ii;
            while ((i = rand.Next(0, kount)) == ii) { }
            m_lbPlayList.SelectedIndex = i;
            m_btnPlay_Click(sender, EventArgs.Empty);
        }

        private void m_btnPause_Click(object sender, EventArgs e)
        {
            Debug.WriteLine($"Command: m_btnPause_Click");
            if (pl.State() == MCIState.Playing) pl.Pause();
            else if (pl.State() == MCIState.Paused) pl.Resume();
        }

        private void m_btnStop_Click(object sender, EventArgs e)
        {
            Debug.WriteLine($"Command: m_btnStop_Click");
            Looper = null;
            pl.Close();
        }

        private void m_btnNext_Click(object sender, EventArgs e)
        {
            if (sender != m_btnLoop) Looper = null;
            int kount = m_lbPlayList.Items.Count;
            if (kount == 0) return;
            int i = m_lbPlayList.SelectedIndex;
            if (i == -1) m_lbPlayList.SelectedIndex = 0;
            else m_lbPlayList.SelectedIndex = ++i >= kount ? 0 : i;
            m_btnPlay_Click(sender, EventArgs.Empty);
        }

        private void m_ctxRemoveMenuItem_Click(object sender, EventArgs e)
        {
            //Can't use Cursor.Position because it refers to the ctx menu dropdown menuitem clicked position, not the item right-clicked upon!
            var i = m_lbPlayList.IndexFromPoint(MouseButtonPos);
            if (i == -1) return;

            m_lbPlayList.Items.RemoveAt(i);
            if (m_lbPlayList.Items.Count == 0) m_lbPlayList.ClearSelected();
            else if (m_lbPlayList.SelectedIndex == -1)
            {
                if (i > m_lbPlayList.Items.Count - 1)
                     m_lbPlayList.SelectedIndex = m_lbPlayList.Items.Count - 1;
                else m_lbPlayList.SelectedIndex = m_lbPlayList.Items.Count > 1 ? i - 1 : 0;
            }

            EnablePlayButtons();
        }

        private void m_lbContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            var i = m_lbPlayList.IndexFromPoint(MouseButtonPos);
            if (i == -1)
            {
                e.Cancel = true;
                return;
            }
            m_ctxRemoveMenuItem.Text = "Remove " + Path.GetFileName((string)m_lbPlayList.Items[i]);
        }

        private void m_lbPlayList_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;
            var files = ((string[])e.Data.GetData(DataFormats.FileDrop));

            files = ValidateFiles(files);
            if (files.Length == 0) return;
            e.Effect = DragDropEffects.Link;
        }

        private void m_lbPlayList_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;
            var files = ((string[])e.Data.GetData(DataFormats.FileDrop));

            files = ValidateFiles(files);
            if (files.Length == 0) return;

            foreach (var f in files)
            {
                m_lbPlayList.Items.AddRange(ReadPlaylist.Makeplaylist(f));
            }
            if (m_lbPlayList.Items.Count > 0 && m_lbPlayList.SelectedIndex == -1) m_lbPlayList.SelectedIndex = 0;
            EnablePlayButtons();
        }

        private string[] ValidateFiles(string[] files)
        {
            var exts = new string[] { ".aac", ".adt", ".adts", ".aif", ".aifc", ".aiff", ".au", ".flac", ".m4a", ".mka", ".mp2", ".mp3", ".snd", ".wav", ".wax", ".wma", ".wpl", ".m3u" };
            return files.Where(f => exts.Any(m => f.EndsWith(m, StringComparison.OrdinalIgnoreCase))).OrderBy(m => m).ToArray();
        }

        private void m_btnAction1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine($"Command: {((Control)sender).Name}");
            pl.Open(global::MP3player.Properties.Resources.ElectronicSoundsMP3);
            PlayClip();
        }

        private void m_btnAction2_Click(object sender, EventArgs e)
        {
            Debug.WriteLine($"Command: {((Control)sender).Name}");
            pl.Open(global::MP3player.Properties.Resources.CoinWAV);
            PlayClip();
        }

        private void EnablePlayButtons() => m_pnlPlayButtons.Enabled = m_lbPlayList.Items.Count > 0;

        private void PlayClip()
        {
            AudioLength = pl.AudioLength(); //ms
            CurrentPositionLableSuffix = " / " + ((int)(pl.AudioLength() / 1000.0 + 0.5)).ToString(); //Exclusively used by SetPlayPosition()
            SetPlayTrackBarPosition(0);
            m_tbPlayPosition.Maximum = AudioLength;
            m_tbPlayPosition.LargeChange = (int)(AudioLength / 20.0 + 0.5);
            PlayTimer.Enabled = true;
            pl.Play(false);
        }
     }
}