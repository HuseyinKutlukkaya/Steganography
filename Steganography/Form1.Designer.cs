namespace Steganography
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
            this.pxOrijinal = new System.Windows.Forms.PictureBox();
            this.pxSaklanacak = new System.Windows.Forms.PictureBox();
            this.pxSaklanmis = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pxCikarilmisSaklanacak = new System.Windows.Forms.PictureBox();
            this.pxCikarilmisOrijinal = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOrjinalSec = new System.Windows.Forms.Button();
            this.btnSaklanacakSec = new System.Windows.Forms.Button();
            this.btnCikarilmisOrjinalKaydet = new System.Windows.Forms.Button();
            this.btnSaklanmisKaydet = new System.Windows.Forms.Button();
            this.btnCikarilmisSaklanacakKaydet = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnBasla = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pxOrijinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxSaklanacak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxSaklanmis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxCikarilmisSaklanacak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxCikarilmisOrijinal)).BeginInit();
            this.SuspendLayout();
            // 
            // pxOrijinal
            // 
            this.pxOrijinal.Location = new System.Drawing.Point(32, 31);
            this.pxOrijinal.Name = "pxOrijinal";
            this.pxOrijinal.Size = new System.Drawing.Size(290, 290);
            this.pxOrijinal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxOrijinal.TabIndex = 0;
            this.pxOrijinal.TabStop = false;
            // 
            // pxSaklanacak
            // 
            this.pxSaklanacak.Location = new System.Drawing.Point(380, 31);
            this.pxSaklanacak.Name = "pxSaklanacak";
            this.pxSaklanacak.Size = new System.Drawing.Size(290, 290);
            this.pxSaklanacak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxSaklanacak.TabIndex = 1;
            this.pxSaklanacak.TabStop = false;
            // 
            // pxSaklanmis
            // 
            this.pxSaklanmis.Location = new System.Drawing.Point(713, 31);
            this.pxSaklanmis.Name = "pxSaklanmis";
            this.pxSaklanmis.Size = new System.Drawing.Size(290, 290);
            this.pxSaklanmis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxSaklanmis.TabIndex = 2;
            this.pxSaklanmis.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(73, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Orijinal Resim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(436, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Saklanacak Resim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(783, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Saklanmış Resim";
            // 
            // pxCikarilmisSaklanacak
            // 
            this.pxCikarilmisSaklanacak.Location = new System.Drawing.Point(380, 359);
            this.pxCikarilmisSaklanacak.Name = "pxCikarilmisSaklanacak";
            this.pxCikarilmisSaklanacak.Size = new System.Drawing.Size(290, 290);
            this.pxCikarilmisSaklanacak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxCikarilmisSaklanacak.TabIndex = 7;
            this.pxCikarilmisSaklanacak.TabStop = false;
            // 
            // pxCikarilmisOrijinal
            // 
            this.pxCikarilmisOrijinal.Location = new System.Drawing.Point(32, 359);
            this.pxCikarilmisOrijinal.Name = "pxCikarilmisOrijinal";
            this.pxCikarilmisOrijinal.Size = new System.Drawing.Size(290, 290);
            this.pxCikarilmisOrijinal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxCikarilmisOrijinal.TabIndex = 6;
            this.pxCikarilmisOrijinal.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(407, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Çıkarılmış Saklanacak Resim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(73, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Çıkarılmış Orijinal Resim";
            // 
            // btnOrjinalSec
            // 
            this.btnOrjinalSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrjinalSec.Location = new System.Drawing.Point(713, 404);
            this.btnOrjinalSec.Name = "btnOrjinalSec";
            this.btnOrjinalSec.Size = new System.Drawing.Size(343, 40);
            this.btnOrjinalSec.TabIndex = 10;
            this.btnOrjinalSec.Text = "Orijinal Resimi Seç";
            this.btnOrjinalSec.UseVisualStyleBackColor = true;
            this.btnOrjinalSec.Click += new System.EventHandler(this.btnOrjinalSec_Click);
            // 
            // btnSaklanacakSec
            // 
            this.btnSaklanacakSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaklanacakSec.Location = new System.Drawing.Point(713, 450);
            this.btnSaklanacakSec.Name = "btnSaklanacakSec";
            this.btnSaklanacakSec.Size = new System.Drawing.Size(343, 40);
            this.btnSaklanacakSec.TabIndex = 11;
            this.btnSaklanacakSec.Text = "Saklanacak Resimi Seç";
            this.btnSaklanacakSec.UseVisualStyleBackColor = true;
            this.btnSaklanacakSec.Click += new System.EventHandler(this.btnSaklanacakSec_Click);
            // 
            // btnCikarilmisOrjinalKaydet
            // 
            this.btnCikarilmisOrjinalKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikarilmisOrjinalKaydet.Location = new System.Drawing.Point(713, 565);
            this.btnCikarilmisOrjinalKaydet.Name = "btnCikarilmisOrjinalKaydet";
            this.btnCikarilmisOrjinalKaydet.Size = new System.Drawing.Size(343, 40);
            this.btnCikarilmisOrjinalKaydet.TabIndex = 13;
            this.btnCikarilmisOrjinalKaydet.Text = "Çıkarılmış Orijinal Resimi Kaydet";
            this.btnCikarilmisOrjinalKaydet.UseVisualStyleBackColor = true;
            this.btnCikarilmisOrjinalKaydet.Click += new System.EventHandler(this.btnCikarilmisOrjinalKaydet_Click);
            // 
            // btnSaklanmisKaydet
            // 
            this.btnSaklanmisKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaklanmisKaydet.Location = new System.Drawing.Point(713, 519);
            this.btnSaklanmisKaydet.Name = "btnSaklanmisKaydet";
            this.btnSaklanmisKaydet.Size = new System.Drawing.Size(343, 40);
            this.btnSaklanmisKaydet.TabIndex = 12;
            this.btnSaklanmisKaydet.Text = "Saklanmış Resimi Kaydet";
            this.btnSaklanmisKaydet.UseVisualStyleBackColor = true;
            this.btnSaklanmisKaydet.Click += new System.EventHandler(this.btnSaklanmisKaydet_Click);
            // 
            // btnCikarilmisSaklanacakKaydet
            // 
            this.btnCikarilmisSaklanacakKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikarilmisSaklanacakKaydet.Location = new System.Drawing.Point(713, 611);
            this.btnCikarilmisSaklanacakKaydet.Name = "btnCikarilmisSaklanacakKaydet";
            this.btnCikarilmisSaklanacakKaydet.Size = new System.Drawing.Size(343, 40);
            this.btnCikarilmisSaklanacakKaydet.TabIndex = 14;
            this.btnCikarilmisSaklanacakKaydet.Text = "Çıkarılmış Saklanacak Resimi Kaydet";
            this.btnCikarilmisSaklanacakKaydet.UseVisualStyleBackColor = true;
            this.btnCikarilmisSaklanacakKaydet.Click += new System.EventHandler(this.btnCikarilmisSaklanacakKaydet_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBasla
            // 
            this.btnBasla.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBasla.Location = new System.Drawing.Point(713, 345);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(343, 40);
            this.btnBasla.TabIndex = 15;
            this.btnBasla.Text = "BAŞLAT";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 661);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.btnCikarilmisSaklanacakKaydet);
            this.Controls.Add(this.btnCikarilmisOrjinalKaydet);
            this.Controls.Add(this.btnSaklanmisKaydet);
            this.Controls.Add(this.btnSaklanacakSec);
            this.Controls.Add(this.btnOrjinalSec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pxCikarilmisSaklanacak);
            this.Controls.Add(this.pxCikarilmisOrijinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pxSaklanmis);
            this.Controls.Add(this.pxSaklanacak);
            this.Controls.Add(this.pxOrijinal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steganography Hüseyin Kutlukkaya";
            ((System.ComponentModel.ISupportInitialize)(this.pxOrijinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxSaklanacak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxSaklanmis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxCikarilmisSaklanacak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxCikarilmisOrijinal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pxOrijinal;
        private System.Windows.Forms.PictureBox pxSaklanacak;
        private System.Windows.Forms.PictureBox pxSaklanmis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pxCikarilmisSaklanacak;
        private System.Windows.Forms.PictureBox pxCikarilmisOrijinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOrjinalSec;
        private System.Windows.Forms.Button btnSaklanacakSec;
        private System.Windows.Forms.Button btnCikarilmisOrjinalKaydet;
        private System.Windows.Forms.Button btnSaklanmisKaydet;
        private System.Windows.Forms.Button btnCikarilmisSaklanacakKaydet;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

