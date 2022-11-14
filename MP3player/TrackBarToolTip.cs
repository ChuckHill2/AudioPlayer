//--------------------------------------------------------------------------
// <summary>
//   
// </summary>
// <copyright file="TrackBarToolTip.cs" company="Chuck Hill">
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
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MP3player
{
    public class TrackBarTooltip : Label
    {
        // Create our own lightweight numerical tooltip for the trackbar thumb movement.
        // A real tooltip will spaz and lock up after a while and I don't want to deal with it.

        private Form Owner;
        int _value = 0;
        int Value
        {
            get => _value;
            set
            {
                _value = value;
                base.Text = value.ToString();
            }
        }

        public TrackBarTooltip(Form owner) : base()
        {
            Owner = owner;
            owner.Controls.Add(this);
            owner.Controls.SetChildIndex(this, 0);
            base.BorderStyle = BorderStyle.FixedSingle;
            base.AutoSize = true;
            base.BackColor = Color.AliceBlue;
        }

        public void Show(Control c, int value)
        {
            if (c is TrackBar)
            {
                //T ToDo: to be generic, need to support trackbar orientation. But this is good enough for us.

                //Get thumb/slider rect in context of top-left corner of trackbar client area.
                var rc = GetSliderRect((TrackBar)c);
                //Get (nested?) bounds of the trackbar control in context of Owner client area.
                var rcOwner = Owner.RectangleToClient(c.RectangleToScreen(c.ClientRectangle));
                //shift the thumb rect into the coordinates of Owner client area.
                rc.Offset(rcOwner.Location);

                Show(c, value, rc.Right + 2, rc.Top);
            }
            else Show(c, value, Owner.PointToClient(Cursor.Position));
        }
        public void Show(Control c, int value, int x, int y) => Show(c, value, new Point(x, y));
        public void Show(Control c, int value, Point pt)
        {
            base.SuspendLayout();
            base.Location = pt;
            this.Value = value;
            base.Visible = true;
            base.Invalidate();
            base.ResumeLayout();
        }

        public void Hide(Control dummy = null)
        {
            //'dummy' exists only to simulate ToolTip.Hide()
            base.Hide();
        }

        private const int TBM_GETCHANNELRECT = 0x400 + 26;
        private const int TBM_GETTHUMBRECT = 0x400 + 25;
        private struct RECT { public int left, top, right, bottom; }
        [DllImport("user32.dll", EntryPoint = "SendMessageW")]
        private static extern IntPtr SendMessageRect(IntPtr hWnd, int msg, IntPtr wp, ref RECT lp);

        //Coordinates in context of Trackbar client area.
        Rectangle GetSliderRect(TrackBar c)
        {
            RECT rc = new RECT();
            SendMessageRect(c.Handle, TBM_GETTHUMBRECT, IntPtr.Zero, ref rc);
            return new Rectangle(rc.left, rc.top, rc.right - rc.left, rc.bottom - rc.top);
        }

        //Coordinates in context of Trackbar client area.
        Rectangle GetChannelRect(TrackBar c)
        {
            RECT rc = new RECT();
            SendMessageRect(c.Handle, TBM_GETCHANNELRECT, IntPtr.Zero, ref rc);
            return new Rectangle(rc.left, rc.top, rc.right - rc.left, rc.bottom - rc.top);
        }
    }
}
