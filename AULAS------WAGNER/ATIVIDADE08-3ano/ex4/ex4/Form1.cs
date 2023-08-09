/* Colegio Técnico Antônio Teixeira Fernandes (Univap)
 * Curso Técnico em Informática - Data de Entrega: DD/MM/2020
 * Autores do Projeto: Enzo Dante Micoli
 *   
 * Turma: 3H
 * Atividade Proposta em aula exercicio 4
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

namespace ex4
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
        public void PrintCirculo(PaintEventArgs e, int x, int y, int raio, Pen c)
        {
            e.Graphics.DrawEllipse(c, x, y, raio, raio);
        }
        public void preencheCirculo(PaintEventArgs e, TextureBrush fundo, int x, int y, int raio)
        {
            e.Graphics.FillEllipse(fundo, x, y, raio, raio);
        }

        public TextureBrush textura(String caminho)
        {            
            return new TextureBrush(new Bitmap(caminho));
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int[] circulo = { 50, 50, 700 };

            Color cor = setCor(0, 255, 0);
            Pen caneta = setPen(cor, 3);

            TextureBrush textur = textura(@"C:\Users\Usuario\Imagens\teste.png");

            PrintCirculo(e, circulo[0], circulo[1], circulo[2], caneta);
            preencheCirculo(e, textur, circulo[0], circulo[1], circulo[2]);
        }
    }
}
