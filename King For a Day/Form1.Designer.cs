namespace King_For_a_Day
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIniciar = new System.Windows.Forms.Button();
            this.txtJogadores = new System.Windows.Forms.TextBox();
            this.lstSelecao = new System.Windows.Forms.ListBox();
            this.lblNomePartida = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lstJogadores = new System.Windows.Forms.ListBox();
            this.lblVersao = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(64, 65);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "button1";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtJogadores
            // 
            this.txtJogadores.BackColor = System.Drawing.Color.Black;
            this.txtJogadores.ForeColor = System.Drawing.Color.White;
            this.txtJogadores.Location = new System.Drawing.Point(31, 115);
            this.txtJogadores.Multiline = true;
            this.txtJogadores.Name = "txtJogadores";
            this.txtJogadores.Size = new System.Drawing.Size(152, 176);
            this.txtJogadores.TabIndex = 1;
            // 
            // lstSelecao
            // 
            this.lstSelecao.ForeColor = System.Drawing.Color.White;
            this.lstSelecao.FormattingEnabled = true;
            this.lstSelecao.Location = new System.Drawing.Point(202, 115);
            this.lstSelecao.Name = "lstSelecao";
            this.lstSelecao.Size = new System.Drawing.Size(131, 173);
            this.lstSelecao.TabIndex = 2;
            this.lstSelecao.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblNomePartida.Location = new System.Drawing.Point(356, 172);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(18, 13);
            this.lblNomePartida.TabIndex = 3;
            this.lblNomePartida.Text = "ID";
            this.lblNomePartida.Click += new System.EventHandler(this.lblNomePartida_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblId.Location = new System.Drawing.Point(356, 197);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(35, 13);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "Nome";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblData.Location = new System.Drawing.Point(356, 226);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 5;
            this.lblData.Text = "Data";
            this.lblData.Click += new System.EventHandler(this.lblData_Click);
            // 
            // lstJogadores
            // 
            this.lstJogadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(10)))), ((int)(((byte)(13)))));
            this.lstJogadores.ForeColor = System.Drawing.Color.White;
            this.lstJogadores.FormattingEnabled = true;
            this.lstJogadores.Location = new System.Drawing.Point(411, 115);
            this.lstJogadores.Name = "lstJogadores";
            this.lstJogadores.Size = new System.Drawing.Size(131, 173);
            this.lstJogadores.TabIndex = 6;
            this.lstJogadores.SelectedIndexChanged += new System.EventHandler(this.lst_SelectedIndexChanged);
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblVersao.Location = new System.Drawing.Point(627, 327);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(40, 13);
            this.lblVersao.TabIndex = 7;
            this.lblVersao.Text = "Versão";
            this.lblVersao.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(579, 31);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "button1";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::King_For_a_Day.Properties.Resources.fundoLobby;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(679, 349);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.lstJogadores);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblNomePartida);
            this.Controls.Add(this.lstSelecao);
            this.Controls.Add(this.txtJogadores);
            this.Controls.Add(this.btnIniciar);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox txtJogadores;
        private System.Windows.Forms.ListBox lstSelecao;
        private System.Windows.Forms.Label lblNomePartida;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.ListBox lstJogadores;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Button btnVoltar;
    }
}

