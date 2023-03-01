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

namespace criar_arquivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            //File.WriteAllText(@"D:\codigo_visual_studio\AULAS------WAGNER\TESTES\ARQUIVOS\hmm.txt", texto);
            File.AppendAllText(@"D:\codigo_visual_studio\AULAS------WAGNER\TESTES\ARQUIVOS\hm2.txt", texto+Environment.NewLine);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string ler = File.ReadAllText(@"D:\codigo_visual_studio\AULAS------WAGNER\TESTES\ARQUIVOS\hm2.txt");
            //textBox2.AppendText(ler);
            string[] ler = File.ReadAllLines(@"D:\codigo_visual_studio\AULAS------WAGNER\TESTES\ARQUIVOS\hm2.txt");
            foreach(string x in ler)
            {
                textBox2.AppendText(x+Environment.NewLine);
            }
        }
    }
}
