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
        }

        //remover fundo ---- remover esta função!!!!
        /*public Bitmap removerFundo(Bitmap imagem, Color corRemover)
        {
            Bitmap resultado = new Bitmap(imagem.Width, imagem.Height);
            
            for(int y = 0; y < imagem.Height; y++)
            {
                for(int x = 0; x< imagem.Width; x++)
                {
                    Color corpixel = imagem.GetPixel(x, y);
                    if (DistanciadasCores(corpixel, corRemover) > 100)//150
                        resultado.SetPixel(x, y, corpixel);
                    else
                        resultado.SetPixel(x, y, Color.FromArgb(0, 0, 0, 0));
                }
            }
            return resultado;
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
                    //int gs = (int)(c.R * 0.3 + c.G * 0.59 + c.B * 0.11);
                    Color binar = c.R >= 125 ? Color.White : Color.Black;//128
                    imgBinaria.SetPixel(x, y, binar);

                }
            }
            return imgBinaria;
        }

        //filtro cinza
        public Bitmap filtrocinza(Bitmap imagem)
        {
            Bitmap imagemCinza = new Bitmap(imagem.Width, imagem.Height);
            for (int y = 0; y < imagemCinza.Height; y++)
            {
                for (int x = 0; x < imagemCinza.Width; x++)
                {
                    Color c = imagem.GetPixel(x, y);
                    int gs = (int)(c.R * 0.3 + c.G * 0.59 + c.B * 0.11);
                    //int trasn = imagem.GetPixel(x, y).A;
                    imagemCinza.SetPixel(x, y, Color.FromArgb(gs, gs, gs)); //trasn, gs, gs, gs
                }
            }
            return imagemCinza;
        }
                
        public Bitmap JuntarImagem(Bitmap imagemFundo, Bitmap imagemSob)
        {
            Bitmap resultado = new Bitmap(imagemFundo.Width, imagemFundo.Height);
            int altura = 0;
            for(int y = 0; y < resultado.Height; y++)
            {
                int largura = 0;
                for(int x = 0; x < resultado.Width; x++)
                {
                    Color cor = new Color();
                    if (x > 135 && x <= imagemSob.Width + 135 && y < imagemSob.Height)
                    {                             
                        //if (imagemSob.GetPixel(largura, altura).A != 0)
                        if(DistanciadasCores(imagemSob.GetPixel(largura, altura), Color.Yellow) > 150)  
                            cor = imagemSob.GetPixel(largura, altura);
                        else
                            cor = imagemFundo.GetPixel(x, y);
                        largura++;
                    }else
                        cor = imagemFundo.GetPixel(x, y);
                    resultado.SetPixel(x, y, cor);
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
            //panela = removerFundo(panela, Color.Yellow);            
            Bitmap ImagemCompleta = JuntarImagem(cozinha, panela);

            DesenharImagem(e, 0, 0, ImagemCompleta);

            Bitmap ImgCinza = filtrocinza(ImagemCompleta);
            Bitmap ImgBinaria = filtroBinario(ImgCinza);

            DesenharImagem(e, 650, 0, ImgCinza);
            DesenharImagem(e, 0, 350, ImgBinaria);
            ImagemCompleta.Save(@"D:\codigo_visual_studio\AULAS------WAGNER\PROJETOS\arquivos\hmmm.jpg");
        }


    }
}
