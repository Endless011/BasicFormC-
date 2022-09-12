using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int questionNo = 0, True = 0, False = 0, score = 0;

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnNext.Enabled = true;

            label2.Text = btnB.Text;
            if (label2.Text == label1.Text)
            {
                True++;
                lblTValue.Text = True.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                False++;
                lblFValue.Text = False.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnNext.Enabled = true;

            label2.Text = btnC.Text;
            if (label2.Text == label1.Text)
            {
                True++;
                lblTValue.Text = True.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                False++;
                lblFValue.Text = False.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            questionNo++;
            lblQValue.Text = questionNo.ToString();
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            if (questionNo > 0)
            {
                btnstart.Visible = false;
            }
            if (questionNo == 1)
            {
                richTextBox1.Text = "When was elon musk born?";
                btnA.Text = "1971";
                btnB.Text = "1970";
                btnC.Text = "1985";
                btnD.Text = "1965";
                label1.Text = "1971";
                btnrestart.Visible = true;
            }
        }

        private void btnrestart_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            questionNo = 0;
            True = 0;
            False = 0;
            lblQValue.Text = questionNo.ToString();
            lblTValue.Text = True.ToString();
            lblFValue.Text = False.ToString();
            richTextBox1.Text = "Welcome, Please press Start Button.";
            btnstart.Visible = true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnNext.Enabled = true;

            label2.Text = btnD.Text;
            if (label2.Text == label1.Text)
            {
                True++;
                lblTValue.Text = True.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                False++;
                lblFValue.Text = False.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnNext.Enabled = true;

            label2.Text = btnA.Text;
            if (label2.Text == label1.Text)
            {
                True++;
                lblTValue.Text = True.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                False++;
                lblFValue.Text = False.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnNext.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            questionNo++;
            lblQValue.Text = questionNo.ToString();

            if (questionNo == 1)
            {
                richTextBox1.Text = "When was elon musk born?";
                btnA.Text = "1971";
                btnB.Text = "1970";
                btnC.Text = "1985";
                btnD.Text = "1965";
                label1.Text = "1971";
            }
            if (questionNo == 2)
            {
                richTextBox1.Text = "What is the tallest mountain in the world?";
                btnA.Text = "Himalaya";
                btnB.Text = "Toroslar";
                btnC.Text = "Everest";
                btnD.Text = "Fuji";
                label1.Text = "Everest";
            }
            if (questionNo == 3)
            {
                richTextBox1.Text = "Who is the president of ukraine?";
                btnA.Text = "Elon Musk";
                btnB.Text = "Putin";
                btnC.Text = "Volodimir Zelenski";
                btnD.Text = "Boris Johnson";
                label1.Text = "Volodimir Zelenski";
            }
            if (questionNo == 4)
            {
                richTextBox1.Text = "When was the second world war?";
                btnA.Text = "1939-1945";
                btnB.Text = "1920-1935";
                btnC.Text = "1945-1956";
                btnD.Text = "1925-1940";
                label1.Text = "1939-1945";
            }
            if (questionNo == 5)
            {
                richTextBox1.Text = "What state of matter is the sun?";
                btnA.Text = "Gas";
                btnB.Text = "Fıre";
                btnC.Text = "Solid";
                btnD.Text = "Plasma";
                label1.Text = "Plasma";
                btnNext.Text = "Results";

            }
            if (questionNo == 6)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnNext.Enabled = false;
                score = True * 4 - False * 1;
                MessageBox.Show("True: " + True + "\n" + "False: " + False + "\n" + "Score: " + score);
            }

        }
    }
}
