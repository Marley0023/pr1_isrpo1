using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        int perv = 0;
        int vtor = 0;
        int tret = 0;
        int chet = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            perv++;
            int a = perv % 2;
            if (a == 0)
            {
                panel2.Visible = false;
            }
            else 
            { 
                panel2.Visible = true;
            }
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            vtor++;
            int a = vtor % 2;
            if (a == 0)
            {
                panel3.Visible = false;
            }
            else
            {
                panel3.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tret++;
            int a = tret % 2;
            if (a == 0)
            {
                panel4.Visible = false;
            }
            else
            {
                panel4.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chet++;
            int a = chet % 2;
            if (a == 0)
            {
                panel5.Visible = false;
            }
            else
            {
                panel5.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BackColor = Color.Black;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            game Palochki = new game();
            Palochki.ShowDialog();
        }
    }
}
