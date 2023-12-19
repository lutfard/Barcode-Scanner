namespace BarcodeScanner
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
            this.ddlCameraDevice = new System.Windows.Forms.ComboBox();
            this.scrScanner = new System.Windows.Forms.PictureBox();
            this.lblOutputText = new System.Windows.Forms.Label();
            this.txtBarcodeString = new System.Windows.Forms.TextBox();
            this.btnStartApps = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDevice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scrScanner)).BeginInit();
            this.SuspendLayout();
            // 
            // ddlCameraDevice
            // 
            this.ddlCameraDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlCameraDevice.FormattingEnabled = true;
            this.ddlCameraDevice.Location = new System.Drawing.Point(176, 94);
            this.ddlCameraDevice.Name = "ddlCameraDevice";
            this.ddlCameraDevice.Size = new System.Drawing.Size(469, 28);
            this.ddlCameraDevice.TabIndex = 1;
            // 
            // scrScanner
            // 
            this.scrScanner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scrScanner.Location = new System.Drawing.Point(100, 153);
            this.scrScanner.Name = "scrScanner";
            this.scrScanner.Size = new System.Drawing.Size(545, 319);
            this.scrScanner.TabIndex = 2;
            this.scrScanner.TabStop = false;
            // 
            // lblOutputText
            // 
            this.lblOutputText.AutoSize = true;
            this.lblOutputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputText.Location = new System.Drawing.Point(100, 498);
            this.lblOutputText.Name = "lblOutputText";
            this.lblOutputText.Size = new System.Drawing.Size(71, 25);
            this.lblOutputText.TabIndex = 3;
            this.lblOutputText.Text = "Output";
            // 
            // txtBarcodeString
            // 
            this.txtBarcodeString.Location = new System.Drawing.Point(176, 498);
            this.txtBarcodeString.Name = "txtBarcodeString";
            this.txtBarcodeString.Size = new System.Drawing.Size(349, 26);
            this.txtBarcodeString.TabIndex = 4;
            // 
            // btnStartApps
            // 
            this.btnStartApps.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnStartApps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartApps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartApps.ForeColor = System.Drawing.Color.White;
            this.btnStartApps.Location = new System.Drawing.Point(548, 495);
            this.btnStartApps.Name = "btnStartApps";
            this.btnStartApps.Size = new System.Drawing.Size(97, 37);
            this.btnStartApps.TabIndex = 5;
            this.btnStartApps.Text = "START";
            this.btnStartApps.UseVisualStyleBackColor = false;
            this.btnStartApps.Click += new System.EventHandler(this.btnStartApps_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(169, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(396, 40);
            this.label3.TabIndex = 6;
            this.label3.Text = "BARCODE SCANNER";
            // 
            // lblDevice
            // 
            this.lblDevice.AutoSize = true;
            this.lblDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevice.Location = new System.Drawing.Point(100, 94);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(72, 25);
            this.lblDevice.TabIndex = 7;
            this.lblDevice.Text = "Device";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(727, 590);
            this.Controls.Add(this.lblDevice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStartApps);
            this.Controls.Add(this.txtBarcodeString);
            this.Controls.Add(this.lblOutputText);
            this.Controls.Add(this.scrScanner);
            this.Controls.Add(this.ddlCameraDevice);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Webcam Barcode Scanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scrScanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeviceInput;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox ddlCameraDevice;
        private System.Windows.Forms.PictureBox scrScanner;
        private System.Windows.Forms.Label lblOutputText;
        private System.Windows.Forms.TextBox txtBarcodeString;
        private System.Windows.Forms.Button btnStartApps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDevice;
    }
}

