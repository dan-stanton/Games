using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        int answer1, answer2, answer3;
        bool GameWon = false;

        bool debug = true;
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClearGuesses();


            GenerateNumbers();
            if(debug) mainlabel.Text = "Guess the number!("+answer1+", "+answer2+", "+answer3+")";
            else mainlabel.Text = "Guess the number!";
        }

        public void GenerateNumbers()
        {
            Random r = new Random();
            answer1 = r.Next(0, 9);
            answer2 = r.Next(0, 9);
            answer3 = r.Next(0, 9);
            return;
        }


        public void ButtonJustPressed(int pressed)
        {
            if (GameWon)
            {
                ClearGuesses();
                return;
            }
            if (pressed < 0 || pressed > 9) return;
            string PressedToText = pressed.ToString();
            if (string.IsNullOrEmpty(guess11.Text))
            {
                guess11.Text = pressed.ToString();
                if (pressed == answer1) guess11.ForeColor = System.Drawing.Color.Green;
                else guess11.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (string.IsNullOrEmpty(guess12.Text))
            {
                guess12.Text = pressed.ToString();
                if (pressed == answer2) guess12.ForeColor = System.Drawing.Color.Green;
                else guess12.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (string.IsNullOrEmpty(guess13.Text))
            {
                guess13.Text = pressed.ToString();
                if (pressed == answer3) guess13.ForeColor = System.Drawing.Color.Green;
                else guess13.ForeColor = System.Drawing.Color.Red;

                if(guess11.ForeColor == System.Drawing.Color.Green && guess12.ForeColor == System.Drawing.Color.Green && guess13.ForeColor == System.Drawing.Color.Green)
                {
                    mainlabel.Text = "You Win!";
                    GameWon = true;
                    return;
                }
                return;
            }

            if (string.IsNullOrEmpty(guess21.Text))
            {
                guess21.Text = pressed.ToString();
                if (pressed == answer1) guess21.ForeColor = System.Drawing.Color.Green;
                else guess21.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (string.IsNullOrEmpty(guess22.Text))
            {
                guess22.Text = pressed.ToString();
                if (pressed == answer2) guess22.ForeColor = System.Drawing.Color.Green;
                else guess22.ForeColor = System.Drawing.Color.Red;
                return;
            }
            if (string.IsNullOrEmpty(guess23.Text))
            {
                guess23.Text = pressed.ToString();
                if (pressed == answer3) guess23.ForeColor = System.Drawing.Color.Green;
                else guess23.ForeColor = System.Drawing.Color.Red;

                if (guess21.ForeColor == System.Drawing.Color.Green && guess22.ForeColor == System.Drawing.Color.Green && guess23.ForeColor == System.Drawing.Color.Green)
                {
                    mainlabel.Text = "You Win!";
                    GameWon = true;
                    return;
                }
                return;
            }

            if (string.IsNullOrEmpty(guess31.Text))
            {
                guess31.Text = pressed.ToString();
                if (pressed == answer1) guess31.ForeColor = System.Drawing.Color.Green;
                else guess31.ForeColor = System.Drawing.Color.Red;
                return;
            }
            if (string.IsNullOrEmpty(guess32.Text))
            {
                guess32.Text = pressed.ToString();
                if (pressed == answer2) guess32.ForeColor = System.Drawing.Color.Green;
                else guess32.ForeColor = System.Drawing.Color.Red;
                return;
            }
            if (string.IsNullOrEmpty(guess33.Text))
            {
                guess33.Text = pressed.ToString();
                if (pressed == answer3) guess33.ForeColor = System.Drawing.Color.Green;
                else guess33.ForeColor = System.Drawing.Color.Red;

                if (guess31.ForeColor == System.Drawing.Color.Green && guess32.ForeColor == System.Drawing.Color.Green && guess33.ForeColor == System.Drawing.Color.Green)
                {
                    mainlabel.Text = "You Win!";
                    GameWon = true;
                    return;
                }
                else
                {
                    mainlabel.Text = "You Loose!";
                    GameWon = true;
                }
                return;
            }

            return;
        }

        public void ClearGuesses()
        {
            GameWon = false;
            guess11.Text = "";
            guess12.Text = "";
            guess13.Text = "";

            guess21.Text = "";
            guess22.Text = "";
            guess23.Text = "";

            guess31.Text = "";
            guess32.Text = "";
            guess33.Text = "";

            GenerateNumbers();
            if (debug) mainlabel.Text = "Guess the number!(" + answer1 + ", " + answer2 + ", " + answer3 + ")";
            else mainlabel.Text = "Guess the number!";

            return;
        }

        private void num1_Click(object sender, EventArgs e)
        {
            ButtonJustPressed(1);
            return;
        }

        private void num2_Click(object sender, EventArgs e)
        {
            ButtonJustPressed(2);
            return;
        }

        private void num3_Click(object sender, EventArgs e)
        {
            ButtonJustPressed(3);
            return;
        }

        private void num4_Click(object sender, EventArgs e)
        {
            ButtonJustPressed(4);
            return;
        }

        private void num5_Click(object sender, EventArgs e)
        {
            ButtonJustPressed(5);
            return;
        }

        private void num6_Click(object sender, EventArgs e)
        {
            ButtonJustPressed(6);
            return;
        }

        private void num7_Click(object sender, EventArgs e)
        {
            ButtonJustPressed(7);
            return;
        }

        private void num8_Click(object sender, EventArgs e)
        {
            ButtonJustPressed(8);
            return;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D0)
            {
                num0.PerformClick();
            }
            else if (e.KeyCode == Keys.D1)
            {
                num1.PerformClick();

            }
            else if (e.KeyCode == Keys.D2)
            {
                num2.PerformClick();

            }
            else if (e.KeyCode == Keys.D3)
            {
                num3.PerformClick();

            }
            else if (e.KeyCode == Keys.D4)
            {
                num4.PerformClick();

            }
            else if (e.KeyCode == Keys.D5)
            {
                num5.PerformClick();

            }
            else if (e.KeyCode == Keys.D6)
            {
                num6.PerformClick();

            }
            else if (e.KeyCode == Keys.D7)
            {
                num7.PerformClick();

            }
            else if (e.KeyCode == Keys.D8)
            {
                num8.PerformClick();

            }
            else if (e.KeyCode == Keys.D9)
            {
                num9.PerformClick();

            }
        }

        private void num9_Click(object sender, EventArgs e)
        {
            ButtonJustPressed(9);
            return;
        }

        private void num0_Click(object sender, EventArgs e)
        {
            ButtonJustPressed(0);
            return;
        }
    }
}
