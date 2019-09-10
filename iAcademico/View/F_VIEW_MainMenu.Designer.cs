namespace iAcademico.View
{
    partial class F_VIEW_MainMenu
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
            this.BTN_Add = new System.Windows.Forms.Button();
            this.BTN_Visualize = new System.Windows.Forms.Button();
            this.BTN_About = new System.Windows.Forms.Button();
            this.PICT_CLOSE = new System.Windows.Forms.PictureBox();
            this.PICT_LogoMenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PICT_CLOSE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICT_LogoMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Add
            // 
            this.BTN_Add.Location = new System.Drawing.Point(398, 334);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(134, 55);
            this.BTN_Add.TabIndex = 0;
            this.BTN_Add.Text = "Add";
            this.BTN_Add.UseVisualStyleBackColor = true;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // BTN_Visualize
            // 
            this.BTN_Visualize.Location = new System.Drawing.Point(180, 334);
            this.BTN_Visualize.Name = "BTN_Visualize";
            this.BTN_Visualize.Size = new System.Drawing.Size(134, 55);
            this.BTN_Visualize.TabIndex = 1;
            this.BTN_Visualize.Text = "Visualize";
            this.BTN_Visualize.UseVisualStyleBackColor = true;
            this.BTN_Visualize.Click += new System.EventHandler(this.BTN_Visualize_Click);
            // 
            // BTN_About
            // 
            this.BTN_About.Location = new System.Drawing.Point(664, 376);
            this.BTN_About.Name = "BTN_About";
            this.BTN_About.Size = new System.Drawing.Size(54, 20);
            this.BTN_About.TabIndex = 4;
            this.BTN_About.Text = "About...";
            this.BTN_About.UseVisualStyleBackColor = true;
            this.BTN_About.Click += new System.EventHandler(this.BTN_About_Click);
            // 
            // PICT_CLOSE
            // 
            this.PICT_CLOSE.Image = global::iAcademico.Properties.Resources.power_button;
            this.PICT_CLOSE.Location = new System.Drawing.Point(680, 4);
            this.PICT_CLOSE.Name = "PICT_CLOSE";
            this.PICT_CLOSE.Size = new System.Drawing.Size(36, 30);
            this.PICT_CLOSE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PICT_CLOSE.TabIndex = 3;
            this.PICT_CLOSE.TabStop = false;
            this.PICT_CLOSE.Click += new System.EventHandler(this.PICT_CLOSE_Click);
            // 
            // PICT_LogoMenu
            // 
            this.PICT_LogoMenu.Image = global::iAcademico.Properties.Resources.LogoMainMenu;
            this.PICT_LogoMenu.Location = new System.Drawing.Point(120, 12);
            this.PICT_LogoMenu.Name = "PICT_LogoMenu";
            this.PICT_LogoMenu.Size = new System.Drawing.Size(467, 305);
            this.PICT_LogoMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PICT_LogoMenu.TabIndex = 2;
            this.PICT_LogoMenu.TabStop = false;
            // 
            // F_VIEW_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 401);
            this.Controls.Add(this.BTN_About);
            this.Controls.Add(this.PICT_CLOSE);
            this.Controls.Add(this.PICT_LogoMenu);
            this.Controls.Add(this.BTN_Visualize);
            this.Controls.Add(this.BTN_Add);
            this.Name = "F_VIEW_MainMenu";
            this.Text = "F_VIEW_MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.PICT_CLOSE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICT_LogoMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.Button BTN_Visualize;
        private System.Windows.Forms.PictureBox PICT_LogoMenu;
        private System.Windows.Forms.PictureBox PICT_CLOSE;
        private System.Windows.Forms.Button BTN_About;
    }
}