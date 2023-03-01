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

        public void PrintPont(PaintEventArgs e, int x, int y, Pen c)
        {
            e.Graphics.DrawLine(c, x, y, x + 1, y);
        }
        public void linha(PaintEventArgs e, int x, int y, Pen c)
        {
            for(int i = 1; i <= 100; i++)
            {
                PrintPont(e, x + i, y, c);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen c = SetCor(255, 0, 0);
            PrintPont(e, 200, 100, c);
            //linha(e, 100, 100, c);
        }
    }
}
