namespace Ascension.Forms.Dialog.Extras
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTabControl = new MetroFramework.Controls.MetroTabControl();
            this.PAGE1 = new MetroFramework.Controls.MetroTabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.metroCheckBox3 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox2 = new MetroFramework.Controls.MetroCheckBox();
            this.noclipCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.debugCameraCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.PAGE2 = new MetroFramework.Controls.MetroTabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TOOL_DEBUG = new MetroFramework.Controls.MetroTabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.commandline = new System.Windows.Forms.TextBox();
            this.connectTxt = new System.Windows.Forms.Label();
            this.versionTxt = new System.Windows.Forms.Label();
            this.mousedrag = new System.Windows.Forms.Panel();
            this.connect = new MetroFramework.Controls.MetroButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MainTabControl.SuspendLayout();
            this.PAGE1.SuspendLayout();
            this.PAGE2.SuspendLayout();
            this.TOOL_DEBUG.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.mousedrag.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.CausesValidation = false;
            this.MainTabControl.Controls.Add(this.PAGE1);
            this.MainTabControl.Controls.Add(this.PAGE2);
            this.MainTabControl.Controls.Add(this.TOOL_DEBUG);
            this.MainTabControl.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.MainTabControl.Location = new System.Drawing.Point(0, 11);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(517, 323);
            this.MainTabControl.Style = MetroFramework.MetroColorStyle.White;
            this.MainTabControl.TabIndex = 291;
            this.MainTabControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MainTabControl.UseSelectable = true;
            this.MainTabControl.UseStyleColors = true;
            this.MainTabControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.metroTabControl1_KeyDown);
            // 
            // PAGE1
            // 
            this.PAGE1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.PAGE1.Controls.Add(this.label2);
            this.PAGE1.Controls.Add(this.metroCheckBox3);
            this.PAGE1.Controls.Add(this.metroCheckBox2);
            this.PAGE1.Controls.Add(this.noclipCheckBox);
            this.PAGE1.Controls.Add(this.debugCameraCheckBox);
            this.PAGE1.HorizontalScrollbarBarColor = true;
            this.PAGE1.HorizontalScrollbarHighlightOnWheel = false;
            this.PAGE1.HorizontalScrollbarSize = 10;
            this.PAGE1.Location = new System.Drawing.Point(4, 38);
            this.PAGE1.Name = "PAGE1";
            this.PAGE1.Size = new System.Drawing.Size(509, 281);
            this.PAGE1.TabIndex = 6;
            this.PAGE1.Text = "Functions /";
            this.PAGE1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PAGE1.UseCustomBackColor = true;
            this.PAGE1.UseCustomForeColor = true;
            this.PAGE1.VerticalScrollbarBarColor = true;
            this.PAGE1.VerticalScrollbarHighlightOnWheel = false;
            this.PAGE1.VerticalScrollbarSize = 10;
            this.PAGE1.Click += new System.EventHandler(this.FunctionsBeta_Click);
            this.PAGE1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.FunctionsBeta_PreviewKeyDown);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(149, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 34);
            this.label2.TabIndex = 349;
            this.label2.Text = "[ UNDER CONSTRUCTION ]";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroCheckBox3
            // 
            this.metroCheckBox3.AutoSize = true;
            this.metroCheckBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroCheckBox3.Enabled = false;
            this.metroCheckBox3.ForeColor = System.Drawing.Color.Silver;
            this.metroCheckBox3.Location = new System.Drawing.Point(8, 78);
            this.metroCheckBox3.Name = "metroCheckBox3";
            this.metroCheckBox3.Size = new System.Drawing.Size(125, 15);
            this.metroCheckBox3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroCheckBox3.TabIndex = 389;
            this.metroCheckBox3.Text = "(Not implemented)";
            this.metroCheckBox3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox3.UseCustomBackColor = true;
            this.metroCheckBox3.UseCustomForeColor = true;
            this.metroCheckBox3.UseSelectable = true;
            // 
            // metroCheckBox2
            // 
            this.metroCheckBox2.AutoSize = true;
            this.metroCheckBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroCheckBox2.Enabled = false;
            this.metroCheckBox2.ForeColor = System.Drawing.Color.Silver;
            this.metroCheckBox2.Location = new System.Drawing.Point(8, 57);
            this.metroCheckBox2.Name = "metroCheckBox2";
            this.metroCheckBox2.Size = new System.Drawing.Size(125, 15);
            this.metroCheckBox2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroCheckBox2.TabIndex = 388;
            this.metroCheckBox2.Text = "(Not implemented)";
            this.metroCheckBox2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox2.UseCustomBackColor = true;
            this.metroCheckBox2.UseCustomForeColor = true;
            this.metroCheckBox2.UseSelectable = true;
            // 
            // noclipCheckBox
            // 
            this.noclipCheckBox.AutoSize = true;
            this.noclipCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.noclipCheckBox.Enabled = true;
            this.noclipCheckBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.noclipCheckBox.Location = new System.Drawing.Point(8, 36);
            this.noclipCheckBox.Name = "noclipCheckBox";
            this.noclipCheckBox.Size = new System.Drawing.Size(58, 15);
            this.noclipCheckBox.Style = MetroFramework.MetroColorStyle.Red;
            this.noclipCheckBox.TabIndex = 387;
            this.noclipCheckBox.Text = "Noclip";
            this.noclipCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.noclipCheckBox.UseCustomBackColor = true;
            this.noclipCheckBox.UseCustomForeColor = true;
            this.noclipCheckBox.UseSelectable = true;
            this.noclipCheckBox.CheckedChanged += new System.EventHandler(this.noclipCheckBox_CheckedChanged);
            // 
            // debugCameraCheckBox
            // 
            this.debugCameraCheckBox.AutoSize = true;
            this.debugCameraCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.debugCameraCheckBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.debugCameraCheckBox.Location = new System.Drawing.Point(8, 15);
            this.debugCameraCheckBox.Name = "debugCameraCheckBox";
            this.debugCameraCheckBox.Size = new System.Drawing.Size(102, 15);
            this.debugCameraCheckBox.Style = MetroFramework.MetroColorStyle.Red;
            this.debugCameraCheckBox.TabIndex = 386;
            this.debugCameraCheckBox.Text = "Debug Camera";
            this.debugCameraCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.debugCameraCheckBox.UseCustomBackColor = true;
            this.debugCameraCheckBox.UseCustomForeColor = true;
            this.debugCameraCheckBox.UseSelectable = true;
            this.debugCameraCheckBox.CheckedChanged += new System.EventHandler(this.debugCameraCheckBox_CheckedChanged);
            // 
            // PAGE2
            // 
            this.PAGE2.Controls.Add(this.label3);
            this.PAGE2.Controls.Add(this.button3);
            this.PAGE2.Controls.Add(this.metroTextBox1);
            this.PAGE2.Controls.Add(this.label1);
            this.PAGE2.Controls.Add(this.button1);
            this.PAGE2.Controls.Add(this.comboBox1);
            this.PAGE2.Controls.Add(this.label22);
            this.PAGE2.Controls.Add(this.label4);
            this.PAGE2.HorizontalScrollbarBarColor = true;
            this.PAGE2.HorizontalScrollbarHighlightOnWheel = false;
            this.PAGE2.HorizontalScrollbarSize = 10;
            this.PAGE2.Location = new System.Drawing.Point(4, 38);
            this.PAGE2.Name = "PAGE2";
            this.PAGE2.Size = new System.Drawing.Size(509, 281);
            this.PAGE2.TabIndex = 2;
            this.PAGE2.Text = "Test /";
            this.PAGE2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PAGE2.VerticalScrollbarBarColor = true;
            this.PAGE2.VerticalScrollbarHighlightOnWheel = false;
            this.PAGE2.VerticalScrollbarSize = 10;
            this.PAGE2.Click += new System.EventHandler(this.Gamesave_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(149, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 34);
            this.label3.TabIndex = 382;
            this.label3.Text = "[ UNDER CONSTRUCTION ]";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Silver;
            this.button3.Location = new System.Drawing.Point(345, 99);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 21);
            this.button3.TabIndex = 381;
            this.button3.Text = "SET";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[] {
        "a value"};
            this.metroTextBox1.Location = new System.Drawing.Point(235, 99);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.Size = new System.Drawing.Size(104, 23);
            this.metroTextBox1.TabIndex = 380;
            this.metroTextBox1.Text = "a value";
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(115, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 379;
            this.label1.Text = "Health Bar Size";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(345, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 21);
            this.button1.TabIndex = 378;
            this.button1.Text = "SET";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox1.Location = new System.Drawing.Point(235, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(104, 21);
            this.comboBox1.TabIndex = 352;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Silver;
            this.label22.Location = new System.Drawing.Point(168, 14);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(172, 23);
            this.label22.TabIndex = 377;
            this.label22.Text = "selector example";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(115, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 15);
            this.label4.TabIndex = 353;
            this.label4.Text = "Health Bar Size";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TOOL_DEBUG
            // 
            this.TOOL_DEBUG.Controls.Add(this.groupBox2);
            this.TOOL_DEBUG.Controls.Add(this.groupBox13);
            this.TOOL_DEBUG.Controls.Add(this.commandline);
            this.TOOL_DEBUG.HorizontalScrollbarBarColor = true;
            this.TOOL_DEBUG.HorizontalScrollbarHighlightOnWheel = false;
            this.TOOL_DEBUG.HorizontalScrollbarSize = 10;
            this.TOOL_DEBUG.Location = new System.Drawing.Point(4, 38);
            this.TOOL_DEBUG.Name = "TOOL_DEBUG";
            this.TOOL_DEBUG.Size = new System.Drawing.Size(509, 281);
            this.TOOL_DEBUG.Style = MetroFramework.MetroColorStyle.Red;
            this.TOOL_DEBUG.TabIndex = 8;
            this.TOOL_DEBUG.Text = "Test /";
            this.TOOL_DEBUG.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TOOL_DEBUG.VerticalScrollbarBarColor = true;
            this.TOOL_DEBUG.VerticalScrollbarHighlightOnWheel = false;
            this.TOOL_DEBUG.VerticalScrollbarSize = 10;
            this.TOOL_DEBUG.Click += new System.EventHandler(this.TOOL_DEBUG_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Silver;
            this.groupBox2.Location = new System.Drawing.Point(8, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.groupBox2.Size = new System.Drawing.Size(262, 82);
            this.groupBox2.TabIndex = 388;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Console Legend";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.label14.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label14.Location = new System.Drawing.Point(8, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(237, 22);
            this.label14.TabIndex = 385;
            this.label14.Text = "quit       = Closes Program\r\nclose      = Closes APP_DEBUG";
            // 
            // groupBox13
            // 
            this.groupBox13.BackColor = System.Drawing.Color.Transparent;
            this.groupBox13.Controls.Add(this.button4);
            this.groupBox13.Controls.Add(this.button5);
            this.groupBox13.Controls.Add(this.button2);
            this.groupBox13.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox13.ForeColor = System.Drawing.Color.Silver;
            this.groupBox13.Location = new System.Drawing.Point(8, 98);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Padding = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.groupBox13.Size = new System.Drawing.Size(191, 137);
            this.groupBox13.TabIndex = 387;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Testing";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Silver;
            this.button4.Location = new System.Drawing.Point(8, 55);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 23);
            this.button4.TabIndex = 352;
            this.button4.Text = "Go to PAGE2";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Silver;
            this.button5.Location = new System.Drawing.Point(8, 84);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(174, 23);
            this.button5.TabIndex = 351;
            this.button5.Text = "Close TESTING";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(8, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 23);
            this.button2.TabIndex = 350;
            this.button2.Text = "Go to PAGE1";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // commandline
            // 
            this.commandline.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.commandline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commandline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandline.ForeColor = System.Drawing.Color.Orange;
            this.commandline.Location = new System.Drawing.Point(0, 261);
            this.commandline.Multiline = true;
            this.commandline.Name = "commandline";
            this.commandline.Size = new System.Drawing.Size(509, 20);
            this.commandline.TabIndex = 379;
            this.commandline.Text = "> Command Line";
            this.commandline.MouseClick += new System.Windows.Forms.MouseEventHandler(this.commandline_MouseClick);
            this.commandline.TextChanged += new System.EventHandler(this.commandline_TextChanged);
            this.commandline.KeyDown += new System.Windows.Forms.KeyEventHandler(this.commandline_KeyDown);
            this.commandline.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.commandline_KeyPress);
            // 
            // connectTxt
            // 
            this.connectTxt.AutoSize = true;
            this.connectTxt.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectTxt.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.connectTxt.Location = new System.Drawing.Point(75, 6);
            this.connectTxt.Name = "connectTxt";
            this.connectTxt.Size = new System.Drawing.Size(134, 16);
            this.connectTxt.TabIndex = 349;
            this.connectTxt.Text = "No Connection . . .";
            this.connectTxt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.connectTxt_MouseDown);
            this.connectTxt.MouseMove += new System.Windows.Forms.MouseEventHandler(this.connectTxt_MouseMove);
            this.connectTxt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.connectTxt_MouseUp);
            // 
            // versionTxt
            // 
            this.versionTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.versionTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.versionTxt.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionTxt.ForeColor = System.Drawing.Color.Silver;
            this.versionTxt.Location = new System.Drawing.Point(417, 26);
            this.versionTxt.Name = "versionTxt";
            this.versionTxt.Size = new System.Drawing.Size(97, 15);
            this.versionTxt.TabIndex = 310;
            this.versionTxt.Text = "Version 0.0.1";
            this.versionTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.versionTxt.Click += new System.EventHandler(this.label8_Click);
            this.versionTxt.MouseLeave += new System.EventHandler(this.label8_MouseLeave);
            this.versionTxt.MouseHover += new System.EventHandler(this.label8_MouseHover);
            // 
            // mousedrag
            // 
            this.mousedrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.mousedrag.Controls.Add(this.connect);
            this.mousedrag.Controls.Add(this.label6);
            this.mousedrag.Controls.Add(this.connectTxt);
            this.mousedrag.Controls.Add(this.label7);
            this.mousedrag.Location = new System.Drawing.Point(-5, -3);
            this.mousedrag.Name = "mousedrag";
            this.mousedrag.Size = new System.Drawing.Size(522, 28);
            this.mousedrag.TabIndex = 307;
            this.mousedrag.Paint += new System.Windows.Forms.PaintEventHandler(this.mousedrag_Paint);
            this.mousedrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mousedrag_MouseDown);
            this.mousedrag.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mousedrag_MouseMove);
            this.mousedrag.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mousedrag_MouseUp);
            this.mousedrag.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.mousedrag_PreviewKeyDown);
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(9, 5);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(60, 19);
            this.connect.Style = MetroFramework.MetroColorStyle.Orange;
            this.connect.TabIndex = 389;
            this.connect.Text = "Connect";
            this.connect.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.connect.UseSelectable = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(478, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 26);
            this.label6.TabIndex = 303;
            this.label6.Text = "-";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            this.label6.MouseLeave += new System.EventHandler(this.label6_MouseLeave);
            this.label6.MouseHover += new System.EventHandler(this.label6_MouseHover);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(500, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 24);
            this.label7.TabIndex = 309;
            this.label7.Text = "X";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            this.label7.MouseLeave += new System.EventHandler(this.label7_MouseLeave);
            this.label7.MouseHover += new System.EventHandler(this.label7_MouseHover);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label10.Location = new System.Drawing.Point(610, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 18);
            this.label10.TabIndex = 348;
            this.label10.Text = "Form size: 517, 334";
            this.label10.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(517, 334);
            this.Controls.Add(this.mousedrag);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.versionTxt);
            this.Controls.Add(this.MainTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.xex_offset_manager_KeyDown);
            this.MainTabControl.ResumeLayout(false);
            this.PAGE1.ResumeLayout(false);
            this.PAGE1.PerformLayout();
            this.PAGE2.ResumeLayout(false);
            this.PAGE2.PerformLayout();
            this.TOOL_DEBUG.ResumeLayout(false);
            this.TOOL_DEBUG.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.mousedrag.ResumeLayout(false);
            this.mousedrag.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl MainTabControl;
        private MetroFramework.Controls.MetroTabPage PAGE2;
        private System.Windows.Forms.Panel mousedrag;
        private System.Windows.Forms.Label versionTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroTabPage PAGE1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private MetroFramework.Controls.MetroTabPage TOOL_DEBUG;
        private System.Windows.Forms.TextBox commandline;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox13;
        private MetroFramework.Controls.MetroCheckBox debugCameraCheckBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label connectTxt;
        private MetroFramework.Controls.MetroButton connect;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox3;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox2;
        private MetroFramework.Controls.MetroCheckBox noclipCheckBox;
        private System.Windows.Forms.Label label3;
    }
}