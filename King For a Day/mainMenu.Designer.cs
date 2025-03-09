namespace King_For_a_Day
{
    partial class mainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTransicao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTransicao
            // 
            this.btnTransicao.Location = new System.Drawing.Point(290, 259);
            this.btnTransicao.Name = "btnTransicao";
            this.btnTransicao.Size = new System.Drawing.Size(75, 23);
            this.btnTransicao.TabIndex = 0;
            this.btnTransicao.Text = "button1";
            this.btnTransicao.UseVisualStyleBackColor = true;
            this.btnTransicao.Click += new System.EventHandler(this.btnTransicao_Click);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::King_For_a_Day.Properties.Resources.wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(653, 343);
            this.Controls.Add(this.btnTransicao);
            this.DoubleBuffered = true;
            this.Name = "mainMenu";
            this.Text = "mainMenu";
            this.Load += new System.EventHandler(this.mainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTransicao;
    }
}