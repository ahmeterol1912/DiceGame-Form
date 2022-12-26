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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        

        private void Form2_Load(object sender, EventArgs e)
        {
            // until round number and number of players entered, will be unable to use
            groupBoxPlayers.Enabled = false;

            //loading pictures to avatars section
            pictureBox11.ImageLocation = "avatars\\avatar1.jpg";
            pictureBox12.ImageLocation = "avatars\\avatar2.jpg";
            pictureBox13.ImageLocation = "avatars\\avatar3.jpg";
            pictureBox14.ImageLocation = "avatars\\avatar4.jpg";
            pictureBox15.ImageLocation = "avatars\\avatar5.jpg";

            pictureBox21.ImageLocation = "avatars\\avatar1.jpg";
            pictureBox22.ImageLocation = "avatars\\avatar2.jpg";
            pictureBox23.ImageLocation = "avatars\\avatar3.jpg";
            pictureBox24.ImageLocation = "avatars\\avatar4.jpg";
            pictureBox25.ImageLocation = "avatars\\avatar5.jpg";

            pictureBox31.ImageLocation = "avatars\\avatar1.jpg";
            pictureBox32.ImageLocation = "avatars\\avatar2.jpg";
            pictureBox33.ImageLocation = "avatars\\avatar3.jpg";
            pictureBox34.ImageLocation = "avatars\\avatar4.jpg";
            pictureBox35.ImageLocation = "avatars\\avatar5.jpg";

            pictureBox41.ImageLocation = "avatars\\avatar1.jpg";
            pictureBox42.ImageLocation = "avatars\\avatar2.jpg";
            pictureBox43.ImageLocation = "avatars\\avatar3.jpg";
            pictureBox44.ImageLocation = "avatars\\avatar4.jpg";
            pictureBox45.ImageLocation = "avatars\\avatar5.jpg";



        }


        private void button1_Click(object sender, EventArgs e)
        {
            // values will be saved to class named RoPl to use on the other form
            RoPl.numRound = Convert.ToInt32(textBoxRound.Text);
            RoPl.numPlayer = Convert.ToInt32(textBoxNumP.Text);


            //  if values are correct players can enter the name and choose the avatars
            if (RoPl.numPlayer<5 && RoPl.numPlayer>1 && RoPl.numRound<31 && RoPl.numRound > 4)
            {   
                groupBoxSets.Visible = false;
                groupBoxPlayers.Enabled = true;
            }


            // checking if values are correct. If not givinf error
            if (RoPl.numPlayer < 5 && RoPl.numPlayer > 1 && RoPl.numRound<31 && RoPl.numRound>4)
            {
                
                switch(RoPl.numPlayer)
                    {
                case 2: { groupBoxPlayers.Visible = true; groupBoxPlayer3.Visible = false; groupBoxPlayer4.Visible = false; }
                    break;
                case 3: { groupBoxPlayers.Visible = true; groupBoxPlayer4.Visible = false; }
                    break;
                case 4: { groupBoxPlayers.Visible = true; }
                    break;
                    default:
                    {
                        MessageBox.Show("There is something wrong with number of players. It should be between 2 to 4", "Error Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                }
            }
            else
            {
                if (RoPl.numPlayer>4 || RoPl.numPlayer<2)
                {
                    MessageBox.Show("There is something wrong with number of players. It should be between 2 to 4", "Error Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (RoPl.numRound < 5 || RoPl.numRound > 30)
                    {
                        MessageBox.Show("Rounds Cannot be less than 5 or more than 30", "Error Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
           
            
        }

        private void btnstart2_Click(object sender, EventArgs e)
        {
            // names and the avatars will be saved to class. To use on the next form
            RoPl.p1Name = textBoxP1Name.Text;
            RoPl.p2Name = textBoxP2Name.Text;
            RoPl.p3Name = textBoxP3Name.Text;
            RoPl.p4Name = textBoxP4Name.Text;

            RoPl.p1Pic = pboxP1.ImageLocation;
            RoPl.p2Pic = pboxP2.ImageLocation;
            RoPl.p3Pic = pboxP3.ImageLocation;
            RoPl.p4Pic = pboxP4.ImageLocation;

            // if avatars are same between two players it gives error. Otherwise next form opens
            switch (RoPl.numPlayer)
            {
                case 2:
                    {
                        if (pboxP1.ImageLocation == pboxP2.ImageLocation)
                        {
                            MessageBox.Show("Players can not use same avatar", "Error Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            this.Hide();
                            Form3 form3 = new Form3();

                            form3.lblP1name.Text = textBoxP1Name.Text;
                            form3.lblP2name.Text = textBoxP2Name.Text;
                            form3.lblP3name.Text = textBoxP3Name.Text;
                            form3.lblP4name.Text = textBoxP4Name.Text;


                            form3.ShowDialog();
                            this.Close();
                        }
                    }
                    break;
                case 3:
                    {
                        if (pboxP1.ImageLocation == pboxP2.ImageLocation)
                        {
                            MessageBox.Show("Players can not use same avatar", "Error Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (pboxP1.ImageLocation == pboxP3.ImageLocation)
                        {
                            MessageBox.Show("Players can not use same avatar", "Error Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (pboxP2.ImageLocation == pboxP3.ImageLocation)
                        {
                            MessageBox.Show("Players can not use same avatar", "Error Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            this.Hide();
                            Form3 form3 = new Form3();

                            form3.lblP1name.Text = textBoxP1Name.Text;
                            form3.lblP2name.Text = textBoxP2Name.Text;
                            form3.lblP3name.Text = textBoxP3Name.Text;
                            form3.lblP4name.Text = textBoxP4Name.Text;
                            


                            form3.ShowDialog();
                            this.Close();
                        }

                    }
                    break;
                case 4:
                    {
                        if (pboxP1.ImageLocation == pboxP2.ImageLocation)
                        {
                            MessageBox.Show("Players can not use same avatar", "Error Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (pboxP1.ImageLocation == pboxP3.ImageLocation)
                        {
                            MessageBox.Show("Players can not use same avatar", "Error Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (pboxP1.ImageLocation == pboxP4.ImageLocation)
                        {
                            MessageBox.Show("Players can not use same avatar", "Error Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        else if (pboxP2.ImageLocation == pboxP3.ImageLocation)
                        {
                            MessageBox.Show("Players can not use same avatar", "Error Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        else if (pboxP2.ImageLocation == pboxP4.ImageLocation)
                        {
                            MessageBox.Show("Players can not use same avatar", "Error Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        else if (pboxP3.ImageLocation == pboxP4.ImageLocation)
                        {
                            MessageBox.Show("Players can not use same avatar", "Error Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            this.Hide();
                            Form3 form3 = new Form3();

                            form3.lblP1name.Text = textBoxP1Name.Text;
                            form3.lblP2name.Text = textBoxP2Name.Text;
                            form3.lblP3name.Text = textBoxP3Name.Text;
                            form3.lblP4name.Text = textBoxP4Name.Text;

                            RoPl.p1Name = textBoxP1Name.Text;
                            RoPl.p2Name = textBoxP2Name.Text;
                            RoPl.p3Name = textBoxP3Name.Text;
                            RoPl.p4Name = textBoxP4Name.Text;

                            form3.ShowDialog();
                            this.Close();
                        }
                    }
                    break;
                default:
                     break;
            }
            //Player player1 = new Player(RoPl.p1Name, pboxP1.ImageLocation);
            //Player player2 = new Player(RoPl.p2Name, pboxP2.ImageLocation);
            //Player player3 = new Player(RoPl.p3Name, pboxP3.ImageLocation);
            //Player player4 = new Player(RoPl.p4Name, pboxP4.ImageLocation);
            
        }

        private void btnS2_MouseEnter(object sender, EventArgs e)
        {
            btnS2.BackColor = Color.LimeGreen;
        }

        private void btnS2_MouseLeave(object sender, EventArgs e)
        {
            btnS2.BackColor = Color.White;
        }

        private void btnstart2_MouseEnter(object sender, EventArgs e)
        {
            btnstart2.BackColor = Color.LimeGreen;
        }

        private void btnstart2_MouseLeave(object sender, EventArgs e)
        {
            btnstart2.BackColor = Color.White;
        }

        private void btnexit2_MouseEnter(object sender, EventArgs e)
        {
            btnexit2.BackColor = Color.Red;
        }

        private void btnexit2_MouseLeave(object sender, EventArgs e)
        {
            btnexit2.BackColor = Color.White;
        }

        private void btnexit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pboxP1.Load(pictureBox11.ImageLocation);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pboxP1.Load(pictureBox12.ImageLocation);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pboxP1.Load(pictureBox13.ImageLocation);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pboxP1.Load(pictureBox14.ImageLocation);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pboxP1.Load(pictureBox15.ImageLocation);
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            pboxP2.Load(pictureBox21.ImageLocation);
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            pboxP2.Load(pictureBox22.ImageLocation);
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            pboxP2.Load(pictureBox23.ImageLocation);
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            pboxP2.Load(pictureBox24.ImageLocation);
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            pboxP2.Load(pictureBox25.ImageLocation);
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            pboxP3.Load(pictureBox31.ImageLocation);
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            pboxP3.Load(pictureBox32.ImageLocation);
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            pboxP3.Load(pictureBox33.ImageLocation);
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            pboxP3.Load(pictureBox34.ImageLocation);
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            pboxP3.Load(pictureBox35.ImageLocation);
        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {
            pboxP4.Load(pictureBox41.ImageLocation);
        }

        private void pictureBox42_Click(object sender, EventArgs e)
        {
            pboxP4.Load(pictureBox42.ImageLocation);
        }

        private void pictureBox43_Click(object sender, EventArgs e)
        {
            pboxP4.Load(pictureBox43.ImageLocation);
        }

        private void pictureBox44_Click(object sender, EventArgs e)
        {
            pboxP4.Load(pictureBox44.ImageLocation);
        }

        private void pictureBox45_Click(object sender, EventArgs e)
        {
            pboxP4.Load(pictureBox45.ImageLocation);
        }
    }
}
