using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] P = new double[2];

            P[0] = P[1] = 0.5;

            string[] Text = new string[2];
            Text[0] = "Определенно да!";
            Text[1] = "Никак нет!";


            Random rand = new Random();
            double alfa = rand.NextDouble();

            double A = alfa;
            int k = 0;
            while (A > 0)
            {
                A = A - P[k];
                k++;
            }

            k = k - 1;

            if (k == 0)
            {
                label2.Text = Text[0];
                label2.Visible = true;
            }
            else
                if (k == 1)
            {
                label2.Text = Text[1];
                label2.Visible = true;
            }
        }
    }
}
