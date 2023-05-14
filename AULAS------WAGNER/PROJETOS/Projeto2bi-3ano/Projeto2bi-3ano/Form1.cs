using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projeto2bi_3ano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Boolean pintar = false, segundoClique = false, marcarCoordenada = false;
        int todosPontosCoordenadasCont = 0;
        int[,] coordenadas;
        int[] coordenadasAtuais = new int[10]; //{ 0, 0, 0, 0 }
        int[,] configDesenha = new int[3,3];
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

        //salvar todos os pontos, cores, etc
        public void SaveArquivo()
        {
            File.AppendAllText(@"D:\codigo_visual_studio\AULAS------WAGNER\PROJETOS\arquivos\hm2.txt", caneta + Environment.NewLine);
            /*int i = 0;
            for(int l = 0; l <= 2+GetTipo(); l++)
            {
                if(i >= 0 && i <= 2)
                {
                    coordenadas[todosPontosCoordenadasCont, l] = configDesenha[i, 0];
                }
                coordenadas[todosPontosCoordenadasCont, l] = coordenadasAtuais[l];
            }
            
            todosPontosCoordenadasCont++;*/
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
            caneta = setPen(cor, espessura);
            MessageBox.Show("preto");
        }
        //cinza
        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("cinza");
            cor = setCor(190, 190, 190);
            caneta = setPen(cor, espessura);
        }
        // vermelho escuro
        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("dark red");
        }
        //vermelho
        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("red");
            cor = setCor(255, 0, 0);
            caneta = setPen(cor, espessura);
        }
        //laranja
        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("laranja");
            cor = setCor(255, 165, 0);
            caneta = setPen(cor, espessura);
        }
        //amarelo
        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("marelo");
        }
        //verde escuro
        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("verde escuro");
        }
        //branco
        private void button8_Click(object sender, EventArgs e)
        {

        }
        //cinza escuro
        private void button10_Click(object sender, EventArgs e)
        {

        }
        //marrom
        private void button19_Click(object sender, EventArgs e)
        {
            cor = setCor(165, 42, 42);
            caneta = setPen(cor, espessura);
        }
        //rosa
        private void button20_Click(object sender, EventArgs e)
        {
            cor = setCor(255, 192, 203);
            caneta = setPen(cor, espessura);
        }
        //dourado
        private void button21_Click(object sender, EventArgs e)
        {

        }
        //amarelo claro
        private void button22_Click(object sender, EventArgs e)
        {

        }
        //verde lima
        private void button23_Click(object sender, EventArgs e)
        {

        }
        //turquoise
        private void button24_Click(object sender, EventArgs e)
        {

        }
        //slate gray
        private void button25_Click(object sender, EventArgs e)
        {

        }
        //Thistle
        private void button26_Click(object sender, EventArgs e)
        {

        }

        //azul
        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("azul");
            cor = setCor(0, 0, 255);
            caneta = setPen(cor, espessura);
        }
        //azul escuro
        private void button17_Click(object sender, EventArgs e)
        {
            MessageBox.Show("azul escuro");
        }
        //roxo
        private void button18_Click(object sender, EventArgs e)
        {
            MessageBox.Show("roxo");
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
                //SaveArquivo();
                pintar = false;
                segundoClique = false;
                ContcoordenadasC = 0;
                pontosClicados = 0;
            }

        }
    }
}
