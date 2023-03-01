using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Text = "Parcela  1x";
        }
        double valorTotal;
        DateTime data;

        bool verificarvalor()
        {
            if((textBox1.Text == "") || (double.Parse(textBox1.Text) <= 0))
            {
                label3.Text = "Digite o preço";
                return false;
            }       
            else
                label3.Text = "";
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool verificar = verificarvalor();
            if (verificar)
            {
                valorTotal += double.Parse(textBox1.Text);
                textBox1.Text = "";
                label4.Text = string.Format("Total: {0:C2}",valorTotal);
            }



            DateTime x = DateTime.Now;
            data = dateTimePicker1.Value;
            //textBox3.AppendText(valorTotal+" teste "+data.ToString("dd/MM/yyyy")+Environment.NewLine);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (valorTotal != 0)
            {
                string dado = comboBox1.Text;
                textBox3.AppendText(" teste " + dado + Environment.NewLine);

                for(int i = 1; i <= 12; i++)
                {
                    //MessageBox.Show(listBox1.Items[i].ToString());
                    string parcelas = comboBox1.Items[i-1].ToString();
                    double parcelado = valorTotal / i;
                    textBox3.AppendText(string.Format("{0:C2}", parcelado) + " " + parcelas + Environment.NewLine);
                }


                valorTotal = 0;
                label4.Text = string.Format("Total: {0:C2}", valorTotal);
                //label6.Text = "";
            }
            //else
                //label6.Text = "Insira o preço!";
        }
    }
}
