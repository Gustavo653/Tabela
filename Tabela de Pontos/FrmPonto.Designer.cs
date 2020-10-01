namespace Tabela_de_Pontos
{
    partial class FrmPonto
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPonto));
            this.btnSair = new System.Windows.Forms.Button();
            this.txtJogo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstDados = new System.Windows.Forms.ListBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtPlacar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQRMax = new System.Windows.Forms.TextBox();
            this.txtQRMin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnInstrucoes = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnNovoJogo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(108, 305);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtJogo
            // 
            this.txtJogo.Location = new System.Drawing.Point(164, 64);
            this.txtJogo.Name = "txtJogo";
            this.txtJogo.ReadOnly = true;
            this.txtJogo.Size = new System.Drawing.Size(100, 20);
            this.txtJogo.TabIndex = 22;
            this.txtJogo.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Jogos da Temporada";
            // 
            // lstDados
            // 
            this.lstDados.FormattingEnabled = true;
            this.lstDados.Location = new System.Drawing.Point(300, 12);
            this.lstDados.Name = "lstDados";
            this.lstDados.Size = new System.Drawing.Size(347, 316);
            this.lstDados.TabIndex = 11;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(164, 142);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(100, 20);
            this.txtMax.TabIndex = 2;
            this.txtMax.Text = "0";
            this.txtMax.TextChanged += new System.EventHandler(this.txtMax_TextChanged);
            this.txtMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMax_KeyPress);
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(164, 116);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(100, 20);
            this.txtMin.TabIndex = 1;
            this.txtMin.Text = "0";
            this.txtMin.TextChanged += new System.EventHandler(this.txtMin_TextChanged);
            this.txtMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMin_KeyPress);
            // 
            // txtPlacar
            // 
            this.txtPlacar.Location = new System.Drawing.Point(164, 90);
            this.txtPlacar.Name = "txtPlacar";
            this.txtPlacar.Size = new System.Drawing.Size(100, 20);
            this.txtPlacar.TabIndex = 0;
            this.txtPlacar.Text = "0";
            this.txtPlacar.TextChanged += new System.EventHandler(this.txtPlacar_TextChanged);
            this.txtPlacar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlacar_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Jogo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mínimo Temporada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Placar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Máximo Temporada";
            // 
            // txtQRMax
            // 
            this.txtQRMax.Location = new System.Drawing.Point(164, 194);
            this.txtQRMax.Name = "txtQRMax";
            this.txtQRMax.Size = new System.Drawing.Size(100, 20);
            this.txtQRMax.TabIndex = 4;
            this.txtQRMax.Text = "0";
            this.txtQRMax.TextChanged += new System.EventHandler(this.txtQRMax_TextChanged);
            this.txtQRMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQRMax_KeyPress);
            // 
            // txtQRMin
            // 
            this.txtQRMin.Location = new System.Drawing.Point(164, 168);
            this.txtQRMin.Name = "txtQRMin";
            this.txtQRMin.Size = new System.Drawing.Size(100, 20);
            this.txtQRMin.TabIndex = 3;
            this.txtQRMin.Text = "0";
            this.txtQRMin.TextChanged += new System.EventHandler(this.txtQRMin_TextChanged);
            this.txtQRMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQRMin_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Quebra Recorde Máx.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Quebra Recorde Mín.";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(189, 276);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnInstrucoes
            // 
            this.btnInstrucoes.Location = new System.Drawing.Point(189, 305);
            this.btnInstrucoes.Name = "btnInstrucoes";
            this.btnInstrucoes.Size = new System.Drawing.Size(75, 23);
            this.btnInstrucoes.TabIndex = 10;
            this.btnInstrucoes.Text = "Instruções";
            this.btnInstrucoes.UseVisualStyleBackColor = true;
            this.btnInstrucoes.Click += new System.EventHandler(this.btnInstrucoes_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(108, 276);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 7;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnNovoJogo
            // 
            this.btnNovoJogo.Location = new System.Drawing.Point(27, 276);
            this.btnNovoJogo.Name = "btnNovoJogo";
            this.btnNovoJogo.Size = new System.Drawing.Size(75, 23);
            this.btnNovoJogo.TabIndex = 6;
            this.btnNovoJogo.Text = "Novo Jogo";
            this.btnNovoJogo.UseVisualStyleBackColor = true;
            this.btnNovoJogo.Click += new System.EventHandler(this.btnNovoJogo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Insira o jogo a ser pesquisado";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(164, 220);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(100, 20);
            this.txtPesquisa.TabIndex = 5;
            this.txtPesquisa.Text = "Jogo nº";
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            this.txtPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisa_KeyPress);
            // 
            // FrmPonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 340);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnNovoJogo);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnInstrucoes);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQRMin);
            this.Controls.Add(this.txtQRMax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPlacar);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.lstDados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtJogo);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPonto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabela de Pontuações";
            this.Load += new System.EventHandler(this.FrmPonto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtJogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstDados;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtPlacar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQRMax;
        private System.Windows.Forms.TextBox txtQRMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnInstrucoes;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnNovoJogo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPesquisa;
    }
}

