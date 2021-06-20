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
    public partial class Menu_Form : Form
    {
        int amount1, amount2, amount3, amount4, amount5 = 0, amount6 = 0, amount7 = 0, amount8 = 0, total;
        double discount;
        public Menu_Form()
        {
            InitializeComponent();
            panel8.Visible = false;
            panel15.Visible = false;
            panel16.Visible = false;
            panel17.Visible = false;
            Qty.Visible = false;
            label18.Visible = false;
            label31.Visible = false;
            label32.Visible = false;
            label33.Visible = false;
            label34.Visible = false;
            label35.Visible = false;
            label36.Visible = false;
            label37.Visible = false;
            label38.Visible = false;
            label39.Visible = false;
            label40.Visible = false;
            label41.Visible = false;
            label42.Visible = false;
            label43.Visible = false;
            label44.Visible = false;
            label45.Visible = false;
            panel17.Visible = false;
            button4.Hide();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            HorizontalScroll.Maximum = 0;
            AutoScroll = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home_Page Hp = new Home_Page();
            Hp.Show();
            this.Hide();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            HorizontalScroll.Maximum = 0;
            AutoScroll = true;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            amount2 = 0;
            if (label16.Text == "" && label32.Text == "" && label33.Text == "")
            {
                if (comboBox2.Text == "Small Pan")
                {
                    amount2 = 300;
                    label32.Text = "Checken Tikka Small";
                    label16.Text = "1";
                    label33.Text = "" + amount2;
                }
                else if (comboBox2.Text == "Medium Pan")
                {
                    amount2 = 500;
                    label16.Text = "1";
                    label33.Text = "" + amount2;
                    label32.Text = "Checken Tikka Medium";
                }
                else if (comboBox2.Text == "Large Pan")
                {
                    amount2 = 800;
                    label16.Text = "1";
                    label33.Text = "" + amount2;
                    label32.Text = "Checken Tikka Large";
                }
                else if (comboBox2.Text == "XL Pan")
                {
                    amount2 = 1000;
                    label16.Text = "1";
                    label33.Text = "" + amount2;
                    label32.Text = "Checken Tikka XL";
                }
            }
            else if (label34.Text == "" && label35.Text == "" && label36.Text == "")
            {
                if (comboBox2.Text == "Small Pan")
                {
                    amount2 = 300;
                    label34.Text = "1";
                    label36.Text = "" + amount2;
                    label35.Text = "Checken Tikka Small";
                }
                else if (comboBox2.Text == "Medium Pan")
                {
                    amount2 = 500;
                    label34.Text = "1";
                    label36.Text = "" + amount2;
                    label35.Text = "Checken Tikka Medium";
                }
                else if (comboBox2.Text == "Large Pan")
                {
                    amount2 = 800;
                    label34.Text = "1";
                    label36.Text = "" + amount2;
                    label35.Text = "Checken Tikka Large";
                }
                else if (comboBox2.Text == "XL Pan")
                {
                    amount2 = 1000;
                    label34.Text = "1";
                    label36.Text = "" + amount2;
                    label35.Text = "Checken Tikka XL";
                }
            }
            else if (label37.Text == "" && label38.Text == "" && label39.Text == "")
            {
                if (comboBox2.Text == "Small Pan")
                {
                    amount2 = 300;
                    label38.Text = "Checken Tikka Small";
                    label37.Text = "1";
                    label39.Text = "" + amount2;
                }
                else if (comboBox2.Text == "Medium Pan")
                {
                    amount2 = 500;
                    label37.Text = "1";
                    label39.Text = "" + amount2;
                    label38.Text = "Checken Tikka Medium";
                }
                else if (comboBox2.Text == "Large Pan")
                {
                    amount2 = 800;
                    label37.Text = "1";
                    label39.Text = "" + amount2;
                    label38.Text = "Checken Tikka Large";
                }
                else if (comboBox2.Text == "XL Pan")
                {
                    amount2 = 1000;
                    label37.Text = "1";
                    label39.Text = "" + amount2;
                    label38.Text = "Checken Tikka XL";
                }
            }
            else if (label40.Text == "" && label41.Text == "" && label42.Text == "")
            {
                if (comboBox2.Text == "Small Pan")
                {
                    amount2 = 300;
                    label40.Text = "1";
                    label42.Text = "" + amount2;
                    label41.Text = "Checken Tikka Small";
                }
                else if (comboBox2.Text == "Medium Pan")
                {
                    amount2 = 500;
                    label40.Text = "1";
                    label42.Text = "" + amount2;
                    label41.Text = "Checken Tikka Medium";
                }
                else if (comboBox2.Text == "Large Pan")
                {
                    amount2 = 800;
                    label40.Text = "1";
                    label42.Text = "" + amount2;
                    label41.Text = "Checken Tikka Large";
                }
                else if (comboBox2.Text == "XL Pan")
                {
                    amount2 = 1000;
                    label40.Text = "1";
                    label42.Text = "" + amount2;
                    label41.Text = "Checken Tikka XL";
                }
            }
            total = amount1 + amount2 + amount3 + amount4 + amount5 + amount6 + amount7 + amount8;
            label43.Text = "" + total;
            if (total > 3000)
            {
                discount = total - (total * 0.2 );
                label45.Text = "" + discount;
            }
            else if (total > 2000 && total < 3000)
            {
                discount = total - (total * 0.1 );
                label45.Text = "" + discount;
            }
            else if (total > 1500 && total < 2000)
            {
                discount = total - (total * 0.05 );
                label45.Text = "" + discount;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            amount3 = 0;
            if (label16.Text == "" && label32.Text == "" && label33.Text == "")
            {
                if (comboBox3.Text == "Small Pan")
                {
                    amount3 = 300;
                    label32.Text = "Faj.Scallions Small";
                    label16.Text = "1";
                    label33.Text = "" + amount3;
                }
                else if (comboBox3.Text == "Medium Pan")
                {
                    amount3 = 500;
                    label32.Text = "Faj.Scallions  Medium";
                    label16.Text = "1";
                    label33.Text = "" + amount3;
                }
                else if (comboBox3.Text == "Large Pan")
                {
                    amount3 = 800;
                    label32.Text = "Faj.Scallions  Large";
                    label16.Text = "1";
                    label33.Text = "" + amount3;
                }
                else if (comboBox3.Text == "XL Pan")
                {
                    amount3 = 1000;
                    label32.Text = "Faj.Scallions  XL";
                    label16.Text = "1";
                    label33.Text = "" + amount3;
                }
            }
            else if (label34.Text == "" && label35.Text == "" && label36.Text == "")
            {
                if (comboBox3.Text == "Small Pan")
                {
                    amount3 = 300;
                    label35.Text = "Faj.Scallions  Small";
                    label34.Text = "1";
                    label36.Text = "" + amount3;
                }
                else if (comboBox3.Text == "Medium Pan")
                {
                    amount3 = 500;
                    label35.Text = "Faj.Scallions Medium";
                    label34.Text = "1";
                    label36.Text = "" + amount3;
                }
                else if (comboBox3.Text == "Large Pan")
                {
                    amount3 = 800;
                    label35.Text = "Faj.Scallions  Large";
                    label34.Text = "1";
                    label36.Text = "" + amount3;
                }
                else if (comboBox3.Text == "XL Pan")
                {
                    amount3 = 1000;
                    label35.Text = "Faj.Scallions XL";
                    label34.Text = "1";
                    label36.Text = "" + amount3;
                }
            }
            else if (label37.Text == "" && label38.Text == "" && label39.Text == "")
            {
                if (comboBox3.Text == "Small Pan")
                {
                    amount3 = 300;
                    label38.Text = "Faj.Scallions  Small";
                    label37.Text = "1";
                    label39.Text = "" + amount3;
                }
                else if (comboBox3.Text == "Medium Pan")
                {
                    amount3 = 500;
                    label38.Text = "Faj.Scallions  Medium";
                    label37.Text = "1";
                    label39.Text = "" + amount3;
                }
                else if (comboBox3.Text == "Large Pan")
                {
                    amount3 = 800;
                    label38.Text = "Faj.Scallions  Large";
                    label37.Text = "1";
                    label39.Text = "" + amount3;
                }
                else if (comboBox3.Text == "XL Pan")
                {
                    amount3 = 1000;
                    label38.Text = "Faj.Scallions  XL";
                    label37.Text = "1";
                    label39.Text = "" + amount3;
                }
            }
            else if (label40.Text == "" && label41.Text == "" && label42.Text == "")
            {
                if (comboBox3.Text == "Small Pan")
                {
                    amount3 = 300;
                    label41.Text = "Faj.Scallions  Small";
                    label40.Text = "1";
                    label42.Text = "" + amount3;

                }
                else if (comboBox3.Text == "Medium Pan")
                {
                    amount3 = 500;
                    label41.Text = "Faj.Scallions  Medium";
                    label40.Text = "1";
                    label42.Text = "" + amount3;
                }
                else if (comboBox3.Text == "Large Pan")
                {
                    amount3 = 800;
                    label41.Text = "Faj.Scallions  Large";
                    label40.Text = "1";
                    label42.Text = "" + amount3;
                }
                else if (comboBox3.Text == "XL Pan")
                {
                    amount3 = 1000;
                    label41.Text = "Faj.Scallions  XL";
                    label40.Text = "1";
                    label42.Text = "" + amount3;
                }
            }
            total = amount1 + amount2 + amount3 + amount4 + amount5 + amount6 + amount7 + amount8;
            label43.Text = "" + total;
            if (total > 3000)
            {
                discount = total - (total * 0.2 );
                label45.Text = "" + discount;
            }
            else if (total > 2000 && total < 3000)
            {
                discount = total - (total * 0.1 );
                label45.Text = "" + discount;
            }
            else if (total > 1500 && total < 2000)
            {
                discount = total - (total * 0.05 );
                label45.Text = "" + discount;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Map mp = new Map();
            mp.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            amount4 = 0;
            if (label16.Text == "" && label32.Text == "" && label33.Text == "")
            {
                if (comboBox4.Text == "Small Pan")
                {
                    amount4 = 300;
                    label32.Text = "Chicken Fajita Small";
                    label16.Text = "1";
                    label33.Text = "" + amount4;
                }
                else if (comboBox4.Text == "Medium Pan")
                {
                    amount4 = 500;
                    label32.Text = "Chicken Fajita  Medium";
                    label16.Text = "1";
                    label33.Text = "" + amount4;
                }
                else if (comboBox4.Text == "Large Pan")
                {
                    amount4 = 800;
                    label32.Text = "Chicken Fajita  Large";
                    label16.Text = "1";
                    label33.Text = "" + amount4;
                }
                else if (comboBox4.Text == "XL Pan")
                {
                    amount4 = 1000;
                    label32.Text = "Chicken Fajita  XL";
                    label16.Text = "1";
                    label33.Text = "" + amount4;
                }
            }
            else if (label34.Text == "" && label35.Text == "" && label36.Text == "")
            {
                if (comboBox4.Text == "Small Pan")
                {
                    amount4 = 300;
                    label35.Text = "Chicken Fajita Small";
                    label34.Text = "1";
                    label36.Text = "" + amount4;
                }
                else if (comboBox4.Text == "Medium Pan")
                {
                    amount4 = 500;
                    label35.Text = "Chicken Fajita Medium";
                    label34.Text = "1";
                    label36.Text = "" + amount4;
                }
                else if (comboBox4.Text == "Large Pan")
                {
                    amount4 = 800;
                    label35.Text = "Chicken Fajita Large";
                    label34.Text = "1";
                    label36.Text = "" + amount4;
                }
                else if (comboBox4.Text == "XL Pan")
                {
                    amount4 = 1000;
                    label35.Text = "Chicken Fajita XL";
                    label34.Text = "1";
                    label36.Text = "" + amount4;
                }
            }
            else if (label37.Text == "" && label38.Text == "" && label39.Text == "")
            {
                if (comboBox4.Text == "Small Pan")
                {
                    amount4 = 300;
                    label38.Text = "Chicken Fajita  Small";
                    label37.Text = "1";
                    label39.Text = "" + amount4;
                }
                else if (comboBox4.Text == "Medium Pan")
                {
                    amount4 = 500;
                    label38.Text = "Chicken Fajita  Medium";
                    label37.Text = "1";
                    label39.Text = "" + amount4;
                }
                else if (comboBox4.Text == "Large Pan")
                {
                    amount4 = 800;
                    label38.Text = "Chicken Fajita Large";
                    label37.Text = "1";
                    label39.Text = "" + amount4;
                }
                else if (comboBox4.Text == "XL Pan")
                {
                    amount4 = 1000;
                    label38.Text = "Chicken Fajita XL";
                    label37.Text = "1";
                    label39.Text = "" + amount4;
                }
            }
            else if (label40.Text == "" && label41.Text == "" && label42.Text == "")
            {
                if (comboBox4.Text == "Small Pan")
                {
                    amount4 = 300;
                    label41.Text = "Chicken Fajita Small";
                    label40.Text = "1";
                    label42.Text = "" + amount4;
                }
                else if (comboBox4.Text == "Medium Pan")
                {
                    amount4 = 500;
                    label41.Text = "Chicken Fajita Medium";
                    label40.Text = "1";
                    label42.Text = "" + amount4;
                }
                else if (comboBox4.Text == "Large Pan")
                {
                    amount4 = 800;
                    label41.Text = "Chicken Fajita Large";
                    label40.Text = "1";
                    label42.Text = "" + amount4;
                }
                else if (comboBox4.Text == "XL Pan")
                {
                    amount4 = 1000;
                    label41.Text = "Chicken Fajita XL";
                    label40.Text = "1";
                    label42.Text = "" + amount4;
                }
            }
            total = amount1 + amount2 + amount3 + amount4 + amount5 + amount6 + amount7 + amount8;
            label43.Text = "" + total;
            if (total > 3000)
            {
                discount = total - (total * 0.2);
                label45.Text = "" + discount;
            }
            else if (total > 2000 && total < 3000)
            {
                discount = total - (total * 0.1);
                label45.Text = "" + discount;
            }
            else if (total > 1500 && total < 2000)
            {
                discount = total - (total * 0.05);
                label45.Text = "" + discount;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
                      
            button3.Hide();
            panel8.Visible = true;
            panel15.Visible = true;
            panel16.Visible = true;
            panel17.Visible = true;
            Qty.Visible = true;
            label18.Visible = true;
            label31.Visible = true;
            label32.Visible = true;
            label33.Visible = true;
            label34.Visible = true;
            label35.Visible = true;
            label36.Visible = true;
            label37.Visible = true;
            label38.Visible = true;
            label39.Visible = true;
            label40.Visible = true;
            label41.Visible = true;
            label42.Visible = true;
            label43.Visible = true;
            label44.Visible = true;
            label45.Visible = true;
            panel17.Visible = true;
            button4.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            panel8.Visible = false;
            panel15.Visible = false;
            panel16.Visible = false;
            panel17.Visible = false;
            Qty.Visible = false;
            label18.Visible = false;
            label31.Visible = false;
            label32.Visible = false;
            label33.Visible = false;
            label34.Visible = false;
            label35.Visible = false;
            label36.Visible = false;
            label37.Visible = false;
            label38.Visible = false;
            label39.Visible = false;
            label40.Visible = false;
            label41.Visible = false;
            label42.Visible = false;
            label43.Visible = false;
            label44.Visible = false;
            label45.Visible = false;
            panel17.Visible = false;
            button4.Hide();
            button3.Show();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            amount1 = 0;
            if (label16.Text == "" && label32.Text == "" && label33.Text == "")
            {
                if (comboBox1.Text == "Small Pan")
                {
                    amount1 = 300;
                    label16.Text = "1";
                    label33.Text = "" + amount1;
                    label32.Text = "Checken Supreme Small";
                }
                else if (comboBox1.Text == "Medium Pan")
                {
                    amount1 = 500;
                    label16.Text = "1";
                    label33.Text = "" + amount1;
                    label32.Text = "Checken Supreme Medium";
                }
                else if (comboBox1.Text == "Large Pan")
                {
                    amount1 = 800;
                    label16.Text = "1";
                    label33.Text = "" + amount1;
                    label32.Text = "Checken Supreme Large";
                }
                else if (comboBox1.Text == "XL Pan")
                {
                    amount1 = 1000;
                    label16.Text = "1";
                    label33.Text = "" + amount1;
                    label32.Text = "Checken supreme XL";
                }
            }
            else if (label34.Text == "" && label35.Text == "" && label36.Text == "")
            {
                if (comboBox1.Text == "Small Pan")
                {
                    amount1 = 300;
                    label34.Text = "1";
                    label36.Text = "" + amount1;
                    label35.Text = "Checken Supreme Small";
                }
                else if (comboBox1.Text == "Medium Pan")
                {
                    amount1 = 500;
                    label34.Text = "1";
                    label36.Text = "" + amount1;
                    label35.Text = "Checken Supreme Medium";
                }
                else if (comboBox1.Text == "Large Pan")
                {
                    amount1 = 800;
                    label34.Text = "1";
                    label36.Text = "" + amount1;
                    label35.Text = "Checken Supreme Large";
                }
                else if (comboBox1.Text == "XL Pan")
                {
                    amount1 = 1000;
                    label34.Text = "1";
                    label36.Text = "" + amount1;
                    label35.Text = "Checken Supreme XL";
                }
            }
            else if (label37.Text == "" && label38.Text == "" && label39.Text == "")
            {
                if (comboBox1.Text == "Small Pan")
                {
                    amount1 = 300;
                    label37.Text = "1";
                    label39.Text = "" + amount1;
                    label38.Text = "Checken Supreme Small";
                }
                else if (comboBox1.Text == "Medium Pan")
                {
                    amount1 = 500;
                    label37.Text = "1";
                    label39.Text = "" + amount1;
                    label38.Text = "Checken Supreme Medium";
                }
                else if (comboBox1.Text == "Large Pan")
                {
                    amount1 = 800;
                    label37.Text = "1";
                    label39.Text = "" + amount1;
                    label38.Text = "Checken Spureme Large";
                }
                else if (comboBox1.Text == "XL Pan")
                {
                    amount1 = 1000;
                    label37.Text = "1";
                    label39.Text = "" + amount1;
                    label38.Text = "Checken Supreme XL";
                }
            }
            else if (label40.Text == "" && label41.Text == "" && label42.Text == "")
            {
                if (comboBox1.Text == "Small Pan")
                {
                    amount1 = 300;
                    label40.Text = "1";
                    label42.Text = "" + amount1;
                    label41.Text = "Checken Supreme Small";
                }
                else if (comboBox1.Text == "Medium Pan")
                {
                    amount1 = 500;
                    label40.Text = "1";
                    label42.Text = "" + amount1;
                    label41.Text = "Checken Supreme Medium";
                }
                else if (comboBox1.Text == "Large Pan")
                {
                    amount1 = 800;
                    label40.Text = "1";
                    label42.Text = "" + amount1;
                    label41.Text = "Checken Supreme Large";
                }
                else if (comboBox1.Text == "XL Pan")
                {
                    amount1 = 1000;
                    label40.Text = "1";
                    label42.Text = "" + amount1;
                    label41.Text = "Checken Supreme XL";
                }
            }
            total = amount1 + amount2 + amount3 + amount4 + amount5 + amount6 + amount7 + amount8;
            label43.Text = "" + total;
            if (total > 3000)
            {
                discount = total - (total * 0.2);
                label45.Text = "" + discount;
            }
            else if (total > 2000 && total < 3000)
            {
                discount = total - (total * 0.1 );
                label45.Text = "" + discount;
            }
            else if (total > 1500 && total < 2000)
            {
                discount = total - (total * 0.05);
                label45.Text = "" + discount;
            }
        }

        private void label31_Click(object sender, EventArgs e)
        {
        }
    }
}
