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

namespace ex2
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
        public void PrintEstrela(PaintEventArgs e, int[] pontos, Pen c)
        {
            int i1 = 0, i2 = 2, i3 = 4;
            for(int i = 0; i <= 4; i++)
            {
                PrintTriangulo(e, pontos[i1], pontos[i1+1], pontos[i2], pontos[i2+1], pontos[i3], pontos[i3+1], c);
                i1 += 4;
                i2 += 4;
                i3 += 4;
                if (i3 == 20)
                    i3 = 0;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen caneta = setCor(0, 0, 0);
            int[] pontos = new int[20] { -60, 0, 0, 80, 60, 0, 150, 0, 75, -60, 100, -140, 0, -90, -100, -140, -75, -60, -150, 0 };
            PrintEstrela(e, pontos, caneta);
        }
    }
}
