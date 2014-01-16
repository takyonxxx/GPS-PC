namespace ReadGPS
{
    partial class frmPP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPP));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tIMERSPEEDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.bAUDRATEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gps_status = new System.Windows.Forms.Label();
            this.sattime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.picGSVSkyview = new System.Windows.Forms.PictureBox();
            this.BRate = new System.Windows.Forms.Label();
            this.compass = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.satstatus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.signal = new System.Windows.Forms.Label();
            this.satnumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gps_fix = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_forward = new System.Windows.Forms.Button();
            this.txt_mp3status = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_addfolder = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.alttxt = new System.Windows.Forms.Label();
            this.speedtxt = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGSVSkyview)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(10, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Stop Updates";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Latitude:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(212, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Longitude:";
            // 
            // txtLat
            // 
            this.txtLat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtLat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLat.ForeColor = System.Drawing.Color.White;
            this.txtLat.Location = new System.Drawing.Point(76, 7);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(118, 27);
            this.txtLat.TabIndex = 4;
            this.txtLat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLong
            // 
            this.txtLong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtLong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLong.ForeColor = System.Drawing.Color.White;
            this.txtLong.Location = new System.Drawing.Point(295, 7);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(118, 27);
            this.txtLong.TabIndex = 5;
            this.txtLong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Teal;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tIMERSPEEDToolStripMenuItem,
            this.bAUDRATEToolStripMenuItem,
            this.eXITToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(801, 25);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.openMapToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.exitToolStripMenuItem.Text = "Start Record";
            // 
            // openMapToolStripMenuItem
            // 
            this.openMapToolStripMenuItem.Name = "openMapToolStripMenuItem";
            this.openMapToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.openMapToolStripMenuItem.Text = "Open Map";
            this.openMapToolStripMenuItem.Click += new System.EventHandler(this.openMapToolStripMenuItem_Click);
            // 
            // tIMERSPEEDToolStripMenuItem
            // 
            this.tIMERSPEEDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.tIMERSPEEDToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tIMERSPEEDToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tIMERSPEEDToolStripMenuItem.Name = "tIMERSPEEDToolStripMenuItem";
            this.tIMERSPEEDToolStripMenuItem.Size = new System.Drawing.Size(97, 21);
            this.tIMERSPEEDToolStripMenuItem.Text = "Timer Speed";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(104, 22);
            this.toolStripMenuItem2.Text = "250";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(104, 22);
            this.toolStripMenuItem3.Text = "500";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(104, 22);
            this.toolStripMenuItem4.Text = "750";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(104, 22);
            this.toolStripMenuItem5.Text = "1000";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(104, 22);
            this.toolStripMenuItem6.Text = "2000";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // bAUDRATEToolStripMenuItem
            // 
            this.bAUDRATEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11,
            this.toolStripMenuItem12,
            this.toolStripMenuItem13});
            this.bAUDRATEToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bAUDRATEToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.bAUDRATEToolStripMenuItem.Name = "bAUDRATEToolStripMenuItem";
            this.bAUDRATEToolStripMenuItem.Size = new System.Drawing.Size(82, 21);
            this.bAUDRATEToolStripMenuItem.Text = "Baud Rate";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItem7.Text = "2400";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItem8.Text = "4800";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItem9.Text = "9600";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItem10.Text = "19200";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem10_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItem11.Text = "38400";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.toolStripMenuItem11_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItem12.Text = "57600";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.toolStripMenuItem12_Click);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItem13.Text = "115200";
            this.toolStripMenuItem13.Click += new System.EventHandler(this.toolStripMenuItem13_Click);
            // 
            // eXITToolStripMenuItem1
            // 
            this.eXITToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eXITToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.eXITToolStripMenuItem1.Name = "eXITToolStripMenuItem1";
            this.eXITToolStripMenuItem1.Size = new System.Drawing.Size(43, 21);
            this.eXITToolStripMenuItem1.Text = "Exit";
            this.eXITToolStripMenuItem1.Click += new System.EventHandler(this.eXITToolStripMenuItem1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.gps_status);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.sattime);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 29);
            this.panel1.TabIndex = 9;
            // 
            // gps_status
            // 
            this.gps_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gps_status.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gps_status.ForeColor = System.Drawing.Color.White;
            this.gps_status.Location = new System.Drawing.Point(418, 3);
            this.gps_status.Name = "gps_status";
            this.gps_status.Size = new System.Drawing.Size(379, 23);
            this.gps_status.TabIndex = 2;
            this.gps_status.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sattime
            // 
            this.sattime.BackColor = System.Drawing.Color.Black;
            this.sattime.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sattime.ForeColor = System.Drawing.Color.Lime;
            this.sattime.Location = new System.Drawing.Point(119, 3);
            this.sattime.Name = "sattime";
            this.sattime.Size = new System.Drawing.Size(293, 23);
            this.sattime.TabIndex = 10;
            this.sattime.Text = "TIME";
            this.sattime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(3, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 361);
            this.panel2.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.picGSVSkyview);
            this.panel4.Controls.Add(this.BRate);
            this.panel4.Controls.Add(this.compass);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.satstatus);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.signal);
            this.panel4.Controls.Add(this.satnumber);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.gps_fix);
            this.panel4.Location = new System.Drawing.Point(7, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(777, 81);
            this.panel4.TabIndex = 38;
            // 
            // picGSVSkyview
            // 
            this.picGSVSkyview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picGSVSkyview.BackColor = System.Drawing.Color.Black;
            this.picGSVSkyview.Location = new System.Drawing.Point(504, 0);
            this.picGSVSkyview.Name = "picGSVSkyview";
            this.picGSVSkyview.Size = new System.Drawing.Size(102, 81);
            this.picGSVSkyview.TabIndex = 39;
            this.picGSVSkyview.TabStop = false;
            // 
            // BRate
            // 
            this.BRate.BackColor = System.Drawing.Color.Gainsboro;
            this.BRate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BRate.ForeColor = System.Drawing.Color.Black;
            this.BRate.Location = new System.Drawing.Point(408, 13);
            this.BRate.Name = "BRate";
            this.BRate.Size = new System.Drawing.Size(64, 23);
            this.BRate.TabIndex = 37;
            this.BRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // compass
            // 
            this.compass.BackColor = System.Drawing.Color.Yellow;
            this.compass.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.compass.ForeColor = System.Drawing.Color.Black;
            this.compass.Location = new System.Drawing.Point(386, 42);
            this.compass.Name = "compass";
            this.compass.Size = new System.Drawing.Size(86, 23);
            this.compass.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(617, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 81);
            this.label3.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(255, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Status:";
            // 
            // satstatus
            // 
            this.satstatus.BackColor = System.Drawing.Color.Red;
            this.satstatus.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satstatus.ForeColor = System.Drawing.Color.White;
            this.satstatus.Location = new System.Drawing.Point(344, 42);
            this.satstatus.Name = "satstatus";
            this.satstatus.Size = new System.Drawing.Size(36, 23);
            this.satstatus.TabIndex = 18;
            this.satstatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(255, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Signal Db:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Sat Number:";
            // 
            // signal
            // 
            this.signal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.signal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.signal.ForeColor = System.Drawing.Color.Black;
            this.signal.Location = new System.Drawing.Point(344, 13);
            this.signal.Name = "signal";
            this.signal.Size = new System.Drawing.Size(58, 23);
            this.signal.TabIndex = 14;
            this.signal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // satnumber
            // 
            this.satnumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.satnumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satnumber.ForeColor = System.Drawing.Color.Black;
            this.satnumber.Location = new System.Drawing.Point(106, 39);
            this.satnumber.Name = "satnumber";
            this.satnumber.Size = new System.Drawing.Size(128, 23);
            this.satnumber.TabIndex = 13;
            this.satnumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Gps Status:";
            // 
            // gps_fix
            // 
            this.gps_fix.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gps_fix.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gps_fix.ForeColor = System.Drawing.Color.Black;
            this.gps_fix.Location = new System.Drawing.Point(106, 10);
            this.gps_fix.Name = "gps_fix";
            this.gps_fix.Size = new System.Drawing.Size(128, 23);
            this.gps_fix.TabIndex = 9;
            this.gps_fix.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.progressBar1);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.listBox1);
            this.panel3.Controls.Add(this.alttxt);
            this.panel3.Controls.Add(this.speedtxt);
            this.panel3.Controls.Add(this.txtLat);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtLong);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(7, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(778, 270);
            this.panel3.TabIndex = 17;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(424, 243);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(351, 14);
            this.progressBar1.TabIndex = 40;
            this.progressBar1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.progressBar1_MouseMove);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btn_back);
            this.panel5.Controls.Add(this.btn_forward);
            this.panel5.Controls.Add(this.txt_mp3status);
            this.panel5.Controls.Add(this.btn_start);
            this.panel5.Controls.Add(this.btn_addfolder);
            this.panel5.Location = new System.Drawing.Point(424, 7);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(351, 27);
            this.panel5.TabIndex = 39;
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.Black;
            this.btn_back.Location = new System.Drawing.Point(119, 1);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(38, 23);
            this.btn_back.TabIndex = 41;
            this.btn_back.Text = "<<";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_forward
            // 
            this.btn_forward.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_forward.ForeColor = System.Drawing.Color.Black;
            this.btn_forward.Location = new System.Drawing.Point(163, 1);
            this.btn_forward.Name = "btn_forward";
            this.btn_forward.Size = new System.Drawing.Size(38, 23);
            this.btn_forward.TabIndex = 40;
            this.btn_forward.Text = ">>";
            this.btn_forward.UseVisualStyleBackColor = true;
            this.btn_forward.Click += new System.EventHandler(this.btn_forward_Click);
            // 
            // txt_mp3status
            // 
            this.txt_mp3status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_mp3status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mp3status.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_mp3status.ForeColor = System.Drawing.Color.White;
            this.txt_mp3status.Location = new System.Drawing.Point(-1, -1);
            this.txt_mp3status.Name = "txt_mp3status";
            this.txt_mp3status.Size = new System.Drawing.Size(114, 23);
            this.txt_mp3status.TabIndex = 39;
            this.txt_mp3status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_start
            // 
            this.btn_start.Enabled = false;
            this.btn_start.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_start.ForeColor = System.Drawing.Color.Black;
            this.btn_start.Location = new System.Drawing.Point(209, 1);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(53, 23);
            this.btn_start.TabIndex = 38;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_addfolder
            // 
            this.btn_addfolder.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addfolder.ForeColor = System.Drawing.Color.Black;
            this.btn_addfolder.Location = new System.Drawing.Point(268, 1);
            this.btn_addfolder.Name = "btn_addfolder";
            this.btn_addfolder.Size = new System.Drawing.Size(80, 23);
            this.btn_addfolder.TabIndex = 37;
            this.btn_addfolder.Text = "ADD FOLDER";
            this.btn_addfolder.UseVisualStyleBackColor = true;
            this.btn_addfolder.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.ItemHeight = 11;
            this.listBox1.Location = new System.Drawing.Point(424, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(351, 200);
            this.listBox1.TabIndex = 36;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // alttxt
            // 
            this.alttxt.BackColor = System.Drawing.Color.Gray;
            this.alttxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alttxt.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alttxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.alttxt.Location = new System.Drawing.Point(6, 199);
            this.alttxt.Name = "alttxt";
            this.alttxt.Size = new System.Drawing.Size(407, 58);
            this.alttxt.TabIndex = 34;
            this.alttxt.Text = "0";
            this.alttxt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // speedtxt
            // 
            this.speedtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.speedtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.speedtxt.Font = new System.Drawing.Font("Tahoma", 102F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.speedtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.speedtxt.Location = new System.Drawing.Point(6, 37);
            this.speedtxt.Name = "speedtxt";
            this.speedtxt.Size = new System.Drawing.Size(407, 162);
            this.speedtxt.TabIndex = 35;
            this.speedtxt.Text = "0";
            this.speedtxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 422);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turkay Gps Pc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPP_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGSVSkyview)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label gps_status;
        private System.Windows.Forms.Label sattime;
        private System.Windows.Forms.Label gps_fix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label signal;
        private System.Windows.Forms.Label satnumber;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label compass;
        private System.Windows.Forms.Label alttxt;
        private System.Windows.Forms.Label speedtxt;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openMapToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label satstatus;
        private System.Windows.Forms.PictureBox picGSVSkyview;
        private System.Windows.Forms.Label BRate;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStripMenuItem tIMERSPEEDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem bAUDRATEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_addfolder;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt_mp3status;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_forward;
        private System.Windows.Forms.Button btn_back;
    }
}

