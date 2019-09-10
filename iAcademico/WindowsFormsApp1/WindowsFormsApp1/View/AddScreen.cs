using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.View
{
    public partial class AddScreen : Form
    {
        public AddScreen()
        {
            InitializeComponent();
        }

        public void SHOW_ALL_ADDCLASS(){
            GRPBOX_ADDCLASS.Show();


        }

        private void BUTTON_ADDCLASS_Click(object sender, EventArgs e)
        {
            SHOW_ALL_ADDCLASS();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
