using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SloppyJoes
{
    public partial class Form1 : Form
    {
        MenuMaker menu = new MenuMaker() { Randomizer = new Random() };

        public Form1()
        {
            InitializeComponent();
            ChangeMenu();
           
        }

        public void ChangeMenu()
        {
            label1.Text = menu.GetMenuItem();
            label2.Text = menu.GetMenuItem();
            label3.Text = menu.GetMenuItem();
            label4.Text = menu.GetMenuItem();
            label5.Text = menu.GetMenuItem();
            label6.Text = menu.GetMenuItem();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeMenu();
        }
    }
}
