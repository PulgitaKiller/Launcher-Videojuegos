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
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new pagHome());
        }

        private void btnSnake_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new pagSnake());
        }

        private void btnSimon_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new pagSimon());
        }

        private void btnBird_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new pagBird());
        }

        private void btnTopo_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new pagTopo());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private int i = 0;

        private void label1_Click(object sender, EventArgs e)
        {
            if(i < 11)
            {
                switch (i)
                {
                    case 0:
                        lblUsuario.Text = "👧";
                        break;
                    case 1:
                        lblUsuario.Text = "👨";
                        break;
                    case 2:
                        lblUsuario.Text = "👩";
                        break;
                    case 3:
                        lblUsuario.Text = "🤴";
                        break;
                    case 4:
                        lblUsuario.Text = "👸";
                        break;
                    case 5:
                        lblUsuario.Text = "🐵";
                        break;
                    case 6:
                        lblUsuario.Text = "😺";
                        break;
                    case 7:
                        lblUsuario.Text = "🐶";
                        break;
                    case 8:
                        lblUsuario.Text = "🦝";
                        break;
                    case 9:
                        lblUsuario.Text = "🐸";
                        break;
                    case 10:
                        lblUsuario.Text = "🧒";
                        break;
                }
            }
            else
            {
                i = -1;
            }

            i++;
        }
    }
}
