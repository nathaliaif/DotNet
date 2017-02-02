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
            string n = naipe[numero.Next(3)];
            string f = face[numero.Next(12)];

            //Criando o Array aleatório de Números e Naipes de cartas
            MessageBox.Show( f + " de " + n);
        }
    }
}
