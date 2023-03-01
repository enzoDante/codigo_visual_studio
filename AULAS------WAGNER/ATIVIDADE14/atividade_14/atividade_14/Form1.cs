/* *******************************************************************
* Colegio Técnico Antônio Teixeira Fernandes (Univap)
* Curso Técnico em Informática - Data de Entrega: DD/MM/2020
* Autores do Projeto: Enzo Dante Mícoli
* 
* Turma: 2H
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
using MySql.Data.MySqlClient;

namespace atividade_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string database = "SERVER = localhost; DATABASE = visuals_atv14; UID = root; PASSWORD =;";

            MySqlConnection connection = new MySqlConnection(database);
            connection.Open();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "select * from nomes";
            MySqlDataReader Query = command.ExecuteReader();

            string nome, novonome="";
            string[] nomes;
            while (Query.Read())
            {
                nome = Query.GetString("nome");
                nomes = nome.Split(' ');
                foreach(string i in nomes)
                {
                    novonome +=  " "+i.Substring(0,1).ToUpper()+i.Substring(1, i.Length - 1);
                }


                listBox1.Items.Add(novonome);
                novonome = "";
            }

            connection.Close();

        }
    }
}
