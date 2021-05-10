
namespace BlackJack_ProjOficial
{
    partial class form_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_menu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cad = new System.Windows.Forms.Button();
            this.btn_jogarmaquina = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BlackJack_ProjOficial.Properties.Resources._0;
            this.pictureBox1.Location = new System.Drawing.Point(55, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_cad
            // 
            this.btn_cad.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_cad.BackgroundImage = global::BlackJack_ProjOficial.Properties.Resources.background_min;
            this.btn_cad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cad.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cad.Location = new System.Drawing.Point(96, 300);
            this.btn_cad.Name = "btn_cad";
            this.btn_cad.Size = new System.Drawing.Size(144, 63);
            this.btn_cad.TabIndex = 1;
            this.btn_cad.Text = "Cadastrar Jogadores";
            this.btn_cad.UseVisualStyleBackColor = false;
            this.btn_cad.Click += new System.EventHandler(this.btn_cad_Click);
            // 
            // btn_jogarmaquina
            // 
            this.btn_jogarmaquina.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_jogarmaquina.BackgroundImage = global::BlackJack_ProjOficial.Properties.Resources.background_min;
            this.btn_jogarmaquina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_jogarmaquina.Location = new System.Drawing.Point(96, 381);
            this.btn_jogarmaquina.Name = "btn_jogarmaquina";
            this.btn_jogarmaquina.Size = new System.Drawing.Size(144, 64);
            this.btn_jogarmaquina.TabIndex = 2;
            this.btn_jogarmaquina.Text = "Jogar Contra a Maquina";
            this.btn_jogarmaquina.UseVisualStyleBackColor = false;
            this.btn_jogarmaquina.Click += new System.EventHandler(this.btn_jogarmaquina_Click);
            // 
            // form_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackJack_ProjOficial.Properties.Resources.imagen_de_fundo_pok;
            this.ClientSize = new System.Drawing.Size(343, 452);
            this.Controls.Add(this.btn_jogarmaquina);
            this.Controls.Add(this.btn_cad);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_menu";
            this.Text = "Black Jack";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_cad;
        private System.Windows.Forms.Button btn_jogarmaquina;
    }
}

