using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunTimeControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Label lbl1, lbl2, lblOutput;
        TextBox txt1, txt2;
        Button btnSum;
        private void Form1_Load(object sender, EventArgs e)
        {
            //label1
            lbl1 = new Label();
            lbl1.Name = "label1";
            lbl1.Font = new Font("Georgia", 15, FontStyle.Bold);
            lbl1.Text = "Number 1:";
            lbl1.Location = new Point(50, 100);
            lbl1.Size = new Size(150, 30);
            this.Controls.Add(lbl1);

            //label2
            lbl2 = new Label();
            lbl2.Name = "label2";
            lbl2.Font = new Font("Comic Sans Ms", 15, FontStyle.Underline);
            lbl2.Text = "Number 2:";
            lbl2.Location = new Point(50, 60);
            lbl2.Size = new Size(150, 30);
            this.Controls.Add(lbl2);

            //textbox1
            txt1 = new TextBox();
            txt1.Name = "txtNumber1";
            txt1.Font = new Font(FontFamily.GenericSansSerif, 15, FontStyle.Italic);
            txt1.Location = new Point(200, 30);
            txt1.ForeColor = Color.Red;
            txt1.Size = new Size(150, 30);
            this.Controls.Add(txt1);

            //textbox2
            txt2 = new TextBox();
            txt2.Name = "txtNumber2";
            txt2.Font = new Font(FontFamily.GenericSansSerif, 15, FontStyle.Bold);
            txt2.ForeColor = Color.Blue;
            txt2.Location = new Point(200, 60);
            txt2.Size = new Size(150, 30);
            this.Controls.Add(txt2);

            //button
            btnSum = new Button();
            btnSum.Name = "btnSum";
            btnSum.ForeColor = Color.Pink;
            btnSum.BackColor = Color.White;
            btnSum.Font = new Font("Arial", 15, FontStyle.Bold);
            btnSum.Location = new Point(200, 100);
            btnSum.Size = new Size(150, 40);
            btnSum.Text = "SUM";
            btnSum.Click += btnSum_Click;
            this.Controls.Add(btnSum);

            //lblOutput
            lblOutput = new Label();
            lblOutput.Name = "label1";
            lblOutput.Font = new Font("Georgia", 18, FontStyle.Bold);
            lblOutput.Text = "SUM :";
            lblOutput.Location = new Point(200, 150);
            lblOutput.Size = new Size(150, 30);
            lblOutput.ForeColor = Color.Chocolate;
            this.Controls.Add(lblOutput);
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txt1.Text);
            int num2 = int.Parse(txt2.Text);
            int result = num1 + num2;
            lblOutput.Text = "SUM:" +result.ToString();

        }
    }
}
