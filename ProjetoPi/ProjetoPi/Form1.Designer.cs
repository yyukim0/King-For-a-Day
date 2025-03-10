namespace ProjetoPi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listBox2 = new ListBox();
            label4 = new Label();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            label5 = new Label();
            label6 = new Label();
            button5 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(60, 90);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 170);
            textBox1.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(260, 90);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(151, 169);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(507, 90);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(507, 117);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(507, 149);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(605, 90);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(120, 154);
            listBox2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(724, 415);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 7;
            label4.Text = "label4";
            // 
            // button2
            // 
            button2.Location = new Point(261, 287);
            button2.Name = "button2";
            button2.Size = new Size(150, 56);
            button2.TabIndex = 8;
            button2.Text = "Entrar na Partida";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(608, 287);
            button1.Name = "button1";
            button1.Size = new Size(117, 56);
            button1.TabIndex = 9;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(60, 287);
            button3.Name = "button3";
            button3.Size = new Size(145, 56);
            button3.TabIndex = 10;
            button3.Text = "Criar Partida";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(448, 291);
            button4.Name = "button4";
            button4.Size = new Size(135, 52);
            button4.TabIndex = 11;
            button4.Text = "Iniciar Partida";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(507, 185);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 12;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(507, 218);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 13;
            label6.Text = "label6";
            // 
            // button5
            // 
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(listBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox listBox2;
        private Label label4;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Label label5;
        private Label label6;
        private Button button5;
    }
}
