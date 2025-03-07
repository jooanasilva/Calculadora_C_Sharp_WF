using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;


namespace Calculadora_C_Sharp_WindowsF
{
    public partial class Form1 : Form
    {
        // Variáveis que armazenam o resultado, o valor digitado e a operação selecionada
        private decimal Resultado { get; set; }
        private decimal Valor { get; set; }
        private Operacao OperacaoSelecionada { get; set; }

        // Enum para definir as operações
        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao,
            Porcentagem
        }

        // CRIANDO BORDA NA TEXTBOX
        // O WF não oferece recurso direto para crição de bordas arredondadas em controles
        // para ter uma borda arredondada, você precisa desenhar-la por conta própria
        // e isso é feito com o Paint, desenhando um caminho arredondado com GraphicsPath
        // e depois desenhando esse caminho com um Pen
        public Form1()
        {
            InitializeComponent();

            // Essa linha serve para remover a borda padrão da TextBox,
            // se você não fizer isso, a TextBox ainda terá as bordas retas
            // Remove a borda padrão da TextBox
            txtResultado.BorderStyle = BorderStyle.None;

            // Registra os eventos para redesenhar a borda arredondada
            this.Paint += new PaintEventHandler(Form1_Paint);
            txtResultado.LocationChanged += new EventHandler(textBox1_LocationChanged);
            txtResultado.SizeChanged += new EventHandler(textBox1_SizeChanged);

        }

        // O evento Paint é chamado toda vez que o controle (ou o formulário) precisa ser redesenhado
        // EX: Quado o controle aparece na tela, quando ele é redimensionado, quando ele é movido, etc
        // Ele vai sempre precisar "pintar" o controle
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Define o quanto as bordas seram arredondadas
            int borderRadius = 5;

            // Obtém a área da TextBox - localização e tamanho
            Rectangle textBoxBounds = txtResultado.Bounds;

            // Ajusta um pouco a área para desenhar sem cortes
            textBoxBounds.Inflate(1, 1); // Aumenta ligeiramente o retângulo para evitar cortes

            // GRAPIHCS PATH é uma classe usada para criar formas complexas e caminhos gráficos,
            // como linhas, curvas, arcos, retângulos, como se fosse moldes para desenhar
            // Cria a forma da borda arredondada
            using (GraphicsPath path = new GraphicsPath())
            {
                // Cria um retângulo arredondado
                path.AddArc(textBoxBounds.Left, textBoxBounds.Top, borderRadius * 2, borderRadius * 2, 180, 90); // Canto superior esquerdo
                path.AddArc(textBoxBounds.Right - borderRadius * 2, textBoxBounds.Top, borderRadius * 2, borderRadius * 2, 270, 90); // Canto superior direito
                path.AddArc(textBoxBounds.Right - borderRadius * 2, textBoxBounds.Bottom - borderRadius * 2, borderRadius * 2, borderRadius * 2, 0, 90); // Canto inferior direito
                path.AddArc(textBoxBounds.Left, textBoxBounds.Bottom - borderRadius * 2, borderRadius * 2, borderRadius * 2, 90, 90); // Canto inferior esquerdo
                path.CloseFigure();

                // PEN é usado para desenhar linhas e curvas, ele quem define a aparência da linha como: cor, espessura, estilo
                // Desenha a borda arredondada com uma linha cinza
                using (Pen pen = new Pen(Color.DimGray, 4)) // Cor e espessura da linha
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias; // Suaviza as bordas
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void textBox1_LocationChanged(object sender, EventArgs e)
        {
            // Redesenha o formulário quando a localização da TextBox muda
            this.Invalidate(); // Invalida a área do formulário para forçar o redesenho
        }

        // Quando o tamanho da TextBox mudar, a borda será redesenhada
        private void textBox1_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate(); // Força o redesenho do formulário
        }

        private void buttonFormaRedonda1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //AÇÕES DOS BOTÕES
        private void btnZero_Click(object sender, EventArgs e)
        {
            //Quando o usário clicar no botão zero, o número zero será exibido na tela
            txtResultado.Text += "0";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        //OPERAÇÕES
        private void btnAdicao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao; // Seleciona a operação de adição
            Valor = Convert.ToDecimal(txtResultado.Text); // Armazena o valor que foi digitado pelo usuário
            txtResultado.Text = ""; // Limpa a textBox para o próximo número

        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Porcentagem;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
        }

        // ACAO PARA BOTAO DE VIRUGLA  
        private void btnVirgula_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ","; // Adiciona a vírgula a tetxBox
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpar a tela
            txtResultado.Clear(); // Limpa a textBox
            Resultado = 0; // Reseta o resultado
            Valor = 0; // Reseta o valor
            OperacaoSelecionada = default(Operacao); // Reseta a operação
        }

        // CALCULAR O RESULTADO
        private void btnIgual_Click(object sender, EventArgs e)
        {
            decimal valorAtual = Convert.ToDecimal(txtResultado.Text); // Pega o número atual da textBox
            // Realiza a operação selecionada
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Porcentagem:
                    Resultado = Valor * (valorAtual / 100);
                    break;

            }

            txtResultado.Text = Convert.ToString(Resultado); // Exibe o resultado na textBox
        }
    }
}

