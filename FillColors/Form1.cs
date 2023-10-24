using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FillColors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadColors();
        }

        private void LoadColors()
        {
            Button newButton;
            int size = 40;
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    newButton = new Button();
                    newButton.Size = new Size(size, size);
                    newButton.Location = new Point(size*j+2, size*i+2);
                    newButton.BackColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
                    newButton.Click += newButton_Click;
                    panel1.Controls.Add(newButton);
                }

            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            Button selected = sender as Button;
            
            this.BackColor = selected.BackColor;
        }
    }
}
