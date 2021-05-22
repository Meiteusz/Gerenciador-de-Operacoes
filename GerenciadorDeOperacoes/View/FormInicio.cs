using Controller;
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
            btnCadastroOperacoes.Enabled = false;
            if (moedasBLL.isQuantidadeMoedasValido())
                btnCadastroOperacoes.Enabled = true;
        }

        MoedasBLL moedasBLL = new MoedasBLL();

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
