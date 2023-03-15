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
        Boolean apertouBtn = false;
        int x = 0, y= 0, x1 = 0, m = 0, b = 0;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen preto = SetCor(0, 0, 0);
            e.Graphics.DrawLine(preto, 900, 0, 900, 1600);
            e.Graphics.DrawLine(preto, 0, 600, 2000, 600);
            //PrintLinha(e, x, y, c);
            if (apertouBtn)
            {
                Pen c = SetCor(255, 0, 0);
                e.Graphics.DrawLine(c, 900+x, 600-y, 900+x1, ((x1*m)+b)-600 );
            }
        }
        public Pen SetCor(int r, int g, int b)
        {
            Color cor = Color.FromArgb(r, g, b);
            Pen caneta = new Pen(cor, 0);
            return caneta;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = int.Parse(textBox1.Text);
            y = int.Parse(textBox2.Text);
            x1 = int.Parse(textBox3.Text);
            m = int.Parse(textBox4.Text);
            b = int.Parse(textBox5.Text);

            apertouBtn = true;
            Invalidate();
            //Pen c = SetCor(255, 0, 0);
            //PrintPont(e, x, y, c);
        }
    }
}
