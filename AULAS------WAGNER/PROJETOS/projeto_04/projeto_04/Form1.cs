/* *******************************************************************
* Colegio Técnico Antônio Teixeira Fernandes (Univap)
* Curso Técnico em Informática - Data de Entrega: DD/MM/2020
* Autores do Projeto: Enzo Dante
*                     Samuel Pascoal
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
using System.IO;//necessário para mexer com arquivos, inclusive imagens

namespace projeto_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label7.Text = "";
        }
        //variáveis ligadas ao banco de dados
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader Query;
        //variáveis comuns
        string codigo="", cpf="", nome="", cidade="", bairro="", telefone="", imagem="", caminho = @"D:\codigo_visual_studio\AULAS------WAGNER\PROJETOS\projeto_04\imgs\";
        bool imageminserida = false;
        //-=================-=-=-=--==-=-=-=-=-alterar o caminho no dia do projeto!!!===========================
        //===============================================================================
        //botões para navegar entre os registros 
        //  ||< == primeiro registro
        private void button4_Click(object sender, EventArgs e)
        {
            banco();
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM usuarios ORDER BY codigo ASC";//ordem crescente dos registros e break para utilizar somente o primeiro registro
            Query = command.ExecuteReader();
            while (Query.Read())
            {
                textBox1.Text = Query.GetString("codigo");
                textBox2.Text = Query.GetString("cpf");
                textBox3.Text = Query.GetString("nome");
                textBox4.Text = Query.GetString("cidade");
                textBox5.Text = Query.GetString("bairro");
                textBox6.Text = Query.GetString("telefone");

                pictureBox1.Load(caminho + "img-perfil.png");//imagem padrão para caso registro não tenha uma imagem
                if (Query.GetString("imagem").Contains("."))//caso tenha um nome com extensão no banco, irá carregar a imagem
                    pictureBox1.Load(caminho +""+ Query.GetString("imagem"));
                break;
            }
            connection.Close();
        }

        // < == registro antecessor ao atual
        private void button6_Click(object sender, EventArgs e)
        {
            banco();
            if(textBox1.Text != "")
            {
                command = connection.CreateCommand();
                //ordem decrescente para que o primeiro codigo seja maior dentro todos, porém, menor que o atual
                command.CommandText = "SELECT * FROM usuarios WHERE codigo <"+textBox1.Text+" ORDER BY codigo DESC";
                Query = command.ExecuteReader();
                while (Query.Read())
                {
                    textBox1.Text = Query.GetString("codigo");
                    textBox2.Text = Query.GetString("cpf");
                    textBox3.Text = Query.GetString("nome");
                    textBox4.Text = Query.GetString("cidade");
                    textBox5.Text = Query.GetString("bairro");
                    textBox6.Text = Query.GetString("telefone");

                    pictureBox1.Load(caminho + "img-perfil.png");//imagem padrão para caso registro não tenha uma imagem
                    if (Query.GetString("imagem").Contains("."))
                        pictureBox1.Load(caminho + "" + Query.GetString("imagem"));
                    break;
                }

            }
            connection.Close();
        }

        // > == registro sucessor ao atual
        private void button5_Click(object sender, EventArgs e)
        {
            banco();
            if (textBox1.Text != "")
            {
                command = connection.CreateCommand();
                //ordem crescente para que o primeiro codigo seja menor dentro todos, porém, maior que o atual
                command.CommandText = "SELECT * FROM usuarios WHERE codigo >" + textBox1.Text + " ORDER BY codigo ASC";
                Query = command.ExecuteReader();
                while (Query.Read())
                {
                    textBox1.Text = Query.GetString("codigo");
                    textBox2.Text = Query.GetString("cpf");
                    textBox3.Text = Query.GetString("nome");
                    textBox4.Text = Query.GetString("cidade");
                    textBox5.Text = Query.GetString("bairro");
                    textBox6.Text = Query.GetString("telefone");

                    pictureBox1.Load(caminho + "img-perfil.png");//imagem padrão para caso registro não tenha uma imagem
                    if (Query.GetString("imagem").Contains("."))
                        pictureBox1.Load(caminho + "" + Query.GetString("imagem"));
                    break;
                }

            }
            connection.Close();
        }

        // >|| == último registro
        private void button3_Click(object sender, EventArgs e)
        {
            banco();
            command = connection.CreateCommand();
            //seleciona o último valor (maior codigo)
            command.CommandText = "SELECT * FROM usuarios ORDER BY codigo DESC";
            Query = command.ExecuteReader();
            while (Query.Read())
            {
                textBox1.Text = Query.GetString("codigo");
                textBox2.Text = Query.GetString("cpf");
                textBox3.Text = Query.GetString("nome");
                textBox4.Text = Query.GetString("cidade");
                textBox5.Text = Query.GetString("bairro");
                textBox6.Text = Query.GetString("telefone");

                pictureBox1.Load(caminho+ "img-perfil.png");//imagem padrão para caso registro não tenha uma imagem
                if(Query.GetString("imagem").Contains("."))
                    pictureBox1.Load(caminho + "" + Query.GetString("imagem"));
                break;
            }
            connection.Close();
        }

        //============ao digitar o codigo, deve mostrar os dados do usuario caso exista!!===========
        //caso não exista, deve deixar em branco os campos!!!
        private void button7_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                pictureBox1.Load(caminho + "img-perfil.png");

                banco();
                command = connection.CreateCommand();
                //seleciona registro onde o codigo é igual ao digitado pelo usuario
                command.CommandText = "SELECT * FROM usuarios WHERE codigo="+textBox1.Text;// +"ORDER BY codigo DESC"
                Query = command.ExecuteReader();
                while (Query.Read())
                {
                    textBox2.Text = Query.GetString("cpf");
                    textBox3.Text = Query.GetString("nome");
                    textBox4.Text = Query.GetString("cidade");
                    textBox5.Text = Query.GetString("bairro");
                    textBox6.Text = Query.GetString("telefone");
                    pictureBox1.Load(caminho + "img-perfil.png");//imagem padrão para caso registro não tenha uma imagem                    
                    if (Query.GetString("imagem").Contains("."))
                        pictureBox1.Load(caminho + "" + Query.GetString("imagem"));
                    break;
                }
                connection.Close();
            }
        }

        //====================================================================================================
        //permite carregar a imagem no picturebox
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }

        // inserir imagem e upload da mesma
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //escolha de uma imagem para o picture box
            openFileDialog1.Filter = "JPEG|*.JPG|PNG|*.PNG|JFIF|*.JFIF"; //extensões permitidas
            openFileDialog1.ShowDialog();//abrir o explorador de arquivos para a busca de uma imagem
            imageminserida = true;
        }

        //===============================================================================
        //conectar ao banco
        void banco()
        {
            string database = "SERVER = localhost; DATABASE = projeto4_visual; UID = root; PASSWORD =;";
            connection = new MySqlConnection(database);
            connection.Open();
        }
        //verificar registro existente
        //ao apertar o botão 'O' ou 'X', irá verificar se existe esse registro, então retornará true ou false
        bool registros(string cod)
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM usuarios WHERE codigo = "+cod;
            Query = command.ExecuteReader();
            if (Query.Read())
            {
                return true;
            }
            return false;
        }
        //transformação dos primeiros caracteres para maiusculo (nome, cidade, bairro)
        void transform()
        {
            //array para separar em string diferentes ['joao', 'da', 'silva']
            string[] nome_dividido = nome.Split(' ');
            string[] cidade_divdido = cidade.Split(' ');
            string[] bairro_dividido = bairro.Split(' ');

            string nnome = "", ncidade = "", nbairro = "";
            //novo nome
            foreach(string i in nome_dividido)
            {
                //caso o valor de i seja diferente de determinados caracteres
                //irá concatenar a 1º letra em maiuscula junto com o resto da string a partir do indice '1' que é o segundo indice
                if (i != "de" && i != "do" && i != "da" && i != "dos" && i != "das")
                    nnome += " " + i.Substring(0, 1).ToUpper() + i.Substring(1, i.Length - 1);
                else
                    nnome += " "+i;
            }
            textBox3.Text = nnome;
            //nova cidade
            foreach(string i in cidade_divdido)
            {
                if (i != "de" && i != "do" && i != "da" && i != "dos" && i != "das")
                    ncidade+= " " + i.Substring(0, 1).ToUpper() + i.Substring(1, i.Length - 1);
                else
                    ncidade += " " + i;
            }
            textBox4.Text = ncidade;
            //novo bairro
            foreach (string i in bairro_dividido)
            {
                if (i != "de" && i != "do" && i != "da" && i != "dos" && i != "das")
                    nbairro += " " + i.Substring(0, 1).ToUpper() + i.Substring(1, i.Length - 1);
                else
                    nbairro += " " + i;
            }
            textBox5.Text = nbairro;
            nome = nnome.Trim();
            cidade = ncidade.Trim();
            bairro = nbairro.Trim();

        }

        //adicionar ou atualizar registro=======================================
        private void button1_Click(object sender, EventArgs e)
        {
            //atribuindo valores de textbox e removendo espaços desnecessário
            codigo = textBox1.Text.Trim();
            cpf = textBox2.Text.Trim();
            cpf = cpf.Replace(".","").Replace("-", ""); //para caso esteja com a formatação, irá remove-la
            nome = textBox3.Text.Trim();
            cidade = textBox4.Text.Trim();
            bairro = textBox5.Text.Trim();
            telefone = textBox6.Text.Trim();
            if(codigo != "" && cpf != "" && nome != "" && cidade != "" && bairro != "" && telefone != "")
            {
                cpf = long.Parse(cpf).ToString(@"000\.000\.000\-00");//formatando cpf
                transform(); //chamando o procedimento para deixar as strings com as primeiras letras em maiusculas
                banco(); //conectando com o banco
                //função para verificar se registro existe, caso exista, irá apenas atualizar o registro, senão, irá inserir
                bool verificar = registros(codigo);
                Query.Close();

                //upload de imagem============
                //salvar imagem na pasta do programa
                if(pictureBox1.Image != null && imageminserida)//caso o picturebox não esteja vazio
                {
                    MessageBox.Show("teste2");
                    string extensao = Path.GetExtension(openFileDialog1.FileName);//extensão da imagem
                    DateTime hoje = DateTime.Now;//data atual
                    imagem = textBox1.Text + "_"+hoje.ToString("MM-dd-yyyy-mmss") + extensao;//nome gerado da imagem
                    

                    if(imagem.Contains(".") && imageminserida)//verificando se foi inserida uma imagem que contenha .
                    {
                        //string caminho2 = @"D:\codigo_visual_studio\AULAS------WAGNER\PROJETOS\projeto_04\imgs\" + imagem;
                        //salvando a imagem na pasta com outro nome
                        pictureBox1.Image.Save(caminho+""+imagem, pictureBox1.Image.RawFormat); //==============alterar o caminho no dia da apresentação!!!
                        imageminserida = false;
                    }
                }
                else               
                    imagem = "n";
                
                //inserindo registro inexistente
                if (!verificar)
                {
                    command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO usuarios (codigo, cpf, nome, cidade, bairro, telefone, imagem) VALUES("+codigo+",'"+cpf+"','"+nome+"','"+cidade+"','"+bairro+"','"+telefone+"','"+imagem+"')";
                    command.ExecuteReader();
                    //label7.Text = "Inserido com sucesso!";
                    MessageBox.Show("Inserido com sucesso!");
                }
                //atualizando registro existente
                else
                {
                    command = connection.CreateCommand();
                    string valores = "";
                    if (imagem != "n")
                        valores = "nome='" + nome + "',cpf='" + cpf + "',cidade='" + cidade + "',bairro='" + bairro + "',telefone='" + telefone + "',imagem='" + imagem + "'";
                    else
                        valores = "nome='" + nome + "',cpf='" + cpf + "',cidade='" + cidade + "',bairro='" + bairro + "',telefone='" + telefone + "'";
                    command.CommandText = "UPDATE usuarios set "+valores+" WHERE codigo=" + codigo;
                    command.ExecuteReader();
                    //label7.Text = "Atualizado com sucesso!";
                    MessageBox.Show("Atualizado com sucesso!");
                }
                
                connection.Close();
            }
            else
            {
                MessageBox.Show("Preenche todos os campos!!");
            }

        }

        //remover registro
        private void button2_Click(object sender, EventArgs e)
        {
            codigo = textBox1.Text;
            cpf = textBox2.Text;
            nome = textBox3.Text;
            cidade = textBox4.Text;
            bairro = textBox5.Text;
            telefone = textBox6.Text;

            if (codigo != "" && cpf != "" && nome != "" && cidade != "" && bairro != "" && telefone != "")
            {
                banco();//conectando ao banco
                //verifica se existe o registro no banco
                bool verificar = registros(codigo);
                Query.Close();
                //caso exista, irá remover da tabela
                if (verificar)
                {
                    command = connection.CreateCommand();
                    command.CommandText = "DELETE FROM usuarios WHERE codigo="+codigo;
                    command.ExecuteReader();
                    //label7.Text = "Removido com sucesso!";
                    MessageBox.Show("Removido com sucesso!");
                }
                else
                {
                    MessageBox.Show( "Não existe registro com esse código para ser removido!");
                }
                
                connection.Close();
            }

        } 
    }
}
