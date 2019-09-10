namespace WindowsFormsApp1.View
{
    partial class AddScreen
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
            this.BUTTON_ADDCLASS = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.GRPBOX_ADDCLASS = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LBL_PROFESSOR = new System.Windows.Forms.Label();
            this.TEXTBOX_Name = new System.Windows.Forms.TextBox();
            this.CHECK_LISTBOX_DAYS = new System.Windows.Forms.CheckedListBox();
            this.CBOX_FIM_MIN = new System.Windows.Forms.ComboBox();
            this.CBOX_FIM_HOUR = new System.Windows.Forms.ComboBox();
            this.LABEL_HORARIO_FIM = new System.Windows.Forms.Label();
            this.CBOX_INICIO_MIN = new System.Windows.Forms.ComboBox();
            this.CBOX_INICIO_HOUR = new System.Windows.Forms.ComboBox();
            this.LABEL_HORARIO_INIC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LABEL_DISCIPLINA = new System.Windows.Forms.Label();
            this.BUTTON_CLEAR = new System.Windows.Forms.Button();
            this.BUTTON_OK = new System.Windows.Forms.Button();
            this.BTN_EXIT = new System.Windows.Forms.Button();
            this.GRPBOX_ADDCLASS.SuspendLayout();
            this.SuspendLayout();
            // 
            // BUTTON_ADDCLASS
            // 
            this.BUTTON_ADDCLASS.Location = new System.Drawing.Point(23, 84);
            this.BUTTON_ADDCLASS.Name = "BUTTON_ADDCLASS";
            this.BUTTON_ADDCLASS.Size = new System.Drawing.Size(193, 53);
            this.BUTTON_ADDCLASS.TabIndex = 0;
            this.BUTTON_ADDCLASS.Text = "add class";
            this.BUTTON_ADDCLASS.UseVisualStyleBackColor = true;
            this.BUTTON_ADDCLASS.Click += new System.EventHandler(this.BUTTON_ADDCLASS_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "add homework";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 53);
            this.button2.TabIndex = 2;
            this.button2.Text = "add teacher";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // GRPBOX_ADDCLASS
            // 
            this.GRPBOX_ADDCLASS.Controls.Add(this.textBox1);
            this.GRPBOX_ADDCLASS.Controls.Add(this.LBL_PROFESSOR);
            this.GRPBOX_ADDCLASS.Controls.Add(this.TEXTBOX_Name);
            this.GRPBOX_ADDCLASS.Controls.Add(this.CHECK_LISTBOX_DAYS);
            this.GRPBOX_ADDCLASS.Controls.Add(this.CBOX_FIM_MIN);
            this.GRPBOX_ADDCLASS.Controls.Add(this.CBOX_FIM_HOUR);
            this.GRPBOX_ADDCLASS.Controls.Add(this.LABEL_HORARIO_FIM);
            this.GRPBOX_ADDCLASS.Controls.Add(this.CBOX_INICIO_MIN);
            this.GRPBOX_ADDCLASS.Controls.Add(this.CBOX_INICIO_HOUR);
            this.GRPBOX_ADDCLASS.Controls.Add(this.LABEL_HORARIO_INIC);
            this.GRPBOX_ADDCLASS.Controls.Add(this.label1);
            this.GRPBOX_ADDCLASS.Controls.Add(this.LABEL_DISCIPLINA);
            this.GRPBOX_ADDCLASS.Controls.Add(this.BUTTON_CLEAR);
            this.GRPBOX_ADDCLASS.Controls.Add(this.BUTTON_OK);
            this.GRPBOX_ADDCLASS.Location = new System.Drawing.Point(321, 84);
            this.GRPBOX_ADDCLASS.Name = "GRPBOX_ADDCLASS";
            this.GRPBOX_ADDCLASS.Size = new System.Drawing.Size(541, 392);
            this.GRPBOX_ADDCLASS.TabIndex = 4;
            this.GRPBOX_ADDCLASS.TabStop = false;
            this.GRPBOX_ADDCLASS.Text = "GRPBOX_ADDCLASS";
            this.GRPBOX_ADDCLASS.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(335, 20);
            this.textBox1.TabIndex = 13;
            // 
            // LBL_PROFESSOR
            // 
            this.LBL_PROFESSOR.AutoSize = true;
            this.LBL_PROFESSOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_PROFESSOR.Location = new System.Drawing.Point(15, 87);
            this.LBL_PROFESSOR.Name = "LBL_PROFESSOR";
            this.LBL_PROFESSOR.Size = new System.Drawing.Size(92, 22);
            this.LBL_PROFESSOR.TabIndex = 12;
            this.LBL_PROFESSOR.Text = "Professor:";
            // 
            // TEXTBOX_Name
            // 
            this.TEXTBOX_Name.Location = new System.Drawing.Point(32, 54);
            this.TEXTBOX_Name.Name = "TEXTBOX_Name";
            this.TEXTBOX_Name.Size = new System.Drawing.Size(335, 20);
            this.TEXTBOX_Name.TabIndex = 11;
            // 
            // CHECK_LISTBOX_DAYS
            // 
            this.CHECK_LISTBOX_DAYS.ColumnWidth = 80;
            this.CHECK_LISTBOX_DAYS.FormattingEnabled = true;
            this.CHECK_LISTBOX_DAYS.HorizontalScrollbar = true;
            this.CHECK_LISTBOX_DAYS.Items.AddRange(new object[] {
            "Segunda",
            "Terça",
            "Quarta",
            "Quinta",
            "Sexta",
            "Sábado",
            "Domingo"});
            this.CHECK_LISTBOX_DAYS.Location = new System.Drawing.Point(32, 228);
            this.CHECK_LISTBOX_DAYS.MultiColumn = true;
            this.CHECK_LISTBOX_DAYS.Name = "CHECK_LISTBOX_DAYS";
            this.CHECK_LISTBOX_DAYS.Size = new System.Drawing.Size(165, 94);
            this.CHECK_LISTBOX_DAYS.TabIndex = 10;
            // 
            // CBOX_FIM_MIN
            // 
            this.CBOX_FIM_MIN.FormattingEnabled = true;
            this.CBOX_FIM_MIN.Items.AddRange(new object[] {
            "00",
            "05",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.CBOX_FIM_MIN.Location = new System.Drawing.Point(307, 168);
            this.CBOX_FIM_MIN.Name = "CBOX_FIM_MIN";
            this.CBOX_FIM_MIN.Size = new System.Drawing.Size(46, 21);
            this.CBOX_FIM_MIN.TabIndex = 9;
            // 
            // CBOX_FIM_HOUR
            // 
            this.CBOX_FIM_HOUR.FormattingEnabled = true;
            this.CBOX_FIM_HOUR.Items.AddRange(new object[] {
            "00:",
            "01:",
            "02:",
            "03:",
            "04:",
            "05:",
            "06:",
            "07:",
            "08:",
            "09:",
            "10:",
            "11:",
            "12:",
            "13:",
            "14:",
            "15:",
            "16:",
            "17:",
            "18:",
            "19:",
            "20:",
            "21:",
            "22:",
            "23:"});
            this.CBOX_FIM_HOUR.Location = new System.Drawing.Point(256, 168);
            this.CBOX_FIM_HOUR.Name = "CBOX_FIM_HOUR";
            this.CBOX_FIM_HOUR.Size = new System.Drawing.Size(46, 21);
            this.CBOX_FIM_HOUR.TabIndex = 8;
            // 
            // LABEL_HORARIO_FIM
            // 
            this.LABEL_HORARIO_FIM.AutoSize = true;
            this.LABEL_HORARIO_FIM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_HORARIO_FIM.Location = new System.Drawing.Point(244, 143);
            this.LABEL_HORARIO_FIM.Name = "LABEL_HORARIO_FIM";
            this.LABEL_HORARIO_FIM.Size = new System.Drawing.Size(119, 22);
            this.LABEL_HORARIO_FIM.TabIndex = 7;
            this.LABEL_HORARIO_FIM.Text = "Horário - Fim:";
            // 
            // CBOX_INICIO_MIN
            // 
            this.CBOX_INICIO_MIN.FormattingEnabled = true;
            this.CBOX_INICIO_MIN.Items.AddRange(new object[] {
            "00",
            "05",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.CBOX_INICIO_MIN.Location = new System.Drawing.Point(84, 168);
            this.CBOX_INICIO_MIN.Name = "CBOX_INICIO_MIN";
            this.CBOX_INICIO_MIN.Size = new System.Drawing.Size(46, 21);
            this.CBOX_INICIO_MIN.TabIndex = 6;
            // 
            // CBOX_INICIO_HOUR
            // 
            this.CBOX_INICIO_HOUR.FormattingEnabled = true;
            this.CBOX_INICIO_HOUR.Items.AddRange(new object[] {
            "00:",
            "01:",
            "02:",
            "03:",
            "04:",
            "05:",
            "06:",
            "07:",
            "08:",
            "09:",
            "10:",
            "11:",
            "12:",
            "13:",
            "14:",
            "15:",
            "16:",
            "17:",
            "18:",
            "19:",
            "20:",
            "21:",
            "22:",
            "23:"});
            this.CBOX_INICIO_HOUR.Location = new System.Drawing.Point(32, 168);
            this.CBOX_INICIO_HOUR.Name = "CBOX_INICIO_HOUR";
            this.CBOX_INICIO_HOUR.Size = new System.Drawing.Size(46, 21);
            this.CBOX_INICIO_HOUR.TabIndex = 5;
            this.CBOX_INICIO_HOUR.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // LABEL_HORARIO_INIC
            // 
            this.LABEL_HORARIO_INIC.AutoSize = true;
            this.LABEL_HORARIO_INIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_HORARIO_INIC.Location = new System.Drawing.Point(21, 143);
            this.LABEL_HORARIO_INIC.Name = "LABEL_HORARIO_INIC";
            this.LABEL_HORARIO_INIC.Size = new System.Drawing.Size(131, 22);
            this.LABEL_HORARIO_INIC.TabIndex = 4;
            this.LABEL_HORARIO_INIC.Text = "Horário - Início:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dias:";
            // 
            // LABEL_DISCIPLINA
            // 
            this.LABEL_DISCIPLINA.AutoSize = true;
            this.LABEL_DISCIPLINA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_DISCIPLINA.Location = new System.Drawing.Point(15, 26);
            this.LABEL_DISCIPLINA.Name = "LABEL_DISCIPLINA";
            this.LABEL_DISCIPLINA.Size = new System.Drawing.Size(92, 22);
            this.LABEL_DISCIPLINA.TabIndex = 2;
            this.LABEL_DISCIPLINA.Text = "Disciplina:";
            // 
            // BUTTON_CLEAR
            // 
            this.BUTTON_CLEAR.Location = new System.Drawing.Point(343, 328);
            this.BUTTON_CLEAR.Name = "BUTTON_CLEAR";
            this.BUTTON_CLEAR.Size = new System.Drawing.Size(93, 49);
            this.BUTTON_CLEAR.TabIndex = 1;
            this.BUTTON_CLEAR.Text = "CLEAR";
            this.BUTTON_CLEAR.UseVisualStyleBackColor = true;
            // 
            // BUTTON_OK
            // 
            this.BUTTON_OK.Location = new System.Drawing.Point(442, 328);
            this.BUTTON_OK.Name = "BUTTON_OK";
            this.BUTTON_OK.Size = new System.Drawing.Size(93, 49);
            this.BUTTON_OK.TabIndex = 0;
            this.BUTTON_OK.Text = "OK";
            this.BUTTON_OK.UseVisualStyleBackColor = true;
            // 
            // BTN_EXIT
            // 
            this.BTN_EXIT.Font = new System.Drawing.Font("Myanmar Text", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_EXIT.ForeColor = System.Drawing.Color.Red;
            this.BTN_EXIT.Location = new System.Drawing.Point(897, 12);
            this.BTN_EXIT.Name = "BTN_EXIT";
            this.BTN_EXIT.Size = new System.Drawing.Size(51, 50);
            this.BTN_EXIT.TabIndex = 7;
            this.BTN_EXIT.Text = "<";
            this.BTN_EXIT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_EXIT.UseVisualStyleBackColor = true;
            this.BTN_EXIT.Click += new System.EventHandler(this.BTN_EXIT_Click);
            // 
            // AddScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 582);
            this.Controls.Add(this.BTN_EXIT);
            this.Controls.Add(this.GRPBOX_ADDCLASS);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BUTTON_ADDCLASS);
            this.Name = "AddScreen";
            this.Text = "Form1";
            this.GRPBOX_ADDCLASS.ResumeLayout(false);
            this.GRPBOX_ADDCLASS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BUTTON_ADDCLASS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox GRPBOX_ADDCLASS;
        private System.Windows.Forms.Button BTN_EXIT;
        private System.Windows.Forms.ComboBox CBOX_INICIO_HOUR;
        private System.Windows.Forms.Label LABEL_HORARIO_INIC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LABEL_DISCIPLINA;
        private System.Windows.Forms.Button BUTTON_CLEAR;
        private System.Windows.Forms.Button BUTTON_OK;
        private System.Windows.Forms.TextBox TEXTBOX_Name;
        private System.Windows.Forms.CheckedListBox CHECK_LISTBOX_DAYS;
        private System.Windows.Forms.ComboBox CBOX_FIM_MIN;
        private System.Windows.Forms.ComboBox CBOX_FIM_HOUR;
        private System.Windows.Forms.Label LABEL_HORARIO_FIM;
        private System.Windows.Forms.ComboBox CBOX_INICIO_MIN;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LBL_PROFESSOR;
    }
}