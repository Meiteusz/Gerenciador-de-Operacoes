using Controller;
using Entities;
using Helper;
using System;
using System.Windows.Forms;

namespace GerenciadorDeOperacoes
{
    public partial class FormCadastroOperacoes : Form
    {
        public FormCadastroOperacoes()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            txtTaxaCobrada.Value = 10;
            cmbMoedaOrigem.DataSource = moedasBLL.ListarMoedasCadastradas();
            cmbMoedaDestino.DataSource = moedasBLL.ListarMoedasCadastradas();
        }

        MoedasBLL moedasBLL = new MoedasBLL();
        OperacoesBLL operacoesBLL = new OperacoesBLL();
        Calculadora calculadora = new Calculadora();

        private void btnCadastrarOperacao_Click(object sender, EventArgs e)
        {
            OperacaoCambio operacao = new OperacaoCambio(txtNomeCliente.Text, cmbMoedaOrigem.Text, cmbMoedaDestino.Text, dtpData.Value,
                (double)txtValorOriginal.Value, calculadora.ValorConvertido, (double)(txtValorOriginal.Value * txtTaxaCobrada.Value) / 100);

            Response resposta =  operacoesBLL.CadastrarOperacao(operacao);
            MessageBox.Show(resposta.Mensagem, "Atenção!");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            FormsHelper.LimparControlsForms(Controls);
            txtNomeCliente.Text = string.Empty;
        }

        private void txtValorOriginal_ValueChanged(object sender, EventArgs e)
        {
            calculadora.ConverterValor(cmbMoedaOrigem.Text, cmbMoedaDestino.Text, (double)txtValorOriginal.Value);
            Moeda moeda = new Moeda();
            moeda.TipoMoeda = cmbMoedaDestino.Text;
            SetHelper.SetarMoeda(moeda);
            lblValorConvertido.Text = SetHelper.MoedaSelecionada.Simbolo + calculadora.ValorConvertido.ToString("N2");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormsHelper.MudarForm(this, new FormInicio());
        }
    }
}
