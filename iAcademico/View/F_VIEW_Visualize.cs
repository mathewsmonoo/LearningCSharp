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
    public partial class F_VIEW_Visualize : Form
    {
        public F_VIEW_Visualize()
        {
            InitializeComponent();
        }

        private void PICT_BACK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
