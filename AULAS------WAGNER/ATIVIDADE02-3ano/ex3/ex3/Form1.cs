/**Colegio Técnico Antônio Teixeira Fernandes (Univap)
 *Curso Técnico em Informática - Data de Entrega: 07 / 04 / 2023
* Autores do Projeto: Enzo Dante Micoli
*
* Turma: 2M
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

namespace ex3
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
        public void PrintRetangulo(PaintEventArgs e, int x, int y, int x1, int y1, Pen c)
        {
            PrintLinha(e, x, y, x, y1, c);
            PrintLinha(e, x, y, x1, y, c);

            PrintLinha(e, x1, y1, x1, y, c);
            PrintLinha(e, x1, y1, x, y1, c);

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen caneta = setCor(0, 0, 0);
            PrintRetangulo(e, -70, 0, 70, 80, caneta);
        }
    }
}
