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
    public partial class F_VIEW_MainMenu : Form
    {
        public F_VIEW_MainMenu()
        {
            InitializeComponent();
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            Hide();
            F_VIEW_Add addscreen = new F_VIEW_Add();
            addscreen.ShowDialog();
            Show();
        }

        private void PICT_CLOSE_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_Visualize_Click(object sender, EventArgs e)
        {
            Hide();
            F_VIEW_Visualize visscreen = new F_VIEW_Visualize();
            visscreen.ShowDialog();
            Show();
        }

        private void BTN_About_Click(object sender, EventArgs e)
        {
            
        }
    }
}
