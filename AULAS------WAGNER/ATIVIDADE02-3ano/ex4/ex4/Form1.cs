/**Colegio Técnico Antônio Teixeira Fernandes (Univap)
 *Curso Técnico em Informática - Data de Entrega: 07 / 04 / 2023
* Autores do Projeto: Enzo Dante Micoli
*
* Turma: 3H
* Atividade Proposta em aula
 * Observação:
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

namespace ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Pen setCor(int r, int g, int b)
        {
            Color cor = Color.FromArgb(r, g, b);
            Pen caneta = new Pen(cor, 3);
            return caneta;
        }

        public void PrintLinha(PaintEventArgs e, int x, int y, int x1, int y1, Pen c)
        {
            e.Graphics.DrawLine(c, 960 + x, 540 - y, 960 + x1, 540 - y1);
        }
        public void PrintTriangulo(PaintEventArgs e, int x, int y, int x1, int y1, int x2, int y2, Pen c)
        {
            PrintLinha(e, x, y, x1, y1, c);
            PrintLinha(e, x1, y1, x2, y2, c);
        }
        public void PrintPentagono(PaintEventArgs e, int[] pontos, Pen c)
        {
            int i1 = 0, i2 = 2;
            for(int i = 0; i <= 4; i++)
            {
                PrintLinha(e, pontos[i1], pontos[i1 + 1], pontos[i2], pontos[i2 + 1], c);
                i1 += 2;
                i2 += 2;
                if (i2 == 10)
                    i2 = 0;
            }
            //PrintTriangulo(e, pontos[0], pontos[1], pontos[2], pontos[3], pontos[4], pontos[5], c);
            //PrintTriangulo(e, pontos[4], pontos[5], pontos[6], pontos[7], pontos[8], pontos[9], c);
            //PrintLinha(e, pontos[8], pontos[9], pontos[0], pontos[1], c);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen caneta = setCor(0, 0, 0);
            int[] pontos = new int[10]{ -70, 0, 0, 50, 70, 0, 40, -50, -40, -50 };
            PrintPentagono(e, pontos, caneta);
        }
    }
}
