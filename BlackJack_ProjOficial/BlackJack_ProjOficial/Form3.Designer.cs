
namespace BlackJack_ProjOficial
{
    partial class form_contra_maqui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_contra_maqui));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_jogar = new System.Windows.Forms.Button();
            this.btn_parar = new System.Windows.Forms.Button();
            this.btn_reiniciar = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.lbl_Pontos_A = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Pontos_Maquina = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BlackJack_ProjOficial.Properties.Resources._0;
            this.pictureBox1.Location = new System.Drawing.Point(29, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 281);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BlackJack_ProjOficial.Properties.Resources._0;
            this.pictureBox2.Location = new System.Drawing.Point(513, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(218, 281);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btn_jogar
            // 
            this.btn_jogar.BackgroundImage = global::BlackJack_ProjOficial.Properties.Resources.background_min;
            this.btn_jogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_jogar.Location = new System.Drawing.Point(66, 373);
            this.btn_jogar.Name = "btn_jogar";
            this.btn_jogar.Size = new System.Drawing.Size(140, 30);
            this.btn_jogar.TabIndex = 2;
            this.btn_jogar.Text = "Jogar";
            this.btn_jogar.UseVisualStyleBackColor = true;
            this.btn_jogar.Click += new System.EventHandler(this.btn_jogar_Click);
            // 
            // btn_parar
            // 
            this.btn_parar.BackgroundImage = global::BlackJack_ProjOficial.Properties.Resources.background_min;
            this.btn_parar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_parar.Location = new System.Drawing.Point(66, 411);
            this.btn_parar.Name = "btn_parar";
            this.btn_parar.Size = new System.Drawing.Size(140, 30);
            this.btn_parar.TabIndex = 3;
            this.btn_parar.Text = "Parar";
            this.btn_parar.UseVisualStyleBackColor = true;
            this.btn_parar.Click += new System.EventHandler(this.btn_parar_Click);
            // 
            // btn_reiniciar
            // 
            this.btn_reiniciar.BackgroundImage = global::BlackJack_ProjOficial.Properties.Resources.background_min;
            this.btn_reiniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_reiniciar.Location = new System.Drawing.Point(327, 442);
            this.btn_reiniciar.Name = "btn_reiniciar";
            this.btn_reiniciar.Size = new System.Drawing.Size(109, 35);
            this.btn_reiniciar.TabIndex = 4;
            this.btn_reiniciar.Text = "Reiniciar";
            this.btn_reiniciar.UseVisualStyleBackColor = true;
            this.btn_reiniciar.Click += new System.EventHandler(this.btn_reiniciar_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.BackgroundImage = global::BlackJack_ProjOficial.Properties.Resources.background_min;
            this.btn_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_menu.Location = new System.Drawing.Point(327, 484);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(109, 32);
            this.btn_menu.TabIndex = 5;
            this.btn_menu.Text = "Menu";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // lbl_Pontos_A
            // 
            this.lbl_Pontos_A.AutoSize = true;
            this.lbl_Pontos_A.Location = new System.Drawing.Point(346, 196);
            this.lbl_Pontos_A.Name = "lbl_Pontos_A";
            this.lbl_Pontos_A.Size = new System.Drawing.Size(20, 22);
            this.lbl_Pontos_A.TabIndex = 6;
            this.lbl_Pontos_A.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "X";
            // 
            // lbl_Pontos_Maquina
            // 
            this.lbl_Pontos_Maquina.AutoSize = true;
            this.lbl_Pontos_Maquina.Location = new System.Drawing.Point(401, 196);
            this.lbl_Pontos_Maquina.Name = "lbl_Pontos_Maquina";
            this.lbl_Pontos_Maquina.Size = new System.Drawing.Size(20, 22);
            this.lbl_Pontos_Maquina.TabIndex = 8;
            this.lbl_Pontos_Maquina.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pontos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Resultado";
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Location = new System.Drawing.Point(358, 373);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(20, 22);
            this.lbl_Resultado.TabIndex = 11;
            this.lbl_Resultado.Text = "_";
            // 
            // form_contra_maqui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackJack_ProjOficial.Properties.Resources.imagen_de_fundo_pok;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(821, 525);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Pontos_Maquina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Pontos_A);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.btn_reiniciar);
            this.Controls.Add(this.btn_parar);
            this.Controls.Add(this.btn_jogar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_contra_maqui";
            this.Text = "Black Jack Contra a Máquina";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_jogar;
        private System.Windows.Forms.Button btn_parar;
        private System.Windows.Forms.Button btn_reiniciar;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Label lbl_Pontos_A;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Pontos_Maquina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Resultado;
    }
}