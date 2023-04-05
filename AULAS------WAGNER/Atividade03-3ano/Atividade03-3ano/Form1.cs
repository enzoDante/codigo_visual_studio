/** Colegio Técnico Antônio Teixeira Fernandes (Univap)
 * Curso Técnico em Informática - Data de Entrega: 06/04/2023
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

namespace Atividade03_3ano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] xy = { 0, 0, 0, 0 };
        int i = 0;
        Boolean ativa = false;

        public Color setCor(int r, int g, int b)
        {
            return Color.FromArgb(r, g, b);
        }
        public Pen setCaneta(Color cor, int esp)
        {
            Pen caneta = new Pen(cor, esp);
            return caneta;
        }
        public void PrintLinha(PaintEventArgs e, int x, int y, int x1, int y1, Pen c)
        {
            e.Graphics.DrawLine(c, x, y, x1, y1);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (ativa)
            {
                Color cor = setCor(0, 0, 0);
                Pen caneta = setCaneta(cor, 3);
                PrintLinha(e, xy[0], xy[1], xy[2], xy[3], caneta);
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(i == 0)
            {
                xy[0] = e.X;
                xy[1] = e.Y;
                i++;
            }
            else
            {
                xy[2] = e.X;
                xy[3] = e.Y;
                ativa = true;
                i--;
                Invalidate();
            }
        }
    }
}
