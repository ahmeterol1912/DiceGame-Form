using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project__X
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (RoPl.p1Point > RoPl.p2Point && RoPl.p1Point > RoPl.p3Point && RoPl.p1Point > RoPl.p4Point)
            {
                label1.Text = ("Game winner is\n" + RoPl.p1Name + "\nPoints: " + RoPl.p1Point);
            }
            else if (RoPl.p2Point > RoPl.p1Point && RoPl.p2Point > RoPl.p3Point && RoPl.p2Point > RoPl.p4Point)
            {
                label1.Text = ("Game winner is\n" + RoPl.p2Name + "\nPoints: " + RoPl.p2Point);
            }
            else if (RoPl.p3Point > RoPl.p1Point && RoPl.p3Point > RoPl.p2Point && RoPl.p3Point > RoPl.p4Point)
            {
                label1.Text = ("Game winner is\n" + RoPl.p3Name + "\nPoints: " + RoPl.p3Point);
            }
            else if (RoPl.p4Point > RoPl.p1Point && RoPl.p4Point > RoPl.p3Point && RoPl.p4Point > RoPl.p2Point)
            {
                label1.Text = ("Game winner is\n" + RoPl.p4Name + "\nPoints: " + RoPl.p4Point) ;
            }
            else
            {
                label1.Text = ("There is no winner :(");
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
        }
    }
}
