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
    public partial class MDI_Menu : Form
    {
        public MDI_Menu()
        {
            InitializeComponent();
        }

        private void comBotõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalcBotoes objCalBot = new frmCalcBotoes();  
            objCalBot.MdiParent = this;
            objCalBot.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void MDI_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Saindo...", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                //Cancelar o Fechamento do Formulário
                e.Cancel = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stlDataHora.Text = DateTime.Now.ToString();
        }

        private void comRadioButtonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalcRadio obj_cr = new frmCalcRadio();
            obj_cr.MdiParent = this;
            obj_cr.Show();
        }

        private void visorÚnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalcSuper obj_cs = new frmCalcSuper();
            obj_cs.MdiParent = this;
            obj_cs.Show();
        }

        private void stlUsuario_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
