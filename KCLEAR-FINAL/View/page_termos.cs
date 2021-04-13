using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KCLEAR_FINAL
{
    public partial class page_termos : Form
    {
        public page_termos()
        {
            InitializeComponent();
        }

        private void label8_MouseHover(object sender, EventArgs e)
        {
            label8.BackColor = Color.FromArgb(255,210,0);
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            label7.BackColor = Color.FromArgb(255, 210, 0);
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.BackColor = Color.FromArgb(255, 198, 0);
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.BackColor = Color.FromArgb(255, 198, 0);
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.configuracao_botao_laranja;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.configuracao_botao;
        }
        private void hideConfig(Form page)
        {
            page.Dock = DockStyle.Fill;
            page.TopLevel = false;
            panel_termos.Controls.Add(page);
           panel_termos.BringToFront();
            page.Show();
        }
      

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            hideConfig(new page_configApp());
        }

    }
}
