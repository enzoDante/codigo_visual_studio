/* Colegio Técnico Antônio Teixeira Fernandes (Univap)
 * Curso Técnico em Informática - Data de Entrega: DD/MM/2020
 * Autores do Projeto: Enzo Dante Micoli
 *   
 * Turma: 3H
 * Atividade Proposta em aula exercicio 3
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
using System.Drawing.Drawing2D;

namespace ex3
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

        public HatchBrush rachura(PaintEventArgs e, HatchStyle tipo, Color cor, Color cor2)
        {
            return new HatchBrush(tipo, cor, cor2);
        }
        public HatchStyle tipoHashura(int t)
        {
            if (t == 1)
                return HatchStyle.DarkVertical;
            if (t == 2)
                return HatchStyle.BackwardDiagonal;
            if (t == 3)
                return HatchStyle.ForwardDiagonal;
            if (t == 4)
                return HatchStyle.Cross;
            if (t == 5)
                return HatchStyle.DiagonalCross;
            if (t == 6)
                return HatchStyle.Horizontal;
            if (t == 7)
                return HatchStyle.Vertical;

            return HatchStyle.SolidDiamond;

        }
        public void preencheRetangulo(PaintEventArgs e, HatchBrush fundo, int[] x)
        {
            e.Graphics.FillRectangle(fundo, x[0], x[1], x[2], x[3]);
        }
        public void PrintRetangulo(PaintEventArgs e, int[] x, Pen c)
        {
            // x y    largura    altura
            e.Graphics.DrawRectangle(c, x[0], x[1], x[2], x[3]);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int[] retangulo = { 100, 100, 200, 50 };

            Color cor = setCor(0, 0, 0);
            Color cor2 = setCor(128, 255, 255);
            Pen caneta = setPen(cor, 5);

            HatchStyle tipoHash = tipoHashura(5);
            HatchBrush rachadur = rachura(e, tipoHash, cor, cor2);

            PrintRetangulo(e, retangulo, caneta);
            preencheRetangulo(e, rachadur, retangulo);
        }
    }
}
