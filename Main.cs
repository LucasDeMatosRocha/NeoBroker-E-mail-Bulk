using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Neobroker___Email_Bulk
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            #region Propriedades Gráficas
            //Configurações da GUI
            Enabled = true;
            Visible = true;
            this.StartPosition = FormStartPosition.CenterScreen;

            toolStripStatusLabel1.Text = string.Empty;

            if (tabPage2.IsMirrored)
            {
                abrirAquivoDeListaDeEmailsToolStripMenuItem.Enabled = true;
            }
            else{
                abrirAquivoDeListaDeEmailsToolStripMenuItem.Enabled = false;
            }

            #endregion


            #region Inicialização_Bulk

            
             
            #endregion
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abrir about box
            AboutBox aboutbox = new Neobroker___Email_Bulk.AboutBox(); aboutbox.ShowDialog();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void ajudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Abrir sesssão de ajuda
            Neobroker___Email_Bulk.Help help = new Neobroker___Email_Bulk.Help(); help.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            // Fechar
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Controle de Fechamento de Form.

            if(MessageBox.Show("Deseja realmente sair do Email Bulk ?", "Questão",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
                this.Refresh();
            }
        }

        private void tabPages_View_ChangeUICues(object sender, UICuesEventArgs e)
        {
            if (tabPage2.IsMirrored)
            {
                abrirAquivoDeListaDeEmailsToolStripMenuItem.Enabled = true;
            }
            else
            {
                abrirAquivoDeListaDeEmailsToolStripMenuItem.Enabled = false;
            }
        }
    }
}
