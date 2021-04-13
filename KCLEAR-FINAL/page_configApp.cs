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
    public partial class page_configApp : Form
    {
        public page_configApp()
        {
            InitializeComponent();
            config();
        }
        private void config()
        {
            panel_linguagem.Visible = false;
            panel_modo.Visible = false;
        }
        private void button_linguage_Click(object sender, EventArgs e)
        {
            if (panel_linguagem.Visible == false)
            {
                if (panel16.Visible == false) {
                    panel16.Visible = true;
                }
                panel13.Visible = false;
                panel_modo.Visible = false;
                panel_linguagem.Visible = true;
            }
            else if(panel_linguagem.Visible == true)
            {
                panel13.Visible = true;
                panel_linguagem.Visible = false;
            }
        }

        private void button_modo_Click(object sender, EventArgs e)
        {
            if (panel_modo.Visible == false)
            {
                panel11.Visible = false;
                panel13.Visible = false;
                panel_linguagem.Visible = false;
                panel_modo.Visible = true;
            }
            else if (panel_modo.Visible == true)
            {
                panel11.Visible = true;
                panel13.Visible = true;
                panel_modo.Visible = false;
            }
        }
        private void tradeLinguagem(int lang)
        {
           switch (lang)
            {
                case 1: //Portugues
                    label5.Text = "Escolha a linguagem";
                    button_linguage.Text = "Selecione a Linguagem";
                    label9.Text = "Ingles (EU)";
                    label7.Text = "Espanhol (ES)";
                    label1.Text = "Escolha seu tema";
                    button_modo.Text = "Selecione o modo";
                    label4.Text = "Escuro";
                    label3.Text = "Claro";
                    break;
                case 2: //Ingles
                    label5.Text = "Choose the language";
                    button_linguage.Text = "Select Language";
                    label9.Text = "English (EU)";
                    label7.Text = "Spanish (ES)";
                    label1.Text = "Choose your theme";
                    button_modo.Text = "Select the mode";
                    label4.Text = "Dark";
                    label3.Text = "clear";
                    break;
                case 3: //Espanhol
                    label5.Text = "Seguir un idioma";
                    button_linguage.Text = "Seleccionar idioma";
                    label9.Text = "English (EU)";
                    label7.Text = "Español (ES)";
                    label1.Text = "Elija su tema";
                    button_modo.Text = "Selecione o modo";
                    label4.Text = "Oscuro";
                    label3.Text = "Claro";
                    break;
            }

        }
        private void tradeModoColor(int color)
        {
            switch (color)
            {
                case 1: //Escuro
                    panel4.BackColor = Color.FromArgb(50,50,50);
                    panel7.BackColor = Color.FromArgb(50, 50, 50);
                    panel5.BackColor = Color.FromArgb(50, 50, 50);
                    panel6.BackColor = Color.FromArgb(50, 50, 50);
                    panel3.BackColor = Color.FromArgb(50, 50, 50);
                    panel8.BackColor = Color.FromArgb(50, 50, 50);
                    panel9.BackColor = Color.FromArgb(50, 50, 50);
                    panel10.BackColor = Color.FromArgb(50, 50, 50);
                    label1.ForeColor = Color.White;
                    label5.ForeColor = Color.White;
                    panel1.BackColor = Color.FromArgb(255, 198, 0);
                    panel12.BackColor = Color.FromArgb(255, 198, 0);
                    panel_linguagem.BackColor = Color.FromArgb(255, 198, 0);
                    panel_modo.BackColor = Color.FromArgb(255, 198, 0);
                    label4.ForeColor = Color.Black;
                    label10.ForeColor = Color.Black;
                    break;
                case 2: //Claro
                    panel4.BackColor =  Color.White;
                    panel7.BackColor = Color.White;
                    panel5.BackColor = Color.White;
                    panel6.BackColor = Color.White;
                    panel3.BackColor = Color.White;
                    panel8.BackColor = Color.White;
                    panel9.BackColor = Color.White;
                    panel10.BackColor = Color.White;
                    label1.ForeColor = Color.Black;
                    label5.ForeColor = Color.Black;
                    panel1.BackColor = Color.Black;
                    panel12.BackColor = Color.Black;
                    panel_linguagem.BackColor = Color.Black;
                    panel_modo.BackColor = Color.Black;
                    label4.ForeColor = Color.White;
                    label10.ForeColor = Color.White;


                    break;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            tradeLinguagem(1);
        }
        private void label9_Click(object sender, EventArgs e)
        {
            tradeLinguagem(2);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            tradeLinguagem(3);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            tradeModoColor(1);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            tradeModoColor(2);
        }
        private void label10_MouseHover(object sender, EventArgs e)
        {
            label10.BackColor = Color.FromArgb(255, 210, 0);
        }
        private void label9_MouseHover(object sender, EventArgs e)
        {
            label9.BackColor = Color.FromArgb(255, 210, 0);
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            label7.BackColor = Color.FromArgb(255, 210, 0);
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.BackColor = Color.FromArgb(255, 210, 0);
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.BackColor = Color.FromArgb(255, 210, 0);
        }
        private void label10_MouseLeave(object sender, EventArgs e)
        {
            label10.BackColor = Color.FromArgb(255, 198, 0);
        }
        private void label9_MouseLeave(object sender, EventArgs e)
        {
            label9.BackColor = Color.FromArgb(255,198,0);
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.BackColor = Color.FromArgb(255, 198, 0);
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.BackColor = Color.FromArgb(255, 198, 0);
        }
        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.BackColor = Color.FromArgb(255, 198, 0);
        }

        
    }
}
