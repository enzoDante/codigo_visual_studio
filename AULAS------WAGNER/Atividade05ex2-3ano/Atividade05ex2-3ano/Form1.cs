/* Colegio Técnico Antônio Teixeira Fernandes (Univap)
 * Curso Técnico em Informática - Data de Entrega: 10/05/2023
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

namespace Atividade05ex2_3ano
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
        public void Pintap(PaintEventArgs e, int x, int y, Pen c)
        {
            e.Graphics.DrawLine(c, x, y, x + 1, y);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color cor = setCor(255, 0, 0);
            Pen caneta = setCaneta(cor, 4);

            double Xc = 200, Yc = 200, raiox = 60, raioy = 45;
            Pintap(e, (int)Xc, (int)Yc, caneta);
            int Ti = 0, Tf = 360;
            for (int angulo = Ti; angulo <= Tf; angulo++)
            {
                double x = Xc + raiox * Math.Cos(angulo * (Math.PI / 180));
                double y = Yc + raioy * Math.Sin(angulo * (Math.PI / 180));
                Pintap(e, (int)x, (int)y, caneta);
            }
        }
    }
}
