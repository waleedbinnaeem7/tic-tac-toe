using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_tac_toe
{
    public partial class Form1 : Form
    {

        int _isgameover = 0;
        public Form1()
        {
            InitializeComponent();
        }



        private void refresh()
        {

            A1.Enabled = false;
            A2.Enabled = false;
            A3.Enabled = false;
            B1.Enabled = false;
            B2.Enabled = false;
            B3.Enabled = false;
            C1.Enabled = false;
            C2.Enabled = false;
            C3.Enabled = false;
      
          
           

        }
        

        private void showmsg()
        {
            if (A1.Text == "" && A2.Text == "" && A3.Text == "")
            {

            }
            else
            {
                if (A1.Text == A2.Text && A2.Text == A3.Text)
                {
                    MessageBox.Show("Winner is " + A1.Text + "");
                    _isgameover = 1;
                    refresh();
                }

            }
            if (B1.Text == "" && B2.Text == "" && B3.Text == "")
            {

            }
            else
            {

                if (B1.Text == B2.Text && B2.Text == B3.Text)
                {
                    MessageBox.Show("Winner is" + B2.Text + " ");
                    _isgameover = 1;
                    refresh();
                }
            }
            if (C1.Text == "" && C2.Text == "" && C3.Text == "")
            {

            }
            else
            {
                if (C1.Text == C2.Text && C2.Text == C3.Text)
                {
                    MessageBox.Show("Winner is" + C1.Text + "");
                    _isgameover = 1;
                    refresh();
                }
            }
            if (A1.Text == "" && B2.Text == "" && C3.Text == "")
            {

            }
            else
            {
                if (A1.Text == B2.Text && B2.Text == C3.Text)
                {
                    MessageBox.Show("Winner is" + A1.Text + "");
                    _isgameover = 1;
                    refresh();
                }
            }
            if (C1.Text == "" && B2.Text == "" && A3.Text == "")
            {

            }
            else
            {
                if (C1.Text == B2.Text && B2.Text == A3.Text)
                {
                    MessageBox.Show("Winner is" + A3.Text + "");
                    _isgameover = 1;
                    refresh();
                }
            }
            if (A1.Text == "" && B1.Text == "" && C1.Text == "")
            {

            }
            else
            {
                if (A1.Text == B1.Text && B1.Text == C1.Text)
                {
                    MessageBox.Show("Winner is" + A1.Text + "");
                    _isgameover = 1;
                    refresh();
                }
            }
            if (A2.Text == "" && B2.Text == "" && C2.Text == "")
            {

            }
            else
            {
                if (A2.Text == B2.Text && B2.Text == C2.Text)
                {
                    MessageBox.Show("Winner is" + A2.Text + "");
                    _isgameover = 1;
                    refresh();
                }
            } if (A3.Text == "" && B3.Text == "" && C3.Text == "")
            {

            }
            else
            {
                if (A3.Text == B3.Text && B3.Text == C3.Text)
                {
                    MessageBox.Show("Winner is" + A3.Text + "");
                    _isgameover = 1;
                    refresh();
                }
            }

            if (A1.Text != "" && A2.Text != "" && A3.Text != "" && B1.Text != "" && B2.Text != "" && B3.Text != "" && C1.Text != "" && C2.Text != "" && C3.Text != "")
            if(_isgameover==0)
            {
                MessageBox.Show("Game Over!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnx_Click(object sender, EventArgs e)
        {
            if (btno.ForeColor == Color.Red)
            {
                btnx.ForeColor = Color.Red;
                btno.ForeColor = Color.Black;
            }
        }

        private void btno_Click(object sender, EventArgs e)
        {
            if (btnx.ForeColor == Color.Red)
            {
                btnx.ForeColor = Color.Black;
                btno.ForeColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (btnx.ForeColor == Color.Red)
            {
                A1.Text = "X";
                A1.Enabled = false;
                btno.ForeColor = Color.Red;
                btnx.ForeColor = Color.Black;
            }
            else
            {
                A1.Text = "O";
                A1.Enabled = false;
                btnx.ForeColor = Color.Red;
                btno.ForeColor = Color.Black;
            }
            showmsg();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (btnx.ForeColor == Color.Red)
            {
                B1.Text = "X";
                B1.Enabled = false;
                btno.ForeColor = Color.Red;
                btnx.ForeColor = Color.Black;
            }
            else
            {
                B1.Text = "O";
                B1.Enabled = false;
                btnx.ForeColor = Color.Red;
                btno.ForeColor = Color.Black;
            }
            showmsg();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (btnx.ForeColor == Color.Red)
            {
                C1.Text = "X";
                C1.Enabled = false;
                btno.ForeColor = Color.Red;
                btnx.ForeColor = Color.Black;
            }
            else
            {
                C1.Text = "O";
                C1.Enabled = false;
                btnx.ForeColor = Color.Red;
                btno.ForeColor = Color.Black;
            }
            showmsg();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (btnx.ForeColor == Color.Red)
            {
                A2.Text = "X";
                A2.Enabled = false;
                btno.ForeColor = Color.Red;
                btnx.ForeColor = Color.Black;
            }
            else
            {
                A2.Text = "O";
                A2.Enabled = false;
                btnx.ForeColor = Color.Red;
                btno.ForeColor = Color.Black;
            }
            showmsg();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (btnx.ForeColor == Color.Red)
            {
                B2.Text = "X";
                B2.Enabled = false;
                btno.ForeColor = Color.Red;
                btnx.ForeColor = Color.Black;
            }
            else
            {
                B2.Text = "O";
                B2.Enabled = false;
                btnx.ForeColor = Color.Red;
                btno.ForeColor = Color.Black;
            }
            showmsg();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (btnx.ForeColor == Color.Red)
            {
                C2.Text = "X";
                C2.Enabled = false;
                btno.ForeColor = Color.Red;
                btnx.ForeColor = Color.Black;
            }
            else
            {
                C2.Text = "O";
                C2.Enabled = false;
                btnx.ForeColor = Color.Red;
                btno.ForeColor = Color.Black;
            }
            showmsg();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (btnx.ForeColor == Color.Red)
            {
                A3.Text = "X";
                A3.Enabled = false;
                btno.ForeColor = Color.Red;
                btnx.ForeColor = Color.Black;
            }
            else
            {
                A3.Text = "O";
                A3.Enabled = false;
                btnx.ForeColor = Color.Red;
                btno.ForeColor = Color.Black;
            }
            showmsg();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (btnx.ForeColor == Color.Red)
            {
                B3.Text = "X";
                B3.Enabled = false;
                btno.ForeColor = Color.Red;
                btnx.ForeColor = Color.Black;
            }
            else
            {
                B3.Text = "O";
                B3.Enabled = false;
                btnx.ForeColor = Color.Red;
                btno.ForeColor = Color.Black;
            }
            showmsg();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (btnx.ForeColor == Color.Red)
            {
                C3.Text = "X";
                C3.Enabled = false;
                btno.ForeColor = Color.Red;
                btnx.ForeColor = Color.Black;
            }
            else
            {
                C3.Text = "O";
                C3.Enabled = false;
                btnx.ForeColor = Color.Red;
                btno.ForeColor = Color.Black;
            }
            showmsg();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            A1.Enabled = true;
            A2.Enabled = true;
            A3.Enabled = true;
            B1.Enabled = true;
            B2.Enabled = true;
            B3.Enabled = true;
            C1.Enabled = true;
            C2.Enabled = true;
            C3.Enabled = true;
            A1.Text = "";
            A2.Text = "";
            A3.Text = "";
            B1.Text = "";
            B2.Text = "";
            B3.Text = "";
            C1.Text = "";
            C2.Text = "";
            C3.Text = "";
        }
    }
}
