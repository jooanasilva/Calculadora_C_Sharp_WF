using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculadora_C_Sharp_WindowsF
{
    [ToolboxItem(true)] // Permitir que o botão seja adicionado ao formulário

    public class ButtonFormaRedonda : Button
    {
        public ButtonFormaRedonda()
        {
            // Definindo o tamanho do botao para 50x50 pixels
            this.Size = new Size(50, 50);

            // Garantir que o botão seja quadrado e redondo
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = Color.LightGray; // Cor de fundo
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            // Garantir que o botão seja quadrado
            int size = Math.Min(ClientSize.Width, ClientSize.Height);

            // Criando o caminho gráfico para desenhar um círculo perfeito
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, size, size); // Usar o menor valor entre a largura e altura para garantir um círculo

            // Definindo a região para que o botão tenha bordas arredondadas (formato circular)
            this.Region = new System.Drawing.Region(grPath);

            // Ativar suavização das bordas
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Chama o método base para desenhar o botão normalmente (como um botão)
            base.OnPaint(pevent);

            // Desenha uma borda fina cinza claro ao redor do botão
            using (Pen pen = new Pen(Color.Silver, 5)) // Cor da borda: cinza claro (Silver) e espessura: 2

            {
                // Desenha a borda no contorno do botão circular
                pevent.Graphics.DrawEllipse(pen, 0, 0, size, size); // Desenha o contorno do círculo
            }
        }
    }

}


