using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_LoadingScreen
{
    public partial class Takeout : UserControl
    {
        int panel1_y = 30; int waiter = 0;
        public Takeout()
        {
            InitializeComponent();
        }

        private void Takeout_Load(object sender, EventArgs e)
        {
            panel4.Size = new Size(panel4.Size.Width, 30);
        }

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
    }
}
