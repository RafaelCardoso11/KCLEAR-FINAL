using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KCLEAR_FINAL
{
    public partial class page_booster : Form
    {
        page_main main = new page_main();
        public page_booster()
        {
            InitializeComponent();
            timer1.Start();
            main.buttonOff(false);
        }
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.ico_logo_kodar_true;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.ico_logo_kodar_false;
        }
       
        private void panel9_Paint(object sender, PaintEventArgs e)
        {
        }
        private int letraTimerTrade;
        private void timer1_Tick(object sender, EventArgs e)
        {

            letraTimerTrade++;
            if (letraTimerTrade == 1)
            {
                label_textInicial.Text = "Qualquer problema avisem em nossas redes sociais";
            }
            else if (letraTimerTrade == 2)
            {
                label_textInicial.Text = "Essa versão ainda está em Beta";
            }
            else if (letraTimerTrade == 3)
            {
                label_textInicial.Text = "O Kodar clear é Gratuito!";
            }
            else if (letraTimerTrade == 4)
            {
                label_textInicial.Text = "Otimize seu computador caso esteja com lags";
            }
            else if (letraTimerTrade == 5)
            {
                letraTimerTrade = 0;
            }

        }
        private void tradeForm(Form page)
        {
            page.Show();
        }
        private void progressInicializar()
        {
           
            progressBar1.Step = 1;
            progressBar1.Value = 0;
            progressBar1.Maximum = 100;
            for (int i=1; i<=100; i++)
            {
                Thread.Sleep(5);
                progressBar1.Value+=1;
                if (progressBar1.Value == 100)
                {
                   main.menuProgressBarActive(true);
                }
            }
        }
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            progressInicializar();
        }

        private void label_textInicial_MouseHover(object sender, EventArgs e)
        {
            label_textInicial.Font = new Font("Bebas Neue", 15) ;
        }

        private void label_textInicial_MouseLeave(object sender, EventArgs e)
        {
            label_textInicial.Font = new Font("Bebas Neue", 14);
        }
    }
}
