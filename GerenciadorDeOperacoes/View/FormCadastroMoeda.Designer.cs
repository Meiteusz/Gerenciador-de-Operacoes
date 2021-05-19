
namespace GerenciadorDeOperacoes
{
    partial class FormCadastroMoeda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCadastrarMoeda = new System.Windows.Forms.Button();
            this.cmbMoedas = new System.Windows.Forms.ComboBox();
            this.dgvMoedas = new System.Windows.Forms.DataGridView();
            this.lblValorConvertido1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMoedaEscolhida1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValorConversao = new System.Windows.Forms.NumericUpDown();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAtualizarValor = new System.Windows.Forms.Button();
            this.lblValorConvertido2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMoedaEscolhida2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblValorConvertido4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMoedaEscolhida4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblValorConvertido3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblMoedaEscolhida3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSimbolo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoedas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorConversao)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrarMoeda
            // 
            this.btnCadastrarMoeda.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarMoeda.Location = new System.Drawing.Point(932, 526);
            this.btnCadastrarMoeda.Name = "btnCadastrarMoeda";
            this.btnCadastrarMoeda.Size = new System.Drawing.Size(177, 76);
            this.btnCadastrarMoeda.TabIndex = 0;
            this.btnCadastrarMoeda.Text = "Cadastrar Moeda";
            this.btnCadastrarMoeda.UseVisualStyleBackColor = true;
            this.btnCadastrarMoeda.Click += new System.EventHandler(this.btnCadastrarMoedas_Click);
            // 
            // cmbMoedas
            // 
            this.cmbMoedas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoedas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMoedas.FormattingEnabled = true;
            this.cmbMoedas.Location = new System.Drawing.Point(504, 56);
            this.cmbMoedas.Name = "cmbMoedas";
            this.cmbMoedas.Size = new System.Drawing.Size(287, 29);
            this.cmbMoedas.TabIndex = 1;
            this.cmbMoedas.SelectedIndexChanged += new System.EventHandler(this.cmbMoedas_SelectedIndexChanged);
            // 
            // dgvMoedas
            // 
            this.dgvMoedas.AllowUserToAddRows = false;
            this.dgvMoedas.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.dgvMoedas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMoedas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMoedas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMoedas.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMoedas.EnableHeadersVisualStyles = false;
            this.dgvMoedas.GridColor = System.Drawing.Color.Black;
            this.dgvMoedas.Location = new System.Drawing.Point(21, 57);
            this.dgvMoedas.MultiSelect = false;
            this.dgvMoedas.Name = "dgvMoedas";
            this.dgvMoedas.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMoedas.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMoedas.Size = new System.Drawing.Size(461, 307);
            this.dgvMoedas.TabIndex = 2;
            this.dgvMoedas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMoedas_CellClick);
            // 
            // lblValorConvertido1
            // 
            this.lblValorConvertido1.AutoSize = true;
            this.lblValorConvertido1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorConvertido1.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblValorConvertido1.Location = new System.Drawing.Point(378, 24);
            this.lblValorConvertido1.Name = "lblValorConvertido1";
            this.lblValorConvertido1.Size = new System.Drawing.Size(50, 25);
            this.lblValorConvertido1.TabIndex = 3;
            this.lblValorConvertido1.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(274, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "vale";
            // 
            // lblMoedaEscolhida1
            // 
            this.lblMoedaEscolhida1.AutoSize = true;
            this.lblMoedaEscolhida1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoedaEscolhida1.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblMoedaEscolhida1.Location = new System.Drawing.Point(65, 24);
            this.lblMoedaEscolhida1.Name = "lblMoedaEscolhida1";
            this.lblMoedaEscolhida1.Size = new System.Drawing.Size(156, 25);
            this.lblMoedaEscolhida1.TabIndex = 1;
            this.lblMoedaEscolhida1.Text = "MoedaEscolhida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "1";
            // 
            // txtValorConversao
            // 
            this.txtValorConversao.DecimalPlaces = 3;
            this.txtValorConversao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorConversao.Location = new System.Drawing.Point(986, 57);
            this.txtValorConversao.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.txtValorConversao.Name = "txtValorConversao";
            this.txtValorConversao.Size = new System.Drawing.Size(123, 29);
            this.txtValorConversao.TabIndex = 4;
            this.txtValorConversao.ValueChanged += new System.EventHandler(this.txtValorConversao_ValueChanged);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(21, 526);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(177, 76);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAtualizarValor
            // 
            this.btnAtualizarValor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarValor.Location = new System.Drawing.Point(504, 526);
            this.btnAtualizarValor.Name = "btnAtualizarValor";
            this.btnAtualizarValor.Size = new System.Drawing.Size(177, 76);
            this.btnAtualizarValor.TabIndex = 6;
            this.btnAtualizarValor.Text = "Atualizar Valor";
            this.btnAtualizarValor.UseVisualStyleBackColor = true;
            this.btnAtualizarValor.Click += new System.EventHandler(this.btnAtualizarValor_Click);
            // 
            // lblValorConvertido2
            // 
            this.lblValorConvertido2.AutoSize = true;
            this.lblValorConvertido2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorConvertido2.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblValorConvertido2.Location = new System.Drawing.Point(378, 85);
            this.lblValorConvertido2.Name = "lblValorConvertido2";
            this.lblValorConvertido2.Size = new System.Drawing.Size(50, 25);
            this.lblValorConvertido2.TabIndex = 7;
            this.lblValorConvertido2.Text = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(274, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "valem";
            // 
            // lblMoedaEscolhida2
            // 
            this.lblMoedaEscolhida2.AutoSize = true;
            this.lblMoedaEscolhida2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoedaEscolhida2.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblMoedaEscolhida2.Location = new System.Drawing.Point(65, 85);
            this.lblMoedaEscolhida2.Name = "lblMoedaEscolhida2";
            this.lblMoedaEscolhida2.Size = new System.Drawing.Size(156, 25);
            this.lblMoedaEscolhida2.TabIndex = 5;
            this.lblMoedaEscolhida2.Text = "MoedaEscolhida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(14, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "100";
            // 
            // lblValorConvertido4
            // 
            this.lblValorConvertido4.AutoSize = true;
            this.lblValorConvertido4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorConvertido4.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblValorConvertido4.Location = new System.Drawing.Point(378, 209);
            this.lblValorConvertido4.Name = "lblValorConvertido4";
            this.lblValorConvertido4.Size = new System.Drawing.Size(50, 25);
            this.lblValorConvertido4.TabIndex = 11;
            this.lblValorConvertido4.Text = "0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(274, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "valem";
            // 
            // lblMoedaEscolhida4
            // 
            this.lblMoedaEscolhida4.AutoSize = true;
            this.lblMoedaEscolhida4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoedaEscolhida4.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblMoedaEscolhida4.Location = new System.Drawing.Point(65, 209);
            this.lblMoedaEscolhida4.Name = "lblMoedaEscolhida4";
            this.lblMoedaEscolhida4.Size = new System.Drawing.Size(156, 25);
            this.lblMoedaEscolhida4.TabIndex = 9;
            this.lblMoedaEscolhida4.Text = "MoedaEscolhida";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 25);
            this.label10.TabIndex = 8;
            this.label10.Text = "1000";
            // 
            // lblValorConvertido3
            // 
            this.lblValorConvertido3.AutoSize = true;
            this.lblValorConvertido3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorConvertido3.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblValorConvertido3.Location = new System.Drawing.Point(378, 147);
            this.lblValorConvertido3.Name = "lblValorConvertido3";
            this.lblValorConvertido3.Size = new System.Drawing.Size(50, 25);
            this.lblValorConvertido3.TabIndex = 15;
            this.lblValorConvertido3.Text = "0.00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(274, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 25);
            this.label12.TabIndex = 14;
            this.label12.Text = "valem";
            // 
            // lblMoedaEscolhida3
            // 
            this.lblMoedaEscolhida3.AutoSize = true;
            this.lblMoedaEscolhida3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoedaEscolhida3.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblMoedaEscolhida3.Location = new System.Drawing.Point(65, 147);
            this.lblMoedaEscolhida3.Name = "lblMoedaEscolhida3";
            this.lblMoedaEscolhida3.Size = new System.Drawing.Size(156, 25);
            this.lblMoedaEscolhida3.TabIndex = 13;
            this.lblMoedaEscolhida3.Text = "MoedaEscolhida";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(14, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 25);
            this.label14.TabIndex = 12;
            this.label14.Text = "500";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(530, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Reais";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumBlue;
            this.label5.Location = new System.Drawing.Point(530, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Reais";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumBlue;
            this.label7.Location = new System.Drawing.Point(530, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Reais";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MediumBlue;
            this.label9.Location = new System.Drawing.Point(530, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Reais";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.lblMoedaEscolhida4);
            this.panel1.Controls.Add(this.lblValorConvertido2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblMoedaEscolhida2);
            this.panel1.Controls.Add(this.lblValorConvertido3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblMoedaEscolhida3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblValorConvertido1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblMoedaEscolhida1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lblValorConvertido4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(504, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 261);
            this.panel1.TabIndex = 18;
            // 
            // txtSimbolo
            // 
            this.txtSimbolo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSimbolo.Location = new System.Drawing.Point(887, 57);
            this.txtSimbolo.MaxLength = 4;
            this.txtSimbolo.Name = "txtSimbolo";
            this.txtSimbolo.Size = new System.Drawing.Size(69, 29);
            this.txtSimbolo.TabIndex = 20;
            // 
            // FormCadastroMoeda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(1128, 626);
            this.Controls.Add(this.txtSimbolo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAtualizarValor);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtValorConversao);
            this.Controls.Add(this.dgvMoedas);
            this.Controls.Add(this.cmbMoedas);
            this.Controls.Add(this.btnCadastrarMoeda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadastroMoeda";
            this.Text = "Cadastro de Moeda";
            this.Load += new System.EventHandler(this.FormCadastroMoeda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoedas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorConversao)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarMoeda;
        private System.Windows.Forms.ComboBox cmbMoedas;
        private System.Windows.Forms.DataGridView dgvMoedas;
        private System.Windows.Forms.Label lblValorConvertido1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMoedaEscolhida1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtValorConversao;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAtualizarValor;
        private System.Windows.Forms.Label lblValorConvertido3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblMoedaEscolhida3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblValorConvertido4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMoedaEscolhida4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblValorConvertido2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMoedaEscolhida2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSimbolo;
    }
}