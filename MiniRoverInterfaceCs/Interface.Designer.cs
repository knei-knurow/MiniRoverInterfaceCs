namespace MiniRoverInterfaceCs
{
    partial class Interface
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
            this.SerialPortRecieve = new System.IO.Ports.SerialPort(this.components);
            this.SerialPortSend = new System.IO.Ports.SerialPort(this.components);
            this.TxtRecievePort = new System.Windows.Forms.ComboBox();
            this.TxtSendPort = new System.Windows.Forms.ComboBox();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.BtnDisconnect = new System.Windows.Forms.Button();
            this.Wheel0SpeedSlider = new System.Windows.Forms.TrackBar();
            this.Wheel1SpeedSlider = new System.Windows.Forms.TrackBar();
            this.Wheel2SpeedSlider = new System.Windows.Forms.TrackBar();
            this.Wheel3SpeedSlider = new System.Windows.Forms.TrackBar();
            this.Wheel0SpeedLabel = new System.Windows.Forms.Label();
            this.Wheel1SpeedLabel = new System.Windows.Forms.Label();
            this.Wheel2SpeedLabel = new System.Windows.Forms.Label();
            this.Wheel3SpeedLabel = new System.Windows.Forms.Label();
            this.BtnSyncWheelSpeed = new System.Windows.Forms.Button();
            this.BtnResetWheelSpeed = new System.Windows.Forms.Button();
            this.Wheel0AngleSlider = new System.Windows.Forms.TrackBar();
            this.Wheel1AngleSlider = new System.Windows.Forms.TrackBar();
            this.Wheel2AngleSlider = new System.Windows.Forms.TrackBar();
            this.Wheel3AngleSlider = new System.Windows.Forms.TrackBar();
            this.BtnSyncWheelAngle = new System.Windows.Forms.Button();
            this.BtnResetWheelAngle = new System.Windows.Forms.Button();
            this.Wheel0AngleLabel = new System.Windows.Forms.Label();
            this.Wheel1AngleLabel = new System.Windows.Forms.Label();
            this.Wheel2AngleLabel = new System.Windows.Forms.Label();
            this.Wheel3AngleLabel = new System.Windows.Forms.Label();
            this.BtnArm0Left = new System.Windows.Forms.Button();
            this.BtnArm0Right = new System.Windows.Forms.Button();
            this.BtnArm1Left = new System.Windows.Forms.Button();
            this.BtnArm1Right = new System.Windows.Forms.Button();
            this.BtnArm2Left = new System.Windows.Forms.Button();
            this.BtnArm2Right = new System.Windows.Forms.Button();
            this.BtnArm3Left = new System.Windows.Forms.Button();
            this.BtnArm3Right = new System.Windows.Forms.Button();
            this.BtnArm4Left = new System.Windows.Forms.Button();
            this.BtnArm4Right = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Wheel0SpeedSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wheel1SpeedSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wheel2SpeedSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wheel3SpeedSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wheel0AngleSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wheel1AngleSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wheel2AngleSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wheel3AngleSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtRecievePort
            // 
            this.TxtRecievePort.FormattingEnabled = true;
            this.TxtRecievePort.Location = new System.Drawing.Point(85, 5);
            this.TxtRecievePort.Name = "TxtRecievePort";
            this.TxtRecievePort.Size = new System.Drawing.Size(121, 21);
            this.TxtRecievePort.TabIndex = 0;
            this.TxtRecievePort.DropDown += new System.EventHandler(this.TxtRecievePort_DropDown);
            // 
            // TxtSendPort
            // 
            this.TxtSendPort.FormattingEnabled = true;
            this.TxtSendPort.Location = new System.Drawing.Point(280, 5);
            this.TxtSendPort.Name = "TxtSendPort";
            this.TxtSendPort.Size = new System.Drawing.Size(121, 21);
            this.TxtSendPort.TabIndex = 1;
            this.TxtSendPort.DropDown += new System.EventHandler(this.TxtSendPort_DropDown);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(407, 3);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 25);
            this.BtnEdit.TabIndex = 2;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Send Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Recieve Port";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(488, 3);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 25);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(570, 3);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(75, 25);
            this.BtnConnect.TabIndex = 6;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // BtnDisconnect
            // 
            this.BtnDisconnect.Location = new System.Drawing.Point(651, 3);
            this.BtnDisconnect.Name = "BtnDisconnect";
            this.BtnDisconnect.Size = new System.Drawing.Size(75, 25);
            this.BtnDisconnect.TabIndex = 7;
            this.BtnDisconnect.Text = "Disconnect";
            this.BtnDisconnect.UseVisualStyleBackColor = true;
            this.BtnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
            // 
            // Wheel0SpeedSlider
            // 
            this.Wheel0SpeedSlider.Location = new System.Drawing.Point(10, 60);
            this.Wheel0SpeedSlider.Maximum = 255;
            this.Wheel0SpeedSlider.Minimum = -255;
            this.Wheel0SpeedSlider.Name = "Wheel0SpeedSlider";
            this.Wheel0SpeedSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Wheel0SpeedSlider.Size = new System.Drawing.Size(45, 511);
            this.Wheel0SpeedSlider.TabIndex = 8;
            this.Wheel0SpeedSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.Wheel0SpeedSlider.Scroll += new System.EventHandler(this.Wheel0SpeedSlider_Scroll);
            // 
            // Wheel1SpeedSlider
            // 
            this.Wheel1SpeedSlider.Location = new System.Drawing.Point(60, 60);
            this.Wheel1SpeedSlider.Maximum = 255;
            this.Wheel1SpeedSlider.Minimum = -255;
            this.Wheel1SpeedSlider.Name = "Wheel1SpeedSlider";
            this.Wheel1SpeedSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Wheel1SpeedSlider.Size = new System.Drawing.Size(45, 511);
            this.Wheel1SpeedSlider.TabIndex = 9;
            this.Wheel1SpeedSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.Wheel1SpeedSlider.Scroll += new System.EventHandler(this.Wheel1SpeedSlider_Scroll);
            // 
            // Wheel2SpeedSlider
            // 
            this.Wheel2SpeedSlider.Location = new System.Drawing.Point(110, 60);
            this.Wheel2SpeedSlider.Maximum = 255;
            this.Wheel2SpeedSlider.Minimum = -255;
            this.Wheel2SpeedSlider.Name = "Wheel2SpeedSlider";
            this.Wheel2SpeedSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Wheel2SpeedSlider.Size = new System.Drawing.Size(45, 511);
            this.Wheel2SpeedSlider.TabIndex = 10;
            this.Wheel2SpeedSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.Wheel2SpeedSlider.Scroll += new System.EventHandler(this.Wheel2SpeedSlider_Scroll);
            // 
            // Wheel3SpeedSlider
            // 
            this.Wheel3SpeedSlider.Location = new System.Drawing.Point(160, 60);
            this.Wheel3SpeedSlider.Maximum = 255;
            this.Wheel3SpeedSlider.Minimum = -255;
            this.Wheel3SpeedSlider.Name = "Wheel3SpeedSlider";
            this.Wheel3SpeedSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Wheel3SpeedSlider.Size = new System.Drawing.Size(45, 511);
            this.Wheel3SpeedSlider.TabIndex = 11;
            this.Wheel3SpeedSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.Wheel3SpeedSlider.Scroll += new System.EventHandler(this.Wheel3SpeedSlider_Scroll);
            // 
            // Wheel0SpeedLabel
            // 
            this.Wheel0SpeedLabel.AutoSize = true;
            this.Wheel0SpeedLabel.Location = new System.Drawing.Point(10, 45);
            this.Wheel0SpeedLabel.Name = "Wheel0SpeedLabel";
            this.Wheel0SpeedLabel.Size = new System.Drawing.Size(47, 13);
            this.Wheel0SpeedLabel.TabIndex = 13;
            this.Wheel0SpeedLabel.Text = "Wheel 0";
            // 
            // Wheel1SpeedLabel
            // 
            this.Wheel1SpeedLabel.AutoSize = true;
            this.Wheel1SpeedLabel.Location = new System.Drawing.Point(60, 45);
            this.Wheel1SpeedLabel.Name = "Wheel1SpeedLabel";
            this.Wheel1SpeedLabel.Size = new System.Drawing.Size(47, 13);
            this.Wheel1SpeedLabel.TabIndex = 14;
            this.Wheel1SpeedLabel.Text = "Wheel 1";
            // 
            // Wheel2SpeedLabel
            // 
            this.Wheel2SpeedLabel.AutoSize = true;
            this.Wheel2SpeedLabel.Location = new System.Drawing.Point(110, 45);
            this.Wheel2SpeedLabel.Name = "Wheel2SpeedLabel";
            this.Wheel2SpeedLabel.Size = new System.Drawing.Size(47, 13);
            this.Wheel2SpeedLabel.TabIndex = 15;
            this.Wheel2SpeedLabel.Text = "Wheel 2";
            // 
            // Wheel3SpeedLabel
            // 
            this.Wheel3SpeedLabel.AutoSize = true;
            this.Wheel3SpeedLabel.Location = new System.Drawing.Point(160, 45);
            this.Wheel3SpeedLabel.Name = "Wheel3SpeedLabel";
            this.Wheel3SpeedLabel.Size = new System.Drawing.Size(1047, 13);
            this.Wheel3SpeedLabel.TabIndex = 16;
            this.Wheel3SpeedLabel.Text = "Wheel 3";
            // 
            // BtnSyncWheelSpeed
            // 
            this.BtnSyncWheelSpeed.Location = new System.Drawing.Point(210, 40);
            this.BtnSyncWheelSpeed.Name = "BtnSyncWheelSpeed";
            this.BtnSyncWheelSpeed.Size = new System.Drawing.Size(120, 25);
            this.BtnSyncWheelSpeed.TabIndex = 17;
            this.BtnSyncWheelSpeed.Text = "Sync Wheel Speed";
            this.BtnSyncWheelSpeed.UseVisualStyleBackColor = true;
            this.BtnSyncWheelSpeed.Click += new System.EventHandler(this.BtnSyncWheelSpeed_Click);
            // 
            // BtnResetWheelSpeed
            // 
            this.BtnResetWheelSpeed.Location = new System.Drawing.Point(210, 70);
            this.BtnResetWheelSpeed.Name = "BtnResetWheelSpeed";
            this.BtnResetWheelSpeed.Size = new System.Drawing.Size(120, 25);
            this.BtnResetWheelSpeed.TabIndex = 18;
            this.BtnResetWheelSpeed.Text = "Reset Wheel Speed";
            this.BtnResetWheelSpeed.UseVisualStyleBackColor = true;
            this.BtnResetWheelSpeed.Click += new System.EventHandler(this.BtnResetWheelSpeed_Click);
            // 
            // Wheel0AngleSlider
            // 
            this.Wheel0AngleSlider.Location = new System.Drawing.Point(447, 450);
            this.Wheel0AngleSlider.Maximum = 90;
            this.Wheel0AngleSlider.Minimum = -90;
            this.Wheel0AngleSlider.Name = "Wheel0AngleSlider";
            this.Wheel0AngleSlider.Size = new System.Drawing.Size(181, 45);
            this.Wheel0AngleSlider.TabIndex = 19;
            this.Wheel0AngleSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.Wheel0AngleSlider.Scroll += new System.EventHandler(this.Wheel0AngleSlider_Scroll);
            // 
            // Wheel1AngleSlider
            // 
            this.Wheel1AngleSlider.Location = new System.Drawing.Point(447, 501);
            this.Wheel1AngleSlider.Maximum = 90;
            this.Wheel1AngleSlider.Minimum = -90;
            this.Wheel1AngleSlider.Name = "Wheel1AngleSlider";
            this.Wheel1AngleSlider.Size = new System.Drawing.Size(181, 45);
            this.Wheel1AngleSlider.TabIndex = 20;
            this.Wheel1AngleSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.Wheel1AngleSlider.Scroll += new System.EventHandler(this.Wheel1AngleSlider_Scroll);
            // 
            // Wheel2AngleSlider
            // 
            this.Wheel2AngleSlider.Location = new System.Drawing.Point(260, 450);
            this.Wheel2AngleSlider.Maximum = 90;
            this.Wheel2AngleSlider.Minimum = -90;
            this.Wheel2AngleSlider.Name = "Wheel2AngleSlider";
            this.Wheel2AngleSlider.Size = new System.Drawing.Size(181, 45);
            this.Wheel2AngleSlider.TabIndex = 21;
            this.Wheel2AngleSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.Wheel2AngleSlider.Scroll += new System.EventHandler(this.Wheel2AngleSlider_Scroll);
            // 
            // Wheel3AngleSlider
            // 
            this.Wheel3AngleSlider.Location = new System.Drawing.Point(260, 501);
            this.Wheel3AngleSlider.Maximum = 90;
            this.Wheel3AngleSlider.Minimum = -90;
            this.Wheel3AngleSlider.Name = "Wheel3AngleSlider";
            this.Wheel3AngleSlider.Size = new System.Drawing.Size(181, 45);
            this.Wheel3AngleSlider.TabIndex = 22;
            this.Wheel3AngleSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.Wheel3AngleSlider.Scroll += new System.EventHandler(this.Wheel3AngleSlider_Scroll);
            // 
            // BtnSyncWheelAngle
            // 
            this.BtnSyncWheelAngle.Location = new System.Drawing.Point(690, 450);
            this.BtnSyncWheelAngle.Name = "BtnSyncWheelAngle";
            this.BtnSyncWheelAngle.Size = new System.Drawing.Size(120, 25);
            this.BtnSyncWheelAngle.TabIndex = 23;
            this.BtnSyncWheelAngle.Text = "Sync Wheel Angle";
            this.BtnSyncWheelAngle.UseVisualStyleBackColor = true;
            this.BtnSyncWheelAngle.Click += new System.EventHandler(this.BtnSyncWheelAngle_Click);
            // 
            // BtnResetWheelAngle
            // 
            this.BtnResetWheelAngle.Location = new System.Drawing.Point(690, 480);
            this.BtnResetWheelAngle.Name = "BtnResetWheelAngle";
            this.BtnResetWheelAngle.Size = new System.Drawing.Size(120, 25);
            this.BtnResetWheelAngle.TabIndex = 24;
            this.BtnResetWheelAngle.Text = "Reset Wheel Angle";
            this.BtnResetWheelAngle.UseVisualStyleBackColor = true;
            this.BtnResetWheelAngle.Click += new System.EventHandler(this.BtnResetWheelAngle_Click);
            // 
            // Wheel0AngleLabel
            // 
            this.Wheel0AngleLabel.AutoSize = true;
            this.Wheel0AngleLabel.Location = new System.Drawing.Point(630, 465);
            this.Wheel0AngleLabel.Name = "Wheel0AngleLabel";
            this.Wheel0AngleLabel.Size = new System.Drawing.Size(47, 13);
            this.Wheel0AngleLabel.TabIndex = 25;
            this.Wheel0AngleLabel.Text = "Wheel 0";
            // 
            // Wheel1AngleLabel
            // 
            this.Wheel1AngleLabel.AutoSize = true;
            this.Wheel1AngleLabel.Location = new System.Drawing.Point(630, 515);
            this.Wheel1AngleLabel.Name = "Wheel1AngleLabel";
            this.Wheel1AngleLabel.Size = new System.Drawing.Size(47, 13);
            this.Wheel1AngleLabel.TabIndex = 26;
            this.Wheel1AngleLabel.Text = "Wheel 1";
            // 
            // Wheel2AngleLabel
            // 
            this.Wheel2AngleLabel.AutoSize = true;
            this.Wheel2AngleLabel.Location = new System.Drawing.Point(210, 465);
            this.Wheel2AngleLabel.Name = "Wheel2AngleLabel";
            this.Wheel2AngleLabel.Size = new System.Drawing.Size(47, 13);
            this.Wheel2AngleLabel.TabIndex = 27;
            this.Wheel2AngleLabel.Text = "Wheel 2";
            // 
            // Wheel3AngleLabel
            // 
            this.Wheel3AngleLabel.AutoSize = true;
            this.Wheel3AngleLabel.Location = new System.Drawing.Point(210, 515);
            this.Wheel3AngleLabel.Name = "Wheel3AngleLabel";
            this.Wheel3AngleLabel.Size = new System.Drawing.Size(47, 13);
            this.Wheel3AngleLabel.TabIndex = 28;
            this.Wheel3AngleLabel.Text = "Wheel 3";
            // 
            // BtnArm0Left
            // 
            this.BtnArm0Left.Location = new System.Drawing.Point(800, 5);
            this.BtnArm0Left.Name = "BtnArm0Left";
            this.BtnArm0Left.Size = new System.Drawing.Size(75, 25);
            this.BtnArm0Left.TabIndex = 29;
            this.BtnArm0Left.Text = "Arm 0 left";
            this.BtnArm0Left.UseVisualStyleBackColor = true;
            this.BtnArm0Left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnArm0Left_MouseDown);
            this.BtnArm0Left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnArm0Left_MouseUp);
            // 
            // BtnArm0Right
            // 
            this.BtnArm0Right.Location = new System.Drawing.Point(880, 5);
            this.BtnArm0Right.Name = "BtnArm0Right";
            this.BtnArm0Right.Size = new System.Drawing.Size(75, 25);
            this.BtnArm0Right.TabIndex = 30;
            this.BtnArm0Right.Text = "Arm 0 right";
            this.BtnArm0Right.UseVisualStyleBackColor = true;
            this.BtnArm0Right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnArm0Right_MouseDown);
            this.BtnArm0Right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnArm0Right_MouseUp);
            // 
            // BtnArm1Left
            // 
            this.BtnArm1Left.Location = new System.Drawing.Point(800, 35);
            this.BtnArm1Left.Name = "BtnArm1Left";
            this.BtnArm1Left.Size = new System.Drawing.Size(75, 25);
            this.BtnArm1Left.TabIndex = 31;
            this.BtnArm1Left.Text = "Arm 1 left";
            this.BtnArm1Left.UseVisualStyleBackColor = true;
            this.BtnArm1Left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnArm1Left_MouseDown);
            this.BtnArm1Left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnArm1Left_MouseUp);
            // 
            // BtnArm1Right
            // 
            this.BtnArm1Right.Location = new System.Drawing.Point(880, 35);
            this.BtnArm1Right.Name = "BtnArm1Right";
            this.BtnArm1Right.Size = new System.Drawing.Size(75, 25);
            this.BtnArm1Right.TabIndex = 32;
            this.BtnArm1Right.Text = "Arm 1 right";
            this.BtnArm1Right.UseVisualStyleBackColor = true;
            this.BtnArm1Right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnArm1Right_MouseDown);
            this.BtnArm1Right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnArm1Right_MouseUp);
            // 
            // BtnArm2Left
            // 
            this.BtnArm2Left.Location = new System.Drawing.Point(800, 65);
            this.BtnArm2Left.Name = "BtnArm2Left";
            this.BtnArm2Left.Size = new System.Drawing.Size(75, 25);
            this.BtnArm2Left.TabIndex = 33;
            this.BtnArm2Left.Text = "Arm 2 left";
            this.BtnArm2Left.UseVisualStyleBackColor = true;
            this.BtnArm2Left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnArm2Left_MouseDown);
            this.BtnArm2Left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnArm2Left_MouseUp);
            // 
            // BtnArm2Right
            // 
            this.BtnArm2Right.Location = new System.Drawing.Point(880, 65);
            this.BtnArm2Right.Name = "BtnArm2Right";
            this.BtnArm2Right.Size = new System.Drawing.Size(75, 25);
            this.BtnArm2Right.TabIndex = 34;
            this.BtnArm2Right.Text = "Arm 2 right";
            this.BtnArm2Right.UseVisualStyleBackColor = true;
            this.BtnArm2Right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnArm2Right_MouseDown);
            this.BtnArm2Right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnArm2Right_MouseUp);
            // 
            // BtnArm3Left
            // 
            this.BtnArm3Left.Location = new System.Drawing.Point(800, 95);
            this.BtnArm3Left.Name = "BtnArm3Left";
            this.BtnArm3Left.Size = new System.Drawing.Size(75, 25);
            this.BtnArm3Left.TabIndex = 35;
            this.BtnArm3Left.Text = "Arm 3 left";
            this.BtnArm3Left.UseVisualStyleBackColor = true;
            this.BtnArm3Left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnArm3Left_MouseDown);
            this.BtnArm3Left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnArm3Left_MouseUp);
            // 
            // BtnArm3Right
            // 
            this.BtnArm3Right.Location = new System.Drawing.Point(880, 95);
            this.BtnArm3Right.Name = "BtnArm3Right";
            this.BtnArm3Right.Size = new System.Drawing.Size(75, 25);
            this.BtnArm3Right.TabIndex = 36;
            this.BtnArm3Right.Text = "Arm 3 right";
            this.BtnArm3Right.UseVisualStyleBackColor = true;
            this.BtnArm3Right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnArm3Right_MouseDown);
            this.BtnArm3Right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnArm3Right_MouseUp);
            // 
            // BtnArm4Left
            // 
            this.BtnArm4Left.Location = new System.Drawing.Point(800, 125);
            this.BtnArm4Left.Name = "BtnArm4Left";
            this.BtnArm4Left.Size = new System.Drawing.Size(75, 25);
            this.BtnArm4Left.TabIndex = 37;
            this.BtnArm4Left.Text = "Arm 4 left";
            this.BtnArm4Left.UseVisualStyleBackColor = true;
            this.BtnArm4Left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnArm4Left_MouseDown);
            this.BtnArm4Left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnArm4Left_MouseUp);
            // 
            // BtnArm4Right
            // 
            this.BtnArm4Right.Location = new System.Drawing.Point(880, 125);
            this.BtnArm4Right.Name = "BtnArm4Right";
            this.BtnArm4Right.Size = new System.Drawing.Size(75, 25);
            this.BtnArm4Right.TabIndex = 38;
            this.BtnArm4Right.Text = "Arm 4 right";
            this.BtnArm4Right.UseVisualStyleBackColor = true;
            this.BtnArm4Right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnArm4Right_MouseDown);
            this.BtnArm4Right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnArm4Right_MouseUp);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 601);
            this.Controls.Add(this.BtnArm4Right);
            this.Controls.Add(this.BtnArm4Left);
            this.Controls.Add(this.BtnArm3Right);
            this.Controls.Add(this.BtnArm3Left);
            this.Controls.Add(this.BtnArm2Right);
            this.Controls.Add(this.BtnArm2Left);
            this.Controls.Add(this.BtnArm1Right);
            this.Controls.Add(this.BtnArm1Left);
            this.Controls.Add(this.BtnArm0Right);
            this.Controls.Add(this.BtnArm0Left);
            this.Controls.Add(this.Wheel3AngleLabel);
            this.Controls.Add(this.Wheel2AngleLabel);
            this.Controls.Add(this.Wheel1AngleLabel);
            this.Controls.Add(this.Wheel0AngleLabel);
            this.Controls.Add(this.BtnResetWheelAngle);
            this.Controls.Add(this.BtnSyncWheelAngle);
            this.Controls.Add(this.Wheel3AngleSlider);
            this.Controls.Add(this.Wheel2AngleSlider);
            this.Controls.Add(this.Wheel1AngleSlider);
            this.Controls.Add(this.Wheel0AngleSlider);
            this.Controls.Add(this.BtnResetWheelSpeed);
            this.Controls.Add(this.BtnSyncWheelSpeed);
            this.Controls.Add(this.Wheel3SpeedLabel);
            this.Controls.Add(this.Wheel2SpeedLabel);
            this.Controls.Add(this.Wheel1SpeedLabel);
            this.Controls.Add(this.Wheel0SpeedLabel);
            this.Controls.Add(this.Wheel3SpeedSlider);
            this.Controls.Add(this.Wheel2SpeedSlider);
            this.Controls.Add(this.Wheel1SpeedSlider);
            this.Controls.Add(this.Wheel0SpeedSlider);
            this.Controls.Add(this.BtnDisconnect);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.TxtSendPort);
            this.Controls.Add(this.TxtRecievePort);
            this.Name = "Interface";
            this.Text = "Interface";
            this.Load += new System.EventHandler(this.Interface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Wheel0SpeedSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wheel1SpeedSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wheel2SpeedSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wheel3SpeedSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wheel0AngleSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wheel1AngleSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wheel2AngleSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wheel3AngleSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.IO.Ports.SerialPort SerialPortRecieve;
        public System.IO.Ports.SerialPort SerialPortSend;
        public System.Windows.Forms.ComboBox TxtRecievePort;
        public System.Windows.Forms.ComboBox TxtSendPort;
        public System.Windows.Forms.Button BtnEdit;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button BtnSave;
        public System.Windows.Forms.Button BtnConnect;
        public System.Windows.Forms.Button BtnDisconnect;
        public System.Windows.Forms.TrackBar Wheel0SpeedSlider;
        public System.Windows.Forms.TrackBar Wheel1SpeedSlider;
        public System.Windows.Forms.TrackBar Wheel2SpeedSlider;
        public System.Windows.Forms.TrackBar Wheel3SpeedSlider;
        public System.Windows.Forms.Label Wheel0SpeedLabel;
        public System.Windows.Forms.Label Wheel1SpeedLabel;
        public System.Windows.Forms.Label Wheel2SpeedLabel;
        public System.Windows.Forms.Label Wheel3SpeedLabel;
        public System.Windows.Forms.Button BtnSyncWheelSpeed;
        public System.Windows.Forms.Button BtnResetWheelSpeed;
        public System.Windows.Forms.TrackBar Wheel0AngleSlider;
        public System.Windows.Forms.TrackBar Wheel1AngleSlider;
        public System.Windows.Forms.TrackBar Wheel2AngleSlider;
        public System.Windows.Forms.TrackBar Wheel3AngleSlider;
        public System.Windows.Forms.Button BtnSyncWheelAngle;
        public System.Windows.Forms.Button BtnResetWheelAngle;
        public System.Windows.Forms.Label Wheel0AngleLabel;
        public System.Windows.Forms.Label Wheel1AngleLabel;
        public System.Windows.Forms.Label Wheel2AngleLabel;
        public System.Windows.Forms.Label Wheel3AngleLabel;
        public System.Windows.Forms.Button BtnArm0Left;
        public System.Windows.Forms.Button BtnArm0Right;
        public System.Windows.Forms.Button BtnArm1Left;
        public System.Windows.Forms.Button BtnArm1Right;
        public System.Windows.Forms.Button BtnArm2Left;
        public System.Windows.Forms.Button BtnArm2Right;
        public System.Windows.Forms.Button BtnArm3Left;
        public System.Windows.Forms.Button BtnArm3Right;
        public System.Windows.Forms.Button BtnArm4Left;
        public System.Windows.Forms.Button BtnArm4Right;
    }
}

