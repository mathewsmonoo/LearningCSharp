namespace WindowsFormsApp1
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.BUTTON_ABOUT = new System.Windows.Forms.Button();
            this.PICT_MainMenu = new System.Windows.Forms.PictureBox();
            this.BUTTON_VisualizeScreen = new System.Windows.Forms.Button();
            this.BTN_EXIT = new System.Windows.Forms.Button();
            this.BUTTON_AddScreen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PICT_MainMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // BUTTON_ABOUT
            // 
            this.BUTTON_ABOUT.Location = new System.Drawing.Point(856, 577);
            this.BUTTON_ABOUT.Name = "BUTTON_ABOUT";
            this.BUTTON_ABOUT.Size = new System.Drawing.Size(98, 21);
            this.BUTTON_ABOUT.TabIndex = 4;
            this.BUTTON_ABOUT.Text = "about";
            this.BUTTON_ABOUT.UseVisualStyleBackColor = true;
            // 
            // PICT_MainMenu
            // 
            this.PICT_MainMenu.InitialImage = ((System.Drawing.Image)(resources.GetObject("PICT_MainMenu.InitialImage")));
            this.PICT_MainMenu.Location = new System.Drawing.Point(236, 68);
            this.PICT_MainMenu.Name = "PICT_MainMenu";
            this.PICT_MainMenu.Size = new System.Drawing.Size(472, 280);
            this.PICT_MainMenu.TabIndex = 2;
            this.PICT_MainMenu.TabStop = false;
            // 
            // BUTTON_VisualizeScreen
            // 
            this.BUTTON_VisualizeScreen.Location = new System.Drawing.Point(203, 398);
            this.BUTTON_VisualizeScreen.Name = "BUTTON_VisualizeScreen";
            this.BUTTON_VisualizeScreen.Size = new System.Drawing.Size(239, 125);
            this.BUTTON_VisualizeScreen.TabIndex = 0;
            this.BUTTON_VisualizeScreen.Text = "visualize calendar";
            this.BUTTON_VisualizeScreen.UseVisualStyleBackColor = true;
            this.BUTTON_VisualizeScreen.Click += new System.EventHandler(this.BUTTON_VisualizeScreen_Click);
            // 
            // BTN_EXIT
            // 
            this.BTN_EXIT.Font = new System.Drawing.Font("Myanmar Text", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_EXIT.ForeColor = System.Drawing.Color.Red;
            this.BTN_EXIT.Location = new System.Drawing.Point(902, 12);
            this.BTN_EXIT.Name = "BTN_EXIT";
            this.BTN_EXIT.Size = new System.Drawing.Size(52, 49);
            this.BTN_EXIT.TabIndex = 6;
            this.BTN_EXIT.Text = "X";
            this.BTN_EXIT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_EXIT.UseVisualStyleBackColor = true;
            this.BTN_EXIT.Click += new System.EventHandler(this.BUTTON_EXIT_Click);
            // 
            // BUTTON_AddScreen
            // 
            this.BUTTON_AddScreen.Location = new System.Drawing.Point(520, 398);
            this.BUTTON_AddScreen.Name = "BUTTON_AddScreen";
            this.BUTTON_AddScreen.Size = new System.Drawing.Size(239, 125);
            this.BUTTON_AddScreen.TabIndex = 7;
            this.BUTTON_AddScreen.Text = "add new";
            this.BUTTON_AddScreen.UseVisualStyleBackColor = true;
            this.BUTTON_AddScreen.Click += new System.EventHandler(this.BUTTON_AddScreen_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(966, 610);
            this.Controls.Add(this.BUTTON_AddScreen);
            this.Controls.Add(this.BTN_EXIT);
            this.Controls.Add(this.BUTTON_ABOUT);
            this.Controls.Add(this.PICT_MainMenu);
            this.Controls.Add(this.BUTTON_VisualizeScreen);
            this.Name = "MainMenu";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PICT_MainMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BUTTON_ABOUT;
        private System.Windows.Forms.PictureBox PICT_MainMenu;
        private System.Windows.Forms.Button BUTTON_VisualizeScreen;
        private System.Windows.Forms.Button BTN_EXIT;
        private System.Windows.Forms.Button BUTTON_AddScreen;
    }
}

