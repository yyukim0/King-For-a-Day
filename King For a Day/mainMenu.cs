﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace King_For_a_Day
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnTransicao_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();

            form.ShowDialog();
        }
    }
}
