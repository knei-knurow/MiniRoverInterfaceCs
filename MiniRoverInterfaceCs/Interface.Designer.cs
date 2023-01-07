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
            this.SerialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SerialPort2 = new System.IO.Ports.SerialPort(this.components);
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnSyncWheelSpeed = new System.Windows.Forms.Button();
            this.BtnResetWheelSpeed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Wheel0SpeedSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wheel1SpeedSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wheel2SpeedSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wheel3SpeedSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtRecievePort
            // 
            this.TxtRecievePort.FormattingEnabled = true;
            this.TxtRecievePort.Location = new System.Drawing.Point(274, 6);
            this.TxtRecievePort.Name = "TxtRecievePort";
            this.TxtRecievePort.Size = new System.Drawing.Size(121, 21);
            this.TxtRecievePort.TabIndex = 0;
            this.TxtRecievePort.DropDown += new System.EventHandler(this.TxtRecievePort_DropDown);
            // 
            // TxtSendPort
            // 
            this.TxtSendPort.FormattingEnabled = true;
            this.TxtSendPort.Location = new System.Drawing.Point(72, 6);
            this.TxtSendPort.Name = "TxtSendPort";
            this.TxtSendPort.Size = new System.Drawing.Size(121, 21);
            this.TxtSendPort.TabIndex = 1;
            this.TxtSendPort.DropDown += new System.EventHandler(this.TxtSendPort_DropDown);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(401, 4);
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
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Send Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Recieve Port";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(482, 4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 25);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(564, 4);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(75, 25);
            this.BtnConnect.TabIndex = 6;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // BtnDisconnect
            // 
            this.BtnDisconnect.Location = new System.Drawing.Point(645, 4);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Wheel 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Wheel 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Wheel 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Wheel 3";
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
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.BtnResetWheelSpeed);
            this.Controls.Add(this.BtnSyncWheelSpeed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort SerialPort1;
        private System.IO.Ports.SerialPort SerialPort2;
        private System.Windows.Forms.ComboBox TxtRecievePort;
        private System.Windows.Forms.ComboBox TxtSendPort;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Button BtnDisconnect;
        private System.Windows.Forms.TrackBar Wheel0SpeedSlider;
        private System.Windows.Forms.TrackBar Wheel1SpeedSlider;
        private System.Windows.Forms.TrackBar Wheel2SpeedSlider;
        private System.Windows.Forms.TrackBar Wheel3SpeedSlider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnSyncWheelSpeed;
        private System.Windows.Forms.Button BtnResetWheelSpeed;
    }
}

