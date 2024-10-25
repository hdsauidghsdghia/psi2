using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace jogodosnumeros
{
    public partial class Form1 : Form
    {
        private int vitoriasJogador1 = 0;
        private int vitoriasJogador2 = 0;
        private int empates = 0;
        private List<int> jogadasJogador1 = new List<int>();
        private List<int> jogadasJogador2 = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmeter_Click(object sender, EventArgs e)
        {
            int numeroJogador1, numeroJogador2;

            // Corrigi o operador para &&
            if (ValidarEntrada(Jogador1.Text, out numeroJogador1) && ValidarEntrada(Jogador2.Text, out numeroJogador2))
            {
                jogar(numeroJogador1, numeroJogador2);
            }
        }

        private bool ValidarEntrada(string entrada, out int numero)
        {
            // Corrigi o operador para &&
            if (int.TryParse(entrada, out numero) && numero >= 1 && numero <= 20)
            {
                return true;
            }
            MessageBox.Show("Valor inválido. Por favor, insira um número de 1 a 20.");
            return false;
        }

        private void jogar(int numeroJogador1, int numeroJogador2)
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 21); // número aleatório de 1 a 20

            // Registrar jogadas
            jogadasJogador1.Add(numeroJogador1);
            jogadasJogador2.Add(numeroJogador2); // Corrigi a variável para 'numeroJogador2'

            // Calcular diferenças
            int diferenca1 = Math.Abs(numeroAleatorio - numeroJogador1);
            int diferenca2 = Math.Abs(numeroAleatorio - numeroJogador2);

            if (diferenca1 < diferenca2)
            {
                vitoriasJogador1++; // Jogador 1 ganha
                MessageBox.Show("Jogador 1 ganhou !!");
            }
            else if (diferenca2 < diferenca1)
            {
                vitoriasJogador2++; // Jogador 2 ganha
                MessageBox.Show("Jogador 2 ganhou !!");
            }
            else
            {
                empates++; // Empate
                MessageBox.Show("Empate!");
                vitoriasJogador1++; // Pontuação para empate
                vitoriasJogador2++;
            }
            AtualizarEstatisticas();
        }

        private void AtualizarEstatisticas()
        {
            lblVitoriasJogador1.Text = $"Vitórias: {vitoriasJogador1}";
            lblVitoriasJogador2.Text = $"Vitórias: {vitoriasJogador2}";
            lblEmpates.Text = $"Empates: {empates}";
        }

        private void btnEstatisticas_Click(object sender, EventArgs e)
        {
            // Mostrar estatísticas
            MessageBox.Show($"Jogador 1 - Vitórias: {vitoriasJogador1}, Derrotas: {vitoriasJogador2}, Empates: {empates}\n" +
                            $"Jogador 2 - Vitórias: {vitoriasJogador2}, Derrotas: {vitoriasJogador1}, Empates: {empates}");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
