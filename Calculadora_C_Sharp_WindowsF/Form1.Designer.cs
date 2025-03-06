namespace Calculadora_C_Sharp_WindowsF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnZero = new ButtonFormaRedonda();
            btnVirgula = new ButtonFormaRedonda();
            btnLimpar = new ButtonFormaRedonda();
            btnUm = new ButtonFormaRedonda();
            btnTres = new ButtonFormaRedonda();
            btnDois = new ButtonFormaRedonda();
            btnSeis = new ButtonFormaRedonda();
            btnCinco = new ButtonFormaRedonda();
            btnQuatro = new ButtonFormaRedonda();
            btnNove = new ButtonFormaRedonda();
            btnOito = new ButtonFormaRedonda();
            btnSete = new ButtonFormaRedonda();
            btnPorcentagem = new ButtonFormaRedonda();
            btnIgual = new ButtonBordaArredondada();
            btnAdicao = new ButtonFormaRedonda();
            btnDivisao = new ButtonFormaRedonda();
            btnMultiplicacao = new ButtonFormaRedonda();
            btnSubtracao = new ButtonFormaRedonda();
            txtResultado = new TextBox();
            // 
            // btnZero
            // 
            btnZero.BackColor = Color.LightGray;
            btnZero.FlatAppearance.BorderSize = 0;
            btnZero.FlatStyle = FlatStyle.Flat;
            btnZero.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnZero.ForeColor = SystemColors.ControlDarkDark;
            btnZero.Location = new Point(33, 382);
            btnZero.Margin = new Padding(3, 2, 3, 2);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(57, 54);
            btnZero.TabIndex = 4;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = false;
            btnZero.Click += btnZero_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.BackColor = Color.LightGray;
            btnVirgula.FlatAppearance.BorderSize = 0;
            btnVirgula.FlatStyle = FlatStyle.Flat;
            btnVirgula.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVirgula.ForeColor = SystemColors.ControlDarkDark;
            btnVirgula.Location = new Point(117, 382);
            btnVirgula.Margin = new Padding(3, 2, 3, 2);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(55, 54);
            btnVirgula.TabIndex = 5;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = false;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.LightSlateGray;
            btnLimpar.FlatAppearance.BorderSize = 0;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.ForeColor = Color.WhiteSmoke;
            btnLimpar.Location = new Point(198, 382);
            btnLimpar.Margin = new Padding(3, 2, 3, 2);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(52, 54);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "C";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnUm
            // 
            btnUm.BackColor = Color.LightGray;
            btnUm.FlatAppearance.BorderSize = 0;
            btnUm.FlatStyle = FlatStyle.Flat;
            btnUm.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUm.ForeColor = SystemColors.ControlDarkDark;
            btnUm.Location = new Point(33, 314);
            btnUm.Margin = new Padding(3, 2, 3, 2);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(57, 54);
            btnUm.TabIndex = 7;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = false;
            btnUm.Click += btnUm_Click;
            // 
            // btnTres
            // 
            btnTres.BackColor = Color.LightGray;
            btnTres.FlatAppearance.BorderSize = 0;
            btnTres.FlatStyle = FlatStyle.Flat;
            btnTres.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTres.ForeColor = SystemColors.ControlDarkDark;
            btnTres.Location = new Point(198, 314);
            btnTres.Margin = new Padding(3, 2, 3, 2);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(52, 54);
            btnTres.TabIndex = 8;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = false;
            btnTres.Click += btnTres_Click;
            // 
            // btnDois
            // 
            btnDois.BackColor = Color.LightGray;
            btnDois.FlatAppearance.BorderSize = 0;
            btnDois.FlatStyle = FlatStyle.Flat;
            btnDois.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDois.ForeColor = SystemColors.ControlDarkDark;
            btnDois.Location = new Point(117, 314);
            btnDois.Margin = new Padding(3, 2, 3, 2);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(55, 54);
            btnDois.TabIndex = 9;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = false;
            btnDois.Click += btnDois_Click;
            // 
            // btnSeis
            // 
            btnSeis.BackColor = Color.LightGray;
            btnSeis.FlatAppearance.BorderSize = 0;
            btnSeis.FlatStyle = FlatStyle.Flat;
            btnSeis.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSeis.ForeColor = SystemColors.ControlDarkDark;
            btnSeis.Location = new Point(198, 248);
            btnSeis.Margin = new Padding(3, 2, 3, 2);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(52, 54);
            btnSeis.TabIndex = 10;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = false;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnCinco
            // 
            btnCinco.BackColor = Color.LightGray;
            btnCinco.FlatAppearance.BorderSize = 0;
            btnCinco.FlatStyle = FlatStyle.Flat;
            btnCinco.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCinco.ForeColor = SystemColors.ControlDarkDark;
            btnCinco.Location = new Point(117, 248);
            btnCinco.Margin = new Padding(3, 2, 3, 2);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(55, 54);
            btnCinco.TabIndex = 11;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = false;
            btnCinco.Click += btnCinco_Click;
            // 
            // btnQuatro
            // 
            btnQuatro.BackColor = Color.LightGray;
            btnQuatro.FlatAppearance.BorderSize = 0;
            btnQuatro.FlatStyle = FlatStyle.Flat;
            btnQuatro.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuatro.ForeColor = SystemColors.ControlDarkDark;
            btnQuatro.Location = new Point(33, 248);
            btnQuatro.Margin = new Padding(3, 2, 3, 2);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(57, 54);
            btnQuatro.TabIndex = 12;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = false;
            btnQuatro.Click += btnQuatro_Click;
            // 
            // btnNove
            // 
            btnNove.BackColor = Color.LightGray;
            btnNove.FlatAppearance.BorderSize = 0;
            btnNove.FlatStyle = FlatStyle.Flat;
            btnNove.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNove.ForeColor = SystemColors.ControlDarkDark;
            btnNove.Location = new Point(198, 182);
            btnNove.Margin = new Padding(3, 2, 3, 2);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(52, 54);
            btnNove.TabIndex = 13;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = false;
            btnNove.Click += btnNove_Click;
            // 
            // btnOito
            // 
            btnOito.BackColor = Color.LightGray;
            btnOito.FlatAppearance.BorderSize = 0;
            btnOito.FlatStyle = FlatStyle.Flat;
            btnOito.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOito.ForeColor = SystemColors.ControlDarkDark;
            btnOito.Location = new Point(117, 182);
            btnOito.Margin = new Padding(3, 2, 3, 2);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(55, 54);
            btnOito.TabIndex = 14;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = false;
            btnOito.Click += btnOito_Click;
            // 
            // btnSete
            // 
            btnSete.BackColor = Color.LightGray;
            btnSete.FlatAppearance.BorderSize = 0;
            btnSete.FlatStyle = FlatStyle.Flat;
            btnSete.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSete.ForeColor = SystemColors.ControlDarkDark;
            btnSete.Location = new Point(33, 182);
            btnSete.Margin = new Padding(3, 2, 3, 2);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(57, 54);
            btnSete.TabIndex = 15;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = false;
            btnSete.Click += btnSete_Click;
            // 
            // btnPorcentagem
            // 
            btnPorcentagem.BackColor = Color.Gray;
            btnPorcentagem.FlatAppearance.BorderSize = 0;
            btnPorcentagem.FlatStyle = FlatStyle.Flat;
            btnPorcentagem.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPorcentagem.ForeColor = Color.WhiteSmoke;
            btnPorcentagem.Location = new Point(282, 182);
            btnPorcentagem.Margin = new Padding(3, 2, 3, 2);
            btnPorcentagem.Name = "btnPorcentagem";
            btnPorcentagem.Size = new Size(56, 54);
            btnPorcentagem.TabIndex = 19;
            btnPorcentagem.Text = "/";
            btnPorcentagem.UseVisualStyleBackColor = false;
            btnPorcentagem.Click += btnPorcentagem_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.DarkOrange;
            btnIgual.FlatAppearance.BorderSize = 0;
            btnIgual.FlatStyle = FlatStyle.Flat;
            btnIgual.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIgual.ForeColor = Color.White;
            btnIgual.Location = new Point(280, 248);
            btnIgual.Margin = new Padding(3, 2, 3, 2);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(69, 188);
            btnIgual.TabIndex = 21;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnAdicao
            // 
            btnAdicao.BackColor = Color.Gray;
            btnAdicao.FlatAppearance.BorderSize = 0;
            btnAdicao.FlatStyle = FlatStyle.Flat;
            btnAdicao.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicao.ForeColor = Color.WhiteSmoke;
            btnAdicao.Location = new Point(33, 112);
            btnAdicao.Margin = new Padding(3, 2, 3, 2);
            btnAdicao.Name = "btnAdicao";
            btnAdicao.Size = new Size(57, 54);
            btnAdicao.TabIndex = 22;
            btnAdicao.Text = "+";
            btnAdicao.UseVisualStyleBackColor = false;
            btnAdicao.Click += btnAdicao_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.BackColor = Color.Gray;
            btnDivisao.FlatAppearance.BorderSize = 0;
            btnDivisao.FlatStyle = FlatStyle.Flat;
            btnDivisao.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDivisao.ForeColor = Color.WhiteSmoke;
            btnDivisao.Location = new Point(282, 112);
            btnDivisao.Margin = new Padding(3, 2, 3, 2);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(56, 54);
            btnDivisao.TabIndex = 24;
            btnDivisao.Text = "÷";
            btnDivisao.UseVisualStyleBackColor = false;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.BackColor = Color.Gray;
            btnMultiplicacao.FlatAppearance.BorderSize = 0;
            btnMultiplicacao.FlatStyle = FlatStyle.Flat;
            btnMultiplicacao.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMultiplicacao.ForeColor = Color.WhiteSmoke;
            btnMultiplicacao.Location = new Point(198, 112);
            btnMultiplicacao.Margin = new Padding(3, 2, 3, 2);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(61, 54);
            btnMultiplicacao.TabIndex = 25;
            btnMultiplicacao.Text = "x";
            btnMultiplicacao.UseVisualStyleBackColor = false;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.BackColor = Color.Gray;
            btnSubtracao.FlatAppearance.BorderSize = 0;
            btnSubtracao.FlatStyle = FlatStyle.Flat;
            btnSubtracao.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubtracao.ForeColor = Color.WhiteSmoke;
            btnSubtracao.Location = new Point(117, 112);
            btnSubtracao.Margin = new Padding(3, 2, 3, 2);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(55, 54);
            btnSubtracao.TabIndex = 26;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = false;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // txtResultado
            // 
            txtResultado.BackColor = Color.FromArgb(64, 64, 64);
            txtResultado.Font = new Font("Segoe UI", 33F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResultado.ForeColor = Color.WhiteSmoke;
            txtResultado.Location = new Point(33, 17);
            txtResultado.Margin = new Padding(3, 2, 3, 2);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(316, 68);
            txtResultado.TabIndex = 27;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            // 
            // label2
            // 
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 462);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtResultado);
            Controls.Add(btnSubtracao);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnDivisao);
            Controls.Add(btnAdicao);
            Controls.Add(btnIgual);
            Controls.Add(btnPorcentagem);
            Controls.Add(btnSete);
            Controls.Add(btnOito);
            Controls.Add(btnNove);
            Controls.Add(btnQuatro);
            Controls.Add(btnCinco);
            Controls.Add(btnSeis);
            Controls.Add(btnDois);
            Controls.Add(btnTres);
            Controls.Add(btnUm);
            Controls.Add(btnLimpar);
            Controls.Add(btnVirgula);
            Controls.Add(btnZero);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ButtonFormaRedonda btnZero;
        private ButtonFormaRedonda btnVirgula;
        private ButtonFormaRedonda btnLimpar;
        private ButtonFormaRedonda btnUm;
        private ButtonFormaRedonda btnTres;
        private ButtonFormaRedonda btnDois;
        private ButtonFormaRedonda btnSeis;
        private ButtonFormaRedonda btnCinco;
        private ButtonFormaRedonda btnQuatro;
        private ButtonFormaRedonda btnNove;
        private ButtonFormaRedonda btnOito;
        private ButtonFormaRedonda btnSete;
        private ButtonFormaRedonda btnPorcentagem;
        private ButtonBordaArredondada btnIgual;
        private ButtonFormaRedonda btnAdicao;
        private ButtonFormaRedonda btnDivisao;
        private ButtonFormaRedonda btnMultiplicacao;
        private ButtonFormaRedonda btnSubtracao;
        private TextBox txtResultado;
        private Label label1;
        private Label label2;
    }
}
