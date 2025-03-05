using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Calculadora_C_Sharp_WindowsF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Remove a borda padr�o da TextBox
            textBox1.BorderStyle = BorderStyle.None;

            // Registra os eventos para redesenhar a borda arredondada
            this.Paint += new PaintEventHandler(Form1_Paint);
            textBox1.LocationChanged += new EventHandler(textBox1_LocationChanged);
            textBox1.SizeChanged += new EventHandler(textBox1_SizeChanged);

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Define o raio do arredondamento
            int borderRadius = 5;

            // Obt�m a �rea da TextBox
            Rectangle textBoxBounds = textBox1.Bounds;

            // Ajusta as coordenadas para desenhar a borda corretamente
            textBoxBounds.Inflate(1, 1); // Aumenta ligeiramente o ret�ngulo para evitar cortes

            // Cria um caminho gr�fico para desenhar a borda arredondada
            using (GraphicsPath path = new GraphicsPath())
            {
                // Cria um ret�ngulo arredondado
                path.AddArc(textBoxBounds.Left, textBoxBounds.Top, borderRadius * 2, borderRadius * 2, 180, 90); // Canto superior esquerdo
                path.AddArc(textBoxBounds.Right - borderRadius * 2, textBoxBounds.Top, borderRadius * 2, borderRadius * 2, 270, 90); // Canto superior direito
                path.AddArc(textBoxBounds.Right - borderRadius * 2, textBoxBounds.Bottom - borderRadius * 2, borderRadius * 2, borderRadius * 2, 0, 90); // Canto inferior direito
                path.AddArc(textBoxBounds.Left, textBoxBounds.Bottom - borderRadius * 2, borderRadius * 2, borderRadius * 2, 90, 90); // Canto inferior esquerdo
                path.CloseFigure();

                // Desenha a borda arredondada
                using (Pen pen = new Pen(Color.DimGray, 4)) // Cor e espessura da borda
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias; // Suaviza as bordas
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void textBox1_LocationChanged(object sender, EventArgs e)
        {
            // Redesenha o formul�rio quando a localiza��o da TextBox muda
            this.Invalidate();
        }

        private void textBox1_SizeChanged(object sender, EventArgs e)
        {
            // Redesenha o formul�rio quando o tamanho da TextBox muda
            this.Invalidate();
        }

        private void buttonFormaRedonda1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnZero_Click(object sender, EventArgs e)
        {

        }

        private void btnUm_Click(object sender, EventArgs e)
        {

        }

        private void btnDois_Click(object sender, EventArgs e)
        {

        }

        private void btnTres_Click(object sender, EventArgs e)
        {

        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {

        }

        private void btnCinco_Click(object sender, EventArgs e)
        {

        }

        private void btnSeis_Click(object sender, EventArgs e)
        {

        }

        private void btnSete_Click(object sender, EventArgs e)
        {

        }

        private void btnOito_Click(object sender, EventArgs e)
        {

        }

        private void btnNove_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {

        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {

        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {

        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {

        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {

        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {

        }
    }
}
