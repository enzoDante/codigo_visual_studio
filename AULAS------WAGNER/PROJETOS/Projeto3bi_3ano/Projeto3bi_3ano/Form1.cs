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
            //teste();
        }

        //remover fundo
        public Bitmap teste(PaintEventArgs e)
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
            //aqqqqqqqqqqqq=============================================================
            return resultado;
            //e.Graphics.DrawImage(resultado, /*myBitmap.Width*/200, 50, resultado.Width, resultado.Height);

            //resultado.Save(@"D:\codigo_visual_studio\AULAS------WAGNER\PROJETOS\arquivos\nova_imagem.png");
        }
        static double ColorDistance(Color c1, Color c2)
        {
            int rDiff = c1.R - c2.R;
            int gDiff = c1.G - c2.G;
            int bDiff = c1.B - c2.B;

            return Math.Sqrt(rDiff * rDiff + gDiff * gDiff + bDiff * bDiff);
        }

        //filtro cinza
        public Bitmap filtrocinza(Bitmap imagem)
        {
            Bitmap grayScale = new Bitmap(imagem.Width, imagem.Height);
            for (Int32 y = 0; y < grayScale.Height; y++)
            {
                for (Int32 x = 0; x < grayScale.Width; x++)
                {
                    Color c = imagem.GetPixel(x, y);
                    Int32 gs = (Int32)(c.R * 0.3 + c.G * 0.59 + c.B * 0.11);
                    int trasn = imagem.GetPixel(x, y).A;
                    grayScale.SetPixel(x, y, Color.FromArgb(trasn, gs, gs, gs));
                }
            }
            return grayScale;
        }
        public void cinzaFi(PaintEventArgs e)
        {
            Bitmap myBitmap2 = new Bitmap(@"D:\codigo_visual_studio\AULAS------WAGNER\PROJETOS\arquivos\imagem_A.jpg");
            Bitmap myBitmap = new Bitmap(@"D:\codigo_visual_studio\AULAS------WAGNER\PROJETOS\arquivos\panela.jpg");
            Bitmap myBitmap2New = filtrocinza(myBitmap2);
            myBitmap = teste(e);
            Bitmap myBitmapNew = filtrocinza(myBitmap);

            e.Graphics.DrawImage(myBitmap2New, myBitmap2.Width + 10, 0, myBitmap2.Width, myBitmap2.Height);
            e.Graphics.DrawImage(myBitmapNew, myBitmap2.Width+200, 50, myBitmap.Width, myBitmap.Height);
        }
                

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            testenovo(e);
            cinzaFi(e);
        }
        public void testenovo(PaintEventArgs e)
        {
            Bitmap myBitmap2 = new Bitmap(@"D:\codigo_visual_studio\AULAS------WAGNER\PROJETOS\arquivos\imagem_A.jpg");
            Bitmap myBitmap = new Bitmap(@"D:\codigo_visual_studio\AULAS------WAGNER\PROJETOS\arquivos\panela.jpg");
            e.Graphics.DrawImage(myBitmap2, 0, 0, myBitmap2.Width, myBitmap2.Height);

            //Color backColor = myBitmap.GetPixel(10, 10);

            myBitmap.MakeTransparent();//backColor
            //e.Graphics.DrawImage(myBitmap, /*myBitmap.Width*/200, 50, myBitmap.Width, myBitmap.Height);
            Bitmap resultado = teste(e);
            e.Graphics.DrawImage(resultado, /*myBitmap.Width*/200, 50, resultado.Width, resultado.Height);
        }


    }
}
