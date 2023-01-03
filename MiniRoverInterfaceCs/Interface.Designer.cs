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
            this.Wheel1SpeedSlider = new System.Windows.Forms.TrackBar();
            this.Wheel2SpeedSlider = new System.Windows.Forms.TrackBar();
            this.Wheel3SpeedSlider = new System.Windows.Forms.TrackBar();
            this.Wheel4SpeedSlider = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.Wheel1SpeedSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wheel2SpeedSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wheel3SpeedSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wheel4SpeedSlider)).BeginInit();
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
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
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
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(564, 4);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(75, 23);
            this.BtnConnect.TabIndex = 6;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // BtnDisconnect
            // 
            this.BtnDisconnect.Location = new System.Drawing.Point(645, 4);
            this.BtnDisconnect.Name = "BtnDisconnect";
            this.BtnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.BtnDisconnect.TabIndex = 7;
            this.BtnDisconnect.Text = "Disconnect";
            this.BtnDisconnect.UseVisualStyleBackColor = true;
            this.BtnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
            // 
            // Wheel1SpeedSlider
            // 
            this.Wheel1SpeedSlider.Location = new System.Drawing.Point(10, 35);
            this.Wheel1SpeedSlider.Maximum = 255;
            this.Wheel1SpeedSlider.Minimum = -255;
            this.Wheel1SpeedSlider.Name = "Wheel1SpeedSlider";
            this.Wheel1SpeedSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Wheel1SpeedSlider.Size = new System.Drawing.Size(45, 511);
            this.Wheel1SpeedSlider.TabIndex = 8;
            this.Wheel1SpeedSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // Wheel2SpeedSlider
            // 
            this.Wheel2SpeedSlider.Location = new System.Drawing.Point(60, 35);
            this.Wheel2SpeedSlider.Maximum = 255;
            this.Wheel2SpeedSlider.Minimum = -255;
            this.Wheel2SpeedSlider.Name = "Wheel2SpeedSlider";
            this.Wheel2SpeedSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Wheel2SpeedSlider.Size = new System.Drawing.Size(45, 511);
            this.Wheel2SpeedSlider.TabIndex = 9;
            this.Wheel2SpeedSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // Wheel3SpeedSlider
            // 
            this.Wheel3SpeedSlider.Location = new System.Drawing.Point(110, 35);
            this.Wheel3SpeedSlider.Maximum = 255;
            this.Wheel3SpeedSlider.Minimum = -255;
            this.Wheel3SpeedSlider.Name = "Wheel3SpeedSlider";
            this.Wheel3SpeedSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Wheel3SpeedSlider.Size = new System.Drawing.Size(45, 511);
            this.Wheel3SpeedSlider.TabIndex = 10;
            this.Wheel3SpeedSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // Wheel4SpeedSlider
            // 
            this.Wheel4SpeedSlider.Location = new System.Drawing.Point(160, 35);
            this.Wheel4SpeedSlider.Maximum = 255;
            this.Wheel4SpeedSlider.Minimum = -255;
            this.Wheel4SpeedSlider.Name = "Wheel4SpeedSlider";
            this.Wheel4SpeedSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Wheel4SpeedSlider.Size = new System.Drawing.Size(45, 511);
            this.Wheel4SpeedSlider.TabIndex = 11;
            this.Wheel4SpeedSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 556);
            this.Controls.Add(this.Wheel4SpeedSlider);
            this.Controls.Add(this.Wheel3SpeedSlider);
            this.Controls.Add(this.Wheel2SpeedSlider);
            this.Controls.Add(this.Wheel1SpeedSlider);
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
            ((System.ComponentModel.ISupportInitialize)(this.Wheel1SpeedSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wheel2SpeedSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wheel3SpeedSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wheel4SpeedSlider)).EndInit();
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
        private System.Windows.Forms.TrackBar Wheel1SpeedSlider;
        private System.Windows.Forms.TrackBar Wheel2SpeedSlider;
        private System.Windows.Forms.TrackBar Wheel3SpeedSlider;
        private System.Windows.Forms.TrackBar Wheel4SpeedSlider;
    }
}

