using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste_fazer_ponto_na_tela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public Pen SetCor(int r, int g, int b)
        {
            Color cor = Color.FromArgb(r, g, b);
            Pen caneta = new Pen(cor, 0);
            return caneta;
        }
        public void PrintLinha(PaintEventArgs e, int x0, int y0, int x1, int y1, Pen caneta)
        {
            int dx = x1 - x0;
            int dy = y1 - y0;
            int x = x0;
            int y = y0;
            int s = 0;

            if (dx > dy)
                s = dx;
            else
                s = dy;
            x1 = dx / s;
            y1 = dy / s;

            PrintPont(e, x, y, caneta);
            for(int i = 0; i <= s; i++)
            {
                x += x1;
                y += y1;
                PrintPont(e, x, y, caneta);
            }
        }

        public void PrintPont(PaintEventArgs e, int x, int y, Pen c)
        {
            e.Graphics.DrawLine(c, x, y, x + 1, y);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen c = SetCor(255, 0, 0);
            PrintLinha(e, 100, 200, 300, 400, c);
            //PrintPont(e, 200, 100, c);
        }
    }
}
