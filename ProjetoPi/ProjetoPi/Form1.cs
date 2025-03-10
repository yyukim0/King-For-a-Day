using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingMeServer;

namespace ProjetoPi
{
    public partial class Form1 : Form
    {
        public string Versao { get; set; }
        public int idPartidaSelecionada { get; set; }
        public Form1()
        {
            InitializeComponent();
            ListarPartidas();
        }

        public void AtualizarTela()
        {
            label4.Text = Versao;
        }

        private void ListarPartidas()
        {
            string retorno = Jogo.ListarPartidas("T");
            textBox1.Text = retorno;

            retorno = retorno.Replace("\r", "");
            retorno = retorno.Substring(0, retorno.Length - 1);
            string[] partidas = retorno.Split('\n');

            listBox1.Items.Clear();
            for (int i = 0; i < partidas.Length - 1; i++)
            {
                listBox1.Items.Add(partidas[i]);
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            string partida = listBox1.SelectedItem.ToString();
            string[] dadosPartida = partida.Split(',');

            int idPartida = Convert.ToInt32(dadosPartida[0]);
            string nomePartida = dadosPartida[1];
            string data = dadosPartida[2];

            label1.Text = idPartida.ToString();
            label2.Text = nomePartida;
            label3.Text = data;
            label5.Text = "senhafoda";
            label6.Text = "Carta não definida";

            string retorno = Jogo.ListarJogadores(idPartida);
            if (retorno.Substring(0, 4) == "ERRO")
            {
                MessageBox.Show("Ocorreu um erro:\n" + retorno.Substring(5), "NOSSO PI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            retorno = retorno.Replace("\r", "");
            string[] jogadores = retorno.Split('\n');

            listBox2.Items.Clear();
            for (int i = 0; i < jogadores.Length; i++)
            {
                listBox2.Items.Add(jogadores[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.idPartidaSelecionada = Convert.ToInt32(label1.Text);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nomePartida = "ospilantras"; 
            string senha = "senhafoda";        
            string grupo = "ScriptoresChartres"; 

            string retorno = Jogo.CriarPartida(nomePartida, senha, grupo);

            if (retorno.StartsWith("ERRO"))
            {
                MessageBox.Show("Erro ao criar partida:\n" + retorno.Substring(5), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int idNovaPartida = Convert.ToInt32(retorno);

                label1.Text = $"ID: {idNovaPartida}";
                label5.Text = $"Senha: {senha}";

                MessageBox.Show("Partida criada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarPartidas(); 
            }
        }
    
            private void button4_Click(object sender, EventArgs e)
        {
            string nomeJogador = "JogadorTeste"; 
            int idPartida = Convert.ToInt32(label1.Text.Replace("ID: ", "")); 

            string retorno = Jogo.Entrar(idPartida, nomeJogador, label5.Text.Replace("Senha: ", ""));

            if (retorno.StartsWith("ERRO"))
            {
                MessageBox.Show("Erro ao entrar na partida:\n" + retorno.Substring(5), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Entrou na partida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
