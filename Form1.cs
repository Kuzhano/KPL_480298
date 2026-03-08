using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_MODUL3_103022400098
{
    public partial class Form1 : Form
    {
        double nilai = 0;
        bool inputBaru = true;

        public Form1()
        {
            InitializeComponent();
            labelDisplay.Text = "0";
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Angka_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (inputBaru)
            {
                labelDisplay.Text = btn.Text;
                inputBaru = false;
            }
            else
            {
                labelDisplay.Text += btn.Text;
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            nilai += Convert.ToDouble(labelDisplay.Text);
            inputBaru = true;
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            nilai += Convert.ToDouble(labelDisplay.Text);
            labelDisplay.Text = nilai.ToString();

            nilai = 0;
            inputBaru = true;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}
