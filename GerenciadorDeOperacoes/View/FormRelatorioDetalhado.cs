using Entities;
using Helper;
using System.Windows.Forms;

namespace GerenciadorDeOperacoes
{
    public partial class FormRelatorioDetalhado : Form
    {
        public FormRelatorioDetalhado()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormRelatorioDetalhado_Load(object sender, System.EventArgs e)
        {
            OperacaoCambio operacao = SetHelper.OperacaoSelecionada;

            string SimboloMoedaOrigem = SetarSimbolo(operacao.MoedaOrigem);
            string SimboloMoedaDestino = SetarSimbolo(operacao.MoedaDestino);

            lblNomeCliente.Text = operacao.NomeCliente;
            lblDataOperacao.Text = operacao.DataOperacao.ToString("dd/MM/yyyy HH:mm");
            lblMoedaOrigem.Text = operacao.MoedaOrigem.Replace("_", " ");
            lblMoedaDestino.Text = operacao.MoedaDestino.Replace("_", " ");
            lblValor.Text = SimboloMoedaOrigem + operacao.ValorOriginal.ToString();
            lblValorOriginal.Text = SimboloMoedaOrigem + operacao.ValorOriginal.ToString();
            lblValorConvertido.Text = SimboloMoedaDestino + operacao.ValorConvertido.ToString();
            lblTaxa.Text = SimboloMoedaOrigem + operacao.TaxaCobrada.ToString();
            lblValorTotalPagar.Text = SimboloMoedaOrigem + (operacao.ValorOriginal + operacao.TaxaCobrada).ToString();
            lblPorcentagem.Text = ((operacao.TaxaCobrada / operacao.ValorOriginal) * 100).ToString() + "%";
        }

        private string SetarSimbolo(string TipoMoeda)
        {
            SetHelper.SetarMoeda(new Moeda()
            {
                TipoMoeda = TipoMoeda
            });
            return SetHelper.MoedaSelecionada.Simbolo;
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            FormsHelper.MudarForm(this, new FormRelatorios());
        }
    }
}
