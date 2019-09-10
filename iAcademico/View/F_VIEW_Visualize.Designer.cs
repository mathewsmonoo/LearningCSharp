namespace iAcademico.View
{
    partial class F_VIEW_Visualize
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
            this.PICT_BACK = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PICT_BACK)).BeginInit();
            this.SuspendLayout();
            // 
            // PICT_BACK
            // 
            this.PICT_BACK.Image = global::iAcademico.Properties.Resources.back_button;
            this.PICT_BACK.Location = new System.Drawing.Point(680, 4);
            this.PICT_BACK.Name = "PICT_BACK";
            this.PICT_BACK.Size = new System.Drawing.Size(36, 30);
            this.PICT_BACK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PICT_BACK.TabIndex = 5;
            this.PICT_BACK.TabStop = false;
            this.PICT_BACK.Click += new System.EventHandler(this.PICT_BACK_Click);
            // 
            // F_VIEW_Visualize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 401);
            this.Controls.Add(this.PICT_BACK);
            this.Name = "F_VIEW_Visualize";
            this.Text = "F_VIEW_View";
            ((System.ComponentModel.ISupportInitialize)(this.PICT_BACK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PICT_BACK;
    }
}