using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade_rad_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*Enzo Dante Mícoli --- 2H
          ATIVIDADE 04
          Ex-02
        */
        private void button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(textBox1.Text);
            int i = 1, aux = 1;

            while(i <= numero)
            {
                aux *= i;

                i++;
            }
            textBox2.AppendText("Fatorial de "+numero+" = " + aux + Environment.NewLine);
        }
    }
}
