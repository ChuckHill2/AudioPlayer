namespace MP3player
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.m_btnOpen = new System.Windows.Forms.Button();
            this.m_grpVolume = new System.Windows.Forms.GroupBox();
            this.m_pnlVolume = new System.Windows.Forms.Panel();
            this.m_chkMuteRightVolume = new System.Windows.Forms.CheckBox();
            this.m_chkMuteLeftVolume = new System.Windows.Forms.CheckBox();
            this.m_tbLeftVolume = new System.Windows.Forms.TrackBar();
            this.m_lblLeftVolume = new System.Windows.Forms.Label();
            this.m_tbRightVolume = new System.Windows.Forms.TrackBar();
            this.m_lblRightVolume = new System.Windows.Forms.Label();
            this.m_lbPlayList = new System.Windows.Forms.ListBox();
            this.m_lbContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.m_ctxRemoveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_grpSoundEffects = new System.Windows.Forms.GroupBox();
            this.m_pnlSoundEffects = new System.Windows.Forms.Panel();
            this.m_lblBassTrebleDisabled = new System.Windows.Forms.Label();
            this.m_tbTrebleEffect = new System.Windows.Forms.TrackBar();
            this.m_btnPlaySpeedNormal = new System.Windows.Forms.Button();
            this.m_lblPlaySpeed = new System.Windows.Forms.Label();
            this.m_tbBassEffect = new System.Windows.Forms.TrackBar();
            this.m_lblBassEffect = new System.Windows.Forms.Label();
            this.m_lblTrebleEffect = new System.Windows.Forms.Label();
            this.m_tbPlaySpeed = new System.Windows.Forms.TrackBar();
            this.m_grpSoundEffectsRightBorder = new System.Windows.Forms.GroupBox();
            this.m_btnClear = new System.Windows.Forms.Button();
            this.m_ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.m_btnAction1 = new System.Windows.Forms.Button();
            this.m_btnAction2 = new System.Windows.Forms.Button();
            this.m_btnAction3 = new System.Windows.Forms.Button();
            this.m_btnAction4 = new System.Windows.Forms.Button();
            this.m_btnAction5 = new System.Windows.Forms.Button();
            this.m_btnAction6 = new System.Windows.Forms.Button();
            this.m_btnPrevious = new System.Windows.Forms.Button();
            this.m_btnPlay = new System.Windows.Forms.Button();
            this.m_btnLoop = new System.Windows.Forms.Button();
            this.m_btnRandom = new System.Windows.Forms.Button();
            this.m_btnPause = new System.Windows.Forms.Button();
            this.m_btnStop = new System.Windows.Forms.Button();
            this.m_btnNext = new System.Windows.Forms.Button();
            this.m_tbPlayPosition = new System.Windows.Forms.TrackBar();
            this.m_lblPlayPosition = new System.Windows.Forms.Label();
            this.m_lblPlayPositionSeconds = new System.Windows.Forms.Label();
            this.m_grpBalance = new System.Windows.Forms.GroupBox();
            this.m_pnlBalance = new System.Windows.Forms.Panel();
            this.m_lblBalance = new System.Windows.Forms.Label();
            this.m_lblMasterVolume = new System.Windows.Forms.Label();
            this.m_btnBalanceCenter = new System.Windows.Forms.Button();
            this.m_chkMuteMasterVolume = new System.Windows.Forms.CheckBox();
            this.m_tbMasterVolume = new System.Windows.Forms.TrackBar();
            this.m_tbBalance = new System.Windows.Forms.TrackBar();
            this.m_pnlActionButtons = new System.Windows.Forms.Panel();
            this.m_pnlPlayButtons = new System.Windows.Forms.Panel();
            this.m_grpEmpty = new System.Windows.Forms.GroupBox();
            this.m_divider1 = new ChuckHill2.Forms.Divider();
            this.m_divider2 = new ChuckHill2.Forms.Divider();
            this.m_grpVolume.SuspendLayout();
            this.m_pnlVolume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_tbLeftVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_tbRightVolume)).BeginInit();
            this.m_lbContextMenuStrip.SuspendLayout();
            this.m_grpSoundEffects.SuspendLayout();
            this.m_pnlSoundEffects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_tbTrebleEffect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_tbBassEffect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_tbPlaySpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_tbPlayPosition)).BeginInit();
            this.m_grpBalance.SuspendLayout();
            this.m_pnlBalance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_tbMasterVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_tbBalance)).BeginInit();
            this.m_pnlActionButtons.SuspendLayout();
            this.m_pnlPlayButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_btnOpen
            // 
            this.m_btnOpen.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.m_btnOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.m_btnOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.m_btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_btnOpen.Image = global::MP3player.Properties.Resources.file_open_16;
            this.m_btnOpen.Location = new System.Drawing.Point(16, 12);
            this.m_btnOpen.Name = "m_btnOpen";
            this.m_btnOpen.Size = new System.Drawing.Size(23, 23);
            this.m_btnOpen.TabIndex = 0;
            this.m_ToolTip.SetToolTip(this.m_btnOpen, "Open file(s)");
            this.m_btnOpen.UseVisualStyleBackColor = true;
            this.m_btnOpen.Click += new System.EventHandler(this.m_btnOpen_Click);
            // 
            // m_grpVolume
            // 
            this.m_grpVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.m_grpVolume.Controls.Add(this.m_pnlVolume);
            this.m_grpVolume.Location = new System.Drawing.Point(11, 212);
            this.m_grpVolume.Name = "m_grpVolume";
            this.m_grpVolume.Size = new System.Drawing.Size(111, 211);
            this.m_grpVolume.TabIndex = 13;
            this.m_grpVolume.TabStop = false;
            this.m_grpVolume.Text = "Volume";
            // 
            // m_pnlVolume
            // 
            this.m_pnlVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.m_pnlVolume.Controls.Add(this.m_chkMuteRightVolume);
            this.m_pnlVolume.Controls.Add(this.m_chkMuteLeftVolume);
            this.m_pnlVolume.Controls.Add(this.m_tbLeftVolume);
            this.m_pnlVolume.Controls.Add(this.m_lblLeftVolume);
            this.m_pnlVolume.Controls.Add(this.m_tbRightVolume);
            this.m_pnlVolume.Controls.Add(this.m_lblRightVolume);
            this.m_pnlVolume.Location = new System.Drawing.Point(4, 12);
            this.m_pnlVolume.Name = "m_pnlVolume";
            this.m_pnlVolume.Size = new System.Drawing.Size(102, 196);
            this.m_pnlVolume.TabIndex = 25;
            // 
            // m_chkMuteRightVolume
            // 
            this.m_chkMuteRightVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_chkMuteRightVolume.Appearance = System.Windows.Forms.Appearance.Button;
            this.m_chkMuteRightVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.m_chkMuteRightVolume.Location = new System.Drawing.Point(52, 171);
            this.m_chkMuteRightVolume.Name = "m_chkMuteRightVolume";
            this.m_chkMuteRightVolume.Size = new System.Drawing.Size(47, 23);
            this.m_chkMuteRightVolume.TabIndex = 11;
            this.m_chkMuteRightVolume.Text = "Mute";
            this.m_chkMuteRightVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_ToolTip.SetToolTip(this.m_chkMuteRightVolume, "Mute right\r\nchannel");
            this.m_chkMuteRightVolume.UseVisualStyleBackColor = true;
            // 
            // m_chkMuteLeftVolume
            // 
            this.m_chkMuteLeftVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_chkMuteLeftVolume.Appearance = System.Windows.Forms.Appearance.Button;
            this.m_chkMuteLeftVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.m_chkMuteLeftVolume.Location = new System.Drawing.Point(3, 171);
            this.m_chkMuteLeftVolume.Name = "m_chkMuteLeftVolume";
            this.m_chkMuteLeftVolume.Size = new System.Drawing.Size(47, 23);
            this.m_chkMuteLeftVolume.TabIndex = 10;
            this.m_chkMuteLeftVolume.Text = "Mute";
            this.m_chkMuteLeftVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_ToolTip.SetToolTip(this.m_chkMuteLeftVolume, "Mute left \r\nchannel");
            this.m_chkMuteLeftVolume.UseVisualStyleBackColor = true;
            // 
            // m_tbLeftVolume
            // 
            this.m_tbLeftVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.m_tbLeftVolume.LargeChange = 1;
            this.m_tbLeftVolume.Location = new System.Drawing.Point(16, -1);
            this.m_tbLeftVolume.Name = "m_tbLeftVolume";
            this.m_tbLeftVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.m_tbLeftVolume.Size = new System.Drawing.Size(45, 158);
            this.m_tbLeftVolume.TabIndex = 6;
            this.m_tbLeftVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.m_tbLeftVolume.Value = 5;
            // 
            // m_lblLeftVolume
            // 
            this.m_lblLeftVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_lblLeftVolume.AutoSize = true;
            this.m_lblLeftVolume.Location = new System.Drawing.Point(14, 155);
            this.m_lblLeftVolume.Name = "m_lblLeftVolume";
            this.m_lblLeftVolume.Size = new System.Drawing.Size(25, 13);
            this.m_lblLeftVolume.TabIndex = 7;
            this.m_lblLeftVolume.Text = "Left";
            // 
            // m_tbRightVolume
            // 
            this.m_tbRightVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.m_tbRightVolume.LargeChange = 1;
            this.m_tbRightVolume.Location = new System.Drawing.Point(65, -1);
            this.m_tbRightVolume.Name = "m_tbRightVolume";
            this.m_tbRightVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.m_tbRightVolume.Size = new System.Drawing.Size(45, 158);
            this.m_tbRightVolume.TabIndex = 8;
            this.m_tbRightVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.m_tbRightVolume.Value = 5;
            // 
            // m_lblRightVolume
            // 
            this.m_lblRightVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_lblRightVolume.AutoSize = true;
            this.m_lblRightVolume.Location = new System.Drawing.Point(59, 155);
            this.m_lblRightVolume.Name = "m_lblRightVolume";
            this.m_lblRightVolume.Size = new System.Drawing.Size(32, 13);
            this.m_lblRightVolume.TabIndex = 9;
            this.m_lblRightVolume.Text = "Right";
            // 
            // m_lbPlayList
            // 
            this.m_lbPlayList.AllowDrop = true;
            this.m_lbPlayList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_lbPlayList.ContextMenuStrip = this.m_lbContextMenuStrip;
            this.m_lbPlayList.FormattingEnabled = true;
            this.m_lbPlayList.IntegralHeight = false;
            this.m_lbPlayList.Location = new System.Drawing.Point(16, 48);
            this.m_lbPlayList.Name = "m_lbPlayList";
            this.m_lbPlayList.Size = new System.Drawing.Size(447, 122);
            this.m_lbPlayList.TabIndex = 12;
            this.m_lbPlayList.DragDrop += new System.Windows.Forms.DragEventHandler(this.m_lbPlayList_DragDrop);
            this.m_lbPlayList.DragEnter += new System.Windows.Forms.DragEventHandler(this.m_lbPlayList_DragEnter);
            this.m_lbPlayList.DoubleClick += new System.EventHandler(this.m_lbPlayList_DoubleClick);
            // 
            // m_lbContextMenuStrip
            // 
            this.m_lbContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_ctxRemoveMenuItem});
            this.m_lbContextMenuStrip.Name = "m_lbContextMenuStrip";
            this.m_lbContextMenuStrip.Size = new System.Drawing.Size(183, 26);
            this.m_lbContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.m_lbContextMenuStrip_Opening);
            // 
            // m_ctxRemoveMenuItem
            // 
            this.m_ctxRemoveMenuItem.Image = global::MP3player.Properties.Resources.Close16;
            this.m_ctxRemoveMenuItem.Name = "m_ctxRemoveMenuItem";
            this.m_ctxRemoveMenuItem.Size = new System.Drawing.Size(182, 22);
            this.m_ctxRemoveMenuItem.Text = "Remove <filename>";
            this.m_ctxRemoveMenuItem.ToolTipText = "Remove file \r\nfrom this list.";
            this.m_ctxRemoveMenuItem.Click += new System.EventHandler(this.m_ctxRemoveMenuItem_Click);
            // 
            // m_grpSoundEffects
            // 
            this.m_grpSoundEffects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.m_grpSoundEffects.Controls.Add(this.m_pnlSoundEffects);
            this.m_grpSoundEffects.Controls.Add(this.m_grpSoundEffectsRightBorder);
            this.m_grpSoundEffects.Location = new System.Drawing.Point(248, 212);
            this.m_grpSoundEffects.Name = "m_grpSoundEffects";
            this.m_grpSoundEffects.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m_grpSoundEffects.Size = new System.Drawing.Size(142, 211);
            this.m_grpSoundEffects.TabIndex = 15;
            this.m_grpSoundEffects.TabStop = false;
            this.m_grpSoundEffects.Text = "Sound Effects";
            // 
            // m_pnlSoundEffects
            // 
            this.m_pnlSoundEffects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.m_pnlSoundEffects.Controls.Add(this.m_lblBassTrebleDisabled);
            this.m_pnlSoundEffects.Controls.Add(this.m_tbTrebleEffect);
            this.m_pnlSoundEffects.Controls.Add(this.m_btnPlaySpeedNormal);
            this.m_pnlSoundEffects.Controls.Add(this.m_lblPlaySpeed);
            this.m_pnlSoundEffects.Controls.Add(this.m_tbBassEffect);
            this.m_pnlSoundEffects.Controls.Add(this.m_lblBassEffect);
            this.m_pnlSoundEffects.Controls.Add(this.m_lblTrebleEffect);
            this.m_pnlSoundEffects.Controls.Add(this.m_tbPlaySpeed);
            this.m_pnlSoundEffects.Location = new System.Drawing.Point(4, 12);
            this.m_pnlSoundEffects.Name = "m_pnlSoundEffects";
            this.m_pnlSoundEffects.Size = new System.Drawing.Size(134, 196);
            this.m_pnlSoundEffects.TabIndex = 25;
            // 
            // m_lblBassTrebleDisabled
            // 
            this.m_lblBassTrebleDisabled.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_lblBassTrebleDisabled.AutoEllipsis = true;
            this.m_lblBassTrebleDisabled.BackColor = System.Drawing.Color.Transparent;
            this.m_lblBassTrebleDisabled.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.m_lblBassTrebleDisabled.Location = new System.Drawing.Point(12, 45);
            this.m_lblBassTrebleDisabled.Name = "m_lblBassTrebleDisabled";
            this.m_lblBassTrebleDisabled.Size = new System.Drawing.Size(70, 70);
            this.m_lblBassTrebleDisabled.TabIndex = 22;
            this.m_lblBassTrebleDisabled.Text = "Bass && Treble not supported for media type MPEGVideo";
            this.m_lblBassTrebleDisabled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_ToolTip.SetToolTip(this.m_lblBassTrebleDisabled, resources.GetString("m_lblBassTrebleDisabled.ToolTip"));
            // 
            // m_tbTrebleEffect
            // 
            this.m_tbTrebleEffect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.m_tbTrebleEffect.LargeChange = 1;
            this.m_tbTrebleEffect.Location = new System.Drawing.Point(55, -1);
            this.m_tbTrebleEffect.Name = "m_tbTrebleEffect";
            this.m_tbTrebleEffect.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.m_tbTrebleEffect.Size = new System.Drawing.Size(45, 158);
            this.m_tbTrebleEffect.TabIndex = 17;
            this.m_tbTrebleEffect.TickStyle = System.Windows.Forms.TickStyle.None;
            this.m_tbTrebleEffect.Value = 5;
            // 
            // m_btnPlaySpeedNormal
            // 
            this.m_btnPlaySpeedNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_btnPlaySpeedNormal.Location = new System.Drawing.Point(84, 171);
            this.m_btnPlaySpeedNormal.Name = "m_btnPlaySpeedNormal";
            this.m_btnPlaySpeedNormal.Size = new System.Drawing.Size(48, 23);
            this.m_btnPlaySpeedNormal.TabIndex = 21;
            this.m_btnPlaySpeedNormal.Text = "Normal";
            this.m_ToolTip.SetToolTip(this.m_btnPlaySpeedNormal, "Set play to the default\r\nrate of speed.");
            this.m_btnPlaySpeedNormal.UseVisualStyleBackColor = true;
            // 
            // m_lblPlaySpeed
            // 
            this.m_lblPlaySpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_lblPlaySpeed.AutoSize = true;
            this.m_lblPlaySpeed.Location = new System.Drawing.Point(89, 155);
            this.m_lblPlaySpeed.Name = "m_lblPlaySpeed";
            this.m_lblPlaySpeed.Size = new System.Drawing.Size(38, 13);
            this.m_lblPlaySpeed.TabIndex = 20;
            this.m_lblPlaySpeed.Text = "Speed";
            this.m_lblPlaySpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_tbBassEffect
            // 
            this.m_tbBassEffect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.m_tbBassEffect.LargeChange = 1;
            this.m_tbBassEffect.Location = new System.Drawing.Point(16, -1);
            this.m_tbBassEffect.Name = "m_tbBassEffect";
            this.m_tbBassEffect.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.m_tbBassEffect.Size = new System.Drawing.Size(45, 158);
            this.m_tbBassEffect.TabIndex = 15;
            this.m_tbBassEffect.TickStyle = System.Windows.Forms.TickStyle.None;
            this.m_tbBassEffect.Value = 5;
            // 
            // m_lblBassEffect
            // 
            this.m_lblBassEffect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_lblBassEffect.AutoSize = true;
            this.m_lblBassEffect.Location = new System.Drawing.Point(11, 155);
            this.m_lblBassEffect.Name = "m_lblBassEffect";
            this.m_lblBassEffect.Size = new System.Drawing.Size(30, 13);
            this.m_lblBassEffect.TabIndex = 16;
            this.m_lblBassEffect.Text = "Bass";
            // 
            // m_lblTrebleEffect
            // 
            this.m_lblTrebleEffect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_lblTrebleEffect.AutoSize = true;
            this.m_lblTrebleEffect.Location = new System.Drawing.Point(47, 155);
            this.m_lblTrebleEffect.Name = "m_lblTrebleEffect";
            this.m_lblTrebleEffect.Size = new System.Drawing.Size(37, 13);
            this.m_lblTrebleEffect.TabIndex = 18;
            this.m_lblTrebleEffect.Text = "Treble";
            // 
            // m_tbPlaySpeed
            // 
            this.m_tbPlaySpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.m_tbPlaySpeed.LargeChange = 1;
            this.m_tbPlaySpeed.Location = new System.Drawing.Point(97, -1);
            this.m_tbPlaySpeed.Name = "m_tbPlaySpeed";
            this.m_tbPlaySpeed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.m_tbPlaySpeed.Size = new System.Drawing.Size(45, 158);
            this.m_tbPlaySpeed.TabIndex = 19;
            this.m_tbPlaySpeed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.m_tbPlaySpeed.Value = 5;
            // 
            // m_grpSoundEffectsRightBorder
            // 
            this.m_grpSoundEffectsRightBorder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.m_grpSoundEffectsRightBorder.Location = new System.Drawing.Point(153, 0);
            this.m_grpSoundEffectsRightBorder.Name = "m_grpSoundEffectsRightBorder";
            this.m_grpSoundEffectsRightBorder.Size = new System.Drawing.Size(12, 224);
            this.m_grpSoundEffectsRightBorder.TabIndex = 13;
            this.m_grpSoundEffectsRightBorder.TabStop = false;
            // 
            // m_btnClear
            // 
            this.m_btnClear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.m_btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.m_btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.m_btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_btnClear.Image = global::MP3player.Properties.Resources.clear_button;
            this.m_btnClear.Location = new System.Drawing.Point(45, 12);
            this.m_btnClear.Name = "m_btnClear";
            this.m_btnClear.Size = new System.Drawing.Size(23, 23);
            this.m_btnClear.TabIndex = 1;
            this.m_ToolTip.SetToolTip(this.m_btnClear, "Clear playlist");
            this.m_btnClear.UseVisualStyleBackColor = true;
            this.m_btnClear.Click += new System.EventHandler(this.m_btnClear_Click);
            // 
            // m_btnAction1
            // 
            this.m_btnAction1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.m_btnAction1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.m_btnAction1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.m_btnAction1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_btnAction1.Location = new System.Drawing.Point(0, 0);
            this.m_btnAction1.Name = "m_btnAction1";
            this.m_btnAction1.Size = new System.Drawing.Size(23, 23);
            this.m_btnAction1.TabIndex = 6;
            this.m_btnAction1.Text = "1";
            this.m_ToolTip.SetToolTip(this.m_btnAction1, "Test byte array \r\nfrom resources.");
            this.m_btnAction1.UseVisualStyleBackColor = true;
            this.m_btnAction1.Click += new System.EventHandler(this.m_btnAction1_Click);
            // 
            // m_btnAction2
            // 
            this.m_btnAction2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.m_btnAction2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.m_btnAction2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.m_btnAction2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_btnAction2.Location = new System.Drawing.Point(29, 0);
            this.m_btnAction2.Name = "m_btnAction2";
            this.m_btnAction2.Size = new System.Drawing.Size(23, 23);
            this.m_btnAction2.TabIndex = 7;
            this.m_btnAction2.Text = "2";
            this.m_ToolTip.SetToolTip(this.m_btnAction2, "Test stream\r\nfrom resources.\r\n");
            this.m_btnAction2.UseVisualStyleBackColor = true;
            this.m_btnAction2.Click += new System.EventHandler(this.m_btnAction2_Click);
            // 
            // m_btnAction3
            // 
            this.m_btnAction3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.m_btnAction3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.m_btnAction3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.m_btnAction3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_btnAction3.Location = new System.Drawing.Point(58, 0);
            this.m_btnAction3.Name = "m_btnAction3";
            this.m_btnAction3.Size = new System.Drawing.Size(23, 23);
            this.m_btnAction3.TabIndex = 8;
            this.m_btnAction3.Text = "3";
            this.m_ToolTip.SetToolTip(this.m_btnAction3, "Not yet used.");
            this.m_btnAction3.UseVisualStyleBackColor = true;
            // 
            // m_btnAction4
            // 
            this.m_btnAction4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.m_btnAction4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.m_btnAction4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.m_btnAction4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_btnAction4.Location = new System.Drawing.Point(87, 0);
            this.m_btnAction4.Name = "m_btnAction4";
            this.m_btnAction4.Size = new System.Drawing.Size(23, 23);
            this.m_btnAction4.TabIndex = 9;
            this.m_btnAction4.Text = "4";
            this.m_ToolTip.SetToolTip(this.m_btnAction4, "Not yet used.");
            this.m_btnAction4.UseVisualStyleBackColor = true;
            // 
            // m_btnAction5
            // 
            this.m_btnAction5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.m_btnAction5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.m_btnAction5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.m_btnAction5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_btnAction5.Location = new System.Drawing.Point(116, 0);
            this.m_btnAction5.Name = "m_btnAction5";
            this.m_btnAction5.Size = new System.Drawing.Size(23, 23);
            this.m_btnAction5.TabIndex = 10;
            this.m_btnAction5.Text = "5";
            this.m_ToolTip.SetToolTip(this.m_btnAction5, "Not yet used.");
            this.m_btnAction5.UseVisualStyleBackColor = true;
            // 
            // m_btnAction6
            // 
            this.m_btnAction6.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.m_btnAction6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.m_btnAction6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.m_btnAction6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_btnAction6.Location = new System.Drawing.Point(145, 0);
            this.m_btnAction6.Name = "m_btnAction6";
            this.m_btnAction6.Size = new System.Drawing.Size(23, 23);
            this.m_btnAction6.TabIndex = 11;
            this.m_btnAction6.Text = "6";
            this.m_ToolTip.SetToolTip(this.m_btnAction6, "Not yet used.");
            this.m_btnAction6.UseVisualStyleBackColor = true;
            // 
            // m_btnPrevious
            // 
            this.m_btnPrevious.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.m_btnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.m_btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.m_btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_btnPrevious.Image = global::MP3player.Properties.Resources.media_step_backward_16;
            this.m_btnPrevious.Location = new System.Drawing.Point(0, 0);
            this.m_btnPrevious.Name = "m_btnPrevious";
            this.m_btnPrevious.Size = new System.Drawing.Size(23, 23);
            this.m_btnPrevious.TabIndex = 18;
            this.m_ToolTip.SetToolTip(this.m_btnPrevious, "Previous Track");
            this.m_btnPrevious.UseVisualStyleBackColor = true;
            this.m_btnPrevious.Click += new System.EventHandler(this.m_btnPrevious_Click);
            // 
            // m_btnPlay
            // 
            this.m_btnPlay.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.m_btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.m_btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.m_btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_btnPlay.Image = global::MP3player.Properties.Resources.media_play_16;
            this.m_btnPlay.Location = new System.Drawing.Point(29, 0);
            this.m_btnPlay.Name = "m_btnPlay";
            this.m_btnPlay.Size = new System.Drawing.Size(23, 23);
            this.m_btnPlay.TabIndex = 19;
            this.m_ToolTip.SetToolTip(this.m_btnPlay, "Play One");
            this.m_btnPlay.UseVisualStyleBackColor = true;
            this.m_btnPlay.Click += new System.EventHandler(this.m_btnPlay_Click);
            // 
            // m_btnLoop
            // 
            this.m_btnLoop.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.m_btnLoop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.m_btnLoop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.m_btnLoop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_btnLoop.Image = global::MP3player.Properties.Resources.loop_circular_16;
            this.m_btnLoop.Location = new System.Drawing.Point(58, 0);
            this.m_btnLoop.Name = "m_btnLoop";
            this.m_btnLoop.Size = new System.Drawing.Size(23, 23);
            this.m_btnLoop.TabIndex = 23;
            this.m_ToolTip.SetToolTip(this.m_btnLoop, "Continuous Play");
            this.m_btnLoop.UseVisualStyleBackColor = true;
            this.m_btnLoop.Click += new System.EventHandler(this.m_btnLoop_Click);
            // 
            // m_btnRandom
            // 
            this.m_btnRandom.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.m_btnRandom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.m_btnRandom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.m_btnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_btnRandom.Image = global::MP3player.Properties.Resources.random_16;
            this.m_btnRandom.Location = new System.Drawing.Point(87, 0);
            this.m_btnRandom.Name = "m_btnRandom";
            this.m_btnRandom.Size = new System.Drawing.Size(23, 23);
            this.m_btnRandom.TabIndex = 24;
            this.m_ToolTip.SetToolTip(this.m_btnRandom, "Random Play");
            this.m_btnRandom.UseVisualStyleBackColor = true;
            this.m_btnRandom.Click += new System.EventHandler(this.m_btnRandom_Click);
            // 
            // m_btnPause
            // 
            this.m_btnPause.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.m_btnPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.m_btnPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.m_btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_btnPause.Image = global::MP3player.Properties.Resources.media_pause_16;
            this.m_btnPause.Location = new System.Drawing.Point(116, 0);
            this.m_btnPause.Name = "m_btnPause";
            this.m_btnPause.Size = new System.Drawing.Size(23, 23);
            this.m_btnPause.TabIndex = 20;
            this.m_ToolTip.SetToolTip(this.m_btnPause, "Pause/Continue");
            this.m_btnPause.UseVisualStyleBackColor = true;
            this.m_btnPause.Click += new System.EventHandler(this.m_btnPause_Click);
            // 
            // m_btnStop
            // 
            this.m_btnStop.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.m_btnStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.m_btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.m_btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_btnStop.Image = global::MP3player.Properties.Resources.media_stop_16;
            this.m_btnStop.Location = new System.Drawing.Point(145, 0);
            this.m_btnStop.Name = "m_btnStop";
            this.m_btnStop.Size = new System.Drawing.Size(23, 23);
            this.m_btnStop.TabIndex = 21;
            this.m_ToolTip.SetToolTip(this.m_btnStop, "Stop");
            this.m_btnStop.UseVisualStyleBackColor = true;
            this.m_btnStop.Click += new System.EventHandler(this.m_btnStop_Click);
            // 
            // m_btnNext
            // 
            this.m_btnNext.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.m_btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.m_btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.m_btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_btnNext.Image = global::MP3player.Properties.Resources.media_step_forward_16;
            this.m_btnNext.Location = new System.Drawing.Point(174, 0);
            this.m_btnNext.Name = "m_btnNext";
            this.m_btnNext.Size = new System.Drawing.Size(23, 23);
            this.m_btnNext.TabIndex = 22;
            this.m_ToolTip.SetToolTip(this.m_btnNext, "Next Track");
            this.m_btnNext.UseVisualStyleBackColor = true;
            this.m_btnNext.Click += new System.EventHandler(this.m_btnNext_Click);
            // 
            // m_tbPlayPosition
            // 
            this.m_tbPlayPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_tbPlayPosition.Location = new System.Drawing.Point(5, 174);
            this.m_tbPlayPosition.Name = "m_tbPlayPosition";
            this.m_tbPlayPosition.Size = new System.Drawing.Size(466, 45);
            this.m_tbPlayPosition.TabIndex = 18;
            this.m_tbPlayPosition.TickStyle = System.Windows.Forms.TickStyle.None;
            this.m_ToolTip.SetToolTip(this.m_tbPlayPosition, "Drag thumb to rewind or \r\nfast-forward while playing.");
            this.m_tbPlayPosition.Value = 10;
            // 
            // m_lblPlayPosition
            // 
            this.m_lblPlayPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_lblPlayPosition.Location = new System.Drawing.Point(295, 199);
            this.m_lblPlayPosition.Name = "m_lblPlayPosition";
            this.m_lblPlayPosition.Size = new System.Drawing.Size(124, 13);
            this.m_lblPlayPosition.TabIndex = 19;
            this.m_lblPlayPosition.Text = "000000 / 000000";
            this.m_lblPlayPosition.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // m_lblPlayPositionSeconds
            // 
            this.m_lblPlayPositionSeconds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_lblPlayPositionSeconds.AutoSize = true;
            this.m_lblPlayPositionSeconds.Location = new System.Drawing.Point(417, 199);
            this.m_lblPlayPositionSeconds.Name = "m_lblPlayPositionSeconds";
            this.m_lblPlayPositionSeconds.Size = new System.Drawing.Size(49, 13);
            this.m_lblPlayPositionSeconds.TabIndex = 20;
            this.m_lblPlayPositionSeconds.Text = "Seconds";
            // 
            // m_grpBalance
            // 
            this.m_grpBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.m_grpBalance.Controls.Add(this.m_pnlBalance);
            this.m_grpBalance.Location = new System.Drawing.Point(128, 212);
            this.m_grpBalance.Name = "m_grpBalance";
            this.m_grpBalance.Size = new System.Drawing.Size(111, 211);
            this.m_grpBalance.TabIndex = 21;
            this.m_grpBalance.TabStop = false;
            this.m_grpBalance.Text = "Balance";
            // 
            // m_pnlBalance
            // 
            this.m_pnlBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.m_pnlBalance.Controls.Add(this.m_lblBalance);
            this.m_pnlBalance.Controls.Add(this.m_lblMasterVolume);
            this.m_pnlBalance.Controls.Add(this.m_btnBalanceCenter);
            this.m_pnlBalance.Controls.Add(this.m_chkMuteMasterVolume);
            this.m_pnlBalance.Controls.Add(this.m_tbMasterVolume);
            this.m_pnlBalance.Controls.Add(this.m_tbBalance);
            this.m_pnlBalance.Location = new System.Drawing.Point(4, 12);
            this.m_pnlBalance.Name = "m_pnlBalance";
            this.m_pnlBalance.Size = new System.Drawing.Size(102, 196);
            this.m_pnlBalance.TabIndex = 25;
            // 
            // m_lblBalance
            // 
            this.m_lblBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_lblBalance.AutoSize = true;
            this.m_lblBalance.Location = new System.Drawing.Point(4, 155);
            this.m_lblBalance.Name = "m_lblBalance";
            this.m_lblBalance.Size = new System.Drawing.Size(46, 13);
            this.m_lblBalance.TabIndex = 19;
            this.m_lblBalance.Text = "Balance";
            // 
            // m_lblMasterVolume
            // 
            this.m_lblMasterVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_lblMasterVolume.AutoSize = true;
            this.m_lblMasterVolume.Location = new System.Drawing.Point(57, 155);
            this.m_lblMasterVolume.Name = "m_lblMasterVolume";
            this.m_lblMasterVolume.Size = new System.Drawing.Size(39, 13);
            this.m_lblMasterVolume.TabIndex = 21;
            this.m_lblMasterVolume.Text = "Master";
            // 
            // m_btnBalanceCenter
            // 
            this.m_btnBalanceCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_btnBalanceCenter.Location = new System.Drawing.Point(2, 171);
            this.m_btnBalanceCenter.Name = "m_btnBalanceCenter";
            this.m_btnBalanceCenter.Size = new System.Drawing.Size(48, 23);
            this.m_btnBalanceCenter.TabIndex = 23;
            this.m_btnBalanceCenter.Text = "Center";
            this.m_ToolTip.SetToolTip(this.m_btnBalanceCenter, "Set both channels \r\nat equal volume");
            this.m_btnBalanceCenter.UseVisualStyleBackColor = true;
            // 
            // m_chkMuteMasterVolume
            // 
            this.m_chkMuteMasterVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_chkMuteMasterVolume.Appearance = System.Windows.Forms.Appearance.Button;
            this.m_chkMuteMasterVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.m_chkMuteMasterVolume.Location = new System.Drawing.Point(53, 171);
            this.m_chkMuteMasterVolume.Name = "m_chkMuteMasterVolume";
            this.m_chkMuteMasterVolume.Size = new System.Drawing.Size(47, 23);
            this.m_chkMuteMasterVolume.TabIndex = 22;
            this.m_chkMuteMasterVolume.Text = "Mute";
            this.m_chkMuteMasterVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_ToolTip.SetToolTip(this.m_chkMuteMasterVolume, "Mute both \r\nchannels");
            this.m_chkMuteMasterVolume.UseVisualStyleBackColor = true;
            // 
            // m_tbMasterVolume
            // 
            this.m_tbMasterVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.m_tbMasterVolume.LargeChange = 1;
            this.m_tbMasterVolume.Location = new System.Drawing.Point(65, -1);
            this.m_tbMasterVolume.Name = "m_tbMasterVolume";
            this.m_tbMasterVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.m_tbMasterVolume.Size = new System.Drawing.Size(45, 158);
            this.m_tbMasterVolume.TabIndex = 20;
            this.m_tbMasterVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.m_tbMasterVolume.Value = 5;
            // 
            // m_tbBalance
            // 
            this.m_tbBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.m_tbBalance.LargeChange = 1;
            this.m_tbBalance.Location = new System.Drawing.Point(16, -1);
            this.m_tbBalance.Name = "m_tbBalance";
            this.m_tbBalance.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.m_tbBalance.Size = new System.Drawing.Size(45, 158);
            this.m_tbBalance.TabIndex = 18;
            this.m_tbBalance.TickStyle = System.Windows.Forms.TickStyle.None;
            this.m_tbBalance.Value = 5;
            // 
            // m_pnlActionButtons
            // 
            this.m_pnlActionButtons.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.m_pnlActionButtons.Controls.Add(this.m_btnAction6);
            this.m_pnlActionButtons.Controls.Add(this.m_btnAction5);
            this.m_pnlActionButtons.Controls.Add(this.m_btnAction4);
            this.m_pnlActionButtons.Controls.Add(this.m_btnAction1);
            this.m_pnlActionButtons.Controls.Add(this.m_btnAction2);
            this.m_pnlActionButtons.Controls.Add(this.m_btnAction3);
            this.m_pnlActionButtons.Location = new System.Drawing.Point(83, 12);
            this.m_pnlActionButtons.Name = "m_pnlActionButtons";
            this.m_pnlActionButtons.Size = new System.Drawing.Size(168, 23);
            this.m_pnlActionButtons.TabIndex = 22;
            // 
            // m_pnlPlayButtons
            // 
            this.m_pnlPlayButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_pnlPlayButtons.Controls.Add(this.m_btnRandom);
            this.m_pnlPlayButtons.Controls.Add(this.m_btnLoop);
            this.m_pnlPlayButtons.Controls.Add(this.m_btnPrevious);
            this.m_pnlPlayButtons.Controls.Add(this.m_btnPlay);
            this.m_pnlPlayButtons.Controls.Add(this.m_btnPause);
            this.m_pnlPlayButtons.Controls.Add(this.m_btnStop);
            this.m_pnlPlayButtons.Controls.Add(this.m_btnNext);
            this.m_pnlPlayButtons.Location = new System.Drawing.Point(266, 12);
            this.m_pnlPlayButtons.Name = "m_pnlPlayButtons";
            this.m_pnlPlayButtons.Size = new System.Drawing.Size(197, 23);
            this.m_pnlPlayButtons.TabIndex = 23;
            // 
            // m_grpEmpty
            // 
            this.m_grpEmpty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_grpEmpty.Location = new System.Drawing.Point(400, 212);
            this.m_grpEmpty.Name = "m_grpEmpty";
            this.m_grpEmpty.Size = new System.Drawing.Size(63, 211);
            this.m_grpEmpty.TabIndex = 24;
            this.m_grpEmpty.TabStop = false;
            // 
            // m_divider1
            // 
            this.m_divider1.ForeColor = System.Drawing.Color.Silver;
            this.m_divider1.ForeColor2 = System.Drawing.Color.White;
            this.m_divider1.LineStyle = ChuckHill2.Forms.DividerLineStyle.Horizontal;
            this.m_divider1.Location = new System.Drawing.Point(75, 12);
            this.m_divider1.Name = "m_divider1";
            this.m_divider1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.m_divider1.Size = new System.Drawing.Size(2, 23);
            this.m_divider1.TabIndex = 2;
            this.m_divider1.TabStop = false;
            this.m_divider1.Thickness = 2;
            // 
            // m_divider2
            // 
            this.m_divider2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_divider2.ForeColor = System.Drawing.Color.Silver;
            this.m_divider2.ForeColor2 = System.Drawing.Color.White;
            this.m_divider2.LineStyle = ChuckHill2.Forms.DividerLineStyle.Horizontal;
            this.m_divider2.Location = new System.Drawing.Point(258, 12);
            this.m_divider2.Name = "m_divider2";
            this.m_divider2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.m_divider2.Size = new System.Drawing.Size(2, 23);
            this.m_divider2.TabIndex = 6;
            this.m_divider2.TabStop = false;
            this.m_divider2.Thickness = 2;
            // 
            // MainPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 434);
            this.Controls.Add(this.m_grpEmpty);
            this.Controls.Add(this.m_lblPlayPositionSeconds);
            this.Controls.Add(this.m_lblPlayPosition);
            this.Controls.Add(this.m_grpVolume);
            this.Controls.Add(this.m_grpBalance);
            this.Controls.Add(this.m_grpSoundEffects);
            this.Controls.Add(this.m_btnOpen);
            this.Controls.Add(this.m_btnClear);
            this.Controls.Add(this.m_divider1);
            this.Controls.Add(this.m_pnlActionButtons);
            this.Controls.Add(this.m_divider2);
            this.Controls.Add(this.m_lbPlayList);
            this.Controls.Add(this.m_pnlPlayButtons);
            this.Controls.Add(this.m_tbPlayPosition);
            this.Icon = global::MP3player.Properties.Resources.AudioPlayer;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 473);
            this.Name = "MainPlayer";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Audio Player Demo";
            this.m_grpVolume.ResumeLayout(false);
            this.m_pnlVolume.ResumeLayout(false);
            this.m_pnlVolume.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_tbLeftVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_tbRightVolume)).EndInit();
            this.m_lbContextMenuStrip.ResumeLayout(false);
            this.m_grpSoundEffects.ResumeLayout(false);
            this.m_pnlSoundEffects.ResumeLayout(false);
            this.m_pnlSoundEffects.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_tbTrebleEffect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_tbBassEffect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_tbPlaySpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_tbPlayPosition)).EndInit();
            this.m_grpBalance.ResumeLayout(false);
            this.m_pnlBalance.ResumeLayout(false);
            this.m_pnlBalance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_tbMasterVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_tbBalance)).EndInit();
            this.m_pnlActionButtons.ResumeLayout(false);
            this.m_pnlPlayButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private System.Windows.Forms.Button m_btnOpen;
        private System.Windows.Forms.GroupBox m_grpVolume;
        private System.Windows.Forms.ListBox m_lbPlayList;
        private System.Windows.Forms.GroupBox m_grpSoundEffects;
        private System.Windows.Forms.Button m_btnClear;
        private ChuckHill2.Forms.Divider m_divider1;
        private ChuckHill2.Forms.Divider m_divider2;
        private System.Windows.Forms.ContextMenuStrip m_lbContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem m_ctxRemoveMenuItem;
        private System.Windows.Forms.ToolTip m_ToolTip;
        private System.Windows.Forms.TrackBar m_tbPlayPosition;
        private System.Windows.Forms.Label m_lblPlayPosition;
        private System.Windows.Forms.Label m_lblPlayPositionSeconds;
        private System.Windows.Forms.GroupBox m_grpBalance;
        private System.Windows.Forms.Panel m_pnlActionButtons;
        private System.Windows.Forms.Button m_btnAction6;
        private System.Windows.Forms.Button m_btnAction5;
        private System.Windows.Forms.Button m_btnAction4;
        private System.Windows.Forms.Button m_btnAction1;
        private System.Windows.Forms.Button m_btnAction2;
        private System.Windows.Forms.Button m_btnAction3;
        private System.Windows.Forms.Panel m_pnlPlayButtons;
        private System.Windows.Forms.Button m_btnRandom;
        private System.Windows.Forms.Button m_btnLoop;
        private System.Windows.Forms.Button m_btnPrevious;
        private System.Windows.Forms.Button m_btnPlay;
        private System.Windows.Forms.Button m_btnPause;
        private System.Windows.Forms.Button m_btnStop;
        private System.Windows.Forms.Button m_btnNext;
        private System.Windows.Forms.GroupBox m_grpSoundEffectsRightBorder;
        private System.Windows.Forms.GroupBox m_grpEmpty;
        private System.Windows.Forms.Panel m_pnlBalance;
        private System.Windows.Forms.Button m_btnBalanceCenter;
        private System.Windows.Forms.CheckBox m_chkMuteMasterVolume;
        private System.Windows.Forms.TrackBar m_tbMasterVolume;
        private System.Windows.Forms.Label m_lblMasterVolume;
        private System.Windows.Forms.Label m_lblBalance;
        private System.Windows.Forms.TrackBar m_tbBalance;
        private System.Windows.Forms.Panel m_pnlVolume;
        private System.Windows.Forms.CheckBox m_chkMuteRightVolume;
        private System.Windows.Forms.CheckBox m_chkMuteLeftVolume;
        private System.Windows.Forms.TrackBar m_tbLeftVolume;
        private System.Windows.Forms.Label m_lblLeftVolume;
        private System.Windows.Forms.TrackBar m_tbRightVolume;
        private System.Windows.Forms.Label m_lblRightVolume;
        private System.Windows.Forms.Panel m_pnlSoundEffects;
        private System.Windows.Forms.Label m_lblBassTrebleDisabled;
        private System.Windows.Forms.TrackBar m_tbTrebleEffect;
        private System.Windows.Forms.Button m_btnPlaySpeedNormal;
        private System.Windows.Forms.Label m_lblPlaySpeed;
        private System.Windows.Forms.TrackBar m_tbBassEffect;
        private System.Windows.Forms.Label m_lblBassEffect;
        private System.Windows.Forms.Label m_lblTrebleEffect;
        private System.Windows.Forms.TrackBar m_tbPlaySpeed;
    }
}

