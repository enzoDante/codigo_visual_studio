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
        Boolean pintar = false, segundoClique = false, marcarCoordenada = false, desenhosIniciais = true;
        int todosPontosCoordenadasCont = 0;
        int[,] coordenadas;
        int[] coordenadasAtuais = new int[10]; //{ 0, 0, 0, 0 }
        int[,] configDesenha = new int[3, 3];
        float[] flinha = new float[1] { 1 };
        float raio = 0, larg = 0, alt = 0;
        int espessura = 1, tipoForma = 0, ContcoordenadasC = 0, pontosClicados = 0;
        String corLinha = "0 0 0", tipoFLinha = "1";
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
            if(tipoForma == 2)
            {
                raio = float.Parse(textBox1.Text);
                e.Graphics.DrawEllipse(c, x[0], x[1], raio, raio);
            }                
            else
            {
                larg = float.Parse(textBox3.Text);
                alt = float.Parse(textBox2.Text);
                e.Graphics.DrawEllipse(c, x[0], x[1], larg, alt);
            }
            
        }
        public void PrintRetangulo(PaintEventArgs e, int[] x, Pen c)
        {
            //e.Graphics.DrawRectangle(c, x[0], x[1], x[2], x[3]);
            /*int aux = 0, aux2 = 2;
            for (int i = 0; i <= 3; i++)
            {
                PrintLinha(e, x[aux], x[aux + 1], x[aux2], x[aux + 1], c);
                aux += 2;
                aux2 += 2;
                if (aux2 == 4)
                {
                    aux2 = 0;
                }                    
            }*/
            PrintLinha(e, x[0], x[1], x[0], x[3], c);
            PrintLinha(e, x[0], x[1], x[2], x[1], c);

            PrintLinha(e, x[2], x[3], x[0], x[3], c);
            PrintLinha(e, x[2], x[3], x[2], x[1], c);
        }
        public void PrintTriangulo(PaintEventArgs e, int[] x, Pen c)
        {
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
            //D:\codigo_visual_studio\AULAS------WAGNER\PROJETOS\arquivos\hm2.txt
            //D:\codigo_visual_studio\AULAS------WAGNER\TESTES\ARQUIVOS
            //C:\Users\aluno\Documents\texto.txt
            File.AppendAllText(@"D:\codigo_visual_studio\AULAS------WAGNER\TESTES\ARQUIVOS\texto.txt", corLinha + " " + espessura + " " + tipoFLinha + " " + tipoForma + " ");

            for (int i = 0; i <= GetTipo() * 2 - 1; i++)
            {
                File.AppendAllText(@"D:\codigo_visual_studio\AULAS------WAGNER\TESTES\ARQUIVOS\texto.txt", coordenadasAtuais[i] + " ");
            }
            if (tipoForma == 2)
                File.AppendAllText(@"D:\codigo_visual_studio\AULAS------WAGNER\TESTES\ARQUIVOS\texto.txt", raio + " ");
            else if (tipoForma == 3)
                File.AppendAllText(@"D:\codigo_visual_studio\AULAS------WAGNER\TESTES\ARQUIVOS\texto.txt", larg + " " + alt + " ");
            File.AppendAllText(@"D:\codigo_visual_studio\AULAS------WAGNER\TESTES\ARQUIVOS\texto.txt", "" + Environment.NewLine);

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
            corLinha = "0 0 0";
            caneta = setPen(cor, espessura);
            caneta.DashPattern = flinha;
        }
        //cinza
        private void button9_Click(object sender, EventArgs e)
        {
            cor = setCor(190, 190, 190);
            corLinha = "190 190 190";
            caneta = setPen(cor, espessura);
            caneta.DashPattern = flinha;
        }
        // vermelho escuro
        private void button11_Click(object sender, EventArgs e)
        {
            cor = setCor(139, 0, 0);
            corLinha = "139 0 0";
            caneta = setPen(cor, espessura);
            caneta.DashPattern = flinha;
        }
        //vermelho
        private void button12_Click(object sender, EventArgs e)
        {
            cor = setCor(255, 0, 0);
            corLinha = "255 0 0";
            caneta = setPen(cor, espessura);
            caneta.DashPattern = flinha;
        }
        //laranja
        private void button13_Click(object sender, EventArgs e)
        {
            cor = setCor(255, 165, 0);
            corLinha = "255 165 0";
            caneta = setPen(cor, espessura);
            caneta.DashPattern = flinha;
        }
        //amarelo
        private void button14_Click(object sender, EventArgs e)
        {
            cor = setCor(255, 255, 0);
            corLinha = "255 255 0";
            caneta = setPen(cor, espessura);
            caneta.DashPattern = flinha;
        }
        //verde escuro
        private void button15_Click(object sender, EventArgs e)
        {
            cor = setCor(0, 100, 0);
            corLinha = "0 100 0";
            caneta = setPen(cor, espessura);
            caneta.DashPattern = flinha;
        }
        //branco
        private void button8_Click(object sender, EventArgs e)
        {
            cor = setCor(255, 255, 255);
            corLinha = "255 255 255";
            caneta = setPen(cor, espessura);
            caneta.DashPattern = flinha;
        }
        //cinza escuro
        private void button10_Click(object sender, EventArgs e)
        {
            cor = setCor(128, 128, 128);
            corLinha = "128 128 128";
            caneta = setPen(cor, espessura);
            caneta.DashPattern = flinha;
        }
        //marrom
        private void button19_Click(object sender, EventArgs e)
        {
            cor = setCor(165, 42, 42);
            corLinha = "165 42 42";
            caneta = setPen(cor, espessura);
            caneta.DashPattern = flinha;
        }
        //rosa
        private void button20_Click(object sender, EventArgs e)
        {
            cor = setCor(255, 192, 203);
            corLinha = "255 192 203";
            caneta = setPen(cor, espessura);
            caneta.DashPattern = flinha;
        }
        //dourado
        private void button21_Click(object sender, EventArgs e)
        {
            cor = setCor(207, 181, 59);
            corLinha = "207 181 59";
            caneta = setPen(cor, espessura);
            caneta.DashPattern = flinha;
        }
        //amarelo claro
        private void button22_Click(object sender, EventArgs e)
        {
            cor = setCor(255, 255, 224);
            corLinha = "255 255 224";
            caneta = setPen(cor, espessura);
            caneta.DashPattern = flinha;
        }
        //verde lima
        private void button23_Click(object sender, EventArgs e)
        {
            cor = setCor(50, 205, 50);
            corLinha = "50 205 50";
            caneta = setPen(cor, espessura);
            caneta.DashPattern = flinha;
        }
        //turquoise
        private void button24_Click(object sender, EventArgs e)
        {
            cor = setCor(64, 224, 208);
            corLinha = "64 224 208";
            caneta = setPen(cor, espessura);
            caneta.DashPattern = flinha;
        }
        //slate gray
        private void button25_Click(object sender, EventArgs e)
        {
            cor = setCor(112, 128, 144);
            corLinha = "112 128 144";
            caneta = setPen(cor, espessura);
            caneta.DashPattern = flinha;
        }
        //Thistle
        private void button26_Click(object sender, EventArgs e)
        {
            cor = setCor(216, 191, 216);
            corLinha = "216 191 216";
            caneta = setPen(cor, espessura);
            caneta.DashPattern = flinha;
        }
        //azul
        private void button16_Click(object sender, EventArgs e)
        {
            cor = setCor(0, 0, 255);
            corLinha = "0 0 255";
            caneta = setPen(cor, espessura);
            caneta.DashPattern = flinha;
        }
        //azul escuro
        private void button17_Click(object sender, EventArgs e)
        {
            cor = setCor(0, 0, 139);
            corLinha = "0 0 139";
            caneta = setPen(cor, espessura);
            caneta.DashPattern = flinha;
        }
        //roxo
        private void button18_Click(object sender, EventArgs e)
        {
            cor = setCor(153, 51, 153);
            corLinha = "153 51 153";
            caneta = setPen(cor, espessura);
            caneta.DashPattern = flinha;
        }
        //========================================================
        public void estiloLinhaForma(String valorTipo)
        {
            switch (int.Parse(valorTipo))
            {
                case 1:
                    flinha = new float[1] { 1 };
                    tipoFLinha = "1";
                    break;
                case 2:
                    flinha = new float[2] { 5, 2 };
                    tipoFLinha = "2";
                    break;
                case 3:
                    flinha = new float[2] { 1, 2 };
                    tipoFLinha = "3";
                    break;
                case 4:
                    flinha = new float[4] { 5, 2, 1, 2 };
                    tipoFLinha = "4";
                    break;
                case 5:
                    flinha = new float[6] { 5, 2, 1, 2, 1, 2 };
                    tipoFLinha = "5";
                    break;
            }
            caneta.DashPattern = flinha;
        }
        //combo box tipos de linha
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valorCombo = int.Parse(comboBox2.SelectedItem.ToString());
            estiloLinhaForma(valorCombo.ToString());
        }
        //combo box espessura
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valorCombo = int.Parse(comboBox1.SelectedItem.ToString());
            espessura = valorCombo * 2;
            caneta = setPen(cor, espessura);
            caneta.DashPattern = flinha;
        }
        //verificar total de cliques
        public void validarInvalidate()
        {
            if (pontosClicados == GetTipo())
            {
                pintar = true;
                Invalidate();
            }
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

                validarInvalidate();
                segundoClique = true;
                //MessageBox.Show(coordenadasAtuais[0].ToString());
            }
            else if(tipoForma != 0 && pintar == false && marcarCoordenada)
            {
                pontosClicados++;
                coordenadasAtuais[ContcoordenadasC] = e.X;
                coordenadasAtuais[ContcoordenadasC+1] = e.Y;
                validarInvalidate();
                ContcoordenadasC += 2;                
            }
        }

        //==========================
        public void desenharFormas(PaintEventArgs e)
        {
            switch (tipoForma)
            {
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
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {


            if(tipoForma != 0 && pintar)
            {
                desenharFormas(e);
                SaveArquivo();
                pintar = false;
                segundoClique = false;
                ContcoordenadasC = 0;
                pontosClicados = 0;
                GerarFormas(e);
            }
            else if (desenhosIniciais)
            {
                GerarFormas(e);
                desenhosIniciais = false;
            }

        }
        public void GerarFormas(PaintEventArgs e)
        {
            //cor espessura, tipolinha tipoForma, coordenadas (raio/larg e alt)
            //D:\codigo_visual_studio\AULAS------WAGNER\TESTES\ARQUIVOS
            //C:\Users\aluno\Documents\texto.txt
            string[] ler = File.ReadAllLines(@"D:\codigo_visual_studio\AULAS------WAGNER\TESTES\ARQUIVOS\texto.txt");
            foreach (string x in ler)
            {
                //textBox4.AppendText(x + Environment.NewLine);
                String[] desenhos = x.Split(' ');

                //textBox4.AppendText(desenhos[0]+" "+ desenhos[1] + " " + desenhos[2] + " " + desenhos[3] + " " + desenhos[4] + " " + desenhos[5] + " " + desenhos[6] + Environment.NewLine

                cor = setCor(int.Parse(desenhos[0]), int.Parse(desenhos[1]), int.Parse(desenhos[2]));
                caneta = setPen(cor, int.Parse(desenhos[3]));
                //desenho[4] dashpattern!!!
                estiloLinhaForma(desenhos[4]);

                tipoForma = int.Parse(desenhos[5]);
                if (tipoForma == 2)
                {
                    raio = int.Parse(desenhos[8]);
                    textBox1.Text = raio.ToString();
                }
                else if (tipoForma == 3)
                {
                    larg = int.Parse(desenhos[8]);
                    alt = int.Parse(desenhos[9]);
                    textBox2.Text = alt.ToString();
                    textBox3.Text = larg.ToString();
                }

                for (int i = 0; i <= GetTipo() * 2 - 1; i++)
                {
                    coordenadasAtuais[i] = int.Parse(desenhos[i + 6]);
                    //textBox4.AppendText(coordenadasAtuais[i] + Environment.NewLine);
                }

                desenharFormas(e);
            }
        }
    }
}
