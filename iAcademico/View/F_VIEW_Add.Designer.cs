namespace iAcademico.View
{
    partial class F_VIEW_Add
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
            this.BTN_AddSubject = new System.Windows.Forms.Button();
            this.LBL_Add = new System.Windows.Forms.Label();
            this.BTN_AddTeacher = new System.Windows.Forms.Button();
            this.BTN_AddClass = new System.Windows.Forms.Button();
            this.BTN_AddHomework = new System.Windows.Forms.Button();
            this.GRPBOX_AddSubject = new System.Windows.Forms.GroupBox();
            this.LBL_AddSubject = new System.Windows.Forms.Label();
            this.GRPBOX_AddTeacher = new System.Windows.Forms.GroupBox();
            this.LBL_AddTeacher = new System.Windows.Forms.Label();
            this.GRPBOX_AddClass = new System.Windows.Forms.GroupBox();
            this.LBL_AddClass = new System.Windows.Forms.Label();
            this.GRPBOX_AddHomework = new System.Windows.Forms.GroupBox();
            this.LBL_AddHomework = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PICT_BACK)).BeginInit();
            this.GRPBOX_AddSubject.SuspendLayout();
            this.GRPBOX_AddTeacher.SuspendLayout();
            this.GRPBOX_AddClass.SuspendLayout();
            this.GRPBOX_AddHomework.SuspendLayout();
            this.SuspendLayout();
            // 
            // PICT_BACK
            // 
            this.PICT_BACK.Image = global::iAcademico.Properties.Resources.back_button;
            this.PICT_BACK.Location = new System.Drawing.Point(680, 4);
            this.PICT_BACK.Name = "PICT_BACK";
            this.PICT_BACK.Size = new System.Drawing.Size(36, 30);
            this.PICT_BACK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PICT_BACK.TabIndex = 4;
            this.PICT_BACK.TabStop = false;
            this.PICT_BACK.Click += new System.EventHandler(this.PICT_BACK_Click);
            // 
            // BTN_AddSubject
            // 
            this.BTN_AddSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_AddSubject.Location = new System.Drawing.Point(64, 65);
            this.BTN_AddSubject.Name = "BTN_AddSubject";
            this.BTN_AddSubject.Size = new System.Drawing.Size(105, 55);
            this.BTN_AddSubject.TabIndex = 5;
            this.BTN_AddSubject.Text = "Subject";
            this.BTN_AddSubject.UseVisualStyleBackColor = true;
            this.BTN_AddSubject.Click += new System.EventHandler(this.BTN_AddSubject_Click);
            // 
            // LBL_Add
            // 
            this.LBL_Add.AutoSize = true;
            this.LBL_Add.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Add.Location = new System.Drawing.Point(12, 20);
            this.LBL_Add.Name = "LBL_Add";
            this.LBL_Add.Size = new System.Drawing.Size(92, 26);
            this.LBL_Add.TabIndex = 6;
            this.LBL_Add.Text = "Add.....";
            // 
            // BTN_AddTeacher
            // 
            this.BTN_AddTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_AddTeacher.Location = new System.Drawing.Point(64, 142);
            this.BTN_AddTeacher.Name = "BTN_AddTeacher";
            this.BTN_AddTeacher.Size = new System.Drawing.Size(105, 55);
            this.BTN_AddTeacher.TabIndex = 7;
            this.BTN_AddTeacher.Text = "Teacher";
            this.BTN_AddTeacher.UseVisualStyleBackColor = true;
            this.BTN_AddTeacher.Click += new System.EventHandler(this.BTN_AddTeacher_Click);
            // 
            // BTN_AddClass
            // 
            this.BTN_AddClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_AddClass.Location = new System.Drawing.Point(64, 219);
            this.BTN_AddClass.Name = "BTN_AddClass";
            this.BTN_AddClass.Size = new System.Drawing.Size(105, 55);
            this.BTN_AddClass.TabIndex = 8;
            this.BTN_AddClass.Text = "Class";
            this.BTN_AddClass.UseVisualStyleBackColor = true;
            this.BTN_AddClass.Click += new System.EventHandler(this.BTN_AddClass_Click);
            // 
            // BTN_AddHomework
            // 
            this.BTN_AddHomework.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_AddHomework.Location = new System.Drawing.Point(64, 296);
            this.BTN_AddHomework.Name = "BTN_AddHomework";
            this.BTN_AddHomework.Size = new System.Drawing.Size(105, 55);
            this.BTN_AddHomework.TabIndex = 9;
            this.BTN_AddHomework.Text = "Homework";
            this.BTN_AddHomework.UseVisualStyleBackColor = true;
            this.BTN_AddHomework.Click += new System.EventHandler(this.BTN_AddHomework_Click);
            // 
            // GRPBOX_AddSubject
            // 
            this.GRPBOX_AddSubject.Controls.Add(this.GRPBOX_AddTeacher);
            this.GRPBOX_AddSubject.Controls.Add(this.LBL_AddSubject);
            this.GRPBOX_AddSubject.Enabled = false;
            this.GRPBOX_AddSubject.Location = new System.Drawing.Point(237, 58);
            this.GRPBOX_AddSubject.Name = "GRPBOX_AddSubject";
            this.GRPBOX_AddSubject.Size = new System.Drawing.Size(419, 307);
            this.GRPBOX_AddSubject.TabIndex = 10;
            this.GRPBOX_AddSubject.TabStop = false;
            this.GRPBOX_AddSubject.Visible = false;
            // 
            // LBL_AddSubject
            // 
            this.LBL_AddSubject.AutoSize = true;
            this.LBL_AddSubject.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_AddSubject.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_AddSubject.Location = new System.Drawing.Point(2, 10);
            this.LBL_AddSubject.Name = "LBL_AddSubject";
            this.LBL_AddSubject.Size = new System.Drawing.Size(141, 20);
            this.LBL_AddSubject.TabIndex = 11;
            this.LBL_AddSubject.Text = "New Subject.....";
            // 
            // GRPBOX_AddTeacher
            // 
            this.GRPBOX_AddTeacher.Controls.Add(this.GRPBOX_AddClass);
            this.GRPBOX_AddTeacher.Controls.Add(this.LBL_AddTeacher);
            this.GRPBOX_AddTeacher.Enabled = false;
            this.GRPBOX_AddTeacher.Location = new System.Drawing.Point(8, 20);
            this.GRPBOX_AddTeacher.Name = "GRPBOX_AddTeacher";
            this.GRPBOX_AddTeacher.Size = new System.Drawing.Size(419, 307);
            this.GRPBOX_AddTeacher.TabIndex = 12;
            this.GRPBOX_AddTeacher.TabStop = false;
            this.GRPBOX_AddTeacher.Visible = false;
            // 
            // LBL_AddTeacher
            // 
            this.LBL_AddTeacher.AutoSize = true;
            this.LBL_AddTeacher.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_AddTeacher.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_AddTeacher.Location = new System.Drawing.Point(3, 11);
            this.LBL_AddTeacher.Name = "LBL_AddTeacher";
            this.LBL_AddTeacher.Size = new System.Drawing.Size(144, 20);
            this.LBL_AddTeacher.TabIndex = 11;
            this.LBL_AddTeacher.Text = "New Teacher.....";
            // 
            // GRPBOX_AddClass
            // 
            this.GRPBOX_AddClass.Controls.Add(this.GRPBOX_AddHomework);
            this.GRPBOX_AddClass.Controls.Add(this.LBL_AddClass);
            this.GRPBOX_AddClass.Enabled = false;
            this.GRPBOX_AddClass.Location = new System.Drawing.Point(13, 17);
            this.GRPBOX_AddClass.Name = "GRPBOX_AddClass";
            this.GRPBOX_AddClass.Size = new System.Drawing.Size(419, 307);
            this.GRPBOX_AddClass.TabIndex = 13;
            this.GRPBOX_AddClass.TabStop = false;
            this.GRPBOX_AddClass.Visible = false;
            // 
            // LBL_AddClass
            // 
            this.LBL_AddClass.AutoSize = true;
            this.LBL_AddClass.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_AddClass.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_AddClass.Location = new System.Drawing.Point(2, 10);
            this.LBL_AddClass.Name = "LBL_AddClass";
            this.LBL_AddClass.Size = new System.Drawing.Size(124, 20);
            this.LBL_AddClass.TabIndex = 11;
            this.LBL_AddClass.Text = "New Class.....";
            // 
            // GRPBOX_AddHomework
            // 
            this.GRPBOX_AddHomework.Controls.Add(this.LBL_AddHomework);
            this.GRPBOX_AddHomework.Enabled = false;
            this.GRPBOX_AddHomework.Location = new System.Drawing.Point(12, 17);
            this.GRPBOX_AddHomework.Name = "GRPBOX_AddHomework";
            this.GRPBOX_AddHomework.Size = new System.Drawing.Size(419, 307);
            this.GRPBOX_AddHomework.TabIndex = 14;
            this.GRPBOX_AddHomework.TabStop = false;
            this.GRPBOX_AddHomework.Visible = false;
            // 
            // LBL_AddHomework
            // 
            this.LBL_AddHomework.AutoSize = true;
            this.LBL_AddHomework.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_AddHomework.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_AddHomework.Location = new System.Drawing.Point(2, 10);
            this.LBL_AddHomework.Name = "LBL_AddHomework";
            this.LBL_AddHomework.Size = new System.Drawing.Size(165, 20);
            this.LBL_AddHomework.TabIndex = 11;
            this.LBL_AddHomework.Text = "New Homework.....";
            // 
            // F_VIEW_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 401);
            this.Controls.Add(this.GRPBOX_AddSubject);
            this.Controls.Add(this.BTN_AddHomework);
            this.Controls.Add(this.BTN_AddClass);
            this.Controls.Add(this.BTN_AddTeacher);
            this.Controls.Add(this.LBL_Add);
            this.Controls.Add(this.BTN_AddSubject);
            this.Controls.Add(this.PICT_BACK);
            this.Name = "F_VIEW_Add";
            this.Text = "F_VIEW_Add";
            ((System.ComponentModel.ISupportInitialize)(this.PICT_BACK)).EndInit();
            this.GRPBOX_AddSubject.ResumeLayout(false);
            this.GRPBOX_AddSubject.PerformLayout();
            this.GRPBOX_AddTeacher.ResumeLayout(false);
            this.GRPBOX_AddTeacher.PerformLayout();
            this.GRPBOX_AddClass.ResumeLayout(false);
            this.GRPBOX_AddClass.PerformLayout();
            this.GRPBOX_AddHomework.ResumeLayout(false);
            this.GRPBOX_AddHomework.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PICT_BACK;
        private System.Windows.Forms.Button BTN_AddSubject;
        private System.Windows.Forms.Label LBL_Add;
        private System.Windows.Forms.Button BTN_AddTeacher;
        private System.Windows.Forms.Button BTN_AddClass;
        private System.Windows.Forms.Button BTN_AddHomework;
        private System.Windows.Forms.GroupBox GRPBOX_AddSubject;
        private System.Windows.Forms.Label LBL_AddSubject;
        private System.Windows.Forms.GroupBox GRPBOX_AddTeacher;
        private System.Windows.Forms.Label LBL_AddTeacher;
        private System.Windows.Forms.GroupBox GRPBOX_AddClass;
        private System.Windows.Forms.Label LBL_AddClass;
        private System.Windows.Forms.GroupBox GRPBOX_AddHomework;
        private System.Windows.Forms.Label LBL_AddHomework;
    }
}