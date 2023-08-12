using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto3bi_3ano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            teste();
        }

        public void teste()
        {
            Bitmap imagem = new Bitmap(@"D:\codigo_visual_studio\AULAS------WAGNER\PROJETOS\arquivos\panela.jpg");
            Color corRemover = Color.Yellow;

            Bitmap resultado = new Bitmap(imagem.Width, imagem.Height);
            for(int y = 0; y < imagem.Height; y++)
            {
                for(int x = 0; x < imagem.Width; x++)
                {
                    Color corPixel = imagem.GetPixel(x, y);

                    if (ColorDistance(corPixel, corRemover) > 150)
                    {
                        resultado.SetPixel(x, y, corPixel);
                    }
                    else
                    {
                        resultado.SetPixel(x, y, Color.Transparent);
                    }
                }
            }

            resultado.Save(@"D:\codigo_visual_studio\AULAS------WAGNER\PROJETOS\arquivos\nova_imagem.png");
        }
        static double ColorDistance(Color c1, Color c2)
        {
            int rDiff = c1.R - c2.R;
            int gDiff = c1.G - c2.G;
            int bDiff = c1.B - c2.B;

            return Math.Sqrt(rDiff * rDiff + gDiff * gDiff + bDiff * bDiff);
        }
    }
}
