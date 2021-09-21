namespace Okul_servisi_sayım
{
    partial class aracsofor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aracsofor));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_plaka = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_konum = new System.Windows.Forms.TextBox();
            this.dtg_aracsofor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_aracsofor)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(233, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "GÜNCELLE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(548, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "GERİ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(389, 247);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 51);
            this.button3.TabIndex = 3;
            this.button3.Text = "SİL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(89, 247);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 51);
            this.button4.TabIndex = 4;
            this.button4.Text = "KAYDET";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(48, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ad Soyad:";
            // 
            // txt_ad
            // 
            this.txt_ad.Font = new System.Drawing.Font("Lucida Bright", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ad.Location = new System.Drawing.Point(184, 33);
            this.txt_ad.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_ad.Multiline = true;
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(507, 39);
            this.txt_ad.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(13, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tc Kimlik No:";
            // 
            // txt_tc
            // 
            this.txt_tc.Font = new System.Drawing.Font("Lucida Bright", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tc.Location = new System.Drawing.Point(184, 84);
            this.txt_tc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_tc.Multiline = true;
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(507, 39);
            this.txt_tc.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(85, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Plaka:";
            // 
            // txt_plaka
            // 
            this.txt_plaka.Font = new System.Drawing.Font("Lucida Bright", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_plaka.Location = new System.Drawing.Point(184, 135);
            this.txt_plaka.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_plaka.Multiline = true;
            this.txt_plaka.Name = "txt_plaka";
            this.txt_plaka.Size = new System.Drawing.Size(507, 39);
            this.txt_plaka.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(70, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Konum:";
            // 
            // txt_konum
            // 
            this.txt_konum.Font = new System.Drawing.Font("Lucida Bright", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_konum.Location = new System.Drawing.Point(184, 181);
            this.txt_konum.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_konum.Multiline = true;
            this.txt_konum.Name = "txt_konum";
            this.txt_konum.Size = new System.Drawing.Size(507, 39);
            this.txt_konum.TabIndex = 12;
            // 
            // dtg_aracsofor
            // 
            this.dtg_aracsofor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_aracsofor.Location = new System.Drawing.Point(76, 321);
            this.dtg_aracsofor.Name = "dtg_aracsofor";
            this.dtg_aracsofor.RowTemplate.Height = 24;
            this.dtg_aracsofor.Size = new System.Drawing.Size(591, 150);
            this.dtg_aracsofor.TabIndex = 13;
            // 
            // aracsofor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(716, 505);
            this.Controls.Add(this.dtg_aracsofor);
            this.Controls.Add(this.txt_konum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_plaka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Name = "aracsofor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Şoför İşlemleri";
            this.Load += new System.EventHandler(this.aracsofor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_aracsofor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_plaka;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_konum;
        private System.Windows.Forms.DataGridView dtg_aracsofor;
    }
}