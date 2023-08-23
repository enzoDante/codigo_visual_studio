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
        public Bitmap removerFundo(Bitmap imagem, Color corRemover)
        {
            Bitmap resultado = new Bitmap(imagem.Width, imagem.Height);
            
            for(int y = 0; y < imagem.Height; y++)
            {
                for(int x = 0; x< imagem.Width; x++)
                {
                    Color corpixel = imagem.GetPixel(x, y);
                    if (DistanciadasCores(corpixel, corRemover) > 150)
                        resultado.SetPixel(x, y, corpixel);
                    else
                        resultado.SetPixel(x, y, Color.FromArgb(0, 0, 0, 0));
                }
            }
            return resultado;
        }
        /*
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

                    if (DistanciadasCores(corPixel, corRemover) > 150)
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
            //resultado.Save(@"D:\codigo_visual_studio\AULAS------WAGNER\PROJETOS\arquivos\nova_imagem.png");
        }*/
        static double DistanciadasCores(Color c1, Color c2)
        {
            int rDiff = c1.R - c2.R;
            int gDiff = c1.G - c2.G;
            int bDiff = c1.B - c2.B;

            return Math.Sqrt(rDiff * rDiff + gDiff * gDiff + bDiff * bDiff);
        }
        //filtro binário
        public Bitmap filtroBinario(Bitmap imgcinza)
        {
            Bitmap imgBinaria = new Bitmap(imgcinza.Width, imgcinza.Height);
            for (int y = 0; y < imgBinaria.Height; y++)
            {
                for (int x = 0; x < imgBinaria.Width; x++)
                {
                    Color c = imgcinza.GetPixel(x, y);
                    int gs = (int)(c.R * 0.3 + c.G * 0.59 + c.B * 0.11);
                    Color binar;
                    if (c == Color.Transparent)
                        binar = Color.Transparent;
                    else
                        binar = gs >= 128 ? Color.White : Color.Black;
                    imgBinaria.SetPixel(x, y, binar);

                }
            }
            return imgBinaria;
        }

        //filtro cinza
        public Bitmap filtrocinza(Bitmap imagem)
        {
            Bitmap grayScale = new Bitmap(imagem.Width, imagem.Height);
            for (int y = 0; y < grayScale.Height; y++)
            {
                for (int x = 0; x < grayScale.Width; x++)
                {
                    Color c = imagem.GetPixel(x, y);
                    int gs = (int)(c.R * 0.3 + c.G * 0.59 + c.B * 0.11);
                    int trasn = imagem.GetPixel(x, y).A;
                    grayScale.SetPixel(x, y, Color.FromArgb(trasn, gs, gs, gs));
                }
            }
            return grayScale;
        }
        /*public void cinzaFi(PaintEventArgs e)
        {
            Bitmap myBitmap2 = new Bitmap(@"D:\codigo_visual_studio\AULAS------WAGNER\PROJETOS\arquivos\imagem_A.jpg");
            Bitmap myBitmap = new Bitmap(@"D:\codigo_visual_studio\AULAS------WAGNER\PROJETOS\arquivos\panela.jpg");
            Bitmap myBitmap2New = filtrocinza(myBitmap2);
            myBitmap = teste(e);
            Bitmap myBitmapNew = filtrocinza(myBitmap);

            e.Graphics.DrawImage(myBitmap2New, myBitmap2.Width + 10, 0, myBitmap2.Width, myBitmap2.Height);
            e.Graphics.DrawImage(myBitmapNew, myBitmap2.Width+145, -5, myBitmap.Width, myBitmap.Height);

            Bitmap binarionew2 = filtroBinario(myBitmap2New);
            Bitmap binarionew = filtroBinario(myBitmapNew);
            e.Graphics.DrawImage(binarionew2, 10, binarionew2.Height+10, binarionew2.Width, binarionew2.Height);
            e.Graphics.DrawImage(binarionew, 135, binarionew2.Height + 15, binarionew.Width, binarionew.Height);
        }*/
                
        public Bitmap JuntarImagem(Bitmap imagemFundo, Bitmap imagemSob)
        {
            Bitmap resultado = new Bitmap(imagemFundo.Width, imagemFundo.Height);
            int altura = 0;
            for(int y = 0; y < resultado.Height; y++)
            {
                int largura = 0;
                for(int x = 0; x < resultado.Width; x++)
                {
                    resultado.SetPixel(x, y, imagemFundo.GetPixel(x, y));

                    if (x > 135 && x <= imagemSob.Width + 135 && y < imagemSob.Height)
                    {
                        Color cor = new Color();
                        if (imagemSob.GetPixel(largura, altura).A != 0)
                            cor = imagemSob.GetPixel(largura, altura);
                        else
                            cor = imagemFundo.GetPixel(x, y);
                        resultado.SetPixel(x, y, cor);
                        largura++;
                    }
                        
                }
                altura++;
            }
            return resultado;

        }
        public void DesenharImagem(PaintEventArgs e, int x, int y, Bitmap imagem)
        {
            e.Graphics.DrawImage(imagem, x, y, imagem.Width, imagem.Height);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Bitmap cozinha = new Bitmap(@"D:\codigo_visual_studio\AULAS------WAGNER\PROJETOS\arquivos\imagem_A.jpg");
            Bitmap panela = new Bitmap(@"D:\codigo_visual_studio\AULAS------WAGNER\PROJETOS\arquivos\panela.jpg");
            panela = removerFundo(panela, Color.Yellow);            
            Bitmap ImagemCompleta = JuntarImagem(cozinha, panela);

            DesenharImagem(e, 0, 0, ImagemCompleta);

            Bitmap ImgCinza = filtrocinza(ImagemCompleta);
            Bitmap ImgBinaria = filtroBinario(ImgCinza);

            DesenharImagem(e, 650, 0, ImgCinza);
            DesenharImagem(e, 0, 350, ImgBinaria);
            //e.Graphics.DrawImage(ImagemCompleta, 0, 0, ImagemCompleta.Width, ImagemCompleta.Height);
            //testenovo(e);
            //cinzaFi(e);
        }
        public void testenovo(PaintEventArgs e)
        {
            Bitmap myBitmap2 = new Bitmap(@"D:\codigo_visual_studio\AULAS------WAGNER\PROJETOS\arquivos\imagem_A.jpg");
            Bitmap myBitmap = new Bitmap(@"D:\codigo_visual_studio\AULAS------WAGNER\PROJETOS\arquivos\panela.jpg");
            e.Graphics.DrawImage(myBitmap2, 0, 0, myBitmap2.Width, myBitmap2.Height);

            //Color backColor = myBitmap.GetPixel(10, 10);

            //e.Graphics.DrawImage(myBitmap, /*myBitmap.Width*/200, 50, myBitmap.Width, myBitmap.Height);
            //Bitmap resultado = teste(e);
            //e.Graphics.DrawImage(resultado, /*myBitmap.Width*/135, -5, resultado.Width, resultado.Height);
        }


    }
}
