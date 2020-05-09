using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OOXX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }


   
      

        public void inter(int i)
        {
        Button butnum = (Button)Controls["button" + i.ToString()];


        if (butnum.Text == "")
            butnum.Text = "O";
        else
            {
            if (butnum.Text == "O")
                butnum.Text = "X";
            else
                butnum.Text = "O";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            inter(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inter(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inter(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inter(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            inter(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            inter(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            inter(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            inter(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            inter(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            inter(10);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            inter(11);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            inter(12);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            inter(13);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            inter(14);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            inter(15);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            inter(16);
        }

        private void clean_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 16; i++)
            {
                Button butnum = (Button)Controls["button" + (i+1).ToString()];
                Button resnum = (Button)Controls["res" + (i + 1).ToString()];


                butnum.Text = "";
                resnum.Text = "";
            }
        }


        bool yn = false;

        private void finish_Click(object sender, EventArgs e)
        {
            StreamReader streader = new StreamReader(@"C:\Users\xujpv\OneDrive\桌面\OOXX\Write.txt");

            for (int i = 0; i < 52; i++)
            {
          
                string str = streader.ReadLine();

                for (int j = 0; j < 16; j++)
                {

                    Button butnum = (Button)Controls["button" + (j + 1).ToString()];
                    if (butnum.Text != "")
                    {
                        if (str.Substring(j, 1) == butnum.Text)
                            yn = true;
                        else
                        {
                            yn = false;
                            break;
                        }
                    }
                }

                if (yn == true)
                {
                    for (int j = 0; j < 16; j++)
                    {
                        Button resnum = (Button)Controls["res" + (j+1).ToString()];
                        resnum.Text = str.Substring(j, 1);
                    }

                    yn = false;
                }




            }
        }


    }
}
