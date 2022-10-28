namespace Lab4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.volume_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimize_button = new Lab4.RoundButton();
            this.exit_button = new Lab4.RoundButton();
            this.line_label = new System.Windows.Forms.Label();
            this.Drawing_Tool_groupBox = new System.Windows.Forms.GroupBox();
            this.brush_radioButton = new System.Windows.Forms.RadioButton();
            this.pen_radioButton = new System.Windows.Forms.RadioButton();
            this.Drawing_Shape_groupBox = new System.Windows.Forms.GroupBox();
            this.myfigure_radioButton = new System.Windows.Forms.RadioButton();
            this.square_radioButton = new System.Windows.Forms.RadioButton();
            this.circle_radioButton = new System.Windows.Forms.RadioButton();
            this.line_radioButton = new System.Windows.Forms.RadioButton();
            this.Color_groupBox = new System.Windows.Forms.GroupBox();
            this.white_color_radioButton = new System.Windows.Forms.RadioButton();
            this.yellow_color_radioButton = new System.Windows.Forms.RadioButton();
            this.magenta_color_radioButton = new System.Windows.Forms.RadioButton();
            this.red_color_radioButton = new System.Windows.Forms.RadioButton();
            this.cyan_color_radioButton = new System.Windows.Forms.RadioButton();
            this.green_color_radioButton = new System.Windows.Forms.RadioButton();
            this.blue_color_radioButton = new System.Windows.Forms.RadioButton();
            this.black_color_radioButton = new System.Windows.Forms.RadioButton();
            this.Sound_Options_groupBox = new System.Windows.Forms.GroupBox();
            this.reset_speed_button = new System.Windows.Forms.Button();
            this.reset_volume_button = new System.Windows.Forms.Button();
            this.stop_voice_button = new System.Windows.Forms.Button();
            this.start_voice_button = new System.Windows.Forms.Button();
            this.voice_comboBox = new System.Windows.Forms.ComboBox();
            this.voice_label = new System.Windows.Forms.Label();
            this.speed_trackBar = new System.Windows.Forms.TrackBar();
            this.speed_label = new System.Windows.Forms.Label();
            this.volume_trackBar = new System.Windows.Forms.TrackBar();
            this.panel1.SuspendLayout();
            this.Drawing_Tool_groupBox.SuspendLayout();
            this.Drawing_Shape_groupBox.SuspendLayout();
            this.Color_groupBox.SuspendLayout();
            this.Sound_Options_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speed_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // volume_label
            // 
            this.volume_label.AutoSize = true;
            this.volume_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.volume_label.ForeColor = System.Drawing.Color.IndianRed;
            this.volume_label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.volume_label.Location = new System.Drawing.Point(8, 40);
            this.volume_label.Name = "volume_label";
            this.volume_label.Size = new System.Drawing.Size(69, 21);
            this.volume_label.TabIndex = 7;
            this.volume_label.Text = "Volume";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.minimize_button);
            this.panel1.Controls.Add(this.exit_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 32);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // minimize_button
            // 
            this.minimize_button.BackColor = System.Drawing.Color.Yellow;
            this.minimize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_button.ForeColor = System.Drawing.Color.Yellow;
            this.minimize_button.Location = new System.Drawing.Point(541, 8);
            this.minimize_button.Name = "minimize_button";
            this.minimize_button.Size = new System.Drawing.Size(16, 16);
            this.minimize_button.TabIndex = 17;
            this.minimize_button.UseVisualStyleBackColor = false;
            this.minimize_button.Click += new System.EventHandler(this.minimize_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.IndianRed;
            this.exit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.ForeColor = System.Drawing.Color.IndianRed;
            this.exit_button.Location = new System.Drawing.Point(567, 8);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(16, 16);
            this.exit_button.TabIndex = 16;
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // line_label
            // 
            this.line_label.BackColor = System.Drawing.Color.IndianRed;
            this.line_label.Location = new System.Drawing.Point(0, 32);
            this.line_label.Name = "line_label";
            this.line_label.Size = new System.Drawing.Size(595, 1);
            this.line_label.TabIndex = 15;
            // 
            // Drawing_Tool_groupBox
            // 
            this.Drawing_Tool_groupBox.BackColor = System.Drawing.Color.Transparent;
            this.Drawing_Tool_groupBox.Controls.Add(this.brush_radioButton);
            this.Drawing_Tool_groupBox.Controls.Add(this.pen_radioButton);
            this.Drawing_Tool_groupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Drawing_Tool_groupBox.ForeColor = System.Drawing.Color.IndianRed;
            this.Drawing_Tool_groupBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Drawing_Tool_groupBox.Location = new System.Drawing.Point(12, 38);
            this.Drawing_Tool_groupBox.Name = "Drawing_Tool_groupBox";
            this.Drawing_Tool_groupBox.Size = new System.Drawing.Size(150, 77);
            this.Drawing_Tool_groupBox.TabIndex = 22;
            this.Drawing_Tool_groupBox.TabStop = false;
            this.Drawing_Tool_groupBox.Text = "Drawing Tool";
            // 
            // brush_radioButton
            // 
            this.brush_radioButton.AutoSize = true;
            this.brush_radioButton.Location = new System.Drawing.Point(6, 46);
            this.brush_radioButton.Name = "brush_radioButton";
            this.brush_radioButton.Size = new System.Drawing.Size(71, 25);
            this.brush_radioButton.TabIndex = 1;
            this.brush_radioButton.TabStop = true;
            this.brush_radioButton.Text = "Brush";
            this.brush_radioButton.UseVisualStyleBackColor = true;
            this.brush_radioButton.CheckedChanged += new System.EventHandler(this.brush_radioButton_CheckedChanged);
            // 
            // pen_radioButton
            // 
            this.pen_radioButton.AutoSize = true;
            this.pen_radioButton.Location = new System.Drawing.Point(6, 21);
            this.pen_radioButton.Name = "pen_radioButton";
            this.pen_radioButton.Size = new System.Drawing.Size(57, 25);
            this.pen_radioButton.TabIndex = 0;
            this.pen_radioButton.TabStop = true;
            this.pen_radioButton.Text = "Pen";
            this.pen_radioButton.UseVisualStyleBackColor = true;
            this.pen_radioButton.CheckedChanged += new System.EventHandler(this.pen_radioButton_CheckedChanged);
            // 
            // Drawing_Shape_groupBox
            // 
            this.Drawing_Shape_groupBox.BackColor = System.Drawing.Color.Transparent;
            this.Drawing_Shape_groupBox.Controls.Add(this.myfigure_radioButton);
            this.Drawing_Shape_groupBox.Controls.Add(this.square_radioButton);
            this.Drawing_Shape_groupBox.Controls.Add(this.circle_radioButton);
            this.Drawing_Shape_groupBox.Controls.Add(this.line_radioButton);
            this.Drawing_Shape_groupBox.Enabled = false;
            this.Drawing_Shape_groupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Drawing_Shape_groupBox.ForeColor = System.Drawing.Color.IndianRed;
            this.Drawing_Shape_groupBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Drawing_Shape_groupBox.Location = new System.Drawing.Point(12, 121);
            this.Drawing_Shape_groupBox.Name = "Drawing_Shape_groupBox";
            this.Drawing_Shape_groupBox.Size = new System.Drawing.Size(150, 156);
            this.Drawing_Shape_groupBox.TabIndex = 23;
            this.Drawing_Shape_groupBox.TabStop = false;
            this.Drawing_Shape_groupBox.Text = "Drawing Shape";
            // 
            // myfigure_radioButton
            // 
            this.myfigure_radioButton.AutoSize = true;
            this.myfigure_radioButton.Location = new System.Drawing.Point(6, 121);
            this.myfigure_radioButton.Name = "myfigure_radioButton";
            this.myfigure_radioButton.Size = new System.Drawing.Size(104, 25);
            this.myfigure_radioButton.TabIndex = 3;
            this.myfigure_radioButton.TabStop = true;
            this.myfigure_radioButton.Text = "My Figure";
            this.myfigure_radioButton.UseVisualStyleBackColor = true;
            this.myfigure_radioButton.CheckedChanged += new System.EventHandler(this.myfigure_radioButton_CheckedChanged);
            // 
            // square_radioButton
            // 
            this.square_radioButton.AutoSize = true;
            this.square_radioButton.Location = new System.Drawing.Point(6, 90);
            this.square_radioButton.Name = "square_radioButton";
            this.square_radioButton.Size = new System.Drawing.Size(81, 25);
            this.square_radioButton.TabIndex = 2;
            this.square_radioButton.TabStop = true;
            this.square_radioButton.Text = "Square";
            this.square_radioButton.UseVisualStyleBackColor = true;
            this.square_radioButton.CheckedChanged += new System.EventHandler(this.square_radioButton_CheckedChanged);
            // 
            // circle_radioButton
            // 
            this.circle_radioButton.AutoSize = true;
            this.circle_radioButton.Location = new System.Drawing.Point(6, 59);
            this.circle_radioButton.Name = "circle_radioButton";
            this.circle_radioButton.Size = new System.Drawing.Size(71, 25);
            this.circle_radioButton.TabIndex = 1;
            this.circle_radioButton.TabStop = true;
            this.circle_radioButton.Text = "Circle";
            this.circle_radioButton.UseVisualStyleBackColor = true;
            this.circle_radioButton.CheckedChanged += new System.EventHandler(this.circle_radioButton_CheckedChanged);
            // 
            // line_radioButton
            // 
            this.line_radioButton.AutoSize = true;
            this.line_radioButton.Location = new System.Drawing.Point(6, 28);
            this.line_radioButton.Name = "line_radioButton";
            this.line_radioButton.Size = new System.Drawing.Size(60, 25);
            this.line_radioButton.TabIndex = 0;
            this.line_radioButton.TabStop = true;
            this.line_radioButton.Text = "Line";
            this.line_radioButton.UseVisualStyleBackColor = true;
            this.line_radioButton.CheckedChanged += new System.EventHandler(this.line_radioButton_CheckedChanged);
            // 
            // Color_groupBox
            // 
            this.Color_groupBox.BackColor = System.Drawing.Color.Transparent;
            this.Color_groupBox.Controls.Add(this.white_color_radioButton);
            this.Color_groupBox.Controls.Add(this.yellow_color_radioButton);
            this.Color_groupBox.Controls.Add(this.magenta_color_radioButton);
            this.Color_groupBox.Controls.Add(this.red_color_radioButton);
            this.Color_groupBox.Controls.Add(this.cyan_color_radioButton);
            this.Color_groupBox.Controls.Add(this.green_color_radioButton);
            this.Color_groupBox.Controls.Add(this.blue_color_radioButton);
            this.Color_groupBox.Controls.Add(this.black_color_radioButton);
            this.Color_groupBox.Enabled = false;
            this.Color_groupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Color_groupBox.ForeColor = System.Drawing.Color.IndianRed;
            this.Color_groupBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Color_groupBox.Location = new System.Drawing.Point(168, 38);
            this.Color_groupBox.Name = "Color_groupBox";
            this.Color_groupBox.Size = new System.Drawing.Size(113, 239);
            this.Color_groupBox.TabIndex = 24;
            this.Color_groupBox.TabStop = false;
            this.Color_groupBox.Text = "Color";
            // 
            // white_color_radioButton
            // 
            this.white_color_radioButton.AutoSize = true;
            this.white_color_radioButton.Location = new System.Drawing.Point(6, 196);
            this.white_color_radioButton.Name = "white_color_radioButton";
            this.white_color_radioButton.Size = new System.Drawing.Size(74, 25);
            this.white_color_radioButton.TabIndex = 7;
            this.white_color_radioButton.TabStop = true;
            this.white_color_radioButton.Text = "White";
            this.white_color_radioButton.UseVisualStyleBackColor = true;
            this.white_color_radioButton.CheckedChanged += new System.EventHandler(this.colors_CheckedChanged);
            // 
            // yellow_color_radioButton
            // 
            this.yellow_color_radioButton.AutoSize = true;
            this.yellow_color_radioButton.Location = new System.Drawing.Point(6, 171);
            this.yellow_color_radioButton.Name = "yellow_color_radioButton";
            this.yellow_color_radioButton.Size = new System.Drawing.Size(79, 25);
            this.yellow_color_radioButton.TabIndex = 6;
            this.yellow_color_radioButton.TabStop = true;
            this.yellow_color_radioButton.Text = "Yellow";
            this.yellow_color_radioButton.UseVisualStyleBackColor = true;
            this.yellow_color_radioButton.CheckedChanged += new System.EventHandler(this.colors_CheckedChanged);
            // 
            // magenta_color_radioButton
            // 
            this.magenta_color_radioButton.AutoSize = true;
            this.magenta_color_radioButton.Location = new System.Drawing.Point(6, 146);
            this.magenta_color_radioButton.Name = "magenta_color_radioButton";
            this.magenta_color_radioButton.Size = new System.Drawing.Size(96, 25);
            this.magenta_color_radioButton.TabIndex = 5;
            this.magenta_color_radioButton.TabStop = true;
            this.magenta_color_radioButton.Text = "Magenta";
            this.magenta_color_radioButton.UseVisualStyleBackColor = true;
            this.magenta_color_radioButton.CheckedChanged += new System.EventHandler(this.colors_CheckedChanged);
            // 
            // red_color_radioButton
            // 
            this.red_color_radioButton.AutoSize = true;
            this.red_color_radioButton.Location = new System.Drawing.Point(6, 121);
            this.red_color_radioButton.Name = "red_color_radioButton";
            this.red_color_radioButton.Size = new System.Drawing.Size(57, 25);
            this.red_color_radioButton.TabIndex = 4;
            this.red_color_radioButton.TabStop = true;
            this.red_color_radioButton.Text = "Red";
            this.red_color_radioButton.UseVisualStyleBackColor = true;
            this.red_color_radioButton.CheckedChanged += new System.EventHandler(this.colors_CheckedChanged);
            // 
            // cyan_color_radioButton
            // 
            this.cyan_color_radioButton.AutoSize = true;
            this.cyan_color_radioButton.Location = new System.Drawing.Point(6, 96);
            this.cyan_color_radioButton.Name = "cyan_color_radioButton";
            this.cyan_color_radioButton.Size = new System.Drawing.Size(66, 25);
            this.cyan_color_radioButton.TabIndex = 3;
            this.cyan_color_radioButton.TabStop = true;
            this.cyan_color_radioButton.Text = "Cyan";
            this.cyan_color_radioButton.UseVisualStyleBackColor = true;
            this.cyan_color_radioButton.CheckedChanged += new System.EventHandler(this.colors_CheckedChanged);
            // 
            // green_color_radioButton
            // 
            this.green_color_radioButton.AutoSize = true;
            this.green_color_radioButton.Location = new System.Drawing.Point(6, 71);
            this.green_color_radioButton.Name = "green_color_radioButton";
            this.green_color_radioButton.Size = new System.Drawing.Size(73, 25);
            this.green_color_radioButton.TabIndex = 2;
            this.green_color_radioButton.TabStop = true;
            this.green_color_radioButton.Text = "Green";
            this.green_color_radioButton.UseVisualStyleBackColor = true;
            this.green_color_radioButton.CheckedChanged += new System.EventHandler(this.colors_CheckedChanged);
            // 
            // blue_color_radioButton
            // 
            this.blue_color_radioButton.AutoSize = true;
            this.blue_color_radioButton.Location = new System.Drawing.Point(6, 46);
            this.blue_color_radioButton.Name = "blue_color_radioButton";
            this.blue_color_radioButton.Size = new System.Drawing.Size(62, 25);
            this.blue_color_radioButton.TabIndex = 1;
            this.blue_color_radioButton.TabStop = true;
            this.blue_color_radioButton.Text = "Blue";
            this.blue_color_radioButton.UseVisualStyleBackColor = true;
            this.blue_color_radioButton.CheckedChanged += new System.EventHandler(this.colors_CheckedChanged);
            // 
            // black_color_radioButton
            // 
            this.black_color_radioButton.AutoSize = true;
            this.black_color_radioButton.Location = new System.Drawing.Point(6, 21);
            this.black_color_radioButton.Name = "black_color_radioButton";
            this.black_color_radioButton.Size = new System.Drawing.Size(69, 25);
            this.black_color_radioButton.TabIndex = 0;
            this.black_color_radioButton.TabStop = true;
            this.black_color_radioButton.Text = "Black";
            this.black_color_radioButton.UseVisualStyleBackColor = true;
            this.black_color_radioButton.CheckedChanged += new System.EventHandler(this.colors_CheckedChanged);
            // 
            // Sound_Options_groupBox
            // 
            this.Sound_Options_groupBox.BackColor = System.Drawing.Color.Transparent;
            this.Sound_Options_groupBox.Controls.Add(this.reset_speed_button);
            this.Sound_Options_groupBox.Controls.Add(this.reset_volume_button);
            this.Sound_Options_groupBox.Controls.Add(this.stop_voice_button);
            this.Sound_Options_groupBox.Controls.Add(this.start_voice_button);
            this.Sound_Options_groupBox.Controls.Add(this.voice_comboBox);
            this.Sound_Options_groupBox.Controls.Add(this.voice_label);
            this.Sound_Options_groupBox.Controls.Add(this.speed_trackBar);
            this.Sound_Options_groupBox.Controls.Add(this.speed_label);
            this.Sound_Options_groupBox.Controls.Add(this.volume_trackBar);
            this.Sound_Options_groupBox.Controls.Add(this.volume_label);
            this.Sound_Options_groupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Sound_Options_groupBox.ForeColor = System.Drawing.Color.IndianRed;
            this.Sound_Options_groupBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Sound_Options_groupBox.Location = new System.Drawing.Point(12, 283);
            this.Sound_Options_groupBox.Name = "Sound_Options_groupBox";
            this.Sound_Options_groupBox.Size = new System.Drawing.Size(571, 143);
            this.Sound_Options_groupBox.TabIndex = 25;
            this.Sound_Options_groupBox.TabStop = false;
            this.Sound_Options_groupBox.Text = "Sound Options";
            // 
            // reset_speed_button
            // 
            this.reset_speed_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.reset_speed_button.Enabled = false;
            this.reset_speed_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset_speed_button.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reset_speed_button.ForeColor = System.Drawing.Color.IndianRed;
            this.reset_speed_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.reset_speed_button.Location = new System.Drawing.Point(532, 28);
            this.reset_speed_button.Name = "reset_speed_button";
            this.reset_speed_button.Size = new System.Drawing.Size(27, 45);
            this.reset_speed_button.TabIndex = 22;
            this.reset_speed_button.Text = "r";
            this.reset_speed_button.UseVisualStyleBackColor = false;
            this.reset_speed_button.Click += new System.EventHandler(this.reset_speed_button_Click);
            // 
            // reset_volume_button
            // 
            this.reset_volume_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.reset_volume_button.Enabled = false;
            this.reset_volume_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset_volume_button.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reset_volume_button.ForeColor = System.Drawing.Color.IndianRed;
            this.reset_volume_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.reset_volume_button.Location = new System.Drawing.Point(251, 28);
            this.reset_volume_button.Name = "reset_volume_button";
            this.reset_volume_button.Size = new System.Drawing.Size(27, 45);
            this.reset_volume_button.TabIndex = 21;
            this.reset_volume_button.Text = "r";
            this.reset_volume_button.UseVisualStyleBackColor = false;
            this.reset_volume_button.Click += new System.EventHandler(this.reset_volume_button_Click);
            // 
            // stop_voice_button
            // 
            this.stop_voice_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.stop_voice_button.Enabled = false;
            this.stop_voice_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop_voice_button.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stop_voice_button.ForeColor = System.Drawing.Color.IndianRed;
            this.stop_voice_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.stop_voice_button.Location = new System.Drawing.Point(363, 87);
            this.stop_voice_button.Name = "stop_voice_button";
            this.stop_voice_button.Size = new System.Drawing.Size(80, 45);
            this.stop_voice_button.TabIndex = 20;
            this.stop_voice_button.Text = "Stop";
            this.stop_voice_button.UseVisualStyleBackColor = false;
            this.stop_voice_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // start_voice_button
            // 
            this.start_voice_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.start_voice_button.Enabled = false;
            this.start_voice_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_voice_button.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.start_voice_button.ForeColor = System.Drawing.Color.IndianRed;
            this.start_voice_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.start_voice_button.Location = new System.Drawing.Point(446, 87);
            this.start_voice_button.Name = "start_voice_button";
            this.start_voice_button.Size = new System.Drawing.Size(80, 45);
            this.start_voice_button.TabIndex = 19;
            this.start_voice_button.Text = "Start";
            this.start_voice_button.UseVisualStyleBackColor = false;
            this.start_voice_button.Click += new System.EventHandler(this.start_voice_button_Click);
            // 
            // voice_comboBox
            // 
            this.voice_comboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.voice_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.voice_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.voice_comboBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.voice_comboBox.ForeColor = System.Drawing.Color.IndianRed;
            this.voice_comboBox.FormattingEnabled = true;
            this.voice_comboBox.Items.AddRange(new object[] {
            "",
            "Voice №1",
            "Voice №2",
            "Voice №3",
            "Voice №4",
            "Voice №5"});
            this.voice_comboBox.Location = new System.Drawing.Point(82, 97);
            this.voice_comboBox.Name = "voice_comboBox";
            this.voice_comboBox.Size = new System.Drawing.Size(163, 25);
            this.voice_comboBox.TabIndex = 11;
            this.voice_comboBox.SelectedIndexChanged += new System.EventHandler(this.voice_comboBox_SelectedIndexChanged);
            // 
            // voice_label
            // 
            this.voice_label.AutoSize = true;
            this.voice_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.voice_label.ForeColor = System.Drawing.Color.IndianRed;
            this.voice_label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.voice_label.Location = new System.Drawing.Point(25, 99);
            this.voice_label.Name = "voice_label";
            this.voice_label.Size = new System.Drawing.Size(52, 21);
            this.voice_label.TabIndex = 10;
            this.voice_label.Text = "Voice";
            // 
            // speed_trackBar
            // 
            this.speed_trackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.speed_trackBar.Enabled = false;
            this.speed_trackBar.Location = new System.Drawing.Point(363, 28);
            this.speed_trackBar.Maximum = 100;
            this.speed_trackBar.Name = "speed_trackBar";
            this.speed_trackBar.Size = new System.Drawing.Size(163, 45);
            this.speed_trackBar.TabIndex = 8;
            this.speed_trackBar.TickFrequency = 10;
            this.speed_trackBar.Value = 50;
            this.speed_trackBar.Scroll += new System.EventHandler(this.speed_trackBar_Scroll);
            // 
            // speed_label
            // 
            this.speed_label.AutoSize = true;
            this.speed_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.speed_label.ForeColor = System.Drawing.Color.IndianRed;
            this.speed_label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.speed_label.Location = new System.Drawing.Point(300, 40);
            this.speed_label.Name = "speed_label";
            this.speed_label.Size = new System.Drawing.Size(57, 21);
            this.speed_label.TabIndex = 9;
            this.speed_label.Text = "Speed";
            // 
            // volume_trackBar
            // 
            this.volume_trackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.volume_trackBar.Enabled = false;
            this.volume_trackBar.Location = new System.Drawing.Point(82, 28);
            this.volume_trackBar.Maximum = 100;
            this.volume_trackBar.Name = "volume_trackBar";
            this.volume_trackBar.Size = new System.Drawing.Size(163, 45);
            this.volume_trackBar.TabIndex = 0;
            this.volume_trackBar.TickFrequency = 10;
            this.volume_trackBar.Value = 50;
            this.volume_trackBar.Scroll += new System.EventHandler(this.volume_trackBar_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(595, 438);
            this.Controls.Add(this.Sound_Options_groupBox);
            this.Controls.Add(this.Color_groupBox);
            this.Controls.Add(this.Drawing_Shape_groupBox);
            this.Controls.Add(this.Drawing_Tool_groupBox);
            this.Controls.Add(this.line_label);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab work 1.1";
            this.panel1.ResumeLayout(false);
            this.Drawing_Tool_groupBox.ResumeLayout(false);
            this.Drawing_Tool_groupBox.PerformLayout();
            this.Drawing_Shape_groupBox.ResumeLayout(false);
            this.Drawing_Shape_groupBox.PerformLayout();
            this.Color_groupBox.ResumeLayout(false);
            this.Color_groupBox.PerformLayout();
            this.Sound_Options_groupBox.ResumeLayout(false);
            this.Sound_Options_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speed_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume_trackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private RoundButton exit_button;
        private RoundButton minimize_button;
        private Label volume_label;
        private Label line_label;

        private Panel panel1;
        private GroupBox Drawing_Tool_groupBox;
        private RadioButton brush_radioButton;
        private RadioButton pen_radioButton;
        private GroupBox Drawing_Shape_groupBox;
        private RadioButton square_radioButton;
        private RadioButton circle_radioButton;
        private RadioButton line_radioButton;
        private GroupBox Color_groupBox;
        private RadioButton red_color_radioButton;
        private RadioButton cyan_color_radioButton;
        private RadioButton green_color_radioButton;
        private RadioButton blue_color_radioButton;
        private RadioButton black_color_radioButton;
        private RadioButton white_color_radioButton;
        private RadioButton yellow_color_radioButton;
        private RadioButton magenta_color_radioButton;
        private GroupBox Sound_Options_groupBox;
        private TrackBar volume_trackBar;
        private TrackBar speed_trackBar;
        private Label speed_label;
        private Label voice_label;
        private ComboBox voice_comboBox;
        private Button start_voice_button;
        private Button stop_voice_button;
        private RadioButton myfigure_radioButton;
        private Button reset_speed_button;
        private Button reset_volume_button;
    }
}