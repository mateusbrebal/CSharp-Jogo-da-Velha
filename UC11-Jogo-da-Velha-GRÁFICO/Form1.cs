using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC11_Jogo_da_Velha_GRÁFICO
{
    public partial class Form1 : Form
    {
        string jogada = "O";
        string acertou = "N";
        int tentativas = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void TesteJogadas()
        {
            // VALIDA VERTICAIS
            if (label1.Text == label4.Text && label4.Text == label7.Text && label4.Text != "?")
            {
                MessageBox.Show("Jogador " + label4.Text + " ganhou!");
                acertou = "S";
            }
            if (label2.Text == label5.Text && label5.Text == label8.Text && label5.Text != "?")
            {
                MessageBox.Show("Jogador " + label5.Text + " ganhou!");
                acertou = "S";
            }
            if (label3.Text == label6.Text && label6.Text == label9.Text && label6.Text != "?")
            {
                MessageBox.Show("Jogador " + label6.Text + " ganhou!");
                acertou = "S";
            }

            // VALIDA HORIZONTAIS
            if (label1.Text == label2.Text && label2.Text == label3.Text && label2.Text != "?")
            {
                MessageBox.Show("Jogador " + label2.Text + " ganhou!");
                acertou = "S";
            }
            if (label4.Text == label5.Text && label5.Text == label6.Text && label5.Text != "?")
            {
                MessageBox.Show("Jogador " + label5.Text + " ganhou!");
                acertou = "S";
            }
            if (label7.Text == label8.Text && label8.Text == label9.Text && label8.Text != "?")
            {
                MessageBox.Show("Jogador " + label8.Text + " ganhou!");
                acertou = "S";
            }

            // VALIDA DIAGONAIS
            if (label1.Text == label5.Text && label5.Text == label9.Text && label5.Text != "?")
            {
                MessageBox.Show("Jogador " + label5.Text + " ganhou!");
                acertou = "S";
            }
            if (label3.Text == label5.Text && label5.Text == label7.Text && label5.Text != "?")
            {
                MessageBox.Show("Jogador " + label5.Text + " ganhou!");
                acertou = "S";
            }

            if (acertou == "N")
            {
                tentativas++; // tentativas = tentativas + 1;
            } else
            {
                acertou = "N";
            }

            MessageBox.Show(tentativas.ToString());


        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (jogada == "O")
            {
                label1.Text = "X";
                jogada = "X";
            } else
            {
                label1.Text = "O";
                jogada = "O";
            }
            TesteJogadas();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (jogada == "O")
            {
                label2.Text = "X";
                jogada = "X";
            }
            else
            {
                label2.Text = "O";
                jogada = "O";
            }
            TesteJogadas();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (jogada == "O")
            {
                label3.Text = "X";
                jogada = "X";
            }
            else
            {
                label3.Text = "O";
                jogada = "O";
            }
            TesteJogadas();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (jogada == "O")
            {
                label4.Text = "X";
                jogada = "X";
            }
            else
            {
                label4.Text = "O";
                jogada = "O";
            }
            TesteJogadas();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (jogada == "O")
            {
                label5.Text = "X";
                jogada = "X";
            }
            else
            {
                label5.Text = "O";
                jogada = "O";
            }
            TesteJogadas();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (jogada == "O")
            {
                label6.Text = "X";
                jogada = "X";
            }
            else
            {
                label6.Text = "O";
                jogada = "O";
            }
            TesteJogadas();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (jogada == "O")
            {
                label7.Text = "X";
                jogada = "X";
            }
            else
            {
                label7.Text = "O";
                jogada = "O";
            }
            TesteJogadas();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (jogada == "O")
            {
                label8.Text = "X";
                jogada = "X";
            }
            else
            {
                label8.Text = "O";
                jogada = "O";
            }
            TesteJogadas();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (jogada == "O")
            {
                label9.Text = "X";
                jogada = "X";
            }
            else
            {
                label9.Text = "O";
                jogada = "O";
            }
            TesteJogadas();
        }
    }
}
