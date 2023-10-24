using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdentityNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
        * 11 HANE OLMALI
        * HER HANE RAKAM OLAMK ZORUNDA
        * İLK HANE 0 OLAMAZ
        * 1.3.5.7.9. HANELERİN TOPLAMININ 7 KATINDAN 2.4.6.8 HANELERİN TOPLAMI ÇIKARTILIP 10'A GÖRE MOD ALINDIĞINDA 10.HANEYİ VERMELİ
        * İLK 10 HANE TOPLAMININ MOD10 ALINDIĞINDA 11.HANEYİ VERMELİ
        */

        private void btnControl_Click(object sender, EventArgs e)
        {
            int oddSum = 0, evenSum = 0, h10, h11;
            
            if (txtInput.Text.Length != 11)
            {
                epControl.SetError(txtInput, "11 hane olmalı!");
                return;
            }
            //12345678900
            for (int i = 0; i < txtInput.Text.Length - 2; i++)
            {
                if (i % 2 == 0)
                {
                    oddSum += Convert.ToInt32(txtInput.Text[i].ToString());
                }
                else
                {
                    evenSum += Convert.ToInt32(txtInput.Text[i].ToString());
                }
            }

            h10 = (7 * oddSum - evenSum) % 10;
            h11 = (oddSum + evenSum + h10) % 10;

            if (h10.ToString() == txtInput.Text[9].ToString() && h11.ToString() == txtInput.Text[10].ToString())
            {
                MessageBox.Show("Geçerli TC kimlik Numarası!", "Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                epControl.SetError(txtInput, "Geçersiz Giriş!");
            }
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            epControl.Clear();

            if (string.IsNullOrEmpty(txtInput.Text) && e.KeyChar == '0')
            {
                epControl.SetError(txtInput, "İlk Karakter 0 Olamaz!");
                e.Handled = true;
            }

            if (!char.IsNumber(e.KeyChar))
            {
                epControl.SetError(txtInput, "Sadece rakam girilebilir!");
                e.Handled = true;
            }
        }
    }
}
