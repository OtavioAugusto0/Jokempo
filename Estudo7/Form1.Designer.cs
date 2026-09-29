namespace Estudo7
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
            this.Btn_pedra = new System.Windows.Forms.Button();
            this.Btn_papel = new System.Windows.Forms.Button();
            this.Btn_tesoura = new System.Windows.Forms.Button();
            this.Lbl_escolhaUsuario = new System.Windows.Forms.Label();
            this.Lbl_resultado = new System.Windows.Forms.Label();
            this.Lbl_escolhaMaquina = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Lbl_pontuacaoMaquina = new System.Windows.Forms.Label();
            this.Lbl_pontuacaoUsuario = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Btn_sair = new System.Windows.Forms.Button();
            this.Btn_limpar = new System.Windows.Forms.Button();
            this.Btn_zerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_vitoriasMaquina = new System.Windows.Forms.Label();
            this.Lbl_vitoriasUsuario = new System.Windows.Forms.Label();
            this.Btn_reiniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_pedra
            // 
            this.Btn_pedra.Location = new System.Drawing.Point(68, 263);
            this.Btn_pedra.Name = "Btn_pedra";
            this.Btn_pedra.Size = new System.Drawing.Size(160, 48);
            this.Btn_pedra.TabIndex = 0;
            this.Btn_pedra.Text = "Pedra";
            this.Btn_pedra.UseVisualStyleBackColor = true;
            this.Btn_pedra.Click += new System.EventHandler(this.Btn_pedra_Click);
            // 
            // Btn_papel
            // 
            this.Btn_papel.Location = new System.Drawing.Point(307, 263);
            this.Btn_papel.Name = "Btn_papel";
            this.Btn_papel.Size = new System.Drawing.Size(160, 48);
            this.Btn_papel.TabIndex = 1;
            this.Btn_papel.Text = "Papel";
            this.Btn_papel.UseVisualStyleBackColor = true;
            this.Btn_papel.Click += new System.EventHandler(this.Btn_papel_Click);
            // 
            // Btn_tesoura
            // 
            this.Btn_tesoura.Location = new System.Drawing.Point(540, 263);
            this.Btn_tesoura.Name = "Btn_tesoura";
            this.Btn_tesoura.Size = new System.Drawing.Size(160, 48);
            this.Btn_tesoura.TabIndex = 2;
            this.Btn_tesoura.Text = "Tesoura";
            this.Btn_tesoura.UseVisualStyleBackColor = true;
            this.Btn_tesoura.Click += new System.EventHandler(this.Btn_tesoura_Click);
            // 
            // Lbl_escolhaUsuario
            // 
            this.Lbl_escolhaUsuario.AutoSize = true;
            this.Lbl_escolhaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_escolhaUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_escolhaUsuario.Location = new System.Drawing.Point(119, 115);
            this.Lbl_escolhaUsuario.Name = "Lbl_escolhaUsuario";
            this.Lbl_escolhaUsuario.Size = new System.Drawing.Size(0, 25);
            this.Lbl_escolhaUsuario.TabIndex = 3;
            // 
            // Lbl_resultado
            // 
            this.Lbl_resultado.AutoSize = true;
            this.Lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_resultado.Location = new System.Drawing.Point(327, 180);
            this.Lbl_resultado.Name = "Lbl_resultado";
            this.Lbl_resultado.Size = new System.Drawing.Size(0, 39);
            this.Lbl_resultado.TabIndex = 4;
            // 
            // Lbl_escolhaMaquina
            // 
            this.Lbl_escolhaMaquina.AutoSize = true;
            this.Lbl_escolhaMaquina.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_escolhaMaquina.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_escolhaMaquina.Location = new System.Drawing.Point(570, 115);
            this.Lbl_escolhaMaquina.Name = "Lbl_escolhaMaquina";
            this.Lbl_escolhaMaquina.Size = new System.Drawing.Size(0, 25);
            this.Lbl_escolhaMaquina.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(115, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Você";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(552, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Máquina";
            // 
            // Lbl_pontuacaoMaquina
            // 
            this.Lbl_pontuacaoMaquina.AutoSize = true;
            this.Lbl_pontuacaoMaquina.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_pontuacaoMaquina.Location = new System.Drawing.Point(572, 9);
            this.Lbl_pontuacaoMaquina.Name = "Lbl_pontuacaoMaquina";
            this.Lbl_pontuacaoMaquina.Size = new System.Drawing.Size(13, 13);
            this.Lbl_pontuacaoMaquina.TabIndex = 9;
            this.Lbl_pontuacaoMaquina.Text = "0";
            // 
            // Lbl_pontuacaoUsuario
            // 
            this.Lbl_pontuacaoUsuario.AutoSize = true;
            this.Lbl_pontuacaoUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_pontuacaoUsuario.Location = new System.Drawing.Point(135, 9);
            this.Lbl_pontuacaoUsuario.Name = "Lbl_pontuacaoUsuario";
            this.Lbl_pontuacaoUsuario.Size = new System.Drawing.Size(13, 13);
            this.Lbl_pontuacaoUsuario.TabIndex = 8;
            this.Lbl_pontuacaoUsuario.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(628, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = ":Pontuação da máquina";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(36, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Sua pontuação:";
            // 
            // Btn_sair
            // 
            this.Btn_sair.Location = new System.Drawing.Point(436, 390);
            this.Btn_sair.Name = "Btn_sair";
            this.Btn_sair.Size = new System.Drawing.Size(122, 30);
            this.Btn_sair.TabIndex = 12;
            this.Btn_sair.Text = "Sair";
            this.Btn_sair.UseVisualStyleBackColor = true;
            this.Btn_sair.Click += new System.EventHandler(this.Btn_sair_Click);
            // 
            // Btn_limpar
            // 
            this.Btn_limpar.Location = new System.Drawing.Point(436, 343);
            this.Btn_limpar.Name = "Btn_limpar";
            this.Btn_limpar.Size = new System.Drawing.Size(122, 30);
            this.Btn_limpar.TabIndex = 13;
            this.Btn_limpar.Text = "Limpar";
            this.Btn_limpar.UseVisualStyleBackColor = true;
            this.Btn_limpar.Click += new System.EventHandler(this.Btn_limpar_Click);
            // 
            // Btn_zerar
            // 
            this.Btn_zerar.Location = new System.Drawing.Point(229, 343);
            this.Btn_zerar.Name = "Btn_zerar";
            this.Btn_zerar.Size = new System.Drawing.Size(122, 30);
            this.Btn_zerar.TabIndex = 14;
            this.Btn_zerar.Text = "Zerar rodada";
            this.Btn_zerar.UseVisualStyleBackColor = true;
            this.Btn_zerar.Click += new System.EventHandler(this.Btn_zerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(75, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Vitórias:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(628, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = ":Vitórias";
            // 
            // Lbl_vitoriasMaquina
            // 
            this.Lbl_vitoriasMaquina.AutoSize = true;
            this.Lbl_vitoriasMaquina.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_vitoriasMaquina.Location = new System.Drawing.Point(572, 31);
            this.Lbl_vitoriasMaquina.Name = "Lbl_vitoriasMaquina";
            this.Lbl_vitoriasMaquina.Size = new System.Drawing.Size(13, 13);
            this.Lbl_vitoriasMaquina.TabIndex = 17;
            this.Lbl_vitoriasMaquina.Text = "0";
            // 
            // Lbl_vitoriasUsuario
            // 
            this.Lbl_vitoriasUsuario.AutoSize = true;
            this.Lbl_vitoriasUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_vitoriasUsuario.Location = new System.Drawing.Point(135, 31);
            this.Lbl_vitoriasUsuario.Name = "Lbl_vitoriasUsuario";
            this.Lbl_vitoriasUsuario.Size = new System.Drawing.Size(13, 13);
            this.Lbl_vitoriasUsuario.TabIndex = 18;
            this.Lbl_vitoriasUsuario.Text = "0";
            // 
            // Btn_reiniciar
            // 
            this.Btn_reiniciar.Location = new System.Drawing.Point(229, 390);
            this.Btn_reiniciar.Name = "Btn_reiniciar";
            this.Btn_reiniciar.Size = new System.Drawing.Size(122, 30);
            this.Btn_reiniciar.TabIndex = 19;
            this.Btn_reiniciar.Text = "Reiniciar";
            this.Btn_reiniciar.UseVisualStyleBackColor = true;
            this.Btn_reiniciar.Click += new System.EventHandler(this.Btn_reiniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_reiniciar);
            this.Controls.Add(this.Lbl_vitoriasUsuario);
            this.Controls.Add(this.Lbl_vitoriasMaquina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_zerar);
            this.Controls.Add(this.Btn_limpar);
            this.Controls.Add(this.Btn_sair);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Lbl_pontuacaoMaquina);
            this.Controls.Add(this.Lbl_pontuacaoUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lbl_escolhaMaquina);
            this.Controls.Add(this.Lbl_resultado);
            this.Controls.Add(this.Lbl_escolhaUsuario);
            this.Controls.Add(this.Btn_tesoura);
            this.Controls.Add(this.Btn_papel);
            this.Controls.Add(this.Btn_pedra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_pedra;
        private System.Windows.Forms.Button Btn_papel;
        private System.Windows.Forms.Button Btn_tesoura;
        private System.Windows.Forms.Label Lbl_escolhaUsuario;
        private System.Windows.Forms.Label Lbl_resultado;
        private System.Windows.Forms.Label Lbl_escolhaMaquina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Lbl_pontuacaoMaquina;
        private System.Windows.Forms.Label Lbl_pontuacaoUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Btn_sair;
        private System.Windows.Forms.Button Btn_limpar;
        private System.Windows.Forms.Button Btn_zerar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_vitoriasMaquina;
        private System.Windows.Forms.Label Lbl_vitoriasUsuario;
        private System.Windows.Forms.Button Btn_reiniciar;
    }
}

