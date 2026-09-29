using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudo7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DesabilitarBotoes()
        {
            Btn_pedra.Enabled = false;
            Btn_papel.Enabled = false;
            Btn_tesoura.Enabled = false;
        }

        private void HabilitarBotoes()
        {
            Btn_pedra.Enabled = true;
            Btn_papel.Enabled = true;
            Btn_tesoura.Enabled = true;
        }

        private void Btn_pedra_Click(object sender, EventArgs e)
        {
            Lbl_escolhaUsuario.Text = "Pedra";
            Random random = new Random();
            int num = random.Next(1, 4);
            if (num == 1)
            {
                Lbl_escolhaMaquina.Text = "Pedra";
                Lbl_resultado.Text = "Empate!";
                Lbl_resultado.ForeColor = Color.Yellow;
                DesabilitarBotoes();

            }
            else if (num == 2)
            {
                Lbl_escolhaMaquina.Text = "Papel";
                Lbl_resultado.Text = "Você perdeu!";
                Lbl_resultado.ForeColor = Color.Red;
                Lbl_pontuacaoMaquina.Text = (int.Parse(Lbl_pontuacaoMaquina.Text) + 1).ToString();
                DesabilitarBotoes();
            }
            else
            {
                Lbl_escolhaMaquina.Text = "Tesoura";
                Lbl_resultado.Text = "Você ganhou!";
                Lbl_resultado.ForeColor = Color.Green;
                Lbl_pontuacaoUsuario.Text = (int.Parse(Lbl_pontuacaoUsuario.Text) + 1).ToString();
                DesabilitarBotoes();
            }

            if(int.Parse(Lbl_pontuacaoUsuario.Text) == 3)
            {
                MessageBox.Show("Parabéns! Você venceu o jogo!");
                Btn_zerar_Click(sender, e);
                Lbl_vitoriasUsuario.Text = (int.Parse(Lbl_vitoriasUsuario.Text) + 1).ToString();
                HabilitarBotoes();

            }
            else if (int.Parse(Lbl_pontuacaoMaquina.Text) == 3)
            {
                MessageBox.Show("Que pena! A máquina venceu o jogo!");
                Btn_zerar_Click(sender, e);
                Lbl_vitoriasMaquina.Text = (int.Parse(Lbl_vitoriasMaquina.Text) + 1).ToString();
                HabilitarBotoes();

            }
        }

        private void Btn_papel_Click(object sender, EventArgs e)
        {
            Lbl_escolhaUsuario.Text = "Papel";
            Random random = new Random();
            int num = random.Next(1, 4);
            if (num == 1)
            {
                Lbl_escolhaMaquina.Text = "Pedra";
                Lbl_resultado.Text = "Você ganhou!";
                Lbl_resultado.ForeColor = Color.Green;
                Lbl_pontuacaoUsuario.Text = (int.Parse(Lbl_pontuacaoUsuario.Text) + 1).ToString();
                DesabilitarBotoes();

            }
            else if (num == 2)
            {
                Lbl_escolhaMaquina.Text = "Papel";
                Lbl_resultado.Text = "Empate!";
                Lbl_resultado.ForeColor = Color.Yellow;
                DesabilitarBotoes();
            }
            else
            {
                Lbl_escolhaMaquina.Text = "Tesoura";
                Lbl_resultado.Text = "Você perdeu!";
                Lbl_resultado.ForeColor = Color.Red;
                Lbl_pontuacaoMaquina.Text = (int.Parse(Lbl_pontuacaoMaquina.Text) + 1).ToString();
                DesabilitarBotoes();
            }
            if (int.Parse(Lbl_pontuacaoUsuario.Text) == 3)
            {
                MessageBox.Show("Parabéns! Você venceu o jogo!");
                Btn_zerar_Click(sender, e);
                Lbl_vitoriasUsuario.Text = (int.Parse(Lbl_vitoriasUsuario.Text) + 1).ToString();
                HabilitarBotoes();

            }
            else if (int.Parse(Lbl_pontuacaoMaquina.Text) == 3)
            {
                MessageBox.Show("Que pena! A máquina venceu o jogo!");
                Btn_zerar_Click(sender, e);
                Lbl_vitoriasMaquina.Text = (int.Parse(Lbl_vitoriasMaquina.Text) + 1).ToString();
                HabilitarBotoes();

            }
        }

        private void Btn_tesoura_Click(object sender, EventArgs e)
        {
            Lbl_escolhaUsuario.Text = "Tesoura";
            Random random = new Random();
            int num = random.Next(1, 4);
            if (num == 1)
            {
                Lbl_escolhaMaquina.Text = "Pedra";
                Lbl_resultado.Text = "Você perdeu!";
                Lbl_resultado.ForeColor = Color.Red;
                Lbl_pontuacaoMaquina.Text = (int.Parse(Lbl_pontuacaoMaquina.Text) + 1).ToString();
                DesabilitarBotoes();

            }
            else if (num == 2)
            {
                Lbl_escolhaMaquina.Text = "Papel";
                Lbl_resultado.Text = "Você ganhou!";
                Lbl_resultado.ForeColor = Color.Green;
                Lbl_pontuacaoUsuario.Text = (int.Parse(Lbl_pontuacaoUsuario.Text) + 1).ToString();
                DesabilitarBotoes();
            }
            else
            {
                Lbl_escolhaMaquina.Text = "Tesoura";
                Lbl_resultado.Text = "Empate!";
                Lbl_resultado.ForeColor = Color.Yellow;
                DesabilitarBotoes();
            }
            if (int.Parse(Lbl_pontuacaoUsuario.Text) == 3)
            {
                MessageBox.Show("Parabéns! Você venceu o jogo!");
                Btn_zerar_Click(sender, e);
                Lbl_vitoriasUsuario.Text = (int.Parse(Lbl_vitoriasUsuario.Text) + 1).ToString();
                HabilitarBotoes();

            }
            else if (int.Parse(Lbl_pontuacaoMaquina.Text) == 3)
            {
                MessageBox.Show("Que pena! A máquina venceu o jogo!");
                Btn_zerar_Click(sender, e);
                Lbl_vitoriasMaquina.Text = (int.Parse(Lbl_vitoriasMaquina.Text) + 1).ToString();
                HabilitarBotoes();
            }
        }

        private void Btn_limpar_Click(object sender, EventArgs e)
        {
            Lbl_escolhaMaquina.Text = "";
            Lbl_escolhaUsuario.Text = "";
            Lbl_resultado.Text = "";
            HabilitarBotoes();
        }

        private void Btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_zerar_Click(object sender, EventArgs e)
        {
            Lbl_escolhaMaquina.Text = "";
            Lbl_escolhaUsuario.Text = "";
            Lbl_resultado.Text = "";
            Lbl_pontuacaoMaquina.Text = "0";
            Lbl_pontuacaoUsuario.Text = "0";
            //Lbl_vitoriasUsuario.Text = "0";
            //Lbl_vitoriasMaquina.Text = "0";

            DialogResult result = MessageBox.Show("A pontuação desta rodada será zerada, você tem certeza?", "Zerar Rodada");
            if(result == DialogResult.Yes)
            {
                Lbl_pontuacaoMaquina.Text = "0";
                Lbl_pontuacaoUsuario.Text = "0";
            }
        }

        private void Btn_reiniciar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("As pontuações serão zeradas, você tem certeza?", "Reiniciar Jogo",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Lbl_escolhaMaquina.Text = "";
                Lbl_escolhaUsuario.Text = "";
                Lbl_resultado.Text = "";
                Lbl_pontuacaoMaquina.Text = "0";
                Lbl_pontuacaoUsuario.Text = "0";
                Lbl_vitoriasUsuario.Text = "0";
                Lbl_vitoriasMaquina.Text = "0";
            }
        }
    }
}
