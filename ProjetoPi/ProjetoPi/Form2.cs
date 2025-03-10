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

namespace ProjetoPi
{
    public partial class Form2 : Form
    {
        private string versao;
        public Form2()
        {
            InitializeComponent();
            this.versao = Jogo.versao;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Versao = this.versao;
            form.AtualizarTela();
            form.ShowDialog();

            label1.Text = form.idPartidaSelecionada.ToString();
        }
    }
}
