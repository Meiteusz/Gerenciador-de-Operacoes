using Controller;
using Entities;
using Helper;
using System;
using System.Windows.Forms;

namespace GerenciadorDeOperacoes
{
    public partial class FormCadastroMoeda : Form
    {
        public FormCadastroMoeda()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            cmbMoedas.DataSource = Enum.GetValues(typeof(TiposMoedas));
            dgvMoedas.DataSource = moedasBLL.MostrarMoedas();
            btnAtualizarValor.Enabled = false;
        }

        MoedasBLL moedasBLL = new MoedasBLL();

        private void btnCadastrarMoedas_Click(object sender, EventArgs e)
        {
            Moeda moeda = new Moeda(cmbMoedas.Text, txtSimbolo.Text, (double)txtValorConversao.Value);
            
            Response resposta =  moedasBLL.CadastrarMoeda(moeda);
            MessageBox.Show(resposta.Mensagem);

            if (resposta.Sucesso)
            {
                dgvMoedas.DataSource = moedasBLL.MostrarMoedas();
            }
        }

        private void cmbMoedas_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMoedaEscolhida1.Text = cmbMoedas.Text.Replace("_", " ");
            lblMoedaEscolhida2.Text = cmbMoedas.Text.Replace("_", " ");
            lblMoedaEscolhida3.Text = cmbMoedas.Text.Replace("_", " ");
            lblMoedaEscolhida4.Text = cmbMoedas.Text.Replace("_", " ");
        }

        private void txtValorConversao_ValueChanged(object sender, EventArgs e)
        {
            lblValorConvertido1.Text = txtValorConversao.Value.ToString("c");
            lblValorConvertido2.Text = (txtValorConversao.Value * 100).ToString("c");
            lblValorConvertido3.Text = (txtValorConversao.Value * 500).ToString("c");
            lblValorConvertido4.Text = (txtValorConversao.Value * 1000).ToString("c");
        }

        private void FormCadastroMoeda_Load(object sender, EventArgs e)
        {
            dgvMoedas.Columns["Id"].Width = 50;
            dgvMoedas.Columns["Moeda"].Width = 200;
            dgvMoedas.Columns["Simbolo"].Width = 60;
            dgvMoedas.Columns["Valor_Conversao"].Width = 110;
        }

        private void dgvMoedas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAtualizarValor.Enabled = true;
            Moeda moeda = new Moeda();
            moeda.Id = (int)dgvMoedas.CurrentRow.Cells[0].Value;
            moeda.TipoMoeda = string.Empty;
            SetHelper.SetarMoeda(moeda);

            txtSimbolo.Text = SetHelper.MoedaSelecionada.Simbolo;
            txtValorConversao.Value = (decimal)SetHelper.MoedaSelecionada.ValorConversao;
        }

        private void btnAtualizarValor_Click(object sender, EventArgs e)
        {
            Moeda moeda = new Moeda(SetHelper.MoedaSelecionada.Id, txtSimbolo.Text, (double)txtValorConversao.Value);

            Response resposta = moedasBLL.AlterarValorMoeda(moeda);
            MessageBox.Show(resposta.Mensagem);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormsHelper.MudarForm(this, new FormInicio());
        }
    }
}
