using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iAcademico.View
{
    public partial class F_VIEW_Add : Form
    {
        public F_VIEW_Add()
        {
            InitializeComponent();
        }

        public string last_screen = "string";

        public void Close_last_screen()
        {
            switch (last_screen)
            {
                case "Subject":
                    GRPBOX_AddSubject.Enabled = false;
                    GRPBOX_AddSubject.Visible = false;
                    break;

                case "Teacher":
                    GRPBOX_AddTeacher.Enabled = false;
                    GRPBOX_AddTeacher.Visible = false;
                    break;

                case "Class":
                    GRPBOX_AddClass.Enabled = false;
                    GRPBOX_AddClass.Visible = false;
                    break;

                case "Homework":
                    GRPBOX_AddHomework.Enabled = false;
                    GRPBOX_AddHomework.Visible = false;
                    break;

                default:
                    return;
            }
        }



        private void PICT_BACK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_AddSubject_Click(object sender, EventArgs e)
        {
            Close_last_screen();
            GRPBOX_AddSubject.Visible = true;
            GRPBOX_AddSubject.Enabled = true;
            last_screen = "Subject";
        }

        private void BTN_AddTeacher_Click(object sender, EventArgs e)
        {
            Close_last_screen();
            GRPBOX_AddTeacher.Visible = true;
            GRPBOX_AddTeacher.Enabled = true;
            last_screen = "Teacher";
        }

        private void BTN_AddClass_Click(object sender, EventArgs e)
        {
            Close_last_screen();
            GRPBOX_AddClass.Visible = true;
            GRPBOX_AddClass.Enabled = true;
            last_screen = "Class";
        }

        private void BTN_AddHomework_Click(object sender, EventArgs e)
        {
            Close_last_screen();
            GRPBOX_AddHomework.Visible = true;
            GRPBOX_AddHomework.Enabled = true;
            last_screen = "Homework";
        }
    }
}
