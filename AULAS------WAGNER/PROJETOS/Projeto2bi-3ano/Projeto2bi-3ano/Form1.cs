using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto2bi_3ano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Boolean pintar = false, segundoClique = false, marcarCoordenada = false;
        int[,] coordenadas;
        int[] coordenadasAtuais = new int[10]; //{ 0, 0, 0, 0 }
        int espessura = 1, tipoForma = 0, ContcoordenadasC = 0, pontosClicados = 0;
        Color cor = Color.FromArgb(0, 0, 0);
        Pen caneta = new Pen(Color.Black, 1);

        public Color setCor(int r, int g, int b)
        {
            return Color.FromArgb(r, g, b);
        }
        public Pen setPen(Color cor, int esp)
        {
            Pen caneta = new Pen(cor, esp);
            return caneta;
        }
        public void PrintLinha(PaintEventArgs e, int x, int y, int x1, int y1, Pen c)
        {
            e.Graphics.DrawLine(c, x, y, x1, y1);
        }
        public void PrintElipse(PaintEventArgs e, int[] x, Pen c)
        {
            //, int y, int larg, int alt
            e.Graphics.DrawEllipse(c, x[0], x[1], x[2], x[3]);
        }
        public void PrintRetangulo(PaintEventArgs e, int[] x, Pen c)
        {
            e.Graphics.DrawRectangle(c, x[0], x[1], x[2], x[3]);
        }
        public void PrintTriangulo(PaintEventArgs e, int[] x, Pen c)
        {
            //, int y, int x1, int y1, int x2, int y2
            // 0 1   2   3 |  2 3   4   5 |  0 1  4  5
            int aux = 0, aux2 = 2;
            for(int i = 0; i <= 2; i++)
            {
                PrintLinha(e, x[aux], x[aux+1], x[aux2], x[aux2 + 1], c);
                aux += 2;
                aux2 += 2;
                if (aux2 == 6)
                    aux2 = 0;
            }
            //PrintLinha(e, x[0], x[1], x[2], x[3], c);
            //PrintLinha(e, x[2], x[3], x[4], x[5], c);
            //PrintLinha(e, x[0], x[1], x[4], x[5], c);
        }
        public void PrintPentagono(PaintEventArgs e, int[] pontos, Pen c)
        {
            int i1 = 0, i2 = 2;
            for (int i = 0; i <= 4; i++)
            {
                PrintLinha(e, pontos[i1], pontos[i1 + 1], pontos[i2], pontos[i2 + 1], c);
                i1 += 2;
                i2 += 2;
                if (i2 == 10)
                    i2 = 0;
            }
        }
        public void PrintLosango(PaintEventArgs e, int[] pontos, Pen c)
        {
            int i1 = 0, i2 = 2;
            for (int i = 0; i <= 3; i++)
            {
                PrintLinha(e, pontos[i1], pontos[i1 + 1], pontos[i2], pontos[i2 + 1], c);
                i1 += 2;
                i2 += 2;
                if (i2 == 8)
                    i2 = 0;
            }
        }

        //verificar tipo forma
        public int GetTipo()
        {
            switch (tipoForma)
            {
                case 1:
                    return 2;
                    break;
                case 2:
                    return 1;
                    break;
                case 3:
                    return 1;
                    break;
                case 4:
                    return 2;
                    break;
                case 5:
                    return 3;
                    break;
                case 6:
                    return 4;
                    break;
                case 7:
                    return 5;
                    break;
            }
            return 0;
        }

        //linha
        private void button1_Click(object sender, EventArgs e)
        {
            tipoForma = 1;
            marcarCoordenada = true;
        }
        //circulo
        private void button2_Click(object sender, EventArgs e)
        {
            tipoForma = 2;
            marcarCoordenada = true;
        }
        //elipse
        private void button27_Click(object sender, EventArgs e)
        {
            tipoForma = 3;
            marcarCoordenada = true;
        }
        //retangulo
        private void button3_Click(object sender, EventArgs e)
        {
            tipoForma = 4;
            marcarCoordenada = true;
        }
        //triangulo
        private void button4_Click(object sender, EventArgs e)
        {
            tipoForma = 5;
            marcarCoordenada = true;
        }
        //losango
        private void button5_Click(object sender, EventArgs e)
        {
            tipoForma = 6;
            marcarCoordenada = true;
        }
        //pentagono
        private void button6_Click(object sender, EventArgs e)
        {
            tipoForma = 7;
            marcarCoordenada = true;
        }

        //========cores==============
        //preto
        private void button7_Click(object sender, EventArgs e)
        {
            cor = setCor(0, 0, 0);
            MessageBox.Show("preto");
        }


        //mouse pontos clicados
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(tipoForma != 0 && pintar == false && segundoClique == false && marcarCoordenada)
            {                
                coordenadasAtuais[0] = e.X;
                coordenadasAtuais[1] = e.Y;
                ContcoordenadasC = 2;
                pontosClicados++;
                segundoClique = true;
                //MessageBox.Show(coordenadasAtuais[0].ToString());
            }
            else if(tipoForma != 0 && pintar == false && marcarCoordenada)
            {
                pontosClicados++;
                coordenadasAtuais[ContcoordenadasC] = e.X;
                coordenadasAtuais[ContcoordenadasC+1] = e.Y;

                if (pontosClicados == GetTipo())
                {
                    pintar = true;
                    Invalidate();
                }
                ContcoordenadasC += 2;                
            }
        }

        //==========================
        private void Form1_Paint(object sender, PaintEventArgs e)
        {


            if(tipoForma != 0 && pintar)
            {
                switch (tipoForma){
                    case 1:
                        PrintLinha(e, coordenadasAtuais[0], coordenadasAtuais[1], coordenadasAtuais[2], coordenadasAtuais[3], caneta);
                        break;
                    case 2:
                        PrintElipse(e, coordenadasAtuais, caneta);
                        break;
                    case 3:
                        PrintElipse(e, coordenadasAtuais, caneta);
                        break;
                    case 4:
                        PrintRetangulo(e, coordenadasAtuais, caneta);
                        break;
                    case 5:
                        PrintTriangulo(e, coordenadasAtuais, caneta);
                        break;
                    case 6:
                        PrintLosango(e, coordenadasAtuais, caneta);
                        break;
                    case 7:
                        PrintPentagono(e, coordenadasAtuais, caneta);
                        break;
                }
                pintar = false;
                segundoClique = false;
                ContcoordenadasC = 0;
                pontosClicados = 0;
            }

        }
    }
}
