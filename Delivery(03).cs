using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_LoadingScreen
{
    public partial class Delivery_03_ : UserControl
    {
        public Delivery_03_()
        {
            InitializeComponent();
        }

        private void Delivery_03__Load(object sender, EventArgs e)
        {
            panel4.Size = new Size(panel4.Size.Width, 30);
        }
        int panel1_y = 30; int waiter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            waiter++;
            if (waiter > 150)
            {
                label1.Hide();
                panel1_y += 6;
                panel4.Size = new Size(panel4.Size.Width, panel1_y);
                if (panel1_y > 251)
                {
                    panel1.Hide();
                    timer1.Enabled = false;

                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
    }
}
