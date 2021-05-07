
namespace Linq_Sorguları
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.lblmin = new System.Windows.Forms.Label();
            this.lblmax = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(858, 146);
            this.dataGridView1.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.Cyan;
            this.radioButton1.Location = new System.Drawing.Point(12, 164);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(187, 31);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1. Sınav<50";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(916, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adı :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Location = new System.Drawing.Point(876, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "LİNQ ENTİTY";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1004, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 34);
            this.textBox1.TabIndex = 4;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.Cyan;
            this.radioButton2.Location = new System.Drawing.Point(12, 216);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(243, 31);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Adı Ali Olanlar";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.Color.Cyan;
            this.radioButton3.Location = new System.Drawing.Point(12, 270);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(397, 31);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Adı Veya Soyadı Textten Al";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(874, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Soyadı :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1004, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(194, 34);
            this.textBox2.TabIndex = 8;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.ForeColor = System.Drawing.Color.Cyan;
            this.radioButton4.Location = new System.Drawing.Point(12, 321);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(271, 31);
            this.radioButton4.TabIndex = 9;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Öğrenci Soyadları";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.ForeColor = System.Drawing.Color.Cyan;
            this.radioButton5.Location = new System.Drawing.Point(12, 370);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(327, 31);
            this.radioButton5.TabIndex = 10;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Adı Büyük Soyad Küçük";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.ForeColor = System.Drawing.Color.Cyan;
            this.radioButton6.Location = new System.Drawing.Point(12, 423);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(201, 31);
            this.radioButton6.TabIndex = 11;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Şartlı Seçim";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.ForeColor = System.Drawing.Color.Cyan;
            this.radioButton7.Location = new System.Drawing.Point(12, 471);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(187, 31);
            this.radioButton7.TabIndex = 12;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Geçti Kaldı";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.ForeColor = System.Drawing.Color.Cyan;
            this.radioButton8.Location = new System.Drawing.Point(12, 519);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(159, 31);
            this.radioButton8.TabIndex = 13;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Birleştir";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.ForeColor = System.Drawing.Color.Cyan;
            this.radioButton9.Location = new System.Drawing.Point(12, 567);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(187, 31);
            this.radioButton9.TabIndex = 14;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "İlk 3 Değer";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.ForeColor = System.Drawing.Color.Cyan;
            this.radioButton10.Location = new System.Drawing.Point(12, 604);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(187, 31);
            this.radioButton10.TabIndex = 15;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Son 3 Değer";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.ForeColor = System.Drawing.Color.Cyan;
            this.radioButton11.Location = new System.Drawing.Point(224, 567);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(285, 31);
            this.radioButton11.TabIndex = 16;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "Ada Göre Ad Sırala";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.ForeColor = System.Drawing.Color.Cyan;
            this.radioButton12.Location = new System.Drawing.Point(224, 604);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(271, 31);
            this.radioButton12.TabIndex = 17;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "İlk 5 Değeri Atla";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.ForeColor = System.Drawing.Color.Cyan;
            this.radioButton13.Location = new System.Drawing.Point(224, 519);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(173, 31);
            this.radioButton13.TabIndex = 18;
            this.radioButton13.TabStop = true;
            this.radioButton13.Text = "Gruplandır";
            this.radioButton13.UseVisualStyleBackColor = true;
            // 
            // lblmin
            // 
            this.lblmin.AutoSize = true;
            this.lblmin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblmin.Location = new System.Drawing.Point(1074, 205);
            this.lblmin.Name = "lblmin";
            this.lblmin.Size = new System.Drawing.Size(110, 27);
            this.lblmin.TabIndex = 19;
            this.lblmin.Text = "Minimum";
            // 
            // lblmax
            // 
            this.lblmax.AutoSize = true;
            this.lblmax.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblmax.Location = new System.Drawing.Point(874, 205);
            this.lblmax.Name = "lblmax";
            this.lblmax.Size = new System.Drawing.Size(110, 27);
            this.lblmax.TabIndex = 20;
            this.lblmax.Text = "Maximum";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1255, 645);
            this.Controls.Add(this.lblmax);
            this.Controls.Add(this.lblmin);
            this.Controls.Add(this.radioButton13);
            this.Controls.Add(this.radioButton12);
            this.Controls.Add(this.radioButton11);
            this.Controls.Add(this.radioButton10);
            this.Controls.Add(this.radioButton9);
            this.Controls.Add(this.radioButton8);
            this.Controls.Add(this.radioButton7);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LİNQ Sorguları";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.Label lblmin;
        private System.Windows.Forms.Label lblmax;
    }
}

