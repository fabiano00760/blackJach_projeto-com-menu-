using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BlackJack_ProjOficial
{
    public partial class form_cad_jog : Form
    {
        public form_cad_jog()
        {
            InitializeComponent();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            Form menu = new form_menu();
            menu.Show();
            this.Visible = false;
        }
        
        private void btn_cad_Click(object sender, EventArgs e)
        {
            string nomejog1, nomejog2;

            nomejog1 = text_nomejog1.Text;
            nomejog2 = text_nomejog2.Text;
            
            Form joga2 = new form_jogo_contra(nomejog1,nomejog2);
            joga2.Show();
            this.Visible = false;

        }

        private void text_nomejog1_Enter(object sender, EventArgs e)
        {
            text_nomejog1.BackColor = Color.LightBlue;
        }

        private void text_nomejog1_Leave(object sender, EventArgs e)
        {
            text_nomejog1.BackColor = Color.White;
        }

        private void text_nomejog2_Enter(object sender, EventArgs e)
        {
            text_nomejog2.BackColor = Color.LightBlue;
        }

        private void text_nomejog2_Leave(object sender, EventArgs e)
        {

            text_nomejog2.BackColor = Color.White;
        }

        private void text_nomejog1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int tecla = (int)e.KeyChar;
            if (!char.IsLetterOrDigit(e.KeyChar) && tecla != 8)
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas letras ou numeros!");
                text_nomejog1.Focus();

            }
            
    
        }

        private void text_nomejog2_KeyPress(object sender, KeyPressEventArgs e)
        {
            int tecla = (int)e.KeyChar;
            if (!char.IsLetterOrDigit(e.KeyChar)&& tecla!=8)
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas letras ou numeros!");
                text_nomejog2.Focus();

            }
        }


    }
}

