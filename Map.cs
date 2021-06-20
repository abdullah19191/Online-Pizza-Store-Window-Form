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
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string street = bunifuMaterialTextbox2.Text;
            string city = bunifuMaterialTextbox1.Text;
            StringBuilder queryaddress = new StringBuilder();
            queryaddress.Append(" http://maps.google.com/maps?q=");
       
            if (city != string.Empty)
            {
                queryaddress.Append(city + "," + "+");
            }
            if (street != string.Empty)
            {
                queryaddress.Append(street + "," + "+");
            }
            webBrowser1.Navigate(queryaddress.ToString());
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Delivery del = new Delivery();
            del.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            takeout02 tkout = new takeout02();
            tkout.Show();
            this.Hide();
        }
    }
}
