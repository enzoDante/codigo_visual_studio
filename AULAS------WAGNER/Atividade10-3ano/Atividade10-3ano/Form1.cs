/* Colegio Técnico Antônio Teixeira Fernandes (Univap)
 * Curso Técnico em Informática - Data de Entrega: 09/08/2023
 * Autores do Projeto: Enzo Dante Micoli
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

namespace Atividade10_3ano
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
        public Pen setCaneta(Color cor, int esp)
        {
            Pen caneta = new Pen(cor, esp);
            return caneta;
        }        
        public Point[] definirPontos(int[] x, int[] y)
        {
            Point[] p = new Point[x.Length];
            for (int i = 0; i <= x.Length-1; i++)
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
        }
        public void PrintPoligono(PaintEventArgs e, Point[] pontos, Pen caneta)
        {
            e.Graphics.DrawPolygon(caneta, pontos);
        }
        public SolidBrush DefinirFundo(Color cor)
        {
            return new SolidBrush(cor);
        }
        public void PreencherPolig(PaintEventArgs e, Point[] pontos, SolidBrush fundo)
        {
            e.Graphics.FillPolygon(fundo, pontos);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int[] pontos_iso = { 278, 35, 76, 116,
                                 138, 176, 278, 35,
                                 357, 217, 138, 176,
                                 357, 218, 438, 190,
                                 438, 190, 278, 29,
                                  360,219 , 278, 35,
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

            Color cor = setCor(255, 0, 0);
            Pen caneta = setCaneta(cor, 2);

            Point[] pontos = DefinirXY(pontos_iso);
            PrintPoligono(e, pontos, caneta);

            SolidBrush fundo = DefinirFundo(cor);
            PreencherPolig(e, pontos, fundo);
        }
    }
}
