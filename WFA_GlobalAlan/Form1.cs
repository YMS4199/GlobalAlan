using System;
using System.Windows.Forms;

namespace WFA_GlobalAlan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayi = 15;
        private void btnArttir_Click(object sender, EventArgs e)
        {
            //int sayi = 15;
            // sayıyı bir üst tam değere taşımak için kullanabilirsiniz.
            // 1. Yol
            //sayi = sayi + 1;
            // 2. Yol
            //sayi += 1;
            // 3. Yol
            sayi++;
            lblSayi.Text = sayi.ToString();
        }

        private void btnEksilt_Click(object sender, EventArgs e)
        {
            //int sayi = 15;
            //sayi = sayi - 1;
            //sayi -= 1;
            sayi--;
            lblSayi.Text = sayi.ToString();
        }
    }
}
