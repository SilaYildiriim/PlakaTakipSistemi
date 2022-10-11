namespace PlakaTakipSistemi
{
    partial class YeniKayit
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
            this.startServerButton = new System.Windows.Forms.Button();
            this.gbResim = new System.Windows.Forms.GroupBox();
            this.pbPlaka = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.infoMessage = new System.Windows.Forms.Label();
            this.timeInfo = new System.Windows.Forms.Label();
            this.sizeInfo = new System.Windows.Forms.Label();
            this.totalTime = new System.Windows.Forms.TextBox();
            this.totalSize = new System.Windows.Forms.TextBox();
            this.gbResim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaka)).BeginInit();
            this.SuspendLayout();
            // 
            // startServerButton
            // 
            this.startServerButton.Location = new System.Drawing.Point(2, 407);
            this.startServerButton.Margin = new System.Windows.Forms.Padding(4);
            this.startServerButton.Name = "startServerButton";
            this.startServerButton.Size = new System.Drawing.Size(478, 39);
            this.startServerButton.TabIndex = 0;
            this.startServerButton.Text = Constant.FormMessages.Start;
            this.startServerButton.UseVisualStyleBackColor = true;
            this.startServerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbResim
            // 
            this.gbResim.Controls.Add(this.pbPlaka);
            this.gbResim.Location = new System.Drawing.Point(16, 13);
            this.gbResim.Margin = new System.Windows.Forms.Padding(4);
            this.gbResim.Name = "gbResim";
            this.gbResim.Padding = new System.Windows.Forms.Padding(4);
            this.gbResim.Size = new System.Drawing.Size(464, 331);
            this.gbResim.TabIndex = 1;
            this.gbResim.TabStop = false;
            this.gbResim.Text = Constant.FormMessages.ReceivedImage;
            // 
            // pbPlaka
            // 
            this.pbPlaka.Location = new System.Drawing.Point(0, 23);
            this.pbPlaka.Margin = new System.Windows.Forms.Padding(4);
            this.pbPlaka.Name = "pbPlaka";
            this.pbPlaka.Size = new System.Drawing.Size(453, 305);
            this.pbPlaka.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlaka.TabIndex = 1;
            this.pbPlaka.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(574, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = Constant.FormMessages.Information;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(564, 407);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(294, 39);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = Constant.FormMessages.Exit;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = Constant.ImageFormats;
            // 
            // infoMessage
            // 
            this.infoMessage.AutoSize = true;
            this.infoMessage.Location = new System.Drawing.Point(574, 88);
            this.infoMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infoMessage.Name = "infoMessage";
            this.infoMessage.Size = new System.Drawing.Size(16, 16);
            this.infoMessage.TabIndex = 9;
            this.infoMessage.Text = Constant.ThreeDots;
            // 
            // timeInfo
            // 
            this.timeInfo.AutoSize = true;
            this.timeInfo.Location = new System.Drawing.Point(574, 144);
            this.timeInfo.Name = "timeInfo";
            this.timeInfo.Size = new System.Drawing.Size(94, 16);
            this.timeInfo.TabIndex = 10;
            this.timeInfo.Text = Constant.FormMessages.TotalTime;
            // 
            // sizeInfo
            // 
            this.sizeInfo.AutoSize = true;
            this.sizeInfo.Location = new System.Drawing.Point(574, 221);
            this.sizeInfo.Name = "sizeInfo";
            this.sizeInfo.Size = new System.Drawing.Size(100, 16);
            this.sizeInfo.TabIndex = 11;
            this.sizeInfo.Text = Constant.FormMessages.TotalSize;
            // 
            // totalTime
            // 
            this.totalTime.Location = new System.Drawing.Point(690, 141);
            this.totalTime.Name = "totalTime";
            this.totalTime.ReadOnly = true;
            this.totalTime.Size = new System.Drawing.Size(100, 22);
            this.totalTime.TabIndex = 12;
            // 
            // totalSize
            // 
            this.totalSize.Location = new System.Drawing.Point(690, 221);
            this.totalSize.Name = "totalSize";
            this.totalSize.ReadOnly = true;
            this.totalSize.Size = new System.Drawing.Size(100, 22);
            this.totalSize.TabIndex = 13;
            // 
            // YeniKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 467);
            this.ControlBox = false;
            this.Controls.Add(this.totalSize);
            this.Controls.Add(this.totalTime);
            this.Controls.Add(this.sizeInfo);
            this.Controls.Add(this.timeInfo);
            this.Controls.Add(this.infoMessage);
            this.Controls.Add(this.startServerButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbResim);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1873, 1446);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(873, 446);
            this.Name = Constant.FormMessages.NewRecord;
            this.Text = Constant.FormMessages.NewPlate;
            this.gbResim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startServerButton;
        private System.Windows.Forms.GroupBox gbResim;
        private System.Windows.Forms.PictureBox pbPlaka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label infoMessage;
        private System.Windows.Forms.Label timeInfo;
        private System.Windows.Forms.Label sizeInfo;
        private System.Windows.Forms.TextBox totalTime;
        private System.Windows.Forms.TextBox totalSize;
    }
}