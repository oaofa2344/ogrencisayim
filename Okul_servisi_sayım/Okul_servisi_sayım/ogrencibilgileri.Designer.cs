namespace Okul_servisi_sayım
{
    partial class ogrencibilgileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogrencibilgileri));
            this.button1 = new System.Windows.Forms.Button();
            this.dtg_avcılar = new System.Windows.Forms.DataGridView();
            this.dtg_beylikduzu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_avcılar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_beylikduzu)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(409, 668);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 91);
            this.button1.TabIndex = 7;
            this.button1.Text = "GERİ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtg_avcılar
            // 
            this.dtg_avcılar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_avcılar.Location = new System.Drawing.Point(12, 40);
            this.dtg_avcılar.Name = "dtg_avcılar";
            this.dtg_avcılar.RowTemplate.Height = 24;
            this.dtg_avcılar.Size = new System.Drawing.Size(431, 608);
            this.dtg_avcılar.TabIndex = 8;
            // 
            // dtg_beylikduzu
            // 
            this.dtg_beylikduzu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_beylikduzu.Location = new System.Drawing.Point(499, 40);
            this.dtg_beylikduzu.Name = "dtg_beylikduzu";
            this.dtg_beylikduzu.RowTemplate.Height = 24;
            this.dtg_beylikduzu.Size = new System.Drawing.Size(428, 608);
            this.dtg_beylikduzu.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(185, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "AVCILAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(613, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "BEYLİKDÜZÜ";
            // 
            // ogrencibilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(939, 829);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtg_beylikduzu);
            this.Controls.Add(this.dtg_avcılar);
            this.Controls.Add(this.button1);
            this.Name = "ogrencibilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Bilgileri";
            this.Load += new System.EventHandler(this.ogrencibilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_avcılar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_beylikduzu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtg_avcılar;
        private System.Windows.Forms.DataGridView dtg_beylikduzu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}