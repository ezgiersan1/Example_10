using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RotateText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool isPlay = false;
        string source = "";
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (isPlay)
            {
                timer1.Stop();
                btnPlay.Text = "PLAY";
                isPlay = false;
            }
            else
            {
                btnPlay.Text = "PAUSE";
                isPlay = true;

                SetWordWidthSpeed();

                timer1.Start();
            }

        }

        private void SetWordWidthSpeed()
        {
            source = "";
            lblOutput.Text = "";

            string[] strings = txtInput.Text.Split();

            for (int i = 0; i < strings.Length - 1; i++)
            {
                source += strings[i].Substring(0, 1).ToUpper() + strings[i].Substring(1).ToLower() + " ";
            }
            source += strings[strings.Length - 1].ToUpper();

            source.Trim();


            for (int i = 0; i < nudWidth.Value; i++)
            {
                source += " ";
            }

            timer1.Interval = 500 / (int)nudSpeed.Value;

            lblOutput.Text = source;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text.Substring(1) + lblOutput.Text.Substring(0, 1);
        }

        private void nud_ValueChanged(object sender, EventArgs e)
        {
            SetWordWidthSpeed();
        }
    }
}
