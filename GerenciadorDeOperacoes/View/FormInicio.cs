using Helper;
using System;
using System.Windows.Forms;

namespace GerenciadorDeOperacoes
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnCadastroMoedas_Click(object sender, EventArgs e)
        {
            FormsHelper.MudarForm(this, new FormCadastroMoeda());
        }

        private void btnCadastroOperacoes_Click(object sender, EventArgs e)
        {
            FormsHelper.MudarForm(this, new FormCadastroOperacoes());
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            FormsHelper.MudarForm(this, new FormRelatorios());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
