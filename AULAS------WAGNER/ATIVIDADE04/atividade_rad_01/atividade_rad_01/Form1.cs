using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade_rad_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*Enzo Dante Mícoli --- 2H
          ATIVIDADE 04
          Ex-01
        */

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("Números múltiplos de 4" + Environment.NewLine);
            int i = 0;
            do
            {
                if (i % 4 == 0)
                    textBox1.AppendText(i + Environment.NewLine);

                i++;
            } while (i < 200);
        }
    }
}
