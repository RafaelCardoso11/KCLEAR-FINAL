using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace KCLEAR_FINAL
{
    public partial class page_main : Form
    {
        public page_main()
        {
            InitializeComponent();
            initialActive();
        }
        #region Configs
        private Form active = null;
        private void tradeForm(Form trade)
        {
            if (active != null)
            {
                active.Close();
            }
          
            active = trade;
            trade.Dock = DockStyle.Fill;
            trade.TopLevel = false;
            panel_main.Controls.Add(trade);
            panel_main.Tag = trade;
            trade.Show();
           
           
        }
     
        private void initialActive()
        {
            panel_lateral.BringToFront();
            tradeForm(new page_booster());
            button_boost.Image = Properties.Resources.foguete_laranja;
            panel_lateral.Visible = false;
            efectPanel.Visible = false;
            panel_main.Dock = DockStyle.Fill;
        }
        #endregion
        #region LateralApper
        private void button_menu_Click(object sender, EventArgs e)
        {
            Thread.Sleep(150);
            if (panel_lateral.Visible == false)
            {
                panel_lateral.Visible = true;
                button_menu.Visible = false;
                panel_top.Visible = false;
                panel_bottom.Visible = false;
                efectPanelColor(true);

            }
            else
            {
                panel_lateral.Visible = false;
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Thread.Sleep(150);
            if (panel_lateral.Visible == true)
            {
                panel_lateral.Visible = false;
                button_menu.Visible = true;
                panel_top.Visible = true;
                panel_bottom.Visible = true;
                efectPanelColor(false);

            }
            else
            {
                panel_lateral.Visible = false;
            }

        }
        #endregion
        #region ColorEfects
        private void efectPanelColor(bool active)
        {
            if (active == true)
            {
                Thread.Sleep(100);
                efectPanel.BringToFront();
                efectPanel.Visible = true;
                efectPanel.BackColor = Color.FromArgb(220, Color.Black);
            }
            else
            {
                efectPanel.Visible = false;
            }
        }
        #region ColorMenuLateral
        private void colorButtonWhite(int i)
        {
            if (i == 1)
            {
                button_boost.Image = Properties.Resources.foguete_branco;
                button_termos.Image = Properties.Resources.icone_kodar_branco;
            }
            else if (i == 2)
            {
                button_comunity.Image = Properties.Resources.comunidade_branco;
                button_boost.Image = Properties.Resources.foguete_branco;
            }
            else if (i == 3)
            {
                button_comunity.Image = Properties.Resources.comunidade_branco;
                button_termos.Image = Properties.Resources.icone_kodar_branco;
            }
           

        }

        private void button_comunity_MouseHover(object sender, EventArgs e)
        {
                
                colorButtonWhite(1);
            if (button_comunity.Image != Properties.Resources.comunidade_laranja)
            {
                button_comunity.Image = Properties.Resources.comunidade_laranja;
            }
              
        }

        private void button_termos_MouseHover(object sender, EventArgs e)
        {
                colorButtonWhite(2);
               if (button_termos.Image != Properties.Resources.icone_kodar_laranja){
                button_termos.Image = Properties.Resources.icone_kodar_laranja;
            }
            
        }

        private void button_boost_MouseHover(object sender, EventArgs e)
        {
                colorButtonWhite(3);
            if (button_boost.Image != Properties.Resources.foguete_laranja)
            {
                button_boost.Image = Properties.Resources.foguete_laranja;
            }
        }
        #endregion
        #endregion
        #region ButtonClick
        private void button_comunity_Click(object sender, EventArgs e)
        {
            tradeForm(new page_comunity());
            if (panel_lateral.Visible == true)
            {
                panel_lateral.Visible = false;
                button_menu.Visible = true;
                button_comunity.Image = Properties.Resources.comunidade_laranja;
                colorButtonWhite(1);
                panel_main.BackgroundImage = Properties.Resources.Foto2;
                panel_top.Visible = true;
                panel_bottom.Visible = true;
                efectPanelColor(false);

            }

        }
        private void button_termos_Click(object sender, EventArgs e)
        {
            tradeForm(new page_termos());
            if (panel_lateral.Visible == true)
            {
                panel_lateral.Visible = false;
                button_menu.Visible = true;
                panel_top.Visible = true;
                panel_bottom.Visible = true;
                button_termos.Image = Properties.Resources.icone_kodar_laranja;
                colorButtonWhite(2);
                panel_main.BackgroundImage = Properties.Resources.Foto3;
                efectPanelColor(false);

            }
        }

        private void button_boost_Click(object sender, EventArgs e)
        {
            tradeForm(new page_booster());
            if (panel_lateral.Visible == true){
                panel_lateral.Visible = false;
                button_menu.Visible = true;
                panel_top.Visible = true;
                panel_bottom.Visible = true;
                button_boost.Image = Properties.Resources.foguete_laranja;
                colorButtonWhite(3);
                panel_main.BackgroundImage = Properties.Resources.Foto1;
                efectPanelColor(false);
            }
          
        }
        #endregion
        #region RedesSociaisEfect

        private void pictureBox1_MouseHover(object sender, EventArgs e) //site
        {
            pictureBox1.BackColor = Color.FromArgb(70,70,70);
        }
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(70, 70, 70);
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(70, 70, 70);
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.FromArgb(70, 70, 70);
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e) //site
        {
            pictureBox1.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.FromArgb(50, 50, 50);
        }
        #endregion
        #region page_initialConfigs
        public void buttonOff(bool off)
        {
            button_menu.Visible = off;
        }
        public void menuProgressBarActive(bool active)
        {
            if (active == true) { 
                panel_lateral.Visible = true;
            }
        }
        #endregion
    }
}
