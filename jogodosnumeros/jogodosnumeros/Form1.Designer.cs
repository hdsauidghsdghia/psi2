using System;

namespace jogodosnumeros
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.Jogador1 = new System.Windows.Forms.Label();
            this.Jogador2 = new System.Windows.Forms.Label();
            this.Jogar = new System.Windows.Forms.Label();
            this.botaoJogar1 = new System.Windows.Forms.Button();
            this.botaoJogar2 = new System.Windows.Forms.Button();
            this.botaoSair = new System.Windows.Forms.Button();
            this.lblVitoriasJogador1 = new System.Windows.Forms.Label();
            this.lblVitoriasJogador2 = new System.Windows.Forms.Label();
            this.lblEmpates = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Jogador1
            // 
            this.Jogador1.Font = new System.Drawing.Font("Playbill", 24F, System.Drawing.FontStyle.Italic);
            this.Jogador1.ForeColor = System.Drawing.Color.Indigo;
            this.Jogador1.Location = new System.Drawing.Point(43, 117);
            this.Jogador1.Name = "Jogador1";
            this.Jogador1.Size = new System.Drawing.Size(156, 50);
            this.Jogador1.TabIndex = 0;
            this.Jogador1.Text = "Jogador 1";
            // 
            // Jogador2
            // 
            this.Jogador2.Font = new System.Drawing.Font("Playbill", 24F);
            this.Jogador2.ForeColor = System.Drawing.Color.Indigo;
            this.Jogador2.Location = new System.Drawing.Point(801, 110);
            this.Jogador2.Name = "Jogador2";
            this.Jogador2.Size = new System.Drawing.Size(156, 60);
            this.Jogador2.TabIndex = 1;
            this.Jogador2.Text = "Jogador 2";
            // 
            // Jogar
            // 
            this.Jogar.Font = new System.Drawing.Font("Stencil", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.Jogar.ForeColor = System.Drawing.Color.Indigo;
            this.Jogar.Location = new System.Drawing.Point(302, 308);
            this.Jogar.Name = "Jogar";
            this.Jogar.Size = new System.Drawing.Size(205, 73);
            this.Jogar.TabIndex = 2;
            this.Jogar.Text = "Jogar";
            // 
            // botaoJogar1
            // 
            this.botaoJogar1.Location = new System.Drawing.Point(3, -2);
            this.botaoJogar1.Name = "botaoJogar1";
            this.botaoJogar1.Size = new System.Drawing.Size(100, 30);
            this.botaoJogar1.TabIndex = 4;
            this.botaoJogar1.Text = "Jogar 1";
            this.botaoJogar1.Click += new System.EventHandler(this.botaojogar1_Click);
            // 
            // botaoJogar2
            // 
            this.botaoJogar2.Location = new System.Drawing.Point(99, -2);
            this.botaoJogar2.Name = "botaoJogar2";
            this.botaoJogar2.Size = new System.Drawing.Size(100, 30);
            this.botaoJogar2.TabIndex = 5;
            this.botaoJogar2.Text = "Jogar 2";
            this.botaoJogar2.Click += new System.EventHandler(this.botaojogar2_Click);
            // 
            // botaoSair
            // 
            this.botaoSair.Location = new System.Drawing.Point(196, -2);
            this.botaoSair.Name = "botaoSair";
            this.botaoSair.Size = new System.Drawing.Size(100, 30);
            this.botaoSair.TabIndex = 6;
            this.botaoSair.Text = "Sair";
            this.botaoSair.Click += new System.EventHandler(this.botaosair_Click);
            // 
            // lblVitoriasJogador1
            // 
            this.lblVitoriasJogador1.AutoSize = true;
            this.lblVitoriasJogador1.Location = new System.Drawing.Point(12, 428);
            this.lblVitoriasJogador1.Name = "lblVitoriasJogador1";
            this.lblVitoriasJogador1.Size = new System.Drawing.Size(103, 13);
            this.lblVitoriasJogador1.TabIndex = 7;
            this.lblVitoriasJogador1.Text = "Vitórias Jogador 1: 0";
            // 
            // lblVitoriasJogador2
            // 
            this.lblVitoriasJogador2.AutoSize = true;
            this.lblVitoriasJogador2.Location = new System.Drawing.Point(685, 428);
            this.lblVitoriasJogador2.Name = "lblVitoriasJogador2";
            this.lblVitoriasJogador2.Size = new System.Drawing.Size(103, 13);
            this.lblVitoriasJogador2.TabIndex = 8;
            this.lblVitoriasJogador2.Text = "Vitórias Jogador 2: 0";
            // 
            // lblEmpates
            // 
            this.lblEmpates.AutoSize = true;
            this.lblEmpates.Location = new System.Drawing.Point(366, 428);
            this.lblEmpates.Name = "lblEmpates";
            this.lblEmpates.Size = new System.Drawing.Size(60, 13);
            this.lblEmpates.TabIndex = 9;
            this.lblEmpates.Text = "Empates: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 54);
            this.label1.TabIndex = 10;
            this.label1.Text = "Jogo dos números";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::jogodosnumeros.Properties.Resources.kazzio_gay;
            this.pictureBox1.Location = new System.Drawing.Point(12, 170);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Playbill", 24F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(632, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 50);
            this.label2.TabIndex = 12;
            this.label2.Text = "Jogador 1";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Jogador1);
            this.Controls.Add(this.Jogador2);
            this.Controls.Add(this.Jogar);
            this.Controls.Add(this.botaoJogar1);
            this.Controls.Add(this.botaoJogar2);
            this.Controls.Add(this.botaoSair);
            this.Controls.Add(this.lblVitoriasJogador1);
            this.Controls.Add(this.lblVitoriasJogador2);
            this.Controls.Add(this.lblEmpates);
            this.Name = "Form1";
            this.Text = "Jogo dos Números";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void botaosair_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void botaojogar2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void botaojogar1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private System.Windows.Forms.Label Jogador1;
        private System.Windows.Forms.Label Jogador2;
        private System.Windows.Forms.Label Jogar;
        private System.Windows.Forms.Button botaoJogar1;
        private System.Windows.Forms.Button botaoJogar2;
        private System.Windows.Forms.Button botaoSair;
        private System.Windows.Forms.Label lblVitoriasJogador1;
        private System.Windows.Forms.Label lblVitoriasJogador2;
        private System.Windows.Forms.Label lblEmpates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}
