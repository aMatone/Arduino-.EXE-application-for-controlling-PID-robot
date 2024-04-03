namespace PIDControllerApplication
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.KdLabel = new System.Windows.Forms.Label();
            this.KdTracker = new System.Windows.Forms.TrackBar();
            this.KdNumeric = new System.Windows.Forms.NumericUpDown();
            this.KiLabel = new System.Windows.Forms.Label();
            this.KiTracker = new System.Windows.Forms.TrackBar();
            this.KiNumeric = new System.Windows.Forms.NumericUpDown();
            this.KpLabel = new System.Windows.Forms.Label();
            this.KpTracker = new System.Windows.Forms.TrackBar();
            this.KpNumeric = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.connect_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.serialDevices = new System.Windows.Forms.ComboBox();
            this.send_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KdTracker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KdNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KiTracker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KiNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KpTracker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KpNumeric)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.KdLabel);
            this.groupBox1.Controls.Add(this.KdTracker);
            this.groupBox1.Controls.Add(this.KdNumeric);
            this.groupBox1.Controls.Add(this.KiLabel);
            this.groupBox1.Controls.Add(this.KiTracker);
            this.groupBox1.Controls.Add(this.KiNumeric);
            this.groupBox1.Controls.Add(this.KpLabel);
            this.groupBox1.Controls.Add(this.KpTracker);
            this.groupBox1.Controls.Add(this.KpNumeric);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 276);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Constants controller";
            // 
            // KdLabel
            // 
            this.KdLabel.AutoSize = true;
            this.KdLabel.Location = new System.Drawing.Point(6, 200);
            this.KdLabel.Name = "KdLabel";
            this.KdLabel.Size = new System.Drawing.Size(25, 16);
            this.KdLabel.TabIndex = 7;
            this.KdLabel.Text = "KD";
            // 
            // KdTracker
            // 
            this.KdTracker.Location = new System.Drawing.Point(6, 219);
            this.KdTracker.Maximum = 100;
            this.KdTracker.Name = "KdTracker";
            this.KdTracker.Size = new System.Drawing.Size(267, 56);
            this.KdTracker.TabIndex = 6;
            this.KdTracker.Scroll += new System.EventHandler(this.KdTracker_Scroll);
            // 
            // KdNumeric
            // 
            this.KdNumeric.Location = new System.Drawing.Point(279, 219);
            this.KdNumeric.Name = "KdNumeric";
            this.KdNumeric.Size = new System.Drawing.Size(82, 22);
            this.KdNumeric.TabIndex = 5;
            this.KdNumeric.ValueChanged += new System.EventHandler(this.KdNumeric_ValueChanged);
            // 
            // KiLabel
            // 
            this.KiLabel.AutoSize = true;
            this.KiLabel.Location = new System.Drawing.Point(6, 118);
            this.KiLabel.Name = "KiLabel";
            this.KiLabel.Size = new System.Drawing.Size(18, 16);
            this.KiLabel.TabIndex = 4;
            this.KiLabel.Text = "KI";
            // 
            // KiTracker
            // 
            this.KiTracker.Location = new System.Drawing.Point(6, 137);
            this.KiTracker.Maximum = 100;
            this.KiTracker.Name = "KiTracker";
            this.KiTracker.Size = new System.Drawing.Size(267, 56);
            this.KiTracker.TabIndex = 3;
            this.KiTracker.Scroll += new System.EventHandler(this.KiTracker_Scroll);
            // 
            // KiNumeric
            // 
            this.KiNumeric.Location = new System.Drawing.Point(279, 137);
            this.KiNumeric.Name = "KiNumeric";
            this.KiNumeric.Size = new System.Drawing.Size(82, 22);
            this.KiNumeric.TabIndex = 2;
            this.KiNumeric.ValueChanged += new System.EventHandler(this.KiNumeric_ValueChanged);
            // 
            // KpLabel
            // 
            this.KpLabel.AutoSize = true;
            this.KpLabel.Location = new System.Drawing.Point(6, 39);
            this.KpLabel.Name = "KpLabel";
            this.KpLabel.Size = new System.Drawing.Size(24, 16);
            this.KpLabel.TabIndex = 1;
            this.KpLabel.Text = "KP";
            // 
            // KpTracker
            // 
            this.KpTracker.Location = new System.Drawing.Point(6, 58);
            this.KpTracker.Maximum = 100;
            this.KpTracker.Name = "KpTracker";
            this.KpTracker.Size = new System.Drawing.Size(267, 56);
            this.KpTracker.TabIndex = 1;
            this.KpTracker.Scroll += new System.EventHandler(this.KpTracker_Scroll);
            // 
            // KpNumeric
            // 
            this.KpNumeric.Location = new System.Drawing.Point(279, 58);
            this.KpNumeric.Name = "KpNumeric";
            this.KpNumeric.Size = new System.Drawing.Size(82, 22);
            this.KpNumeric.TabIndex = 0;
            this.KpNumeric.ValueChanged += new System.EventHandler(this.KpNumeric_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.refresh_btn);
            this.groupBox2.Controls.Add(this.connect_btn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.serialDevices);
            this.groupBox2.Location = new System.Drawing.Point(385, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 134);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bluetooth Settings";
            // 
            // refresh_btn
            // 
            this.refresh_btn.Location = new System.Drawing.Point(51, 89);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(89, 25);
            this.refresh_btn.TabIndex = 3;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // connect_btn
            // 
            this.connect_btn.Location = new System.Drawing.Point(146, 89);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(89, 25);
            this.connect_btn.TabIndex = 2;
            this.connect_btn.Text = "Connect";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.connect_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Devices:";
            // 
            // serialDevices
            // 
            this.serialDevices.FormattingEnabled = true;
            this.serialDevices.Location = new System.Drawing.Point(82, 39);
            this.serialDevices.Name = "serialDevices";
            this.serialDevices.Size = new System.Drawing.Size(153, 24);
            this.serialDevices.TabIndex = 0;
            // 
            // send_btn
            // 
            this.send_btn.Location = new System.Drawing.Point(512, 262);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(120, 26);
            this.send_btn.TabIndex = 2;
            this.send_btn.Text = "Send Constants";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 303);
            this.Controls.Add(this.send_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "PID Constants Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KdTracker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KdNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KiTracker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KiNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KpTracker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KpNumeric)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label KdLabel;
        private System.Windows.Forms.TrackBar KdTracker;
        private System.Windows.Forms.NumericUpDown KdNumeric;
        private System.Windows.Forms.Label KiLabel;
        private System.Windows.Forms.TrackBar KiTracker;
        private System.Windows.Forms.NumericUpDown KiNumeric;
        private System.Windows.Forms.Label KpLabel;
        private System.Windows.Forms.TrackBar KpTracker;
        private System.Windows.Forms.NumericUpDown KpNumeric;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox serialDevices;
        private System.Windows.Forms.Button send_btn;
    }
}

