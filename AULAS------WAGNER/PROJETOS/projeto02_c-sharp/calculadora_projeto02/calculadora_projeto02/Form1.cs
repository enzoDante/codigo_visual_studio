/* *******************************************************************
* Colegio Técnico Antônio Teixeira Fernandes (Univap)
* Curso Técnico em Informática - Data de Entrega: 28/05/2022
* Autores do Projeto: Enzo Dante 50210203
*                     Samuel Pascoal 50210085
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

namespace calculadora_projeto02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double num1 = 0;
        double num2 = 0;
        string texxboc;
        int num1feito = 0;
        int operador = 0;
        int matematica = 0;
        int calculado = 0;
        int virgula1 = 0;
        string sinal = "";
        int operacao_especial = 0; //raiz qualquer número
        int operacao_especial2 = 0; // x elevado a y
        int operacao_especial3 = 0; // x mod y (resto de divisão)
        int valida_op_esp = 0;
        double num_especial = 0;
        private void button10_Click(object sender, EventArgs e)
        {//0
            if (calculado == 1)
            {
                textBox1.Text = "";
                texxboc = "";
                calculado = 0;
                virgula1 = 0;
                num1 = 0;
                num2 = 0;
            }
            textBox1.Text += '0';
            texxboc += '0';
        }

        private void button9_Click(object sender, EventArgs e)
        {//1
            if (calculado == 1)
            {
                textBox1.Text = "";
                texxboc = "";
                calculado = 0;
                virgula1 = 0;
                num1 = 0;
                num2 = 0;
            }
            textBox1.Text += '1';
            texxboc += '1';
        }

        private void button8_Click(object sender, EventArgs e)
        {//2
            if (calculado == 1)
            {
                textBox1.Text = "";
                texxboc = "";
                calculado = 0;
                virgula1 = 0;
                num1 = 0;
                num2 = 0;
            }
            textBox1.Text += '2';
            texxboc += '2';
        }

        private void button7_Click(object sender, EventArgs e)
        {//3
            if (calculado == 1)
            {
                textBox1.Text = "";
                texxboc = "";
                calculado = 0;
                virgula1 = 0;
                num1 = 0;
                num2 = 0;
            }
            textBox1.Text += '3';
            texxboc += '3';
        }

        private void button6_Click(object sender, EventArgs e)
        {//4
            if (calculado == 1)
            {
                textBox1.Text = "";
                texxboc = "";
                calculado = 0;
                virgula1 = 0;
                num1 = 0;
                num2 = 0;
            }
            textBox1.Text += '4';
            texxboc += '4';
        }

        private void button5_Click(object sender, EventArgs e)
        {//5
            if (calculado == 1)
            {
                textBox1.Text = "";
                texxboc = "";
                calculado = 0;
                virgula1 = 0;
                num1 = 0;
                num2 = 0;
            }
            textBox1.Text += '5';
            texxboc += '5';
        }

        private void button4_Click(object sender, EventArgs e)
        {//6
            if (calculado == 1)
            {
                textBox1.Text = "";
                texxboc = "";
                calculado = 0;
                virgula1 = 0;
                num1 = 0;
                num2 = 0;
            }
            textBox1.Text += '6';
            texxboc += '6';
        }

        private void button1_Click(object sender, EventArgs e)
        {//7
            if (calculado == 1)
            {
                textBox1.Text = "";
                texxboc = "";
                calculado = 0;
                virgula1 = 0;
                num1 = 0;
                num2 = 0;
            }
            textBox1.Text += '7';
            texxboc += '7';
        }

        private void button2_Click(object sender, EventArgs e)
        {//8
            if (calculado == 1)
            {
                textBox1.Text = "";
                texxboc = "";
                calculado = 0;
                virgula1 = 0;
                num1 = 0;
                num2 = 0;
            }
            textBox1.Text += '8';
            texxboc += '8';
        }

        private void button3_Click(object sender, EventArgs e)
        {//9
            if (calculado == 1)
            {
                textBox1.Text = "";
                texxboc = "";
                calculado = 0;
                virgula1 = 0;
                num1 = 0;
                num2 = 0;
            }
            textBox1.Text += '9';
            texxboc += '9';
        }

        public void Operacao_matematica()
        {
            if (textBox1.Text != ""){
                if ((operacao_especial >= 1) || (operacao_especial2 >= 1) || (operacao_especial3 >= 1))
                    calculos_especiais();                
                operador++;
                //=========se apertar = após uma operação e logo em seguita algum operador:====================
                if ((calculado == 1) && (operacao_especial == 0) && (operacao_especial2 == 0) && (operacao_especial3 == 0)){
                    num1 = Double.Parse(textBox1.Text);
                    calculado = 0;
                    switch (sinal)
                    {
                        case "+":
                            textBox1.Text += '+';
                            matematica = 1;
                            break;
                        case "-":
                            textBox1.Text += '-';
                            matematica = 2;
                            break;
                        case "*":
                            textBox1.Text += '*';
                            matematica = 3;
                            break;
                        case "/":
                            textBox1.Text += '/';
                            matematica = 4;
                            break;
                    }
                    texxboc = "";
                    num1feito = 1;
                    virgula1 = 0;
                    
                }
                else{
                    //============se não foi apertado = ==========================
                    if ((operador == 1) && (operacao_especial == 0) && (operacao_especial2 == 0) && (operacao_especial3 == 0)){                        
                        num1 = Double.Parse(texxboc);
                        //=============ainda não tem nenhum operador matemático (+, -, /, *)===================
                        switch (sinal)
                        {
                            case "+":
                                textBox1.Text += '+';
                                matematica = 1;
                                break;
                            case "-":
                                textBox1.Text += '-';
                                matematica = 2;
                                break;
                            case "*":
                                textBox1.Text += '*';
                                matematica = 3;
                                break;
                            case "/":
                                textBox1.Text += '/';
                                matematica = 4;
                                break;
                        }
                        texxboc = "";
                        num1feito = 1;
                    }
                    else{
                        //==========================================caso já exista alguma operação preste a ser efetuada=================
                        if ((operador >= 2) && (operacao_especial == 0) && (operacao_especial2 == 0) && (operacao_especial3 == 0)){
                            if (texxboc != ""){
                                num2 = Double.Parse(texxboc);
                                switch (matematica)
                                {
                                    case 1:
                                        double soma = num1 + num2;
                                        num1 = soma;
                                        texxboc = "";
                                        textBox1.Text = string.Format("{0:N}", soma);
                                        if (sinal == "-"){
                                            textBox1.Text += "-";
                                            matematica = 2;
                                        }
                                        else{
                                            if (sinal == "*"){
                                                textBox1.Text += "*";
                                                matematica = 3;
                                            }
                                            else if (sinal == "/"){
                                                textBox1.Text += "/";
                                                matematica = 4;
                                            }
                                            else
                                                textBox1.Text += "+";
                                        }
                                        break;
                                    case 2:
                                        double sub = num1 - num2;
                                        num1 = sub;
                                        texxboc = "";
                                        textBox1.Text = string.Format("{0:N}", sub);
                                        if (sinal == "+"){
                                            textBox1.Text += "+";
                                            matematica = 1;
                                        }
                                        else{
                                            if (sinal == "*") {
                                                textBox1.Text += "*";
                                                matematica = 3;
                                            }
                                            else if (sinal == "/"){
                                                textBox1.Text += "/";
                                                matematica = 4;
                                            }
                                            else
                                                textBox1.Text += "-";
                                        }
                                        break;
                                    case 3:
                                        double mult = num1 * num2;
                                        num1 = mult;
                                        texxboc = "";
                                        textBox1.Text = string.Format("{0:N}", mult);
                                        if (sinal == "+"){
                                            textBox1.Text += "+";
                                            matematica = 1;
                                        }
                                        else{
                                            if (sinal == "-"){
                                                textBox1.Text += "-";
                                                matematica = 2;
                                            }
                                            else if (sinal == "/"){
                                                textBox1.Text += "/";
                                                matematica = 4;
                                            }
                                            else
                                                textBox1.Text += "*";
                                        }
                                        break;
                                    case 4:
                                        double div = num1 / num2;
                                        num1 = div;
                                        texxboc = "";
                                        textBox1.Text = string.Format("{0:N}", div);
                                        if (sinal == "+"){
                                            textBox1.Text += "+";
                                            matematica = 1;
                                        }
                                        else{
                                            if (sinal == "-"){
                                                textBox1.Text += "-";
                                                matematica = 2;
                                            }
                                            else if (sinal == "*"){
                                                textBox1.Text += "*";
                                                matematica = 3;
                                            }
                                            else
                                                textBox1.Text += "/";
                                        }
                                        break;
                                }
                            }
                            //====se o usuario n digitou um número mas quer trocar o sinal exenp('2 +' e depois aperta '-' ent fica '2 -')
                            else{
                                string texto = num1.ToString();
                                switch (sinal)
                                {
                                    case "+":
                                        textBox1.Text = texto + '+';
                                        matematica = 1;
                                        break;
                                    case "-":
                                        textBox1.Text = texto + '-';
                                        matematica = 2;
                                        break;
                                    case "*":
                                        textBox1.Text = texto + '*';
                                        matematica = 3;
                                        break;
                                    case "/":
                                        textBox1.Text = texto + '/';
                                        matematica = 4;
                                        break;
                                }
                            }
                        }
                    }
                    if (virgula1 == 1)
                        virgula1 = 0;
                }          
            }
        }
        public void calculos_especiais()
        {
            if(texxboc != ""){
                if((operacao_especial >= 1) && (operacao_especial2 == 0) && (operacao_especial3 == 0)){
                    //=============raiz escolhida pelo usuário===================
                    if ((num1feito == 1) && (valida_op_esp != 1)){
                        //caso seja o primeiro número do usuário
                        double raiz = 0;
                        num_especial = Double.Parse(texxboc);
                        raiz = (Double)Math.Pow(num_especial, 1.0 / num1);
                        textBox1.Text = string.Format("{0:N}", raiz);
                        texxboc = raiz.ToString();
                        calculado = 1;
                        virgula1 = 1;
                        operacao_especial = 0;
                    }
                    else{
                        //caso seja o segundo número do usuario: 2 + '4raiz'
                        string texto = "";
                        num_especial = Double.Parse(texxboc);
                        num2 = (Double)Math.Pow(num_especial, 1.0 / num2);
                        texxboc = num2.ToString();
                        texto = num1.ToString() + sinal;
                        string texto2 = num2.ToString();
                        textBox1.Text = texto + texto2;
                        virgula1 = 1;
                        valida_op_esp = 0;
                        operacao_especial = 0;

                    }
                }
                else{
                    //=======numero elevado a outro numero escolhido pelo usuario==========
                    if((operacao_especial2 >= 1) && (operacao_especial3 == 0)){
                        if ((num1feito == 1) && (valida_op_esp != 1)){
                            //caso seja o primeiro número do usuário
                            double r = 0;
                            num_especial = Double.Parse(texxboc);
                            r = (Double)Math.Pow(num1, num_especial);
                            textBox1.Text = string.Format("{0:N}", r);
                            texxboc = r.ToString();
                            calculado = 1;
                            virgula1 = 1;
                            operacao_especial2 = 0;
                        }
                        else{
                            //caso seja o segundo número do usuario: 2 + '5^3'
                            string texto = "";
                            num_especial = Double.Parse(texxboc);
                            num2 = (Double)Math.Pow(num2, num_especial);
                            texxboc = num2.ToString();
                            texto = num1.ToString() + sinal;
                            string texto2 = num2.ToString();
                            textBox1.Text = texto + texto2;
                            virgula1 = 1;
                            valida_op_esp = 0;
                            operacao_especial2 = 0;

                        }
                    }
                    else{
                        if(operacao_especial3 >= 1){
                            //calcula resto de divisão de um número por outro número digitado pelo usuário!
                            if ((num1feito == 1) && (valida_op_esp != 1)){
                                //caso seja o primeiro número do usuário
                                double r = 0;
                                num_especial = Double.Parse(texxboc);
                                r = num1 % num_especial;
                                textBox1.Text = string.Format("{0:N}", r);
                                texxboc = r.ToString();
                                calculado = 1;
                                virgula1 = 1;
                                operacao_especial3 = 0;
                            }
                            else{
                                //caso seja o segundo número do usuario: 2 + '4 mod 2'
                                string texto = "";
                                num_especial = Double.Parse(texxboc);
                                num2 = num2 % num_especial;
                                texxboc = num2.ToString();
                                texto = num1.ToString() + sinal;
                                string texto2 = num2.ToString();
                                textBox1.Text = texto + texto2;
                                virgula1 = 1;
                                valida_op_esp = 0;
                                operacao_especial3 = 0;

                            }
                        }
                    }
                }

            }
        }
        private void button12_Click(object sender, EventArgs e)
        {//+
            sinal = "+";
            Operacao_matematica();
        }

        private void button13_Click(object sender, EventArgs e)
        {//-            
            sinal = "-";
            Operacao_matematica();
        }

        private void button14_Click(object sender, EventArgs e)
        {//*
            sinal = "*";
            Operacao_matematica();
        }

        private void button15_Click(object sender, EventArgs e)
        {// /
            sinal = "/";
            Operacao_matematica();
        }

        private void button16_Click(object sender, EventArgs e)
        {// =
            calculos_especiais();
            if (operador >= 1){
                operador = 0;
                if(texxboc == ""){
                    num2 = num1;
                }
                else{
                    num2 = Double.Parse(texxboc);
                    texxboc = "";

                }
                if (matematica == 1){
                    double soma = num1 + num2;
                    textBox1.Text = string.Format("{0:N}", soma);//format para fazer a separação de milhar

                }
                else{
                    if (matematica == 2){
                        double sub = num1 - num2;
                        textBox1.Text = string.Format("{0:N}", sub);
                    }
                    else{
                        if (matematica == 3){
                            double mult = num1 * num2;
                            textBox1.Text = string.Format("{0:N}", mult);
                        }
                        else{
                            double divi = num1 / num2;
                            textBox1.Text = string.Format("{0:N}", divi);
                        }
                    }
                }
                num1 = Double.Parse(textBox1.Text);
                calculado = 1;
                matematica = 0;
                virgula1 = 0;
                operacao_especial = 0;
                operacao_especial2 = 0;
                operacao_especial3 = 0;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {// +/-
            if((textBox1.Text != "") && (operacao_especial == 0) && (operacao_especial2 == 0) && (operacao_especial3 == 0)){
                if (num1feito == 0){
                    num1 = Double.Parse(texxboc);
                    num1 = num1 * (-1);
                    texxboc = num1.ToString();
                    textBox1.Text = texxboc;
                }
                else{
                    if(texxboc != ""){
                        num2 = Double.Parse(texxboc);
                        num2 = num2 * (-1);

                        texxboc = num2.ToString();
                        string texto = num1.ToString();
                        string texto2 = "";
                        if (matematica == 3)
                            texto2 = "*" + texxboc;
                        else{
                            if (matematica == 4)
                                texto2 = "/" + texxboc;
                            else{
                                if (matematica == 1)
                                    texto2 = "+" + texxboc;
                                else{
                                    if (num2 <= 0){
                                        //caso o valor seja negativo, na verdade ele deve ser positivo, pois o sinal clicado pelo usuário é '-'
                                        double valor = num2 * (-1);
                                        texto2 = "+" + valor.ToString();
                                    }
                                    else
                                        texto2 = "-" + texxboc;
                                }
                                    
                            }
                                
                        }
                        //texto2 = "+" + texxboc;
                        textBox1.Text = texto + texto2;
                    }
                    
                }
            }
            
            
        }
        //===============Vírgula, somente uma vírgula para cada variável (num1 e num2)============
        private void button11_Click(object sender, EventArgs e)
        {// ,
            if(texxboc != ""){
                if(virgula1 == 0){
                    texxboc += ",";
                    textBox1.Text += ",";
                    virgula1++;
                }
                if(num1feito == 1){
                    if(virgula1 == 0){
                        texxboc += ",";
                        textBox1.Text += ",";
                        virgula1++;

                    }
                }
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {//limpa tela C (Limpa tudo da calculadora)
            textBox1.Text = "";
            texxboc = "";
            num1 = 0;
            num1feito = 0;
            num2 = 0;
            matematica = 0;
            calculado = 0;
            virgula1 = 0;
            operador = 0;
            operacao_especial = 0;
            sinal = "";
        }

        private void button22_Click(object sender, EventArgs e)
        {//limpa tela CE (Deixa somente um valor digitado antes da operação ou somente a resposta calculada!)
            if(textBox1.Text != "")
                textBox1.Text = num1.ToString() + sinal;
            if(calculado == 1)
            {
                textBox1.Text = "0";
            }

            //texxboc = num1.ToString();
            texxboc = "";
            //num1 = 0;
            //num1feito = 0;
            num2 = 0;
            //matematica = 0;
            //calculado = 1;
            virgula1 = 0;
            //operador = 0;
            operacao_especial = 0;
            //sinal = "";
        }

        private void button20_Click(object sender, EventArgs e)
        {// raiz quadrada
            if((textBox1.Text != "") && (operacao_especial == 0) && (operacao_especial2 == 0) && (operacao_especial3 == 0)){
                double raiz = 0;
                //============funciona como se fosse o botão '=' mas, calcula a raiz quadrada==========
                if (operador == 0){
                    num1 = Double.Parse(textBox1.Text);
                    raiz = (Double)Math.Sqrt(num1);
                    textBox1.Text = string.Format("{0:N}", raiz);
                    texxboc = raiz.ToString();
                    num1 = raiz;
                    calculado = 1;
                    virgula1 = 1;
                }
                else{
                    if(texxboc != ""){
                        //=========calcula raiz quadrada do segundo número da calculadora==========
                        num2 = Double.Parse(texxboc);
                        num2 = (Double)Math.Sqrt(num2);
                        texxboc = num2.ToString();
                        string texto = num1.ToString() + sinal;
                        string texto2 = num2.ToString();
                        textBox1.Text = texto + texto2;
                        virgula1 = 1;
                    }
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {// 1/x
            //float resp = 0;
            if((textBox1.Text != "") && (operacao_especial == 0) && (operacao_especial2 == 0) && (operacao_especial3 == 0)){
                if (operador == 0){
                    num1 = Double.Parse(textBox1.Text);
                    num1 = 1 / num1;
                    textBox1.Text = num1.ToString();
                    //textBox1.Text = string.Format("{0:N}", num1);
                    calculado = 1;
                    virgula1 = 1;
                }
                else{
                    if(texxboc != ""){
                        //calculando 1/x do segundo número da calculadora=====
                        num2 = Double.Parse(texxboc);
                        num2 = 1 / num2;
                        texxboc = num2.ToString();
                        string texto = num1.ToString() + sinal + num2.ToString();
                        textBox1.Text = texto;
                        virgula1 = 1;
                    }
                }
            }

        }

        private void button26_Click(object sender, EventArgs e)
        {// =====calcula a raiz cubica==========
            if ((textBox1.Text != "") && (operacao_especial == 0) && (operacao_especial2 == 0) && (operacao_especial3 == 0)){
                double raiz = 0;
                //============raiz cubica do primeiro numero==========
                if (operador == 0){
                    num1 = Double.Parse(textBox1.Text);
                    raiz = (Double)Math.Pow(num1, 1.0/3.0);
                    textBox1.Text = string.Format("{0:N}", raiz);
                    texxboc = raiz.ToString();
                    num1 = raiz;
                    calculado = 1;
                    virgula1 = 1;
                }
                else{
                    if (texxboc != ""){
                        //=========calcula raiz cubica do segundo número da calculadora==========
                        num2 = Double.Parse(texxboc);
                        num2 = (Double)Math.Pow(num2, 1.0/3.0);
                        texxboc = num2.ToString();
                        string texto = num1.ToString() + sinal;
                        string texto2 = num2.ToString();
                        textBox1.Text = texto + texto2;
                        virgula1 = 1;
                    }
                }
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {// raiz qualquer numero==================================================
            
            if ((textBox1.Text != "") && (operacao_especial == 0) && (operacao_especial2 == 0) && (operacao_especial3 == 0)){
                operacao_especial++;
                //============raiz  do primeiro numero==========
                if (operador == 0){
                    if(operacao_especial == 1){
                        num1 = Double.Parse(textBox1.Text);
                        textBox1.Text = num1.ToString() + "√";
                        texxboc = "";
                        num1feito = 1;

                    }
                }
                else{

                    if (texxboc != ""){
                        //=========calcula raiz  do segundo número da calculadora==========
                        string texto = "";
                        if(operacao_especial == 1){
                            num2 = Double.Parse(texxboc);
                            texto = num1.ToString() + sinal + num2.ToString() + "√";
                            textBox1.Text = texto;
                            texxboc = "";
                            valida_op_esp = 1;

                        }
                        
                    }
                }
            }

        }

        private void button29_Click(object sender, EventArgs e)
        {// x elevado a y
            if ((textBox1.Text != "") && (operacao_especial == 0) && (operacao_especial2 == 0) && (operacao_especial3 == 0)){
                operacao_especial2++;
                //============num elevado a outro (antes de existir alguma operação!!!)==========
                if (operador == 0){
                    if (operacao_especial2 == 1){
                        num1 = Double.Parse(textBox1.Text);
                        textBox1.Text = num1.ToString() + "^";
                        texxboc = "";
                        num1feito = 1;

                    }
                }
                else{
                    if (texxboc != ""){
                        //=========num elevado a outro depois de operação: 2 '+' 3^2 ==========
                        string texto = "";
                        if (operacao_especial2 == 1){
                            num2 = Double.Parse(texxboc);
                            texto = num1.ToString() + sinal + num2.ToString() + "^";
                            textBox1.Text = texto;
                            texxboc = "";
                            valida_op_esp = 1;

                        }

                    }
                }
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {// fatorial
            if ((textBox1.Text != "") && (operacao_especial == 0) && (operacao_especial2 == 0) && (operacao_especial3 == 0)){                
                //======================fatorial do primeiro numero====================
                if (operador == 0){
                    num1 = Double.Parse(textBox1.Text);
                    float f = 1;
                    for(int i = 1; i <= num1; i++)
                    {
                        f = f * i;
                    }
                    num1 = f;
                    textBox1.Text = string.Format("{0:N}", f);
                    texxboc = f.ToString();
                    calculado = 1;
                    virgula1 = 1;
                }
                else{
                    if (texxboc != ""){
                        //=========calcula fatorial do segundo número da calculadora==========
                        num2 = Double.Parse(texxboc);
                        double f = 1;
                        for (int i = 1; i <= num2; i++)
                        {
                            f = f * i;
                        }
                        num2 = f;
                        texxboc = num2.ToString();
                        string texto = num1.ToString() + sinal;
                        string texto2 = num2.ToString();
                        textBox1.Text = texto + texto2;
                        virgula1 = 1;
                    }
                }
            }

        }

        private void button28_Click(object sender, EventArgs e)
        {// x ao quadrado============
            if ((textBox1.Text != "") && (operacao_especial == 0) && (operacao_especial2 == 0) && (operacao_especial3 == 0)){
                //======================primeiro numero ao quadrado====================
                if (operador == 0){
                    num1 = Double.Parse(textBox1.Text);
                    num1 = num1 * num1;
                    textBox1.Text = string.Format("{0:N}", num1);
                    texxboc = num1.ToString();
                    calculado = 1;
                    virgula1 = 1;
                }
                else{
                    if (texxboc != ""){
                        //=========segundo número ao quadrado==========
                        num2 = Double.Parse(texxboc);
                        num2 = num2 * num2;
                        texxboc = num2.ToString();
                        string texto = num1.ToString() + sinal;
                        string texto2 = num2.ToString();
                        textBox1.Text = texto + texto2;
                        virgula1 = 1;
                    }
                }
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {// x ao cubo
            if ((textBox1.Text != "") && (operacao_especial == 0) && (operacao_especial2 == 0) && (operacao_especial3 == 0)){
                //======================primeiro numero ao cubo====================
                if (operador == 0){
                    num1 = Double.Parse(textBox1.Text);
                    num1 = (Double)Math.Pow(num1, 3);
                    textBox1.Text = string.Format("{0:N}", num1);
                    texxboc = num1.ToString();
                    calculado = 1;
                    virgula1 = 1;
                }
                else{
                    if (texxboc != ""){
                        //=========segundo número ao cubo==========
                        num2 = Double.Parse(texxboc);
                        num2 = (Double)Math.Pow(num2, 3);
                        texxboc = num2.ToString();
                        string texto = num1.ToString() + sinal;
                        string texto2 = num2.ToString();
                        textBox1.Text = texto + texto2;
                        virgula1 = 1;
                    }
                }
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {// 10 elevado a 'x'
            if ((textBox1.Text != "") && (operacao_especial == 0) && (operacao_especial2 == 0) && (operacao_especial3 == 0)){
                //======================10 elevado ao primeiro numero====================
                if (operador == 0){
                    num1 = Double.Parse(textBox1.Text);
                    num1 = (Double)Math.Pow(10, num1);
                    textBox1.Text = string.Format("{0:N}", num1);
                    texxboc = num1.ToString();
                    calculado = 1;
                    virgula1 = 1;
                }
                else{
                    if (texxboc != ""){
                        //=========10 elevado ao segundo número==========
                        num2 = Double.Parse(texxboc);
                        num2 = (Double)Math.Pow(10, num2);
                        texxboc = num2.ToString();
                        string texto = num1.ToString() + sinal;
                        string texto2 = num2.ToString();
                        textBox1.Text = texto + texto2;
                        virgula1 = 1;
                    }
                }
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {// log base 10
            if ((textBox1.Text != "") && (operacao_especial == 0) && (operacao_especial2 == 0) && (operacao_especial3 == 0)){
                double log = 0;
                //============funciona como se fosse o botão '=' mas, calcula a raiz quadrada==========
                if (operador == 0){
                    num1 = Double.Parse(textBox1.Text);
                    log = (double)Math.Log10(num1);
                    textBox1.Text = string.Format("{0:N}", log);
                    texxboc = log.ToString();
                    num1 = log;
                    calculado = 1;
                    virgula1 = 1;
                }
                else{
                    if (texxboc != ""){
                        //=========calcula raiz quadrada do segundo número da calculadora==========
                        num2 = Double.Parse(texxboc);
                        num2 = (double)Math.Log10(num2);
                        texxboc = num2.ToString();
                        string texto = num1.ToString() + sinal;
                        string texto2 = num2.ToString();
                        textBox1.Text = texto + texto2;
                        virgula1 = 1;
                    }
                }
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {// mod (resto de divisão)
            if ((textBox1.Text != "") && (operacao_especial == 0) && (operacao_especial2 == 0) && (operacao_especial3 == 0)){
                operacao_especial3++;
                //============num mod outro (antes de existir alguma operação!!!)==========
                if (operador == 0){
                    if (operacao_especial3 == 1){
                        num1 = Double.Parse(textBox1.Text);
                        textBox1.Text = num1.ToString() + "mod";
                        texxboc = "";
                        num1feito = 1;

                    }
                }
                else{
                    if (texxboc != ""){
                        //=========num mod outro depois de operação: 2 '+' 3mod125 ==========
                        string texto = "";
                        if (operacao_especial3 == 1){
                            num2 = Double.Parse(texxboc);
                            texto = num1.ToString() + sinal + num2.ToString() + "mod";
                            textBox1.Text = texto;
                            texxboc = "";
                            valida_op_esp = 1;
                        }
                    }
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {// cálculo de % de um número
            if ((textBox1.Text != "") && (operacao_especial == 0) && (operacao_especial2 == 0) && (operacao_especial3 == 0)){
                //======================porcentagem do primeiro número====================
                if (operador == 0){
                    num1 = Double.Parse(textBox1.Text);
                    num1 = num1/ 100 ;
                    textBox1.Text = string.Format("{0:N}", num1);
                    texxboc = num1.ToString();
                    calculado = 1;
                    virgula1 = 1;
                }
                else{
                    if (texxboc != ""){
                        //=========segundo porcentagem exemp (2 + 3% = 2,06) (2 * 3% = 0,06) ==========
                        num2 = Double.Parse(texxboc);
                        num2 = num2 / 100;
                        double res = num1 * num2;
                        calculado = 1;
                        operador = 0;
                        virgula1 = 1;
                        if (matematica == 3){
                            textBox1.Text = string.Format("{0:N}", res);
                        }
                        else{
                            if(matematica == 1){
                                res = num1 + res;
                                textBox1.Text = string.Format("{0:N}", res);
                                texxboc = res.ToString();
                                num1 = res;
                            }
                            else{
                                if(matematica == 2){
                                    res = num1 - res;
                                    textBox1.Text = string.Format("{0:N}", res);
                                    texxboc = res.ToString();
                                    num1 = res;
                                }
                                else{
                                    res = num1 / num2;
                                    textBox1.Text = string.Format("{0:N}", res);
                                    num1 = res;
                                    texxboc = res.ToString();
                                }
                            }
                        }                        
                    }
                }
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {//seno
            if ((textBox1.Text != "") && (operacao_especial == 0) && (operacao_especial2 == 0) && (operacao_especial3 == 0)){
                //======================seno do primeiro numero====================
                if (operador == 0){
                    num1 = Double.Parse(textBox1.Text);
                    num1 = (double)(Math.PI * num1 / 180.0); //transforma o numero para graus
                    num1 = (double)Math.Sin(num1); //calcula seno
                    textBox1.Text = string.Format("{0:N}", num1);
                    texxboc = num1.ToString();
                    calculado = 1;
                    virgula1 = 1;
                }
                else{
                    if (texxboc != ""){
                        //=========seno do segundo número==========
                        num2 = Double.Parse(texxboc);
                        num2 = (double)(Math.PI * num2 / 180.0);
                        num2 = (double)Math.Sin(num2);
                        texxboc = num2.ToString();
                        string texto = num1.ToString() + sinal;
                        string texto2 = num2.ToString();
                        textBox1.Text = texto + texto2;
                        virgula1 = 1;
                    }
                }
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {//cos
            if ((textBox1.Text != "") && (operacao_especial == 0) && (operacao_especial2 == 0) && (operacao_especial3 == 0)){
                //======================cos do primeiro numero====================
                if (operador == 0){
                    num1 = Double.Parse(textBox1.Text);
                    num1 = (double)(Math.PI * num1 / 180.0); //transforma o numero para graus
                    num1 = (double)Math.Cos(num1); //calcula cosseno
                    textBox1.Text = string.Format("{0:N}", num1);
                    texxboc = num1.ToString();
                    calculado = 1;
                    virgula1 = 1;
                }
                else{
                    if (texxboc != ""){
                        //=========cos do segundo número==========
                        num2 = Double.Parse(texxboc);
                        num2 = (double)(Math.PI * num2 / 180.0);
                        num2 = (double)Math.Cos(num2);
                        texxboc = num2.ToString();
                        string texto = num1.ToString() + sinal;
                        string texto2 = num2.ToString();
                        textBox1.Text = texto + texto2;
                        virgula1 = 1;
                    }
                }
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {//tg
            if ((textBox1.Text != "") && (operacao_especial == 0) && (operacao_especial2 == 0) && (operacao_especial3 == 0)){
                //======================tg do primeiro numero====================
                if (operador == 0){
                    num1 = Double.Parse(textBox1.Text);
                    num1 = (double)(Math.PI * num1 / 180.0); //transforma o numero para graus
                    num1 = (double)Math.Tan(num1); //calcula tg
                    textBox1.Text = string.Format("{0:N}", num1);
                    texxboc = num1.ToString();
                    calculado = 1;
                    virgula1 = 1;
                }
                else{
                    if (texxboc != ""){
                        //=========tg do segundo número==========
                        num2 = Double.Parse(texxboc);
                        num2 = (double)(Math.PI * num2 / 180.0);
                        num2 = (double)Math.Tan(num2);
                        texxboc = num2.ToString();
                        string texto = num1.ToString() + sinal;
                        string texto2 = num2.ToString();
                        textBox1.Text = texto + texto2;
                        virgula1 = 1;
                    }
                }
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {// <- backspace
            if(textBox1.Text != ""){                
                if ((num1feito == 0) && (calculado == 0)){
                    texxboc = texxboc.Remove(texxboc.Length - 1);
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                }                    
                else{
                    if ((texxboc != "") && (calculado == 0)){
                        textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                        texxboc = texxboc.Remove(texxboc.Length - 1);
                    }       
                }
            }
        }
    }
}
