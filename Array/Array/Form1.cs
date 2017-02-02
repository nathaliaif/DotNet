using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArray1_Click(object sender, EventArgs e)
        {
            //Criando e iniciando um simples array
            //Neste caso o tamanho do Array pode variar 
            string[] times = {"Corinthians","Palmeiras","São Paulo", "Santos"};

            //recuperando o conteúdo de um array
            MessageBox.Show("Time" + times[0]);
        }

        private void btnCarta_Click(object sender, EventArgs e)
        {
            //Criando os naipes e tipos de cartas
            string[] face = { "1","2","3","4","5","6","7","8","9","10","Valete","Dama","Rei"};

            string[] naipe = { "Ouros", "Paus", "Espadas", "Copas" };

            //A linha abaixo ajuda no entendimento do raciocínio lógico
            //MessageBox.Show("Carta Sorteada: " + numeros[10] + " de " + naipe[3]);

            Random numero = new Random();

            //Função para gerar números aleatórios dos números e naipes
            //Criando duas variáveis que vão receber números aleatórios
            string n = naipe[numero.Next(4)];
            string f = face[numero.Next(13)];

            //Criando o Array aleatório de Números e Naipes de cartas
            MessageBox.Show( f + " de " + n);
        }

        private void btnArray2_Click(object sender, EventArgs e)
        {
            //Outra forma de declarar e iniciar um Array 
            //Neste caso o Array SEMPRE tem um tamanho fixo
            
            //"Criando um objeto Array do tipo inteiro de tamanho 5"

            int[] numeros = new int[5];
            numeros[0] = 1;
            numeros[1] = 5;
            numeros[2] = 18;
            numeros[3] = 45;
            numeros[4] = 90;

            MessageBox.Show("Número: " + numeros[2]);
        }

        private void btnArray3_Click(object sender, EventArgs e)
        {
            //Preenchendo o Array com o laço for
            int[] numeros = new int[5];

            //A estrutura abaixo cria as variáveis que irão preencher as 5 "casinhas" do Array

            //++ equivale a i=i+1
            for (int i = 0; i < 5; i++)
            {
                numeros[i] = i;
                //listBox1.Items.Add(i);
                listBox1.Items.Add("numeros [" + i + "] = " + i);
            }
        }
    }
}
