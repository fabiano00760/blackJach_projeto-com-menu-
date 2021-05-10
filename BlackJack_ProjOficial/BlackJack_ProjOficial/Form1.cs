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
    public partial class form_menu : Form
    {
        public form_menu()
        {
            InitializeComponent();
        }

        private void btn_cad_Click(object sender, EventArgs e)
        {
            Form cadastro = new form_cad_jog();
            cadastro.Show();
            this.Visible = false;
        }

        private void btn_jogarmaquina_Click(object sender, EventArgs e)
        {
            Form contramaqui = new form_contra_maqui();
            contramaqui.Show();
            this.Visible = false;
        }
    }
}
