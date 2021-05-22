using Controller;
using Entities;
using Helper;
using System;
using System.Windows.Forms;

namespace GerenciadorDeOperacoes
{
    public partial class FormRelatorios : Form
    {
        public FormRelatorios()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            AtualizarGridView(txtNomeCliente.Text, dtpDataInicio.Value, dtpDataTermino.Value);
            cmbMoedas.DataSource = moedasBLL.ListarMoedasCadastradas();
        }

        OperacoesBLL operacoesBLL = new OperacoesBLL();
        MoedasBLL moedasBLL = new MoedasBLL();

        private void txtNomeCliente_TextChanged(object sender, System.EventArgs e)
        {
            AtualizarGridView(txtNomeCliente.Text, dtpDataInicio.Value, dtpDataTermino.Value);
        }

        private void dtpDataInicio_ValueChanged(object sender, System.EventArgs e)
        {
            AtualizarGridView(txtNomeCliente.Text, dtpDataInicio.Value, dtpDataTermino.Value);
            FiltrarValoresTotais(cmbMoedas.Text, dtpDataInicio.Value, dtpDataTermino.Value);
        }

        private void dtpDataTermino_ValueChanged(object sender, System.EventArgs e)
        {
            AtualizarGridView(txtNomeCliente.Text, dtpDataInicio.Value, dtpDataTermino.Value);
            FiltrarValoresTotais(cmbMoedas.Text, dtpDataInicio.Value, dtpDataTermino.Value);
        }

        private void FormRelatorios_Load(object sender, System.EventArgs e)
        {
            dgvRelatorios.Columns["Id"].Width = 50;
            dgvRelatorios.Columns["Cliente_Nome"].Width = 240;
            dgvRelatorios.Columns["Moeda_Origem"].Width = 120;
            dgvRelatorios.Columns["Moeda_Destino"].Width = 120;
            dgvRelatorios.Columns["Data_Operacao"].Width = 120;
            dgvRelatorios.Columns["Valor_Convertido"].Width = 115;
            dgvRelatorios.Columns["Taxa"].Width = 50;
        }

        private void cmbMoedas_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            FiltrarValoresTotais(cmbMoedas.Text, dtpDataInicio.Value, dtpDataTermino.Value);
        }

        private void dgvRelatorios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblDica.Visible = false;
            btnVisualizar.Enabled = true;
            SetHelper.SetarOperacao(new OperacaoCambio
            {
                Id = (int)dgvRelatorios.CurrentRow.Cells[0].Value
            });
        }

        private void btnVisualizar_Click(object sender, System.EventArgs e)
        {
            FormsHelper.MudarForm(this, new FormRelatorioDetalhado());
        }

        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            FormsHelper.MudarForm(this, new FormInicio());
        }

        private void AtualizarGridView(string NomeCliente, DateTime DataInicio, DateTime DataTermino)
        {
            dgvRelatorios.DataSource = operacoesBLL.FiltrarOperacoes(NomeCliente, DataInicio, DataTermino);
        }

        private void FiltrarValoresTotais(string TipoMoeda, DateTime DataInicio, DateTime DataTermino)
        {
            Valores valores = operacoesBLL.PegarValorTotalOperacoesTaxas(TipoMoeda, DataInicio, DataTermino);
            SetHelper.SetarMoeda(new Moeda()
            {
                TipoMoeda = cmbMoedas.Text
            });
            lblValorOperacoes.Text = SetHelper.MoedaSelecionada.Simbolo + valores.TotalOperacoes.ToString("N2");
            lblValorTaxas.Text = SetHelper.MoedaSelecionada.Simbolo + valores.TotalTaxas.ToString("N2");
        }
    }
}
