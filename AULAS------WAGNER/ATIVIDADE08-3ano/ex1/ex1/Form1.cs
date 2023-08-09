/* Colegio Técnico Antônio Teixeira Fernandes (Univap)
 * Curso Técnico em Informática - Data de Entrega: DD/MM/2020
 * Autores do Projeto: Enzo Dante Micoli
 *   
 * Turma: 3H
 * Atividade Proposta em aula exercicio (1 e 2)
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

namespace ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Color setCor(int r, int g, int b)
        {
            return Color.FromArgb(r, g, b);
        }
        public Pen setPen(Color cor, int esp)
        {
            Pen caneta = new Pen(cor, esp);
            return caneta;
        }

        public SolidBrush Preencher(PaintEventArgs e, Color cor)
        {
            return new SolidBrush(cor);
        }
        public void preencheRetangulo(PaintEventArgs e, SolidBrush fundo, int[] x)
        {
            e.Graphics.FillRectangle(fundo, x[0], x[1], x[2], x[3]);
        }

        public void preencheElipse(PaintEventArgs e, SolidBrush fundo, int[] x)
        {
            e.Graphics.FillEllipse(fundo, x[0], x[1], x[2], x[3]);
        }
        public void preencheCirculo(PaintEventArgs e, SolidBrush fundo, int x, int y, int raio)
        {
            e.Graphics.FillEllipse(fundo, x, y, raio, raio);
        }

        public void PrintLinha(PaintEventArgs e, int x, int y, int x1, int y1, Pen c)
        {
            e.Graphics.DrawLine(c, x, y, x1, y1);
        }
        public void PrintCirculo(PaintEventArgs e, int x, int y, int raio, Pen c)
        {
            e.Graphics.DrawEllipse(c, x, y, raio, raio);
        }
        public void PrintElipse(PaintEventArgs e, int x, int y, int larg, int alt, Pen c)
        {
                e.Graphics.DrawEllipse(c, x, y, larg, alt);
        }
        public void PrintRetangulo(PaintEventArgs e, int[] x, Pen c)
        {
            /*PrintLinha(e, x[0], x[1], x[0], x[3], c);
            PrintLinha(e, x[0], x[1], x[2], x[1], c);

            PrintLinha(e, x[2], x[3], x[0], x[3], c);
            PrintLinha(e, x[2], x[3], x[2], x[1], c);*/

            // x y    largura    altura
            e.Graphics.DrawRectangle(c, x[0], x[1], x[2], x[3]);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int[] retangulo = { 100, 100, 200, 50 };
            int[] circulo = { 100, 300, 50 };
            int[] elipse = { 300, 250, 50, 20 };

            Color cor = setCor(0, 255, 0);
            Pen caneta = setPen(cor, 3);

            SolidBrush preenchimento = Preencher(e, cor);

            PrintRetangulo(e, retangulo, caneta);
            preencheRetangulo(e, preenchimento, retangulo);

            PrintCirculo(e, circulo[0], circulo[1], circulo[2], caneta);
            preencheCirculo(e, preenchimento, circulo[0], circulo[1], circulo[2]);

            PrintElipse(e, elipse[0], elipse[1], elipse[2], elipse[3], caneta);
            preencheElipse(e, preenchimento, elipse);
        }
    }
}
