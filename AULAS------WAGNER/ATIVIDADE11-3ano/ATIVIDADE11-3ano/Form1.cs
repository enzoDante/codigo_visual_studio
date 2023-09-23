/* Colegio Técnico Antônio Teixeira Fernandes (Univap)
 * Curso Técnico em Informática - Data de Entrega: 06/09/2023
 * Autores do Projeto: Enzo Dante Mícoli
 *   
 * Turma: 3H
 * Atividade Proposta em aula
 * Observação: <colocar se houver>
 * 
 * 
 * ******************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE11_3ano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //rotaciona imagem aproveitando os conceitos de matriz transposta e lógica da função em comentário
        public Bitmap RotacionarImagem(String caminho)
        {
            Bitmap img = new Bitmap(caminho);
            Bitmap resultado = new Bitmap(img.Height, img.Width);

            int largura = img.Height-1;
            for(int y = 0; y < img.Height; y++)
            {
                int altura = 0;
                for(int x = 0; x < img.Width; x++)
                {
                    Color pixel = img.GetPixel(x, y);
                    resultado.SetPixel(largura, altura, pixel);
                    altura++;
                }
                largura--;
            }


            return resultado;
        }
        /*
         * rotaciona imagem - resultado é a transposta de img
         public Bitmap RotacionarImagem(String caminho)
        {
            Bitmap img = new Bitmap(caminho);
            Bitmap resultado = new Bitmap(img.Height, img.Width);

            for(int y = 0; y < img.Height; y++)
            {
                for(int x = 0; x < img.Width; x++)
                {
                    Color pixel = img.GetPixel(x, y);
                    resultado.SetPixel(y, x, pixel);
                }
            }


            return resultado;
        }
         */
        public void PrintImagem(PaintEventArgs e, Bitmap img, int x, int y)
        {
            e.Graphics.DrawImage(img, x, y);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            String img = @"D:\codigo_visual_studio\AULAS------WAGNER\imagemTeste.jpg";

            Bitmap imagemR = RotacionarImagem(img);

            PrintImagem(e, imagemR, 10, 10);
            //imagemR.Save(@"C:\imagens\imagemRo.jpg");

            img = @"D:\codigo_visual_studio\AULAS------WAGNER\teste2img.jpg";
            imagemR = RotacionarImagem(img);

            PrintImagem(e, imagemR, 500, 10);

        }
    }
}
