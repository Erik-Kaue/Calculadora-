using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            double vl1, vl2, res;

            vl1 = double.Parse(txtValor1.Text);
            vl2 = double.Parse(txtValor2.Text);

            res = vl1 + vl2;

            txtResultado.Text = res.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            double vl1, vl2, res;

            vl1 = double.Parse(txtValor1.Text);
            vl2 = double.Parse(txtValor2.Text);

            res = vl1 - vl2;

            txtResultado.Text = res.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double vl1, vl2, res;

            vl1 = double.Parse(txtValor1.Text);
            vl2 = double.Parse(txtValor2.Text);

            res = vl1 / vl2;

            txtResultado.Text = res.ToString();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            double vl1, vl2, res;

            vl1 = double.Parse(txtValor1.Text);
            vl2 = double.Parse(txtValor2.Text);

            res = vl1 * vl2;

            txtResultado.Text = res.ToString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
