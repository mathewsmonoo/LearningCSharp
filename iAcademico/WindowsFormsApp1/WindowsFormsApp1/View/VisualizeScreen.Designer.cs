namespace WindowsFormsApp1.View
{
    partial class VisualizeScreen
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
            this.CAL_First = new System.Windows.Forms.MonthCalendar();
            this.BTN_EXIT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CAL_First
            // 
            this.CAL_First.Location = new System.Drawing.Point(342, 205);
            this.CAL_First.Name = "CAL_First";
            this.CAL_First.TabIndex = 0;
            this.CAL_First.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.CAL_First_DateChanged);
            // 
            // BTN_EXIT
            // 
            this.BTN_EXIT.Font = new System.Drawing.Font("Myanmar Text", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_EXIT.ForeColor = System.Drawing.Color.Red;
            this.BTN_EXIT.Location = new System.Drawing.Point(889, 12);
            this.BTN_EXIT.Name = "BTN_EXIT";
            this.BTN_EXIT.Size = new System.Drawing.Size(52, 49);
            this.BTN_EXIT.TabIndex = 7;
            this.BTN_EXIT.Text = "X";
            this.BTN_EXIT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_EXIT.UseVisualStyleBackColor = true;
            // 
            // VisualizeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 609);
            this.Controls.Add(this.BTN_EXIT);
            this.Controls.Add(this.CAL_First);
            this.Name = "VisualizeScreen";
            this.Text = "VisualizeScreen";
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.MonthCalendar CAL_First;
        private System.Windows.Forms.Button BTN_EXIT;
    }
}