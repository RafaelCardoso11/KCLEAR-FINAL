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
    public partial class page_comunity : Form
    {
        public page_comunity()
        {
            InitializeComponent();
            timer1.Start();
        }
        #region efectFont

        private void label1_MouseHover(object sender, EventArgs e)
        {
            letra1.Font = new Font("Bebas", 23);
        }
        private void letra1_MouseLeave(object sender, EventArgs e)
        {
            letra1.Font = new Font("Bebas", 22);
        }

        private void letra2_MouseHover(object sender, EventArgs e)
        {
            letra2.Font = new Font("Bebas", 23);
        }

        private void letra2_MouseLeave(object sender, EventArgs e)
        {
            letra2.Font = new Font("Bebas", 22);
        }

        private void letra3_MouseHover(object sender, EventArgs e)
        {
            letra3.Font = new Font("Bebas", 23);
        }

        private void letra3_MouseLeave(object sender, EventArgs e)
        {
            letra3.Font = new Font("Bebas", 22);
        }
        #endregion
        #region efectTradeColor
        private int inicio;
        private void timer1_Tick(object sender, EventArgs e)
        {
            inicio++;
            if (inicio == 1)
            {
               
                button_entrar.BackColor = Color.White;
                button_entrar.ForeColor = Color.Black;
            }
            else if (inicio == 2)
            {
               
                button_entrar.BackColor = Color.FromArgb(255, 198, 0);
                button_entrar.ForeColor = Color.White;
            }

            else if (inicio == 3)
            {
                inicio = 0;
            }
          
        }

        private void button_entrar_MouseHover(object sender, EventArgs e)
        {
            timer1.Stop();
           
            button_entrar.Font = new Font("Bebas", 19);
           
           
        }

        private void button_entrar_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
            button_entrar.Font = new Font("Bebas", 18);

        }
        #endregion
    }
}
