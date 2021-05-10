
namespace BlackJack_ProjOficial
{
    partial class form_cad_jog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_cad_jog));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_nomejog1 = new System.Windows.Forms.TextBox();
            this.text_nomejog2 = new System.Windows.Forms.TextBox();
            this.btn_cad = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Jogador 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome Jogador 2:";
            // 
            // text_nomejog1
            // 
            this.text_nomejog1.Location = new System.Drawing.Point(209, 89);
            this.text_nomejog1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.text_nomejog1.MaxLength = 20;
            this.text_nomejog1.Name = "text_nomejog1";
            this.text_nomejog1.PlaceholderText = "Digite o nome do jogador 1";
            this.text_nomejog1.Size = new System.Drawing.Size(607, 29);
            this.text_nomejog1.TabIndex = 2;
            this.text_nomejog1.Enter += new System.EventHandler(this.text_nomejog1_Enter);
            this.text_nomejog1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_nomejog1_KeyPress);
            this.text_nomejog1.Leave += new System.EventHandler(this.text_nomejog1_Leave);
            // 
            // text_nomejog2
            // 
            this.text_nomejog2.Location = new System.Drawing.Point(209, 148);
            this.text_nomejog2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.text_nomejog2.MaxLength = 20;
            this.text_nomejog2.Name = "text_nomejog2";
            this.text_nomejog2.PlaceholderText = "Digite o nome do jogador 2";
            this.text_nomejog2.Size = new System.Drawing.Size(607, 29);
            this.text_nomejog2.TabIndex = 3;
            this.text_nomejog2.Enter += new System.EventHandler(this.text_nomejog2_Enter);
            this.text_nomejog2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_nomejog2_KeyPress);
            this.text_nomejog2.Leave += new System.EventHandler(this.text_nomejog2_Leave);
            // 
            // btn_cad
            // 
            this.btn_cad.BackgroundImage = global::BlackJack_ProjOficial.Properties.Resources.background_min;
            this.btn_cad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cad.Location = new System.Drawing.Point(323, 215);
            this.btn_cad.Name = "btn_cad";
            this.btn_cad.Size = new System.Drawing.Size(270, 51);
            this.btn_cad.TabIndex = 4;
            this.btn_cad.Text = "Cadastrar Jogadores";
            this.btn_cad.UseVisualStyleBackColor = true;
            this.btn_cad.Click += new System.EventHandler(this.btn_cad_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.BackgroundImage = global::BlackJack_ProjOficial.Properties.Resources.background_min;
            this.btn_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_menu.Location = new System.Drawing.Point(323, 273);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(270, 46);
            this.btn_menu.TabIndex = 5;
            this.btn_menu.Text = "Menu";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // form_cad_jog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackJack_ProjOficial.Properties.Resources.imagen_de_fundo_pok;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(851, 353);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.btn_cad);
            this.Controls.Add(this.text_nomejog2);
            this.Controls.Add(this.text_nomejog1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_cad_jog";
            this.Text = "Cadastro Jogadores Blackjack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_nomejog1;
        private System.Windows.Forms.TextBox text_nomejog2;
        private System.Windows.Forms.Button btn_cad;
        private System.Windows.Forms.Button btn_menu;
    }
}