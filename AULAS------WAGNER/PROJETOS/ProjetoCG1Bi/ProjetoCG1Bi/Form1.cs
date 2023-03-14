/*Colegio Técnico Antônio Teixeira Fernandes (Univap)
 *Curso Técnico em Informática - Data de Entrega: DD / MM / 2020
* Autores do Projeto: XXXXXXXXXXXXXXXXXXXXXXXXX
*
* Turma: 2M
* Atividade Proposta em aula
 * Observação: < colocar se houver>
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

namespace ProjetoCG1Bi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PaintEventArgs e1;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e1 = e;
        }
        public Pen SetCor(int r, int g, int b)
        {
            Color cor = Color.FromArgb(r, g, b);
            Pen caneta = new Pen(cor, 0);
            return caneta;
        }

        public void PrintPont(PaintEventArgs e, int x, int y, Pen c)
        {
            e1.Graphics.DrawLine(c, x, y, x + 1, y);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            Pen c = SetCor(255, 0, 0);
            PrintPont(e1, x, y, c);
        }
    }
}
