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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnstart_Click(object sender, EventArgs e)
        {
            // new form opening
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Close();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnstart_MouseEnter(object sender, EventArgs e)
        {
            btnstart.BackColor = Color.LimeGreen;
        }

        private void btnstart_MouseLeave(object sender, EventArgs e)
        {
            btnstart.BackColor = Color.White;
        }

        private void btnexit_MouseEnter(object sender, EventArgs e)
        {
            btnexit.BackColor = Color.Red;
        }

        private void btnexit_MouseLeave(object sender, EventArgs e)
        {
            btnexit.BackColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // backgroung picture
            Bitmap img = new Bitmap("avatars\\dice.jpg");
            this.BackgroundImage = img;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
