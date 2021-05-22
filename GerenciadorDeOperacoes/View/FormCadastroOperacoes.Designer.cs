
namespace GerenciadorDeOperacoes
{
    partial class FormCadastroOperacoes
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMoedaOrigem = new System.Windows.Forms.ComboBox();
            this.cmbMoedaDestino = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.txtValorOriginal = new System.Windows.Forms.NumericUpDown();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrarOperacao = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtTaxaCobrada = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReverter = new System.Windows.Forms.Button();
            this.lblValorConvertido = new System.Windows.Forms.Label();
            this.lblSimboloDestino = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxaCobrada)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do cliente";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(60, 51);
            this.txtNomeCliente.MaxLength = 250;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(528, 29);
            this.txtNomeCliente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Moeda de Origem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(509, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Moeda de Destino";
            // 
            // cmbMoedaOrigem
            // 
            this.cmbMoedaOrigem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoedaOrigem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMoedaOrigem.FormattingEnabled = true;
            this.cmbMoedaOrigem.Location = new System.Drawing.Point(58, 48);
            this.cmbMoedaOrigem.Name = "cmbMoedaOrigem";
            this.cmbMoedaOrigem.Size = new System.Drawing.Size(215, 29);
            this.cmbMoedaOrigem.TabIndex = 4;
            this.cmbMoedaOrigem.SelectedIndexChanged += new System.EventHandler(this.cmbMoedaOrigem_SelectedIndexChanged);
            // 
            // cmbMoedaDestino
            // 
            this.cmbMoedaDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoedaDestino.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMoedaDestino.FormattingEnabled = true;
            this.cmbMoedaDestino.Location = new System.Drawing.Point(513, 48);
            this.cmbMoedaDestino.Name = "cmbMoedaDestino";
            this.cmbMoedaDestino.Size = new System.Drawing.Size(215, 29);
            this.cmbMoedaDestino.TabIndex = 5;
            this.cmbMoedaDestino.SelectedIndexChanged += new System.EventHandler(this.cmbMoedaDestino_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(60, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data";
            // 
            // dtpData
            // 
            this.dtpData.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpData.Location = new System.Drawing.Point(63, 131);
            this.dtpData.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(239, 29);
            this.dtpData.TabIndex = 7;
            // 
            // txtValorOriginal
            // 
            this.txtValorOriginal.DecimalPlaces = 2;
            this.txtValorOriginal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorOriginal.Location = new System.Drawing.Point(58, 90);
            this.txtValorOriginal.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.txtValorOriginal.Name = "txtValorOriginal";
            this.txtValorOriginal.Size = new System.Drawing.Size(121, 29);
            this.txtValorOriginal.TabIndex = 10;
            this.txtValorOriginal.ValueChanged += new System.EventHandler(this.txtValorOriginal_ValueChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(381, 410);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(160, 70);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrarOperacao
            // 
            this.btnCadastrarOperacao.BackColor = System.Drawing.Color.White;
            this.btnCadastrarOperacao.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarOperacao.Location = new System.Drawing.Point(688, 410);
            this.btnCadastrarOperacao.Name = "btnCadastrarOperacao";
            this.btnCadastrarOperacao.Size = new System.Drawing.Size(160, 70);
            this.btnCadastrarOperacao.TabIndex = 13;
            this.btnCadastrarOperacao.Text = "Cadastrar Operação ";
            this.btnCadastrarOperacao.UseVisualStyleBackColor = false;
            this.btnCadastrarOperacao.Click += new System.EventHandler(this.btnCadastrarOperacao_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.White;
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(62, 410);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(160, 70);
            this.btnVoltar.TabIndex = 14;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtTaxaCobrada
            // 
            this.txtTaxaCobrada.DecimalPlaces = 2;
            this.txtTaxaCobrada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxaCobrada.Location = new System.Drawing.Point(430, 135);
            this.txtTaxaCobrada.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.txtTaxaCobrada.Name = "txtTaxaCobrada";
            this.txtTaxaCobrada.Size = new System.Drawing.Size(125, 29);
            this.txtTaxaCobrada.TabIndex = 16;
            this.txtTaxaCobrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTaxaCobrada.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(426, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Taxa p/ Câmbio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(560, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "%";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReverter);
            this.groupBox1.Controls.Add(this.lblValorConvertido);
            this.groupBox1.Controls.Add(this.lblSimboloDestino);
            this.groupBox1.Controls.Add(this.cmbMoedaDestino);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbMoedaOrigem);
            this.groupBox1.Controls.Add(this.txtValorOriginal);
            this.groupBox1.Location = new System.Drawing.Point(63, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 143);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // btnReverter
            // 
            this.btnReverter.BackColor = System.Drawing.Color.White;
            this.btnReverter.FlatAppearance.BorderSize = 0;
            this.btnReverter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReverter.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReverter.Location = new System.Drawing.Point(355, 48);
            this.btnReverter.Name = "btnReverter";
            this.btnReverter.Size = new System.Drawing.Size(72, 29);
            this.btnReverter.TabIndex = 20;
            this.btnReverter.Text = "⇆";
            this.btnReverter.UseVisualStyleBackColor = false;
            this.btnReverter.Click += new System.EventHandler(this.btnReverter_Click);
            // 
            // lblValorConvertido
            // 
            this.lblValorConvertido.AutoSize = true;
            this.lblValorConvertido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorConvertido.ForeColor = System.Drawing.Color.Lime;
            this.lblValorConvertido.Location = new System.Drawing.Point(541, 92);
            this.lblValorConvertido.Name = "lblValorConvertido";
            this.lblValorConvertido.Size = new System.Drawing.Size(0, 21);
            this.lblValorConvertido.TabIndex = 22;
            // 
            // lblSimboloDestino
            // 
            this.lblSimboloDestino.AutoSize = true;
            this.lblSimboloDestino.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimboloDestino.ForeColor = System.Drawing.Color.White;
            this.lblSimboloDestino.Location = new System.Drawing.Point(509, 92);
            this.lblSimboloDestino.Name = "lblSimboloDestino";
            this.lblSimboloDestino.Size = new System.Drawing.Size(0, 21);
            this.lblSimboloDestino.TabIndex = 21;
            // 
            // FormCadastroOperacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(915, 516);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTaxaCobrada);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadastrarOperacao);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadastroOperacoes";
            this.Text = "Cadastro de Operações";
            ((System.ComponentModel.ISupportInitialize)(this.txtValorOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxaCobrada)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMoedaOrigem;
        private System.Windows.Forms.ComboBox cmbMoedaDestino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.NumericUpDown txtValorOriginal;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrarOperacao;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.NumericUpDown txtTaxaCobrada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSimboloDestino;
        private System.Windows.Forms.Label lblValorConvertido;
        private System.Windows.Forms.Button btnReverter;
    }
}

