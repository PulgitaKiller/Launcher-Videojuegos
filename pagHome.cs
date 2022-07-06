using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher
{
    public partial class pagHome : Form
    {
        public pagHome()
        {
            InitializeComponent();
        }

        private int i = 0;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            switch (i)
            {
                case 0:
                    lblSnake.Visible = true;
                    break;
                case 1:
                    lblTopo.Visible = true;
                    break;
                case 2:
                    lblSimon.Visible = true;
                    break;
                case 3:
                    lblBird.Visible = true;
                    break;
            }

            i++;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
