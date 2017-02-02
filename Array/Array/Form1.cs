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
            string[] numeros = { "1","2","3","4","5","6","7","8","9","10","Valete","Dama","Rei"};

            string[] naipe = { "Ouros", "Paus", "Espadas", "Copas" };

            //Função para gerar números aleatórios
            Random snumeros = new Random(12);
            Random snaipes = new Random(3);

            MessageBox.Show("Carta Sorteada: " + numeros[Convert.ToInt16(snumeros)] + " de " + naipe[Convert.ToInt16(snaipes)]);
        }
    }
}
