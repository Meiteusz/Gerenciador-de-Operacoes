
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCadastroOperacoes
            // 
            this.btnCadastroOperacoes.BackColor = System.Drawing.Color.White;
            this.btnCadastroOperacoes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCadastroOperacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroOperacoes.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroOperacoes.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnCadastroOperacoes.Location = new System.Drawing.Point(356, 255);
            this.btnCadastroOperacoes.Name = "btnCadastroOperacoes";
            this.btnCadastroOperacoes.Size = new System.Drawing.Size(218, 102);
            this.btnCadastroOperacoes.TabIndex = 0;
            this.btnCadastroOperacoes.Text = "Operações";
            this.btnCadastroOperacoes.UseVisualStyleBackColor = false;
            this.btnCadastroOperacoes.Click += new System.EventHandler(this.btnCadastroOperacoes_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.BackColor = System.Drawing.Color.White;
            this.btnRelatorios.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorios.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnRelatorios.Location = new System.Drawing.Point(589, 255);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(218, 102);
            this.btnRelatorios.TabIndex = 1;
            this.btnRelatorios.Text = "Relatorios";
            this.btnRelatorios.UseVisualStyleBackColor = false;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // btnCadastroMoedas
            // 
            this.btnCadastroMoedas.BackColor = System.Drawing.Color.White;
            this.btnCadastroMoedas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCadastroMoedas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroMoedas.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroMoedas.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnCadastroMoedas.Location = new System.Drawing.Point(123, 255);
            this.btnCadastroMoedas.Name = "btnCadastroMoedas";
            this.btnCadastroMoedas.Size = new System.Drawing.Size(218, 102);
            this.btnCadastroMoedas.TabIndex = 2;
            this.btnCadastroMoedas.Text = "Moedas";
            this.btnCadastroMoedas.UseVisualStyleBackColor = false;
            this.btnCadastroMoedas.Click += new System.EventHandler(this.btnCadastroMoedas_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(783, 437);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(141, 50);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(265, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 85);
            this.label1.TabIndex = 4;
            this.label1.Text = "Casa de Câmbio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(317, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 65);
            this.label2.TabIndex = 5;
            this.label2.Text = "Muito Dinheiro";
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(931, 495);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCadastroMoedas);
            this.Controls.Add(this.btnRelatorios);
            this.Controls.Add(this.btnCadastroOperacoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroOperacoes;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Button btnCadastroMoedas;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}