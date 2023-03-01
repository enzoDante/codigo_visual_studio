using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto03_c_sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //quantidade de vezes q pode pagar a parcela
        int controlePagamentos=0;
        //se for verdadeiro, irá efetuar a baixa, se n, fará o pagamento da parcela 
        bool removerParcela = false;
        //preco inserido pelo usuario
        double preco;
        //preco calculado do total restante a ser pago das parcelas
        double precoRestante = 0;
        //data inserida pelo usuario, dia da compra
        DateTime dataCompra;
        //escolha do usuario de quantas vezes vai parcelar
        int parcela;
        //informacoes para a caixa de texto, com todos os dados das parcelas
        string[] linhasParcelas = new string[13];
        //dia na qual foi efetuado o pagamento da devida parcela (usuario selecionou uma data simulada)
        DateTime[] datasParcelas = new DateTime[13];
        
        bool precoVazio()
        {
            //valida o campo do preco digitado pelo usuario
            if ((textBox1.Text == "") || (double.Parse(textBox1.Text) <= 0))
            {
                label1.Text = "Informe o preço!";
                return false;
            }
            else
                label1.Text = "Preço e data da compra";
            return true;
        }
        bool parcelados()
        {
            //verifica qual parcela foi selecionada/valida se foi ou n selecionado
            for(int i = 0; i < 12; i++)
            {
                if (listBox1.GetSelected(i))
                {
                    label1.Text = "Preço e data da compra";
                    parcela = i + 1;
                    return true;
                }
            }
            label1.Text = "Selecione a parcela!";
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {//fazer a compra, ira inserir os dados(preco,dataCompra) efetuando a compra e permitindo a funcionalidade de outros botoes
            if (precoVazio() && parcelados() && controlePagamentos == 0)
            {
                textBox2.Text = "a";
                preco = double.Parse(textBox1.Text);
                //precoRestante iniciara com mesmo valor de preco, para mostrar o valor total q se falta pagar das parcelas
                precoRestante = preco;
                dataCompra = dateTimePicker1.Value;
                label3.Text = string.Format("Total: {0:C2}  ", preco);
                label3.Text += " Parcelado em " + parcela + " vezes";

                //inserindo as parcelas a ser pagas p o usuario visualizar
                for(int i = 0; i < parcela; i++)
                {
                    //data de vencimento de cada parcela
                    DateTime pagarParcela = dataCompra.AddMonths(i + 1);
                    datasParcelas[i] = pagarParcela;
                    linhasParcelas[i] = pagarParcela.ToString("dd/MM/yyyy") + " Data de pagamento da parcela" + string.Format(" {0:C2}",preco/parcela);
                    textBox2.AppendText(linhasParcelas[i] + " " + Environment.NewLine);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {//efetua o pagamento de determinada parcela
            if (precoVazio() && parcelados() && removerParcela == false && precoRestante > 0)
            {
                //valor simulado da data em q se pagou a parcela
                DateTime pagouParcela = dateTimePicker2.Value;
                removerParcela = true;
                //caso a data seja maior que a data do vencimento, ocorrera o reajuste do valor a ser pago
                if (datasParcelas[controlePagamentos] < pagouParcela)
                {
                    textBox2.Text = "";
                    label4.Text = "Parcela vencida!";
                    linhasParcelas[0] = dataCompra.AddMonths(controlePagamentos + 1).ToString("dd/MM/yyyy") + " Data de pagamento da parcela" + string.Format(" {0:C2}", (preco / parcela) * 1.03);
                    //atualiza os dados visuais para o usuario
                    for (int i = 0; i < parcela; i++)
                    {
                        textBox2.AppendText(linhasParcelas[i] + " " + Environment.NewLine);
                    }
                }
                else
                    label4.Text = "Pago!";
                //calcula o total q falta a se pagar no total das parcelas
                precoRestante = precoRestante - (preco/parcela);
                label3.Text = string.Format("Total: {0:C2}",precoRestante);
                //controle para indicar a parcela atual em que o usuario esta interagindo(no caso, esta pagando ou removendo)
                controlePagamentos++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {//remover a parcela (fazer baixa) caso tenha feito o pagamento o usuario deve fazer a baixa do mesmo
            if(linhasParcelas[0] != "" && removerParcela)
            {
                removerParcela = false;
                label4.Text = "";
                textBox2.Text = "";
                //remove a parcela em que foi paga
                for (int i = 0; i < parcela; i++)
                {
                    linhasParcelas[i] = linhasParcelas[i + 1];
                    textBox2.AppendText(linhasParcelas[i] + " " + Environment.NewLine);
                }
            }
            //caso o usuario tenha pago todas as parcelas, ele podera inserir outros valores de pagamento, recomecando o programa
            if(precoRestante <= 1)
                controlePagamentos = 0;
        }
    }
}
