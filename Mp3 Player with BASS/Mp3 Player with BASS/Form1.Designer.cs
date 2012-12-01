namespace Mp3_Player_with_BASS
{
    partial class Form1
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
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbShuffle = new System.Windows.Forms.CheckBox();
            this.cbLoop = new System.Windows.Forms.CheckBox();
            this.cbMute = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fetchFromServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBoxSpectrum = new System.Windows.Forms.PictureBox();
            this.timerSpectrum = new System.Windows.Forms.Timer(this.components);
            this.trackBar50EQ = new System.Windows.Forms.TrackBar();
            this.label50Hz = new System.Windows.Forms.Label();
            this.trackBar100EQ = new System.Windows.Forms.TrackBar();
            this.trackBar200EQ = new System.Windows.Forms.TrackBar();
            this.trackBar400EQ = new System.Windows.Forms.TrackBar();
            this.trackBar700EQ = new System.Windows.Forms.TrackBar();
            this.label16kHz = new System.Windows.Forms.Label();
            this.label5kHz = new System.Windows.Forms.Label();
            this.label3kHz = new System.Windows.Forms.Label();
            this.label700Hz = new System.Windows.Forms.Label();
            this.label400Hz = new System.Windows.Forms.Label();
            this.label7kHz = new System.Windows.Forms.Label();
            this.trackBar1EQ = new System.Windows.Forms.TrackBar();
            this.trackBar2EQ = new System.Windows.Forms.TrackBar();
            this.trackBar4EQ = new System.Windows.Forms.TrackBar();
            this.trackBar6EQ = new System.Windows.Forms.TrackBar();
            this.trackBar8EQ = new System.Windows.Forms.TrackBar();
            this.label8kHz = new System.Windows.Forms.Label();
            this.label1kHz = new System.Windows.Forms.Label();
            this.label100Hz = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarEcho = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarChorus = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpectrum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar50EQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar100EQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar200EQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar400EQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar700EQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1EQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2EQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4EQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6EQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8EQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEcho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarChorus)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(83, 523);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Open";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(164, 523);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFolder.TabIndex = 1;
            this.btnOpenFolder.Text = "Open folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(245, 523);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(326, 523);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 3;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(407, 523);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(488, 523);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 5;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(569, 523);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(24, 421);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(626, 42);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseUp);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(670, 402);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(42, 104);
            this.trackBar2.TabIndex = 8;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(716, 89);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(37, 460);
            this.trackBar3.Maximum = 100;
            this.trackBar3.Minimum = -100;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(104, 42);
            this.trackBar3.TabIndex = 10;
            this.trackBar3.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar3_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbShuffle);
            this.groupBox1.Controls.Add(this.cbLoop);
            this.groupBox1.Controls.Add(this.cbMute);
            this.groupBox1.Location = new System.Drawing.Point(180, 473);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 33);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // cbShuffle
            // 
            this.cbShuffle.AutoSize = true;
            this.cbShuffle.Location = new System.Drawing.Point(133, 10);
            this.cbShuffle.Name = "cbShuffle";
            this.cbShuffle.Size = new System.Drawing.Size(59, 17);
            this.cbShuffle.TabIndex = 2;
            this.cbShuffle.Text = "Shuffle";
            this.cbShuffle.UseVisualStyleBackColor = true;
            this.cbShuffle.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // cbLoop
            // 
            this.cbLoop.AutoSize = true;
            this.cbLoop.Location = new System.Drawing.Point(77, 10);
            this.cbLoop.Name = "cbLoop";
            this.cbLoop.Size = new System.Drawing.Size(50, 17);
            this.cbLoop.TabIndex = 1;
            this.cbLoop.Text = "Loop";
            this.cbLoop.UseVisualStyleBackColor = true;
            this.cbLoop.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cbMute
            // 
            this.cbMute.AutoSize = true;
            this.cbMute.Location = new System.Drawing.Point(21, 10);
            this.cbMute.Name = "cbMute";
            this.cbMute.Size = new System.Drawing.Size(50, 17);
            this.cbMute.TabIndex = 0;
            this.cbMute.Text = "Mute";
            this.cbMute.UseVisualStyleBackColor = true;
            this.cbMute.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.fetchFromServerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 70);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // fetchFromServerToolStripMenuItem
            // 
            this.fetchFromServerToolStripMenuItem.Name = "fetchFromServerToolStripMenuItem";
            this.fetchFromServerToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.fetchFromServerToolStripMenuItem.Text = "FetchFromServer";
            this.fetchFromServerToolStripMenuItem.Click += new System.EventHandler(this.fetchFromServerToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "0 : 00 / 0 : 00";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 395);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(607, 20);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(37, 325);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(607, 20);
            this.textBox2.TabIndex = 14;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(48, 349);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(110, 23);
            this.button9.TabIndex = 16;
            this.button9.Text = "Execute Statement";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(164, 349);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 17;
            this.button10.Text = "Clear";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(242, 351);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(130, 23);
            this.button12.TabIndex = 19;
            this.button12.Text = "SwitchToServ";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = " SwitchToClient";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 559);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(722, 108);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // pictureBoxSpectrum
            // 
            this.pictureBoxSpectrum.BackColor = System.Drawing.Color.White;
            this.pictureBoxSpectrum.Location = new System.Drawing.Point(141, 12);
            this.pictureBoxSpectrum.Name = "pictureBoxSpectrum";
            this.pictureBoxSpectrum.Size = new System.Drawing.Size(387, 82);
            this.pictureBoxSpectrum.TabIndex = 22;
            this.pictureBoxSpectrum.TabStop = false;
            this.pictureBoxSpectrum.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSpectrum_MouseDown);
            // 
            // timerSpectrum
            // 
            this.timerSpectrum.Tick += new System.EventHandler(this.timerSpectrum_Tick);
            // 
            // trackBar50EQ
            // 
            this.trackBar50EQ.AutoSize = false;
            this.trackBar50EQ.LargeChange = 50;
            this.trackBar50EQ.Location = new System.Drawing.Point(37, 28);
            this.trackBar50EQ.Maximum = 150;
            this.trackBar50EQ.Minimum = -150;
            this.trackBar50EQ.Name = "trackBar50EQ";
            this.trackBar50EQ.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar50EQ.Size = new System.Drawing.Size(38, 138);
            this.trackBar50EQ.SmallChange = 10;
            this.trackBar50EQ.TabIndex = 200;
            this.trackBar50EQ.Tag = "0";
            this.trackBar50EQ.TickFrequency = 50;
            this.trackBar50EQ.ValueChanged += new System.EventHandler(this.trackBar50EQ_ValueChanged);
            // 
            // label50Hz
            // 
            this.label50Hz.AutoSize = true;
            this.label50Hz.Location = new System.Drawing.Point(34, 12);
            this.label50Hz.Name = "label50Hz";
            this.label50Hz.Size = new System.Drawing.Size(35, 13);
            this.label50Hz.TabIndex = 83;
            this.label50Hz.Text = "50 Hz";
            // 
            // trackBar100EQ
            // 
            this.trackBar100EQ.AutoSize = false;
            this.trackBar100EQ.LargeChange = 50;
            this.trackBar100EQ.Location = new System.Drawing.Point(73, 28);
            this.trackBar100EQ.Maximum = 150;
            this.trackBar100EQ.Minimum = -150;
            this.trackBar100EQ.Name = "trackBar100EQ";
            this.trackBar100EQ.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar100EQ.Size = new System.Drawing.Size(38, 138);
            this.trackBar100EQ.SmallChange = 10;
            this.trackBar100EQ.TabIndex = 201;
            this.trackBar100EQ.Tag = "1";
            this.trackBar100EQ.TickFrequency = 50;
            this.trackBar100EQ.ValueChanged += new System.EventHandler(this.trackBar100EQ_ValueChanged);
            // 
            // trackBar200EQ
            // 
            this.trackBar200EQ.AutoSize = false;
            this.trackBar200EQ.LargeChange = 50;
            this.trackBar200EQ.Location = new System.Drawing.Point(114, 28);
            this.trackBar200EQ.Maximum = 150;
            this.trackBar200EQ.Minimum = -150;
            this.trackBar200EQ.Name = "trackBar200EQ";
            this.trackBar200EQ.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar200EQ.Size = new System.Drawing.Size(38, 138);
            this.trackBar200EQ.SmallChange = 10;
            this.trackBar200EQ.TabIndex = 202;
            this.trackBar200EQ.Tag = "2";
            this.trackBar200EQ.TickFrequency = 50;
            this.trackBar200EQ.ValueChanged += new System.EventHandler(this.trackBar200EQ_ValueChanged);
            // 
            // trackBar400EQ
            // 
            this.trackBar400EQ.AutoSize = false;
            this.trackBar400EQ.LargeChange = 50;
            this.trackBar400EQ.Location = new System.Drawing.Point(155, 28);
            this.trackBar400EQ.Maximum = 150;
            this.trackBar400EQ.Minimum = -150;
            this.trackBar400EQ.Name = "trackBar400EQ";
            this.trackBar400EQ.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar400EQ.Size = new System.Drawing.Size(38, 138);
            this.trackBar400EQ.SmallChange = 10;
            this.trackBar400EQ.TabIndex = 203;
            this.trackBar400EQ.Tag = "3";
            this.trackBar400EQ.TickFrequency = 50;
            this.trackBar400EQ.ValueChanged += new System.EventHandler(this.trackBar400EQ_ValueChanged);
            // 
            // trackBar700EQ
            // 
            this.trackBar700EQ.AutoSize = false;
            this.trackBar700EQ.LargeChange = 50;
            this.trackBar700EQ.Location = new System.Drawing.Point(199, 28);
            this.trackBar700EQ.Maximum = 150;
            this.trackBar700EQ.Minimum = -150;
            this.trackBar700EQ.Name = "trackBar700EQ";
            this.trackBar700EQ.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar700EQ.Size = new System.Drawing.Size(38, 138);
            this.trackBar700EQ.SmallChange = 10;
            this.trackBar700EQ.TabIndex = 71;
            this.trackBar700EQ.Tag = "4";
            this.trackBar700EQ.TickFrequency = 50;
            this.trackBar700EQ.ValueChanged += new System.EventHandler(this.trackBar700EQ_ValueChanged);
            // 
            // label16kHz
            // 
            this.label16kHz.AutoSize = true;
            this.label16kHz.Location = new System.Drawing.Point(416, 12);
            this.label16kHz.Name = "label16kHz";
            this.label16kHz.Size = new System.Drawing.Size(35, 13);
            this.label16kHz.TabIndex = 81;
            this.label16kHz.Text = "8 kHz";
            // 
            // label5kHz
            // 
            this.label5kHz.AutoSize = true;
            this.label5kHz.Location = new System.Drawing.Point(284, 12);
            this.label5kHz.Name = "label5kHz";
            this.label5kHz.Size = new System.Drawing.Size(35, 13);
            this.label5kHz.TabIndex = 80;
            this.label5kHz.Text = "2 kHz";
            // 
            // label3kHz
            // 
            this.label3kHz.AutoSize = true;
            this.label3kHz.Location = new System.Drawing.Point(240, 12);
            this.label3kHz.Name = "label3kHz";
            this.label3kHz.Size = new System.Drawing.Size(35, 13);
            this.label3kHz.TabIndex = 79;
            this.label3kHz.Text = "1 kHz";
            // 
            // label700Hz
            // 
            this.label700Hz.AutoSize = true;
            this.label700Hz.Location = new System.Drawing.Point(152, 12);
            this.label700Hz.Name = "label700Hz";
            this.label700Hz.Size = new System.Drawing.Size(41, 13);
            this.label700Hz.TabIndex = 78;
            this.label700Hz.Text = "400 Hz";
            // 
            // label400Hz
            // 
            this.label400Hz.AutoSize = true;
            this.label400Hz.Location = new System.Drawing.Point(111, 12);
            this.label400Hz.Name = "label400Hz";
            this.label400Hz.Size = new System.Drawing.Size(41, 13);
            this.label400Hz.TabIndex = 77;
            this.label400Hz.Text = "200 Hz";
            // 
            // label7kHz
            // 
            this.label7kHz.AutoSize = true;
            this.label7kHz.Location = new System.Drawing.Point(328, 12);
            this.label7kHz.Name = "label7kHz";
            this.label7kHz.Size = new System.Drawing.Size(35, 13);
            this.label7kHz.TabIndex = 76;
            this.label7kHz.Text = "4 kHz";
            // 
            // trackBar1EQ
            // 
            this.trackBar1EQ.AutoSize = false;
            this.trackBar1EQ.LargeChange = 50;
            this.trackBar1EQ.Location = new System.Drawing.Point(243, 28);
            this.trackBar1EQ.Maximum = 150;
            this.trackBar1EQ.Minimum = -150;
            this.trackBar1EQ.Name = "trackBar1EQ";
            this.trackBar1EQ.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1EQ.Size = new System.Drawing.Size(38, 138);
            this.trackBar1EQ.SmallChange = 10;
            this.trackBar1EQ.TabIndex = 75;
            this.trackBar1EQ.Tag = "5";
            this.trackBar1EQ.TickFrequency = 50;
            this.trackBar1EQ.ValueChanged += new System.EventHandler(this.trackBar1EQ_ValueChanged);
            // 
            // trackBar2EQ
            // 
            this.trackBar2EQ.AutoSize = false;
            this.trackBar2EQ.LargeChange = 50;
            this.trackBar2EQ.Location = new System.Drawing.Point(287, 28);
            this.trackBar2EQ.Maximum = 150;
            this.trackBar2EQ.Minimum = -150;
            this.trackBar2EQ.Name = "trackBar2EQ";
            this.trackBar2EQ.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2EQ.Size = new System.Drawing.Size(38, 138);
            this.trackBar2EQ.SmallChange = 10;
            this.trackBar2EQ.TabIndex = 74;
            this.trackBar2EQ.Tag = "6";
            this.trackBar2EQ.TickFrequency = 50;
            this.trackBar2EQ.ValueChanged += new System.EventHandler(this.trackBar2EQ_ValueChanged);
            // 
            // trackBar4EQ
            // 
            this.trackBar4EQ.AutoSize = false;
            this.trackBar4EQ.LargeChange = 50;
            this.trackBar4EQ.Location = new System.Drawing.Point(331, 28);
            this.trackBar4EQ.Maximum = 150;
            this.trackBar4EQ.Minimum = -150;
            this.trackBar4EQ.Name = "trackBar4EQ";
            this.trackBar4EQ.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar4EQ.Size = new System.Drawing.Size(38, 138);
            this.trackBar4EQ.SmallChange = 10;
            this.trackBar4EQ.TabIndex = 73;
            this.trackBar4EQ.Tag = "7";
            this.trackBar4EQ.TickFrequency = 50;
            this.trackBar4EQ.ValueChanged += new System.EventHandler(this.trackBar4EQ_ValueChanged);
            // 
            // trackBar6EQ
            // 
            this.trackBar6EQ.AutoSize = false;
            this.trackBar6EQ.LargeChange = 50;
            this.trackBar6EQ.Location = new System.Drawing.Point(375, 28);
            this.trackBar6EQ.Maximum = 150;
            this.trackBar6EQ.Minimum = -150;
            this.trackBar6EQ.Name = "trackBar6EQ";
            this.trackBar6EQ.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar6EQ.Size = new System.Drawing.Size(38, 138);
            this.trackBar6EQ.SmallChange = 10;
            this.trackBar6EQ.TabIndex = 72;
            this.trackBar6EQ.Tag = "8";
            this.trackBar6EQ.TickFrequency = 50;
            this.trackBar6EQ.ValueChanged += new System.EventHandler(this.trackBar6EQ_ValueChanged);
            // 
            // trackBar8EQ
            // 
            this.trackBar8EQ.AutoSize = false;
            this.trackBar8EQ.LargeChange = 50;
            this.trackBar8EQ.Location = new System.Drawing.Point(419, 28);
            this.trackBar8EQ.Maximum = 150;
            this.trackBar8EQ.Minimum = -150;
            this.trackBar8EQ.Name = "trackBar8EQ";
            this.trackBar8EQ.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar8EQ.Size = new System.Drawing.Size(38, 138);
            this.trackBar8EQ.SmallChange = 10;
            this.trackBar8EQ.TabIndex = 82;
            this.trackBar8EQ.Tag = "9";
            this.trackBar8EQ.TickFrequency = 50;
            this.trackBar8EQ.ValueChanged += new System.EventHandler(this.trackBar8EQ_ValueChanged);
            // 
            // label8kHz
            // 
            this.label8kHz.AutoSize = true;
            this.label8kHz.Location = new System.Drawing.Point(372, 12);
            this.label8kHz.Name = "label8kHz";
            this.label8kHz.Size = new System.Drawing.Size(35, 13);
            this.label8kHz.TabIndex = 61;
            this.label8kHz.Text = "6 kHz";
            // 
            // label1kHz
            // 
            this.label1kHz.AutoSize = true;
            this.label1kHz.Location = new System.Drawing.Point(196, 12);
            this.label1kHz.Name = "label1kHz";
            this.label1kHz.Size = new System.Drawing.Size(41, 13);
            this.label1kHz.TabIndex = 59;
            this.label1kHz.Text = "700 Hz";
            // 
            // label100Hz
            // 
            this.label100Hz.AutoSize = true;
            this.label100Hz.Location = new System.Drawing.Point(70, 12);
            this.label100Hz.Name = "label100Hz";
            this.label100Hz.Size = new System.Drawing.Size(41, 13);
            this.label100Hz.TabIndex = 57;
            this.label100Hz.Text = "100 Hz";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(517, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 63;
            this.label2.Text = "Echo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // trackBarEcho
            // 
            this.trackBarEcho.AutoSize = false;
            this.trackBarEcho.Location = new System.Drawing.Point(526, 28);
            this.trackBarEcho.Maximum = 100;
            this.trackBarEcho.Name = "trackBarEcho";
            this.trackBarEcho.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarEcho.Size = new System.Drawing.Size(38, 138);
            this.trackBarEcho.TabIndex = 64;
            this.trackBarEcho.Tag = "echochorus";
            this.trackBarEcho.TickFrequency = 10;
            this.trackBarEcho.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarEcho.ValueChanged += new System.EventHandler(this.trackBarEcho_ValueChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(561, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 65;
            this.label3.Text = "Chorus";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // trackBarChorus
            // 
            this.trackBarChorus.AutoSize = false;
            this.trackBarChorus.Location = new System.Drawing.Point(569, 28);
            this.trackBarChorus.Maximum = 100;
            this.trackBarChorus.Name = "trackBarChorus";
            this.trackBarChorus.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarChorus.Size = new System.Drawing.Size(38, 138);
            this.trackBarChorus.TabIndex = 66;
            this.trackBarChorus.Tag = "echochorus";
            this.trackBarChorus.TickFrequency = 10;
            this.trackBarChorus.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarChorus.ValueChanged += new System.EventHandler(this.trackBarChorus_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(463, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 67;
            this.label7.Text = "-15dB";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(502, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 12);
            this.label9.TabIndex = 69;
            this.label9.Text = "Dry";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(500, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 12);
            this.label8.TabIndex = 68;
            this.label8.Text = "Wet";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(463, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 12);
            this.label6.TabIndex = 70;
            this.label6.Text = "+15dB";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.trackBar50EQ);
            this.groupBox3.Controls.Add(this.label50Hz);
            this.groupBox3.Controls.Add(this.trackBar8EQ);
            this.groupBox3.Controls.Add(this.label16kHz);
            this.groupBox3.Controls.Add(this.label5kHz);
            this.groupBox3.Controls.Add(this.label3kHz);
            this.groupBox3.Controls.Add(this.label700Hz);
            this.groupBox3.Controls.Add(this.label400Hz);
            this.groupBox3.Controls.Add(this.label7kHz);
            this.groupBox3.Controls.Add(this.trackBar1EQ);
            this.groupBox3.Controls.Add(this.trackBar2EQ);
            this.groupBox3.Controls.Add(this.trackBar4EQ);
            this.groupBox3.Controls.Add(this.trackBar6EQ);
            this.groupBox3.Controls.Add(this.trackBar700EQ);
            this.groupBox3.Controls.Add(this.trackBar400EQ);
            this.groupBox3.Controls.Add(this.trackBar200EQ);
            this.groupBox3.Controls.Add(this.trackBar100EQ);
            this.groupBox3.Controls.Add(this.label8kHz);
            this.groupBox3.Controls.Add(this.label1kHz);
            this.groupBox3.Controls.Add(this.label100Hz);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.trackBarEcho);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.trackBarChorus);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(37, 112);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(643, 188);
            this.groupBox3.TabIndex = 85;
            this.groupBox3.TabStop = false;
            this.groupBox3.Tag = "eq";
            this.groupBox3.Text = "Equalizer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 679);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBoxSpectrum);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btnNext);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpectrum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar50EQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar100EQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar200EQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar400EQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar700EQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1EQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2EQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4EQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6EQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8EQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEcho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarChorus)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbShuffle;
        private System.Windows.Forms.CheckBox cbLoop;
        private System.Windows.Forms.CheckBox cbMute;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.ToolStripMenuItem fetchFromServerToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBoxSpectrum;
        private System.Windows.Forms.Timer timerSpectrum;
        private System.Windows.Forms.TrackBar trackBar50EQ;
        private System.Windows.Forms.TrackBar trackBar100EQ;
        private System.Windows.Forms.TrackBar trackBar200EQ;
        private System.Windows.Forms.TrackBar trackBar400EQ;
        private System.Windows.Forms.TrackBar trackBar700EQ;
        private System.Windows.Forms.TrackBar trackBar1EQ;
        private System.Windows.Forms.TrackBar trackBar2EQ;
        private System.Windows.Forms.TrackBar trackBar4EQ;
        private System.Windows.Forms.TrackBar trackBar6EQ;
        private System.Windows.Forms.TrackBar trackBar8EQ;
        private System.Windows.Forms.Label label50Hz;
        
        private System.Windows.Forms.Label label16kHz;
        private System.Windows.Forms.Label label5kHz;
        private System.Windows.Forms.Label label3kHz;
        private System.Windows.Forms.Label label700Hz;
        private System.Windows.Forms.Label label400Hz;
        private System.Windows.Forms.Label label7kHz;
        
        
        
        
        
        
        private System.Windows.Forms.Label label8kHz;
        private System.Windows.Forms.Label label1kHz;
        private System.Windows.Forms.Label label100Hz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarEcho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBarChorus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;


    }
}

