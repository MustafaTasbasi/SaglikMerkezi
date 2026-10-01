namespace SaglikMerkezi
{
    partial class Hasta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIsim = new System.Windows.Forms.Label();
            this.lblSoyisim = new System.Windows.Forms.Label();
            this.doktorgrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Grandevu = new System.Windows.Forms.DataGridView();
            this.txtDid = new System.Windows.Forms.TextBox();
            this.txtrid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.doktorgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grandevu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyisim";
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Location = new System.Drawing.Point(122, 13);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(44, 16);
            this.lblIsim.TabIndex = 2;
            this.lblIsim.Text = "label3";
            // 
            // lblSoyisim
            // 
            this.lblSoyisim.AutoSize = true;
            this.lblSoyisim.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblSoyisim.Location = new System.Drawing.Point(125, 57);
            this.lblSoyisim.Name = "lblSoyisim";
            this.lblSoyisim.Size = new System.Drawing.Size(44, 16);
            this.lblSoyisim.TabIndex = 3;
            this.lblSoyisim.Text = "label4";
            // 
            // doktorgrid
            // 
            this.doktorgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doktorgrid.Location = new System.Drawing.Point(134, 83);
            this.doktorgrid.Name = "doktorgrid";
            this.doktorgrid.RowHeadersWidth = 51;
            this.doktorgrid.RowTemplate.Height = 24;
            this.doktorgrid.Size = new System.Drawing.Size(531, 184);
            this.doktorgrid.TabIndex = 4;
            this.doktorgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.doktorgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Doktor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tarih";
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(134, 284);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(100, 22);
            this.txtTarih.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Saat";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17"});
            this.comboBox1.Location = new System.Drawing.Point(134, 329);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(482, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 11;
            this.button2.Text = "sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Grandevu
            // 
            this.Grandevu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grandevu.Location = new System.Drawing.Point(134, 406);
            this.Grandevu.Name = "Grandevu";
            this.Grandevu.RowHeadersWidth = 51;
            this.Grandevu.RowTemplate.Height = 24;
            this.Grandevu.Size = new System.Drawing.Size(819, 391);
            this.Grandevu.TabIndex = 12;
            this.Grandevu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grandevu_CellContentClick);
            this.Grandevu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grandevu_CellContentClick);
            // 
            // txtDid
            // 
            this.txtDid.Location = new System.Drawing.Point(134, 370);
            this.txtDid.Name = "txtDid";
            this.txtDid.Size = new System.Drawing.Size(100, 22);
            this.txtDid.TabIndex = 13;
            this.txtDid.Visible = false;
            this.txtDid.TextChanged += new System.EventHandler(this.txtDid_TextChanged);
            // 
            // txtrid
            // 
            this.txtrid.Location = new System.Drawing.Point(286, 369);
            this.txtrid.Name = "txtrid";
            this.txtrid.Size = new System.Drawing.Size(100, 22);
            this.txtrid.TabIndex = 14;
            this.txtrid.Visible = false;
            // 
            // Hasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 809);
            this.Controls.Add(this.txtrid);
            this.Controls.Add(this.txtDid);
            this.Controls.Add(this.Grandevu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.doktorgrid);
            this.Controls.Add(this.lblSoyisim);
            this.Controls.Add(this.lblIsim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Hasta";
            this.Text = "Hasta";
            this.Load += new System.EventHandler(this.Hasta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doktorgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grandevu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.Label lblSoyisim;
        private System.Windows.Forms.DataGridView doktorgrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView Grandevu;
        private System.Windows.Forms.TextBox txtDid;
        private System.Windows.Forms.TextBox txtrid;
    }
}