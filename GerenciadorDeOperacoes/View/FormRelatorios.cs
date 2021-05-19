using Controller;
using Entities;
using Helper;
using System.Windows.Forms;

namespace GerenciadorDeOperacoes
{
    public partial class FormRelatorios : Form
    {
        public FormRelatorios()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dgvRelatorios.DataSource = operacoesBLL.MostrarOperacoes();
            cmbMoedas.DataSource = moedasBLL.ListarMoedasCadastradas();
        }

        OperacoesBLL operacoesBLL = new OperacoesBLL();
        MoedasBLL moedasBLL = new MoedasBLL();

        private void txtNomeCliente_TextChanged(object sender, System.EventArgs e)
        {
            if (txtNomeCliente.Text.Equals(string.Empty))
                dgvRelatorios.DataSource = operacoesBLL.MostrarOperacoes();
            else
                dgvRelatorios.DataSource = operacoesBLL.FiltrarOperacoes(txtNomeCliente.Text, dtpDataInicio.Value, dtpDataTermino.Value);
        }

        private void dtpDataInicio_ValueChanged(object sender, System.EventArgs e)
        {
            dgvRelatorios.DataSource = operacoesBLL.FiltrarOperacoes(txtNomeCliente.Text, dtpDataInicio.Value, dtpDataTermino.Value);
        }

        private void dtpDataTermino_ValueChanged(object sender, System.EventArgs e)
        {
            dgvRelatorios.DataSource = operacoesBLL.FiltrarOperacoes(txtNomeCliente.Text, dtpDataInicio.Value, dtpDataTermino.Value);
        }

        private void FormRelatorios_Load(object sender, System.EventArgs e)
        {
            txtNomeCliente.AutoCompleteCustomSource = operacoesBLL.ListarNomesClientes();
            txtNomeCliente.AutoCompleteMode = AutoCompleteMode.Append;
            txtNomeCliente.AutoCompleteSource = AutoCompleteSource.CustomSource;

            dgvRelatorios.Columns["Id"].Width = 50;
            dgvRelatorios.Columns["Cliente_Nome"].Width = 270;
            dgvRelatorios.Columns["Moeda_Destino"].Width = 110;
            dgvRelatorios.Columns["Valor_Convertido"].Width = 115;
            dgvRelatorios.Columns["Taxa"].Width = 70;
        }

        private void cmbMoedas_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Valores valores = operacoesBLL.PegarValorTotalOperacoesTaxas(cmbMoedas.Text);
            Moeda moeda = new Moeda();
            moeda.TipoMoeda = cmbMoedas.Text;
            SetHelper.SetarMoeda(moeda);
            lblValorOperacoes.Text = SetHelper.MoedaSelecionada.Simbolo + valores.TotalOperacoes.ToString("N2");
            lblValorTaxas.Text = SetHelper.MoedaSelecionada.Simbolo + valores.TotalTaxas.ToString("N2");
        }

        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            FormsHelper.MudarForm(this, new FormInicio());
        }
    }
}
