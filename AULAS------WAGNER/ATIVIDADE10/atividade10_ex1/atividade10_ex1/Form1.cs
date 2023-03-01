/* *******************************************************************
 * Colegio Técnico Antônio Teixeira Fernandes (Univap)
 * Curso Técnico em Informática - Data de Entrega: 08/08/2022
 * Autores do Projeto: Enzo Dante Mícoli
 *                     
 * Turma: 2h
 * Atividade Proposta em aula
 * Observação: <colocar se houver>
 * 
 * problema_aula.cs
 * ************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade10_ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text.ToLower();
            texto = texto.Trim();
            string resultado = texto.Substring(0, 1).ToUpper() + texto.Substring(1, texto.Length-1);
            textBox1.Text = resultado;
        }
    }
}
