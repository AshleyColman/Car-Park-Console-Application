namespace Assignment1Design
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
            this.lblOverPercent = new System.Windows.Forms.Label();
            this.lblWarden = new System.Windows.Forms.Label();
            this.lblAllotted = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtWarden = new System.Windows.Forms.TextBox();
            this.txtOverPercent = new System.Windows.Forms.TextBox();
            this.txtAllotted = new System.Windows.Forms.TextBox();
            this.txtTimeLimit = new System.Windows.Forms.TextBox();
            this.txtTimes = new System.Windows.Forms.TextBox();
            this.lblTimes = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.save2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.save3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.load2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.load3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.launchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtTimes2 = new System.Windows.Forms.TextBox();
            this.txtTimeLimit2 = new System.Windows.Forms.TextBox();
            this.txtAllotted2 = new System.Windows.Forms.TextBox();
            this.txtOverPercent2 = new System.Windows.Forms.TextBox();
            this.txtWarden2 = new System.Windows.Forms.TextBox();
            this.btnCalculate2 = new System.Windows.Forms.Button();
            this.txtCarParkName = new System.Windows.Forms.TextBox();
            this.txtCarParkName2 = new System.Windows.Forms.TextBox();
            this.txtCarParkName3 = new System.Windows.Forms.TextBox();
            this.txtTimes3 = new System.Windows.Forms.TextBox();
            this.txtTimeLimit3 = new System.Windows.Forms.TextBox();
            this.txtAllotted3 = new System.Windows.Forms.TextBox();
            this.txtOverPercent3 = new System.Windows.Forms.TextBox();
            this.txtWarden3 = new System.Windows.Forms.TextBox();
            this.btnCalculate3 = new System.Windows.Forms.Button();
            this.lblTimeLimit = new System.Windows.Forms.Label();
            this.lblTimeLimit2 = new System.Windows.Forms.Label();
            this.lblTimes2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWarden2 = new System.Windows.Forms.Label();
            this.lblOverPercent2 = new System.Windows.Forms.Label();
            this.lblCarParkName = new System.Windows.Forms.Label();
            this.lblCarParkName2 = new System.Windows.Forms.Label();
            this.lblCarParkName3 = new System.Windows.Forms.Label();
            this.lblTimeLimit3 = new System.Windows.Forms.Label();
            this.lblTimes3 = new System.Windows.Forms.Label();
            this.lblAllotted3 = new System.Windows.Forms.Label();
            this.lblWarden3 = new System.Windows.Forms.Label();
            this.lblOverPercent3 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOverPercent
            // 
            this.lblOverPercent.AutoSize = true;
            this.lblOverPercent.Location = new System.Drawing.Point(8, 182);
            this.lblOverPercent.Name = "lblOverPercent";
            this.lblOverPercent.Size = new System.Drawing.Size(138, 13);
            this.lblOverPercent.TabIndex = 1;
            this.lblOverPercent.Text = "Time Limit Over Percentage";
            // 
            // lblWarden
            // 
            this.lblWarden.AutoSize = true;
            this.lblWarden.Location = new System.Drawing.Point(8, 221);
            this.lblWarden.Name = "lblWarden";
            this.lblWarden.Size = new System.Drawing.Size(68, 13);
            this.lblWarden.TabIndex = 2;
            this.lblWarden.Text = "50 Percent +";
            // 
            // lblAllotted
            // 
            this.lblAllotted.AutoSize = true;
            this.lblAllotted.Location = new System.Drawing.Point(8, 143);
            this.lblAllotted.Name = "lblAllotted";
            this.lblAllotted.Size = new System.Drawing.Size(66, 13);
            this.lblAllotted.TabIndex = 3;
            this.lblAllotted.Text = "Stayed Over";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 263);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.toolTip1.SetToolTip(this.btnCalculate, "Click to calculate");
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtWarden
            // 
            this.txtWarden.Location = new System.Drawing.Point(11, 237);
            this.txtWarden.Name = "txtWarden";
            this.txtWarden.Size = new System.Drawing.Size(100, 20);
            this.txtWarden.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtWarden, "Does a warden need to be sent?");
            // 
            // txtOverPercent
            // 
            this.txtOverPercent.Location = new System.Drawing.Point(11, 198);
            this.txtOverPercent.Name = "txtOverPercent";
            this.txtOverPercent.Size = new System.Drawing.Size(100, 20);
            this.txtOverPercent.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtOverPercent, "Percentage of cars that stayed over the time limit ");
            // 
            // txtAllotted
            // 
            this.txtAllotted.Location = new System.Drawing.Point(11, 159);
            this.txtAllotted.Name = "txtAllotted";
            this.txtAllotted.Size = new System.Drawing.Size(100, 20);
            this.txtAllotted.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtAllotted, "Number of cars that stayed over the time limit");
            // 
            // txtTimeLimit
            // 
            this.txtTimeLimit.Location = new System.Drawing.Point(12, 118);
            this.txtTimeLimit.Name = "txtTimeLimit";
            this.txtTimeLimit.Size = new System.Drawing.Size(100, 20);
            this.txtTimeLimit.TabIndex = 10;
            this.toolTip1.SetToolTip(this.txtTimeLimit, "Enter the car park time limit here");
            // 
            // txtTimes
            // 
            this.txtTimes.Location = new System.Drawing.Point(152, 76);
            this.txtTimes.Multiline = true;
            this.txtTimes.Name = "txtTimes";
            this.txtTimes.Size = new System.Drawing.Size(100, 178);
            this.txtTimes.TabIndex = 11;
            this.toolTip1.SetToolTip(this.txtTimes, "List of times displayed here");
            // 
            // lblTimes
            // 
            this.lblTimes.AutoSize = true;
            this.lblTimes.Location = new System.Drawing.Point(183, 60);
            this.lblTimes.Name = "lblTimes";
            this.lblTimes.Size = new System.Drawing.Size(35, 13);
            this.lblTimes.TabIndex = 12;
            this.lblTimes.Text = "Times";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "msMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.save2ToolStripMenuItem,
            this.save3ToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.load2ToolStripMenuItem,
            this.load3ToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.ToolTipText = "Click for file options";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.ToolTipText = "Click to exit the application";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.saveToolStripMenuItem.Text = "Save1";
            this.saveToolStripMenuItem.ToolTipText = "Click to save the first car park";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // save2ToolStripMenuItem
            // 
            this.save2ToolStripMenuItem.Name = "save2ToolStripMenuItem";
            this.save2ToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.save2ToolStripMenuItem.Text = "Save2";
            this.save2ToolStripMenuItem.ToolTipText = "Click to save the second car park";
            this.save2ToolStripMenuItem.Click += new System.EventHandler(this.save2ToolStripMenuItem_Click);
            // 
            // save3ToolStripMenuItem
            // 
            this.save3ToolStripMenuItem.Name = "save3ToolStripMenuItem";
            this.save3ToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.save3ToolStripMenuItem.Text = "Save3";
            this.save3ToolStripMenuItem.ToolTipText = "Click to save the third car park";
            this.save3ToolStripMenuItem.Click += new System.EventHandler(this.save3ToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.loadToolStripMenuItem.Text = "Load1";
            this.loadToolStripMenuItem.ToolTipText = "Click to load the first car park";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // load2ToolStripMenuItem
            // 
            this.load2ToolStripMenuItem.Name = "load2ToolStripMenuItem";
            this.load2ToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.load2ToolStripMenuItem.Text = "Load2";
            this.load2ToolStripMenuItem.ToolTipText = "Click to load the second car park";
            this.load2ToolStripMenuItem.Click += new System.EventHandler(this.load2ToolStripMenuItem_Click);
            // 
            // load3ToolStripMenuItem
            // 
            this.load3ToolStripMenuItem.Name = "load3ToolStripMenuItem";
            this.load3ToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.load3ToolStripMenuItem.Text = "Load3";
            this.load3ToolStripMenuItem.ToolTipText = "Click to load the third car park";
            this.load3ToolStripMenuItem.Click += new System.EventHandler(this.load3ToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.launchToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.ToolTipText = "Click for help options";
            // 
            // launchToolStripMenuItem
            // 
            this.launchToolStripMenuItem.Name = "launchToolStripMenuItem";
            this.launchToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.launchToolStripMenuItem.Text = "Launch";
            this.launchToolStripMenuItem.ToolTipText = "Click to launch help webpage";
            this.launchToolStripMenuItem.Click += new System.EventHandler(this.launchToolStripMenuItem_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(148, 13);
            this.lblTitle.TabIndex = 41;
            this.lblTitle.Text = "Please enter the details below";
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // txtTimes2
            // 
            this.txtTimes2.Location = new System.Drawing.Point(413, 76);
            this.txtTimes2.Multiline = true;
            this.txtTimes2.Name = "txtTimes2";
            this.txtTimes2.Size = new System.Drawing.Size(100, 178);
            this.txtTimes2.TabIndex = 51;
            this.toolTip1.SetToolTip(this.txtTimes2, "List of times displayed here");
            // 
            // txtTimeLimit2
            // 
            this.txtTimeLimit2.Location = new System.Drawing.Point(273, 118);
            this.txtTimeLimit2.Name = "txtTimeLimit2";
            this.txtTimeLimit2.Size = new System.Drawing.Size(100, 20);
            this.txtTimeLimit2.TabIndex = 50;
            this.toolTip1.SetToolTip(this.txtTimeLimit2, "Enter the car park time limit here");
            // 
            // txtAllotted2
            // 
            this.txtAllotted2.Location = new System.Drawing.Point(272, 159);
            this.txtAllotted2.Name = "txtAllotted2";
            this.txtAllotted2.Size = new System.Drawing.Size(100, 20);
            this.txtAllotted2.TabIndex = 49;
            this.toolTip1.SetToolTip(this.txtAllotted2, "Number of cars that stayed over the time limit");
            // 
            // txtOverPercent2
            // 
            this.txtOverPercent2.Location = new System.Drawing.Point(272, 198);
            this.txtOverPercent2.Name = "txtOverPercent2";
            this.txtOverPercent2.Size = new System.Drawing.Size(100, 20);
            this.txtOverPercent2.TabIndex = 48;
            this.toolTip1.SetToolTip(this.txtOverPercent2, "Percentage of cars that stayed over the time limit ");
            // 
            // txtWarden2
            // 
            this.txtWarden2.Location = new System.Drawing.Point(272, 237);
            this.txtWarden2.Name = "txtWarden2";
            this.txtWarden2.Size = new System.Drawing.Size(100, 20);
            this.txtWarden2.TabIndex = 47;
            this.toolTip1.SetToolTip(this.txtWarden2, "Does a warden need to be sent?");
            // 
            // btnCalculate2
            // 
            this.btnCalculate2.Location = new System.Drawing.Point(273, 263);
            this.btnCalculate2.Name = "btnCalculate2";
            this.btnCalculate2.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate2.TabIndex = 46;
            this.btnCalculate2.Text = "Calculate";
            this.toolTip1.SetToolTip(this.btnCalculate2, "Click to calculate");
            this.btnCalculate2.UseVisualStyleBackColor = true;
            this.btnCalculate2.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCarParkName
            // 
            this.txtCarParkName.Location = new System.Drawing.Point(11, 79);
            this.txtCarParkName.Name = "txtCarParkName";
            this.txtCarParkName.Size = new System.Drawing.Size(100, 20);
            this.txtCarParkName.TabIndex = 54;
            this.toolTip1.SetToolTip(this.txtCarParkName, "Enter the car park name here");
            // 
            // txtCarParkName2
            // 
            this.txtCarParkName2.Location = new System.Drawing.Point(273, 79);
            this.txtCarParkName2.Name = "txtCarParkName2";
            this.txtCarParkName2.Size = new System.Drawing.Size(100, 20);
            this.txtCarParkName2.TabIndex = 56;
            this.toolTip1.SetToolTip(this.txtCarParkName2, "Enter the car park name here");
            // 
            // txtCarParkName3
            // 
            this.txtCarParkName3.Location = new System.Drawing.Point(537, 79);
            this.txtCarParkName3.Name = "txtCarParkName3";
            this.txtCarParkName3.Size = new System.Drawing.Size(100, 20);
            this.txtCarParkName3.TabIndex = 69;
            this.toolTip1.SetToolTip(this.txtCarParkName3, "Enter the car park name here");
            // 
            // txtTimes3
            // 
            this.txtTimes3.Location = new System.Drawing.Point(677, 76);
            this.txtTimes3.Multiline = true;
            this.txtTimes3.Name = "txtTimes3";
            this.txtTimes3.Size = new System.Drawing.Size(100, 178);
            this.txtTimes3.TabIndex = 66;
            this.toolTip1.SetToolTip(this.txtTimes3, "List of times displayed here");
            // 
            // txtTimeLimit3
            // 
            this.txtTimeLimit3.Location = new System.Drawing.Point(537, 118);
            this.txtTimeLimit3.Name = "txtTimeLimit3";
            this.txtTimeLimit3.Size = new System.Drawing.Size(100, 20);
            this.txtTimeLimit3.TabIndex = 65;
            this.toolTip1.SetToolTip(this.txtTimeLimit3, "Enter the car park time limit here");
            // 
            // txtAllotted3
            // 
            this.txtAllotted3.Location = new System.Drawing.Point(536, 159);
            this.txtAllotted3.Name = "txtAllotted3";
            this.txtAllotted3.Size = new System.Drawing.Size(100, 20);
            this.txtAllotted3.TabIndex = 64;
            this.toolTip1.SetToolTip(this.txtAllotted3, "Number of cars that stayed over the time limit");
            // 
            // txtOverPercent3
            // 
            this.txtOverPercent3.Location = new System.Drawing.Point(536, 198);
            this.txtOverPercent3.Name = "txtOverPercent3";
            this.txtOverPercent3.Size = new System.Drawing.Size(100, 20);
            this.txtOverPercent3.TabIndex = 63;
            this.toolTip1.SetToolTip(this.txtOverPercent3, "Percentage of cars that stayed over the time limit ");
            // 
            // txtWarden3
            // 
            this.txtWarden3.Location = new System.Drawing.Point(536, 237);
            this.txtWarden3.Name = "txtWarden3";
            this.txtWarden3.Size = new System.Drawing.Size(100, 20);
            this.txtWarden3.TabIndex = 62;
            this.toolTip1.SetToolTip(this.txtWarden3, "Does a warden need to be sent?");
            // 
            // btnCalculate3
            // 
            this.btnCalculate3.Location = new System.Drawing.Point(537, 263);
            this.btnCalculate3.Name = "btnCalculate3";
            this.btnCalculate3.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate3.TabIndex = 61;
            this.btnCalculate3.Text = "Calculate";
            this.toolTip1.SetToolTip(this.btnCalculate3, "Click to calculate");
            this.btnCalculate3.UseVisualStyleBackColor = true;
            this.btnCalculate3.Click += new System.EventHandler(this.btnCalculate3_Click);
            // 
            // lblTimeLimit
            // 
            this.lblTimeLimit.AutoSize = true;
            this.lblTimeLimit.Location = new System.Drawing.Point(9, 102);
            this.lblTimeLimit.Name = "lblTimeLimit";
            this.lblTimeLimit.Size = new System.Drawing.Size(54, 13);
            this.lblTimeLimit.TabIndex = 42;
            this.lblTimeLimit.Text = "Time Limit";
            // 
            // lblTimeLimit2
            // 
            this.lblTimeLimit2.AutoSize = true;
            this.lblTimeLimit2.Location = new System.Drawing.Point(270, 102);
            this.lblTimeLimit2.Name = "lblTimeLimit2";
            this.lblTimeLimit2.Size = new System.Drawing.Size(54, 13);
            this.lblTimeLimit2.TabIndex = 53;
            this.lblTimeLimit2.Text = "Time Limit";
            // 
            // lblTimes2
            // 
            this.lblTimes2.AutoSize = true;
            this.lblTimes2.Location = new System.Drawing.Point(444, 60);
            this.lblTimes2.Name = "lblTimes2";
            this.lblTimes2.Size = new System.Drawing.Size(35, 13);
            this.lblTimes2.TabIndex = 52;
            this.lblTimes2.Text = "Times";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Stayed Over";
            // 
            // lblWarden2
            // 
            this.lblWarden2.AutoSize = true;
            this.lblWarden2.Location = new System.Drawing.Point(269, 221);
            this.lblWarden2.Name = "lblWarden2";
            this.lblWarden2.Size = new System.Drawing.Size(68, 13);
            this.lblWarden2.TabIndex = 44;
            this.lblWarden2.Text = "50 Percent +";
            // 
            // lblOverPercent2
            // 
            this.lblOverPercent2.AutoSize = true;
            this.lblOverPercent2.Location = new System.Drawing.Point(269, 182);
            this.lblOverPercent2.Name = "lblOverPercent2";
            this.lblOverPercent2.Size = new System.Drawing.Size(138, 13);
            this.lblOverPercent2.TabIndex = 43;
            this.lblOverPercent2.Text = "Time Limit Over Percentage";
            // 
            // lblCarParkName
            // 
            this.lblCarParkName.AutoSize = true;
            this.lblCarParkName.Location = new System.Drawing.Point(8, 63);
            this.lblCarParkName.Name = "lblCarParkName";
            this.lblCarParkName.Size = new System.Drawing.Size(60, 13);
            this.lblCarParkName.TabIndex = 55;
            this.lblCarParkName.Text = "Park Name";
            // 
            // lblCarParkName2
            // 
            this.lblCarParkName2.AutoSize = true;
            this.lblCarParkName2.Location = new System.Drawing.Point(270, 63);
            this.lblCarParkName2.Name = "lblCarParkName2";
            this.lblCarParkName2.Size = new System.Drawing.Size(60, 13);
            this.lblCarParkName2.TabIndex = 57;
            this.lblCarParkName2.Text = "Park Name";
            // 
            // lblCarParkName3
            // 
            this.lblCarParkName3.AutoSize = true;
            this.lblCarParkName3.Location = new System.Drawing.Point(534, 63);
            this.lblCarParkName3.Name = "lblCarParkName3";
            this.lblCarParkName3.Size = new System.Drawing.Size(60, 13);
            this.lblCarParkName3.TabIndex = 70;
            this.lblCarParkName3.Text = "Park Name";
            // 
            // lblTimeLimit3
            // 
            this.lblTimeLimit3.AutoSize = true;
            this.lblTimeLimit3.Location = new System.Drawing.Point(534, 102);
            this.lblTimeLimit3.Name = "lblTimeLimit3";
            this.lblTimeLimit3.Size = new System.Drawing.Size(54, 13);
            this.lblTimeLimit3.TabIndex = 68;
            this.lblTimeLimit3.Text = "Time Limit";
            // 
            // lblTimes3
            // 
            this.lblTimes3.AutoSize = true;
            this.lblTimes3.Location = new System.Drawing.Point(708, 60);
            this.lblTimes3.Name = "lblTimes3";
            this.lblTimes3.Size = new System.Drawing.Size(35, 13);
            this.lblTimes3.TabIndex = 67;
            this.lblTimes3.Text = "Times";
            // 
            // lblAllotted3
            // 
            this.lblAllotted3.AutoSize = true;
            this.lblAllotted3.Location = new System.Drawing.Point(533, 143);
            this.lblAllotted3.Name = "lblAllotted3";
            this.lblAllotted3.Size = new System.Drawing.Size(66, 13);
            this.lblAllotted3.TabIndex = 60;
            this.lblAllotted3.Text = "Stayed Over";
            // 
            // lblWarden3
            // 
            this.lblWarden3.AutoSize = true;
            this.lblWarden3.Location = new System.Drawing.Point(533, 221);
            this.lblWarden3.Name = "lblWarden3";
            this.lblWarden3.Size = new System.Drawing.Size(68, 13);
            this.lblWarden3.TabIndex = 59;
            this.lblWarden3.Text = "50 Percent +";
            // 
            // lblOverPercent3
            // 
            this.lblOverPercent3.AutoSize = true;
            this.lblOverPercent3.Location = new System.Drawing.Point(533, 182);
            this.lblOverPercent3.Name = "lblOverPercent3";
            this.lblOverPercent3.Size = new System.Drawing.Size(138, 13);
            this.lblOverPercent3.TabIndex = 58;
            this.lblOverPercent3.Text = "Time Limit Over Percentage";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "\\\\svr-cs-03\\homedrives$\\WS243476\\My Documents\\IT Practitioners\\A3 Car Park Progra" +
    "m Complete\\Help.htm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 298);
            this.Controls.Add(this.lblCarParkName3);
            this.Controls.Add(this.txtCarParkName3);
            this.Controls.Add(this.lblTimeLimit3);
            this.Controls.Add(this.lblTimes3);
            this.Controls.Add(this.txtTimes3);
            this.Controls.Add(this.txtTimeLimit3);
            this.Controls.Add(this.txtAllotted3);
            this.Controls.Add(this.txtOverPercent3);
            this.Controls.Add(this.txtWarden3);
            this.Controls.Add(this.btnCalculate3);
            this.Controls.Add(this.lblAllotted3);
            this.Controls.Add(this.lblWarden3);
            this.Controls.Add(this.lblOverPercent3);
            this.Controls.Add(this.lblCarParkName2);
            this.Controls.Add(this.txtCarParkName2);
            this.Controls.Add(this.lblCarParkName);
            this.Controls.Add(this.txtCarParkName);
            this.Controls.Add(this.lblTimeLimit2);
            this.Controls.Add(this.lblTimes2);
            this.Controls.Add(this.txtTimes2);
            this.Controls.Add(this.txtTimeLimit2);
            this.Controls.Add(this.txtAllotted2);
            this.Controls.Add(this.txtOverPercent2);
            this.Controls.Add(this.txtWarden2);
            this.Controls.Add(this.btnCalculate2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblWarden2);
            this.Controls.Add(this.lblOverPercent2);
            this.Controls.Add(this.lblTimeLimit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTimes);
            this.Controls.Add(this.txtTimes);
            this.Controls.Add(this.txtTimeLimit);
            this.Controls.Add(this.txtAllotted);
            this.Controls.Add(this.txtOverPercent);
            this.Controls.Add(this.txtWarden);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblAllotted);
            this.Controls.Add(this.lblWarden);
            this.Controls.Add(this.lblOverPercent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Car Park Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOverPercent;
        private System.Windows.Forms.Label lblWarden;
        private System.Windows.Forms.Label lblAllotted;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtWarden;
        private System.Windows.Forms.TextBox txtOverPercent;
        private System.Windows.Forms.TextBox txtAllotted;
        private System.Windows.Forms.TextBox txtTimeLimit;
        private System.Windows.Forms.TextBox txtTimes;
        private System.Windows.Forms.Label lblTimes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem launchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblTimeLimit;
        private System.Windows.Forms.Label lblTimeLimit2;
        private System.Windows.Forms.Label lblTimes2;
        private System.Windows.Forms.TextBox txtTimes2;
        private System.Windows.Forms.TextBox txtTimeLimit2;
        private System.Windows.Forms.TextBox txtAllotted2;
        private System.Windows.Forms.TextBox txtOverPercent2;
        private System.Windows.Forms.TextBox txtWarden2;
        private System.Windows.Forms.Button btnCalculate2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWarden2;
        private System.Windows.Forms.Label lblOverPercent2;
        private System.Windows.Forms.Label lblCarParkName;
        private System.Windows.Forms.TextBox txtCarParkName;
        private System.Windows.Forms.Label lblCarParkName2;
        private System.Windows.Forms.TextBox txtCarParkName2;
        private System.Windows.Forms.Label lblCarParkName3;
        private System.Windows.Forms.TextBox txtCarParkName3;
        private System.Windows.Forms.Label lblTimeLimit3;
        private System.Windows.Forms.Label lblTimes3;
        private System.Windows.Forms.TextBox txtTimes3;
        private System.Windows.Forms.TextBox txtTimeLimit3;
        private System.Windows.Forms.TextBox txtAllotted3;
        private System.Windows.Forms.TextBox txtOverPercent3;
        private System.Windows.Forms.TextBox txtWarden3;
        private System.Windows.Forms.Button btnCalculate3;
        private System.Windows.Forms.Label lblAllotted3;
        private System.Windows.Forms.Label lblWarden3;
        private System.Windows.Forms.Label lblOverPercent3;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ToolStripMenuItem save2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem save3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem load2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem load3ToolStripMenuItem;
    }
}

