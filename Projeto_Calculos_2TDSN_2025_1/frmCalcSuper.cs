using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Calculos_2TDSN_2025_1
{
    public partial class frmCalcSuper : Form
    {
        string operacao;
        decimal vNumAnt;
        bool vLimpar = false;
        public frmCalcSuper()
        {
            InitializeComponent();
        }

        private void f_numeros(object sender, EventArgs e)
        {
            string digito = ((Button)sender).Text;

            if (vLimpar)
            {
                lblVisor.Text = "";
                vLimpar = false ;
            }

            if (lblVisor.Text == "0")
            {
                lblVisor.Text = digito;
            }
            else
            {
                lblVisor.Text += digito;
            }
            lblVisor.Focus();

        }
        private void f_operacoes(object sender, EventArgs e)
        {
            operacao = ((Button)sender).Text;
            vNumAnt = decimal.Parse(lblVisor.Text);
            vLimpar = true;
            lblVisor.Focus();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            decimal vNumAtual = decimal.Parse(lblVisor.Text);
            try
            {
                switch (operacao)
                {
                    case "+":
                        label1.Text = "+";
                        lblVisor.Text = (vNumAnt + vNumAtual).ToString();
                        break;

                    case "-":
                        label1.Text = "-";
                        lblVisor.Text = (vNumAnt - vNumAtual).ToString();
                        break;

                    case "*":
                        label1.Text = "*";
                        lblVisor.Text = (vNumAnt * vNumAtual).ToString();
                        break;

                    case "/":
                        label1.Text = "/";
                        lblVisor.Text = (vNumAnt / vNumAtual).ToString();
                        break;

                    case "pot":
                        label1.Text = "^";
                        lblVisor.Text = Math.Pow((double)vNumAnt, (double)vNumAtual).ToString();
                        break;

                    case "Return":
                        btnIgual_Click(sender, e);
                        break;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Favor, apenas números", "Erro!!");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Impossível divisão", "Erro!!");
            }

            lblVisor.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!lblVisor.Text.Contains(","))
            {
                lblVisor.Text += ",";

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmCalcSuper_KeyDown(object sender, KeyEventArgs e)
        {
            label1.Text = e.KeyCode.ToString();
            string digito = e.KeyCode.ToString();

            Button bot = new Button();
            /*
             O trecho abaixo implementa 
             */

            if (e.KeyCode >= Keys.D0&&e.KeyCode <= Keys.D9)
            {
                bot.Text = digito.Substring(1, 1);
                f_numeros(bot, e); 
            }

            else if (e.KeyCode >= Keys.NumPad0&&e.KeyCode <= Keys.NumPad9)
            {
                bot.Text = digito.Substring(6, 1);
                f_numeros(bot, e);
            }

            switch (e.KeyCode.ToString())
            {
                case "Add":
                    bot.Text = "+";
                    break;

                case "Subtract":
                    bot.Text = "-";
                    break;

                case "Multiply":
                    bot.Text = "*";
                    break;

                case "Divide":
                    bot.Text = "/";
                    break;
                
                case "Power":
                    bot.Text = "^";
                    break;
            }
        }

        private void lblVisor_Click(object sender, EventArgs e)
        {

        }

        private void btnMaisMenos_Click(object sender, EventArgs e)
        {
            lblVisor.Text = (Convert.ToDecimal(lblVisor.Text) * -1).ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            lblVisor.Text = lblVisor.Text.Substring(0, lblVisor.Text.Length-1);
            if(lblVisor.Text=="")
            {
                lblVisor.Text = "0";
            }
        }
        
    }
}
