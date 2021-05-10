using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack_ProjOficial
{
    public partial class form_contra_maqui : Form
    {
        public form_contra_maqui()
        {
            InitializeComponent();
            btn_parar.Enabled = false;
            btn_reiniciar.Enabled = false;
        }
        int pontos_A = 0;
        int pontos_B = 0;
        int pontos_Maqui  =  0 ;

        public void resultado()
        {



            if (pontos_A > pontos_B && pontos_A <= 21)
                lbl_Resultado.Text = "Jogador GANHOU!";
            else
                if (pontos_A < pontos_B && pontos_B <= 21)
                lbl_Resultado.Text = "Maquina GANHOU!";
            else
                    if (pontos_A <= 21 && pontos_B <= 21)
                lbl_Resultado.Text = "EMPATE";
            else
                if (pontos_A < 21 && pontos_B > 21)
                lbl_Resultado.Text = "Jogador GANHOU!";
            else
                if (pontos_B < 21 && pontos_A > 21)
                lbl_Resultado.Text = "Maquina GANHOU!";
            else

                lbl_Resultado.Text = "SEM VENCEDOR.";


        }


        



        public void Jogada(PictureBox A, int jogador)
        {
            int x, total_pontos = 0;
            Random sorteio = new Random();
            x = sorteio.Next(1, 14);
            int maqui_mode = x + pontos_Maqui;

            if (jogador == 2 && maqui_mode < 21 || jogador == 1) { 
            switch (x)
            {
                case 1: A.Image = Properties.Resources.a; total_pontos += 1; break;
                case 2: A.Image = Properties.Resources._2; total_pontos += 2; break;
                case 3: A.Image = Properties.Resources._3; total_pontos += 3; break;
                case 4: A.Image = Properties.Resources._4; total_pontos += 4; break;
                case 5: A.Image = Properties.Resources._5; total_pontos += 5; break;
                case 6: A.Image = Properties.Resources._6; total_pontos += 6; break;
                case 7: A.Image = Properties.Resources._7; total_pontos += 7; break;
                case 8: A.Image = Properties.Resources._8; total_pontos += 8; break;
                case 9: A.Image = Properties.Resources._9; total_pontos += 9; break;
                case 10: A.Image = Properties.Resources._10; total_pontos += 10; break;
                case 11: A.Image = Properties.Resources.J; total_pontos += 10; break;
                case 12: A.Image = Properties.Resources.Q; total_pontos += 10; break;
                case 13: A.Image = Properties.Resources.K; total_pontos += 10; break;
            }
            }
            else
            {
                pontos_Maqui = 22;
            }

            if (jogador == 1)
            {
                pontos_A += total_pontos;
            }
                
            else

                pontos_Maqui += total_pontos;
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            Form menu = new form_menu();
            menu.Show();
            this.Visible = false;
        }
    

        private void btn_jogar_Click(object sender, EventArgs e)
        {
            Jogada(pictureBox1,1);




            if (pontos_A <= 21)
            {   // JOGANDO
                lbl_Pontos_A.Text = Convert.ToString(pontos_A);
                if (pontos_A == 21)
                {
                    //lbl_Resultado.Text = "GANHOU!!!";
                    btn_jogar.Enabled = false;
                    btn_reiniciar.Enabled = true;
                }
            }
            
        }
        
        private void btn_parar_Click(object sender, EventArgs e)
        {
            btn_jogar.Enabled = false;
            btn_parar.Enabled = false;
            timeMaquina.Enablad = true;


        }

        private void btn_reiniciar_Click(object sender, EventArgs e)
        {
            pontos_A = 0;
            pontos_B = 0;
            btn_jogar.Enabled = true;
            btn_parar.Enabled = true;
           
            btn_reiniciar.Enabled = false;
            lbl_Pontos_A.Text = "0";
            lbl_Pontos_Maquina.Text = "0";
            lbl_Resultado.Text = "";

           pictureBox1.Image = Properties.Resources._0;
           pictureBox2.Image = Properties.Resources._0;
        }
       private void timeMaquina_Tick(object sender, EventArgs e)
        {
            Jogada(pictureBox2, 2);

            if (pontos_Maqui <= 21)
            {
                pontos_B = pontos_Maqui;
                lbl_Pontos_Maquina.Text = Convert.ToString(pontos_B);


                if (pontos_B == 21)
                {
                    resultado();
                    timeMaquina_Tick.Enabled = false;
                    btn_reiniciar.Enabled = true;

                }
                else
                {
                    resultado();
                    timeMaquina_Tick.Enabled = false;
                    btn_reiniciar.Enabled = true;
                }
            }
        }
    }
}

