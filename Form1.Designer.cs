namespace PlakaTakipSistemi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.startButton = new System.Windows.Forms.Button();
            this.dgPlaka = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sortingSelections = new System.Windows.Forms.Label();
            this.cbSirala = new System.Windows.Forms.ComboBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbPlaka = new System.Windows.Forms.Label();
            this.lbGirisTarihi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlaka)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(19, 555);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(601, 38);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Sistemi Başlat";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgPlaka
            // 
            this.dgPlaka.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPlaka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPlaka.Location = new System.Drawing.Point(8, 54);
            this.dgPlaka.Margin = new System.Windows.Forms.Padding(4);
            this.dgPlaka.Name = "dgPlaka";
            this.dgPlaka.RowHeadersWidth = 51;
            this.dgPlaka.Size = new System.Drawing.Size(585, 266);
            this.dgPlaka.TabIndex = 1;
            this.dgPlaka.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPlaka_CellContentClick);
            this.dgPlaka.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPlaka_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sortingSelections);
            this.groupBox1.Controls.Add(this.cbSirala);
            this.groupBox1.Controls.Add(this.refreshButton);
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.searchTextBox);
            this.groupBox1.Controls.Add(this.dgPlaka);
            this.groupBox1.Location = new System.Drawing.Point(11, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(601, 320);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plaka Kayıtları";
            // 
            // sortingSelections
            // 
            this.sortingSelections.AutoSize = true;
            this.sortingSelections.Location = new System.Drawing.Point(300, 27);
            this.sortingSelections.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sortingSelections.Name = "sortingSelections";
            this.sortingSelections.Size = new System.Drawing.Size(45, 16);
            this.sortingSelections.TabIndex = 6;
            this.sortingSelections.Text = "Sırala:";
            // 
            // cbSirala
            // 
            this.cbSirala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSirala.FormattingEnabled = true;
            this.cbSirala.Items.AddRange(new object[] {
            "Plaka",
            "Tarih"});
            this.cbSirala.Location = new System.Drawing.Point(355, 22);
            this.cbSirala.Margin = new System.Windows.Forms.Padding(4);
            this.cbSirala.Name = "cbSirala";
            this.cbSirala.Size = new System.Drawing.Size(129, 24);
            this.cbSirala.TabIndex = 5;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(493, 20);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(4);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(100, 28);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Yenile";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.Location = new System.Drawing.Point(8, 27);
            this.search.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(62, 16);
            this.search.TabIndex = 3;
            this.search.Text = "Araç Ara:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(78, 24);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(132, 22);
            this.searchTextBox.TabIndex = 2;
            this.searchTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbPlaka);
            this.groupBox2.Controls.Add(this.lbGirisTarihi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(11, 361);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(609, 126);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıt Detayları";
            // 
            // lbPlaka
            // 
            this.lbPlaka.AutoSize = true;
            this.lbPlaka.Location = new System.Drawing.Point(95, 39);
            this.lbPlaka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPlaka.Name = "lbPlaka";
            this.lbPlaka.Size = new System.Drawing.Size(79, 16);
            this.lbPlaka.TabIndex = 0;
            this.lbPlaka.Text = "------------------";
            // 
            // lbGirisTarihi
            // 
            this.lbGirisTarihi.AutoSize = true;
            this.lbGirisTarihi.Location = new System.Drawing.Point(95, 70);
            this.lbGirisTarihi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGirisTarihi.Name = "lbGirisTarihi";
            this.lbGirisTarihi.Size = new System.Drawing.Size(79, 16);
            this.lbGirisTarihi.TabIndex = 0;
            this.lbGirisTarihi.Text = "------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giriş Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Plaka:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(652, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.dosyaToolStripMenuItem.Text = "Ayarlar";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(19, 495);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(601, 38);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Kaydı Sil";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 606);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Plaka Takip Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPlaka)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.DataGridView dgPlaka;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label search;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label sortingSelections;
        private System.Windows.Forms.ComboBox cbSirala;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbPlaka;
        private System.Windows.Forms.Label lbGirisTarihi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Button deleteButton;
    }
}

