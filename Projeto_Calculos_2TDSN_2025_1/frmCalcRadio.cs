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
    public partial class frmCalcRadio : Form
    {
        public frmCalcRadio()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal a, b;
            double potencia;

            a = decimal.Parse(textBox1.Text);
            b = Convert.ToDecimal(textBox2.Text);

            if (rdbSomar.Checked)
            {
                decimal add = a + b;
                lblResultado.Text = add.ToString();
            }
            else if (rdbSubtrair.Checked)
            {
                decimal sub = a - b;
                lblResultado.Text = sub.ToString();
            }
            else if(rdbMultiplicar.Checked)
            {
                decimal mul = a * b;
                lblResultado.Text = mul.ToString();
            }
            else if (rdbDividir.Checked)
            {
                decimal div = a / b;
                lblResultado.Text = div.ToString();
            }
            else if (rdbPotenciacao.Checked)
            {
                potencia = Math.Pow((double)a, (double)b);
                lblResultado.Text += potencia.ToString();
            }
            
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            lblResultado.Text = "";
        }
    }
}
