using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Calculos_2TDSN_2025_1
{
    public partial class frmCalcBotoes : Form
    {
        public frmCalcBotoes()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            lblSinal.Text = "+";
            decimal a, b;
            try
            {
                a = decimal.Parse(txtN1.Text);
                b = decimal.Parse(txtN2.Text);
                lblResultado.Text = (a + b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Favor apenas números", "Erro!!!");
            }
            catch (DivideByZeroException) //Na divisão
            {
                MessageBox.Show("Impossível divisão", "Erro!!!");
            }


        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            lblSinal.Text = "-";
            decimal a, b;
            try
            {
                a = decimal.Parse(txtN1.Text);
                b = decimal.Parse(txtN2.Text);
                lblResultado.Text = (a - b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Favor apenas números", "Erro!!!");
            }

        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Clear();
            txtN2.Clear();
            lblSinal.Text = "?";
            lblResultado.Text = "?";
            txtN1.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblSinal.Text = "*";
            decimal a, b;
            try
            {
                a = decimal.Parse(txtN1.Text);
                b = decimal.Parse(txtN2.Text);
                lblResultado.Text = (a * b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Favor apenas números", "Erro!!!");
            }
        }

        private void btnDIvision_Click(object sender, EventArgs e)
        {
            lblSinal.Text = "/";
            decimal a, b;
            try
            {
                a = decimal.Parse(txtN1.Text);
                b = decimal.Parse(txtN2.Text);
                lblResultado.Text = (a / b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Favor apenas números", "Erro!!!");
            }
        }
    }
}
