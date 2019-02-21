using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganography
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap Orjinal, Yazilcak, Karma, SonucO, SonucS;

        private void btnOrjinalSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (of.ShowDialog() == DialogResult.OK)
            {
                pxOrijinal.ImageLocation = of.FileName;

            }
        }

        private void btnSaklanacakSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
           
            of.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (of.ShowDialog() == DialogResult.OK)
            {
                pxSaklanacak.ImageLocation = of.FileName;
                Color a;
                
            }
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            if (pxOrijinal.Image==null||pxSaklanacak.Image == null)
            {
                MessageBox.Show("Orijinal resim ve saklanacak resim boş olamaz","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if(pxSaklanacak.Image.Height==pxOrijinal.Image.Height&&pxOrijinal.Image.Width==pxSaklanacak.Image.Width)
            {
                Orjinal = new Bitmap(pxOrijinal.Image);
                Yazilcak = new Bitmap(pxSaklanacak.Image);
                Karma = new Bitmap(Yazilcak.Width, Yazilcak.Height);
                SonucS = new Bitmap(Yazilcak.Width, Yazilcak.Height);
                SonucO = new Bitmap(Yazilcak.Width, Yazilcak.Height);
                pxCikarilmisOrijinal.Image = null;
                pxSaklanmis.Image = null;
                pxCikarilmisSaklanacak.Image = null;

                MessageBox.Show("Bu işlem bilgisayarınızın hızına göre biraz zaman alabilir.","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Karistir();
                SonucSCikar();
                SonucOCikar();
                pxSaklanmis.Image = Karma;
                pxCikarilmisSaklanacak.Image = SonucS;
                pxCikarilmisOrijinal.Image = SonucO;
            }
            else
            {
                MessageBox.Show("Seçilen resimlerin boyları ve enleri eşit olmalıdır", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }


        String IkiligeCevir(int a)
        {

            return Convert.ToString(a, 2).PadLeft(8, '0');
        }
        int OnlugaCevir(string s)
        {
            var dec = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[s.Length - i - 1] == '1')
                    dec += (int)Math.Pow(2, i);
            }
            return dec;
        }
        void Karistir()
        {
            for (int x = 0; x < Orjinal.Width; x++)
            {
                for (int y = 0; y < Orjinal.Height; y++)
                {
                    Karma.SetPixel(x, y, GetColorK(x, y));

                }
            }


        }
        void SonucSCikar()
        {
            for (int x = 0; x < Karma.Width; x++)
            {
                for (int y = 0; y < Karma.Height; y++)
                {
                    SonucS.SetPixel(x, y, GetColorS(x, y));

                }
            }
        }



        Color GetColorS(int x, int y)
        {
            string r = IkiligeCevir(Karma.GetPixel(x, y).R).Substring(4);
            r += "0000";
            string b = IkiligeCevir(Karma.GetPixel(x, y).B).Substring(4);
            b += "0000";
            string g = IkiligeCevir(Karma.GetPixel(x, y).G).Substring(4);
            g += "0000";


            Color c = Color.FromArgb(OnlugaCevir(r), OnlugaCevir(g), OnlugaCevir(b));

            return c;
        }

        private void btnSaklanmisKaydet_Click(object sender, EventArgs e)
        {
            Kaydet(pxSaklanmis);
        }

        private void btnCikarilmisOrjinalKaydet_Click(object sender, EventArgs e)
        {
            Kaydet(pxCikarilmisOrijinal);

        }

        private void btnCikarilmisSaklanacakKaydet_Click(object sender, EventArgs e)
        {
            Kaydet(pxCikarilmisSaklanacak);
        }

        void SonucOCikar()
        {
            for (int x = 0; x < Karma.Width; x++)
            {
                for (int y = 0; y < Karma.Height; y++)
                {
                    SonucO.SetPixel(x, y, GetColorO(x, y));

                }
            }
        }



        Color GetColorO(int x, int y)
        {
            string r = IkiligeCevir(Karma.GetPixel(x, y).R).Substring(0,4);
            r += "0000";
            string b = IkiligeCevir(Karma.GetPixel(x, y).B).Substring(0,4);
            b += "0000";
            string g = IkiligeCevir(Karma.GetPixel(x, y).G).Substring(0,4);
            g += "0000";


            Color c = Color.FromArgb(OnlugaCevir(r), OnlugaCevir(g), OnlugaCevir(b));

            return c;
        }
        Color GetColorK(int x, int y)
        {
            string r = IkiligeCevir(Orjinal.GetPixel(x, y).R).Substring(0, 4);
            r += IkiligeCevir(Yazilcak.GetPixel(x, y).R).Substring(0, 4);
            string b = IkiligeCevir(Orjinal.GetPixel(x, y).B).Substring(0, 4);
            b += IkiligeCevir(Yazilcak.GetPixel(x, y).B).Substring(0, 4);
            string g = IkiligeCevir(Orjinal.GetPixel(x, y).G).Substring(0, 4);
            g += IkiligeCevir(Yazilcak.GetPixel(x, y).G).Substring(0, 4);
            Color c = Color.FromArgb(OnlugaCevir(r), OnlugaCevir(g), OnlugaCevir(b));

            return c;
        }


        void Kaydet(PictureBox px)
        {
            if(px.Image==null)
            {
                MessageBox.Show("Lütfen işlem yaptıktan sonra tekrar deneyiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                px.Image.Save(sfd.FileName, format);
            }
        }
    }
}
