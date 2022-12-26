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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        static int a = 1;
        static int dice;
        static int visRound = 1;
        
        
        private void btnRoll_Click(object sender, EventArgs e)
        {
            
            // Random dice number generator
            Random random = new Random();
            dice = random.Next(1,7);
            switch (dice)
            {
                case 1:
                    pictureBox1.ImageLocation = "avatars\\dice (1).png"; 
                    break;
                case 2:
                    pictureBox1.ImageLocation = "avatars\\dice (2).png";
                    break;
                case 3:
                    pictureBox1.ImageLocation = "avatars\\dice (3).png";
                    break;
                case 4:
                    pictureBox1.ImageLocation = "avatars\\dice (4).png";
                    break;
                case 5:
                    pictureBox1.ImageLocation = "avatars\\dice (5).png";
                    break;
                case 6:
                    pictureBox1.ImageLocation = "avatars\\dice (6).png";
                    break;
            }


            

            // color changes on each players turn
            a++;
            switch (RoPl.numPlayer)
            {
                case 2:
                    {
                        
                        if (a == 1)
                        {
                            groupBox1.BackColor = Color.Green;
                        }
                        else if (a == 2)
                        {
                            groupBox1.BackColor = Color.White;
                            groupBox2.BackColor = Color.Green;
                            lblP1bank.Text = dice.ToString();

                        }
                        else if (a == 3)
                        {
                            lblP2bank.Text = dice.ToString();
                            RoPl.p1Bank = Convert.ToInt32(lblP1bank.Text);
                            RoPl.p2Bank = Convert.ToInt32(lblP2bank.Text);
                            if (RoPl.p1Bank > RoPl.p2Bank)
                            {
                                RoPl.p1Point += RoPl.p1Bank;
                                MessageBox.Show("Round winner "+lblP1name.Text);
                            }
                            else if (RoPl.p1Bank < RoPl.p2Bank)
                            {
                                RoPl.p2Point += RoPl.p2Bank;
                                MessageBox.Show("Round winner "+lblP2name.Text);
                            }
                            else
                            {
                                MessageBox.Show("No winner ");
                            }
                            lblP1bank.Text = "0";
                            lblP2bank.Text = "0";
                            lblRound.Text = (visRound++).ToString();
                            groupBox2.BackColor = Color.White;
                            groupBox1.BackColor = Color.Green;
                            a = 1;
                        }
                        lblP1point.Text = Convert.ToString(RoPl.p1Point);
                        lblP2point.Text = Convert.ToString(RoPl.p2Point);
                    }
                    
                    if (visRound-2 == RoPl.numRound)
                    {
                        this.Hide();
                        Form4 form4 = new Form4();
                        form4.ShowDialog();
                        this.Close();
                    }
                    break;
                case 3:
                    {
                        
                        if (a == 1)
                        {
                            groupBox1.BackColor = Color.Green;
                        }
                        else if (a == 2)
                        {
                            groupBox1.BackColor = Color.White;
                            groupBox2.BackColor = Color.Green;
                            lblP1bank.Text = dice.ToString();
                        }
                        else if (a == 3)
                        {
                            groupBox2.BackColor = Color.White;
                            groupBox3.BackColor = Color.Green;
                            lblP2bank.Text = dice.ToString();
                        }

                        else if (a == 4)
                        {
                            lblP3bank.Text = dice.ToString();
                            RoPl.p1Bank = Convert.ToInt32(lblP1bank.Text);
                            RoPl.p2Bank = Convert.ToInt32(lblP2bank.Text);
                            RoPl.p3Bank = Convert.ToInt32(lblP3bank.Text);
                            if (RoPl.p1Bank > RoPl.p2Bank && RoPl.p1Bank > RoPl.p3Bank)
                            {
                                RoPl.p1Point += RoPl.p1Bank;
                                MessageBox.Show("Round winner " + lblP1name.Text);
                            }
                            else if (RoPl.p2Bank > RoPl.p1Bank && RoPl.p2Bank > RoPl.p3Bank)
                            {
                                RoPl.p2Point += RoPl.p2Bank;
                                MessageBox.Show("Round winner " + lblP2name.Text);
                            }
                            else if (RoPl.p3Bank > RoPl.p1Bank && RoPl.p3Bank > RoPl.p2Bank)
                            {
                                RoPl.p3Point += RoPl.p3Bank;
                                MessageBox.Show("Round winner " + lblP3name.Text);
                            }
                            else if (RoPl.p1Bank == RoPl.p2Bank)
                            {
                                RoPl.p3Point += RoPl.p3Bank;
                                MessageBox.Show("Round winner " + lblP3name.Text);
                            }
                            else if (RoPl.p1Bank == RoPl.p3Bank)
                            {
                                RoPl.p2Point += RoPl.p2Bank;
                                MessageBox.Show("Round winner " + lblP2name.Text);
                            }
                            else if (RoPl.p2Bank == RoPl.p3Bank)
                            {
                                RoPl.p1Point += RoPl.p1Bank;
                                MessageBox.Show("Round winner " + lblP1name.Text);
                            }
                            //MessageBox.Show("round winner x");
                            lblP1bank.Text = "0";
                            lblP2bank.Text = "0";
                            lblP3bank.Text = "0";
                            lblRound.Text = (visRound++).ToString();
                            groupBox3.BackColor = Color.White;
                            groupBox1.BackColor = Color.Green;
                            a = 1;
                        }
                        lblP1point.Text = Convert.ToString(RoPl.p1Point);
                        lblP2point.Text = Convert.ToString(RoPl.p2Point);
                        lblP3point.Text = Convert.ToString(RoPl.p3Point);
                    }
                    if (visRound - 2 == RoPl.numRound)
                    {
                        this.Hide();
                        Form4 form4 = new Form4();
                        form4.ShowDialog();
                        this.Close();
                    }
                    break;
                case 4:
                    {
                        if (a == 1)
                        {
                            groupBox1.BackColor = Color.Green;
                        }
                        else if (a == 2)
                        {
                            groupBox1.BackColor = Color.White;
                            groupBox2.BackColor = Color.Green;
                            lblP1bank.Text = dice.ToString();
                        }
                        else if (a == 3)
                        {
                            groupBox2.BackColor = Color.White;
                            groupBox3.BackColor = Color.Green;
                            lblP2bank.Text = dice.ToString();
                        }

                        else if (a == 4)
                        {
                            groupBox3.BackColor = Color.White;
                            groupBox4.BackColor = Color.Green;
                            lblP3bank.Text = dice.ToString();
                        }

                        if (a == 5)
                        {
                            lblP4bank.Text = dice.ToString();
                            RoPl.p1Bank = Convert.ToInt32(lblP1bank.Text);
                            RoPl.p2Bank = Convert.ToInt32(lblP2bank.Text);
                            RoPl.p3Bank = Convert.ToInt32(lblP3bank.Text);
                            RoPl.p4Bank = Convert.ToInt32(lblP4bank.Text);

                            if (RoPl.p1Bank > RoPl.p2Bank && RoPl.p1Bank > RoPl.p3Bank && RoPl.p1Bank > RoPl.p4Bank)
                            {
                                RoPl.p1Point += RoPl.p1Bank;
                                MessageBox.Show("Round winner " + lblP1name.Text);
                            }
                            else if (RoPl.p2Bank > RoPl.p1Bank && RoPl.p2Bank > RoPl.p3Bank && RoPl.p2Bank > RoPl.p4Bank)
                            {
                                RoPl.p2Point += RoPl.p2Bank;
                                MessageBox.Show("Round winner " + lblP2name.Text);
                            }
                            else if (RoPl.p3Bank > RoPl.p1Bank && RoPl.p3Bank > RoPl.p2Bank && RoPl.p3Bank > RoPl.p4Bank)
                            {
                                RoPl.p3Point += RoPl.p3Bank;
                                MessageBox.Show("Round winner " + lblP3name.Text);
                            }
                            else if (RoPl.p4Bank > RoPl.p1Bank && RoPl.p4Bank > RoPl.p2Bank && RoPl.p4Bank > RoPl.p3Bank)
                            {
                                RoPl.p4Point += RoPl.p4Bank;
                                MessageBox.Show("Round winner " + lblP4name.Text);
                            }
                            else if (RoPl.p1Bank == RoPl.p2Bank)
                            {
                                if (RoPl.p3Bank > RoPl.p4Bank)
                                {
                                    RoPl.p3Point += RoPl.p3Bank;
                                    MessageBox.Show("Round winner " + lblP3name.Text);
                                }
                                if (RoPl.p4Bank > RoPl.p3Bank)
                                {
                                    RoPl.p4Point += RoPl.p4Bank;
                                    MessageBox.Show("Round winner " + lblP4name.Text);
                                }
                            }
                            else if (RoPl.p1Bank == RoPl.p3Bank)
                            {
                                if (RoPl.p2Bank > RoPl.p4Bank)
                                {
                                    RoPl.p2Point += RoPl.p2Bank;
                                    MessageBox.Show("Round winner " + lblP2name.Text);
                                }
                                if (RoPl.p4Bank > RoPl.p2Bank)
                                {
                                    RoPl.p4Point += RoPl.p4Bank;
                                    MessageBox.Show("Round winner " + lblP4name.Text);
                                }
                               

                            }
                            else if (RoPl.p2Bank == RoPl.p3Bank)
                            {
                                if (RoPl.p1Bank > RoPl.p4Bank)
                                {
                                    RoPl.p1Point += RoPl.p1Bank;
                                    MessageBox.Show("Round winner " + lblP1name.Text);
                                }
                                if (RoPl.p4Bank > RoPl.p1Bank)
                                {
                                    RoPl.p4Point += RoPl.p4Bank;
                                    MessageBox.Show("Round winner " + lblP4name.Text);
                                }
                            }
                            else if (RoPl.p2Bank == RoPl.p4Bank)
                            {
                                if (RoPl.p1Bank > RoPl.p3Bank)
                                {
                                    RoPl.p1Point += RoPl.p1Bank;
                                    MessageBox.Show("Round winner " + lblP1name.Text);
                                }
                                if (RoPl.p3Bank > RoPl.p1Bank)
                                {
                                    RoPl.p3Point += RoPl.p3Bank;
                                    MessageBox.Show("Round winner " + lblP3name.Text);
                                }
                            }
                            else if (RoPl.p3Bank == RoPl.p4Bank)
                            {
                                if (RoPl.p1Bank > RoPl.p2Bank)
                                {
                                    RoPl.p1Point += RoPl.p1Bank;
                                    MessageBox.Show("Round winner " + lblP1name.Text);
                                }
                                if (RoPl.p3Bank > RoPl.p1Bank)
                                {
                                    RoPl.p2Point += RoPl.p2Bank;
                                    MessageBox.Show("Round winner " + lblP2name.Text);
                                }
                            }
                            else if (RoPl.p1Bank == RoPl.p4Bank)
                            {
                                if (RoPl.p3Bank > RoPl.p2Bank)
                                {
                                    RoPl.p3Point += RoPl.p3Bank;
                                    MessageBox.Show("Round winner " + lblP3name.Text);
                                }
                                if (RoPl.p2Bank > RoPl.p3Bank)
                                {
                                    RoPl.p2Point += RoPl.p2Bank;
                                    MessageBox.Show("Round winner " + lblP2name.Text);
                                }
                            }
                            


                            lblP1bank.Text = "0";
                            lblP2bank.Text = "0";
                            lblP3bank.Text = "0";
                            lblP4bank.Text = "0";
                            lblRound.Text = (visRound++).ToString();
                            groupBox4.BackColor = Color.White;
                            a = 1;
                            groupBox1.BackColor = Color.Green;

                            
                        }
                        lblP1point.Text = Convert.ToString(RoPl.p1Point);
                        lblP2point.Text = Convert.ToString(RoPl.p2Point);
                        lblP3point.Text = Convert.ToString(RoPl.p3Point);
                        lblP4point.Text = Convert.ToString(RoPl.p4Point);

                        if (visRound - 2 == RoPl.numRound)
                        {
                            this.Hide();
                            Form4 form4 = new Form4();
                            form4.ShowDialog();
                            this.Close();

                        }

                        break;


                    }
                    

            }
          
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lblRound2.Text ="/ "+ RoPl.numRound.ToString();
            lblRound.Text = visRound.ToString();
            visRound++;
            // depends on the player groupbox will be visible
            switch (RoPl.numPlayer)
            {
                case 2: groupBox3.Visible = false; groupBox4.Visible = false; break;
                case 3: groupBox4.Visible = false; break;
                
                default:
                    break;
            }

            // depends on the player number uploades the pictures
            // and names
            switch (RoPl.numPlayer)
            {   case 2: pictureBoxP1.Load(RoPl.p1Pic); pictureBoxP2.Load(RoPl.p2Pic); break; 
                case 3: pictureBoxP1.Load(RoPl.p1Pic); pictureBoxP2.Load(RoPl.p2Pic); pictureBoxP3.Load(RoPl.p3Pic); break;
                case 4: pictureBoxP1.Load(RoPl.p1Pic); pictureBoxP2.Load(RoPl.p2Pic); pictureBoxP3.Load(RoPl.p3Pic); pictureBoxP4.Load(RoPl.p4Pic); break;
                default:
                    break;
            }

            groupBox1.BackColor = Color.Green;
            
        }

        private void Form3_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Game has started good luck !!!");
        }

       
    }
}
