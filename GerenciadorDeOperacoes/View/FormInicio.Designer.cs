
namespace GerenciadorDeOperacoes
{
    partial class FormInicio
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
            this.btnCadastroOperacoes = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.btnCadastroMoedas = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastroOperacoes
            // 
            this.btnCadastroOperacoes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroOperacoes.Location = new System.Drawing.Point(374, 202);
            this.btnCadastroOperacoes.Name = "btnCadastroOperacoes";
            this.btnCadastroOperacoes.Size = new System.Drawing.Size(218, 102);
            this.btnCadastroOperacoes.TabIndex = 0;
            this.btnCadastroOperacoes.Text = "Cadastro de Operações";
            this.btnCadastroOperacoes.UseVisualStyleBackColor = true;
            this.btnCadastroOperacoes.Click += new System.EventHandler(this.btnCadastroOperacoes_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorios.Location = new System.Drawing.Point(598, 202);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(218, 102);
            this.btnRelatorios.TabIndex = 1;
            this.btnRelatorios.Text = "Relatorios";
            this.btnRelatorios.UseVisualStyleBackColor = true;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // btnCadastroMoedas
            // 
            this.btnCadastroMoedas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroMoedas.Location = new System.Drawing.Point(150, 202);
            this.btnCadastroMoedas.Name = "btnCadastroMoedas";
            this.btnCadastroMoedas.Size = new System.Drawing.Size(218, 102);
            this.btnCadastroMoedas.TabIndex = 2;
            this.btnCadastroMoedas.Text = "Cadastro de Moedas";
            this.btnCadastroMoedas.UseVisualStyleBackColor = true;
            this.btnCadastroMoedas.Click += new System.EventHandler(this.btnCadastroMoedas_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(829, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(141, 50);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(982, 517);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCadastroMoedas);
            this.Controls.Add(this.btnRelatorios);
            this.Controls.Add(this.btnCadastroOperacoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroOperacoes;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Button btnCadastroMoedas;
        private System.Windows.Forms.Button btnSair;
    }
}