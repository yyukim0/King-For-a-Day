using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingMeServer;

namespace King_For_a_Day
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblVersao.Text = Jogo.versao;
            lstJogadores.BackColor = Color.Transparent;

        }

        private void listarPartidas()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.ListarPartidas("T");
            txtJogadores.Text = retorno;

            retorno = retorno.Replace("\r", "");

            retorno = retorno.Substring(0, retorno.Length - 1);
            string[] partidas = retorno.Split('\n');

            for (int i = 0; i < partidas.Length - 1; i++)
            {
                lstSelecao.Items.Add(partidas[i]);
            }

            lstSelecao.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string partida = lstSelecao.SelectedItem.ToString();
            string[] dadosPartida = partida.Split(',');

            int idPartida = Convert.ToInt32(dadosPartida[0]);
            string nomePartida = dadosPartida[1];
            string dataPartida = dadosPartida[2];

            lblNomePartida.Text = idPartida.ToString();
            lblId.Text = nomePartida;
            lblData.Text = dataPartida;

            string retorno = Jogo.ListarJogadores(idPartida);
            if (retorno.Substring(0, 4) == "ERRO")
            {
                MessageBox.Show($"Ocorreu um erro: \n{retorno.Substring(5)}", "Meu PI III", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            retorno = retorno.Replace("\r", "");
            string[] jogadores = retorno.Split('\n');

            lstJogadores.Items.Clear();
            for(int i = 0; i < jogadores.Length; i++)
            {
                lstJogadores.Items.Add(jogadores[i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblNomePartida_Click(object sender, EventArgs e)
        {

        }

        private void lblData_Click(object sender, EventArgs e)
        {

        }

        private void lst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
