using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.View;
using WindowsFormsApp1.Properties;


namespace WindowsFormsApp1
{

    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void BUTTON_EXIT_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void BUTTON_VisualizeScreen_Click(object sender, EventArgs e)
        {
            Hide();
            Form mod = new VisualizeScreen();
            mod.Show();
            Show();
        }

        private void BUTTON_AddScreen_Click(object sender, EventArgs e)
        {
            Hide();
            Form mod = new AddScreen();
            mod.ShowDialog();
            Show();

        }
    }
}

