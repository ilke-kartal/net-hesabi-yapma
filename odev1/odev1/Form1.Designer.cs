namespace odev1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatNet = new System.Windows.Forms.TextBox();
            this.txtMatYanlis = new System.Windows.Forms.TextBox();
            this.txtMatDogru = new System.Windows.Forms.TextBox();
            this.txtTrYanlis = new System.Windows.Forms.TextBox();
            this.txtTrNet = new System.Windows.Forms.TextBox();
            this.txtTrDogru = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMatNet);
            this.groupBox1.Controls.Add(this.txtMatYanlis);
            this.groupBox1.Controls.Add(this.txtMatDogru);
            this.groupBox1.Controls.Add(this.txtTrYanlis);
            this.groupBox1.Controls.Add(this.txtTrNet);
            this.groupBox1.Controls.Add(this.txtTrDogru);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(179, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 267);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sınav 1. oturum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Net";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Yanlış";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Doğru";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Matematik";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Türkçe";
            // 
            // txtMatNet
            // 
            this.txtMatNet.Enabled = false;
            this.txtMatNet.Location = new System.Drawing.Point(387, 121);
            this.txtMatNet.Name = "txtMatNet";
            this.txtMatNet.Size = new System.Drawing.Size(62, 27);
            this.txtMatNet.TabIndex = 5;
            // 
            // txtMatYanlis
            // 
            this.txtMatYanlis.Location = new System.Drawing.Point(284, 121);
            this.txtMatYanlis.Name = "txtMatYanlis";
            this.txtMatYanlis.Size = new System.Drawing.Size(62, 27);
            this.txtMatYanlis.TabIndex = 4;
            this.txtMatYanlis.TextChanged += new System.EventHandler(this.txtMatYanlis_TextChanged);
            // 
            // txtMatDogru
            // 
            this.txtMatDogru.Location = new System.Drawing.Point(188, 121);
            this.txtMatDogru.Name = "txtMatDogru";
            this.txtMatDogru.Size = new System.Drawing.Size(62, 27);
            this.txtMatDogru.TabIndex = 3;
            this.txtMatDogru.TextChanged += new System.EventHandler(this.txtMatDogru_TextChanged);
            // 
            // txtTrYanlis
            // 
            this.txtTrYanlis.Location = new System.Drawing.Point(284, 56);
            this.txtTrYanlis.Name = "txtTrYanlis";
            this.txtTrYanlis.Size = new System.Drawing.Size(62, 27);
            this.txtTrYanlis.TabIndex = 2;
            this.txtTrYanlis.TextChanged += new System.EventHandler(this.txtTrYanlis_TextChanged);
            // 
            // txtTrNet
            // 
            this.txtTrNet.Enabled = false;
            this.txtTrNet.Location = new System.Drawing.Point(387, 56);
            this.txtTrNet.Name = "txtTrNet";
            this.txtTrNet.Size = new System.Drawing.Size(62, 27);
            this.txtTrNet.TabIndex = 1;
            // 
            // txtTrDogru
            // 
            this.txtTrDogru.Location = new System.Drawing.Point(188, 56);
            this.txtTrDogru.Name = "txtTrDogru";
            this.txtTrDogru.Size = new System.Drawing.Size(62, 27);
            this.txtTrDogru.TabIndex = 0;
            this.txtTrDogru.TextChanged += new System.EventHandler(this.txtTrDogru_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Net Hesaplama";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatNet;
        private System.Windows.Forms.TextBox txtMatYanlis;
        private System.Windows.Forms.TextBox txtMatDogru;
        private System.Windows.Forms.TextBox txtTrYanlis;
        private System.Windows.Forms.TextBox txtTrNet;
        private System.Windows.Forms.TextBox txtTrDogru;
    }
}

