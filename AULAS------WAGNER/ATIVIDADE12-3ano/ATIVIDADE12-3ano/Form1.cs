/* *******************************************************************
* Colegio Técnico Antônio Teixeira Fernandes (Univap)
* Curso Técnico em Informática - Data de Entrega: 23/09/2023
* Autores do Projeto: Enzo Dante Micoli
*                     
* Turma: 3H
* Atividade Proposta em aula
* Observação: <colocar se houver>
* 
* problema_aula.cs  exercício 3
* ************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE12_3ano
{
    public partial class Form1 : Form
    {
        int scala1 = 1;
        int[] pontos_iso = { 278, 35, 76, 116,
                        138, 176, 278, 35,
                        357, 217, 138, 176,
                        357, 218, 438, 190,
                        438, 190, 278, 29,
                        360, 219 , 278, 35,
                        73, 118, 138, 172,
                        75, 124, 31, 311,
                        133, 170, 40, 304,
                        132, 179, 206, 386,
                        207, 386, 359, 218,
                        358, 217, 398, 402,
                        397, 401, 440, 191,
                        37, 311, 208, 386,
                        206, 385, 402, 402,
                        402, 402, 195, 474,
                        195, 474, 208, 389,
                        195, 474, 32, 308};
        public Form1()
        {
            InitializeComponent();
        }
        public Color setCor(int r, int g, int b)
        {
            return Color.FromArgb(r, g, b);
        }
        public Pen setCaneta(Color cor, int esp)
        {
            Pen caneta = new Pen(cor, esp);
            return caneta;
        }
        public SolidBrush DefinirFundo(Color cor)
        {
            return new SolidBrush(cor);
        }
        public Point[] formaGeometrica(PaintEventArgs e, Pen cor, int[] pontos, int scala)
        {
            Point[] p = new Point[pontos_iso.Length];
            int cont = 0;
            for (int i = 0; i <= pontos.Length - 1; i += 4)
            {
                PrintLinha(
                e, cor,
                (pontos[i]) * scala,
                (pontos[i + 1]) * scala,
                (pontos[i + 2]) * scala,
                (pontos[i + 3]) * scala
                );
                Point point1 = new Point(pontos[i], pontos[i+1]);
                p[cont] = point1;
                point1 = new Point(pontos[i + 2], pontos[i + 3]);
                p[cont + 1] = point1;
                cont += 2;
            }

            return p;
        }
        /*public Point[] definirPontos(int[] x, int[] y)
        {
            Point[] p = new Point[x.Length];
            for (int i = 0; i <= x.Length - 1; i++)
            {
                Point point1 = new Point(x[i], y[i]);
                p[i] = point1;
            }
            return p;
        }
        public Point[] DefinirXY(int[] pontos)
        {
            int[] x = new int[pontos.Length / 2];
            int[] y = new int[pontos.Length / 2];
            int c = 0;
            for (int i = 0; i <= (pontos.Length / 2) - 1; i++)
            {
                x[i] = pontos[c];
                y[i] = pontos[c + 1];
                c += 2;
            }
            return definirPontos(x, y);
        }*/
        public void formaGeometricaFundo(PaintEventArgs e, Pen cor, Point[] pontos, SolidBrush corfundo, int scala)
        {
            e.Graphics.FillPolygon(corfundo, pontos);
        }
        public void PrintPoligono(PaintEventArgs e, Point[] pontos, Pen caneta)
        {
            e.Graphics.DrawPolygon(caneta, pontos);
        }
        public void PrintLinha(PaintEventArgs e, Pen c, int x, int y, int x1, int y1)
        {
            e.Graphics.DrawLine(c, x, y, x1, y1);
        }


        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color cor = setCor(255, 0, 0);
            Pen caneta = setCaneta(cor, 2);

            Point[] ponts = formaGeometrica(e, caneta, pontos_iso, scala1);

            SolidBrush fundo = DefinirFundo(cor);
            formaGeometricaFundo(e, caneta, ponts, fundo, scala1);

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            scala1 = trackBar1.Value;
            Invalidate();
        }
    }
}
