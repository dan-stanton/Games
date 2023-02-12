using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        int turn = 0; // 0 = X, 1 = Y
        const int TURN_X = 0, TURN_O = 1;
        bool gameover = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gameover) return;
            if (button1.Text != "-") return;
            if (turn == TURN_X)
            {
                button1.Text = "X";
                button1.ForeColor = System.Drawing.Color.Red;
            }
            else if (turn == TURN_O)
            {
                button1.Text = "O";
                button1.ForeColor = System.Drawing.Color.Blue;
            }
            SwitchTurn();
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (gameover) return;
            if (button2.Text != "-") return;
            if (turn == TURN_X)
            {
                button2.Text = "X";
                button2.ForeColor = System.Drawing.Color.Red;
            }
            else if (turn == TURN_O)
            {
                button2.Text = "O";
                button2.ForeColor = System.Drawing.Color.Blue;
            }
            SwitchTurn();
            return;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (gameover) return;
            if (button3.Text != "-") return;
            if (turn == TURN_X)
            {
                button3.Text = "X";
                button3.ForeColor = System.Drawing.Color.Red;
            }
            else if (turn == TURN_O)
            {
                button3.Text = "O";
                button3.ForeColor = System.Drawing.Color.Blue;
            }
            SwitchTurn();
            return;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (gameover) return;
            if (button6.Text != "-") return;
            if (turn == TURN_X)
            {
                button6.Text = "X";
                button6.ForeColor = System.Drawing.Color.Red;
            }
            else if (turn == TURN_O)
            {
                button6.Text = "O";
                button6.ForeColor = System.Drawing.Color.Blue;
            }
            SwitchTurn();
            return;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (gameover) return;
            if (button5.Text != "-") return;
            if (turn == TURN_X)
            {
                button5.Text = "X";
                button5.ForeColor = System.Drawing.Color.Red;
            }
            else if (turn == TURN_O)
            {
                button5.Text = "O";
                button5.ForeColor = System.Drawing.Color.Blue;
            }
            SwitchTurn();
            return;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (gameover) return;
            if (button4.Text != "-") return;
            if (turn == TURN_X)
            {
                button4.Text = "X";
                button4.ForeColor = System.Drawing.Color.Red;
            }
            else if (turn == TURN_O)
            {
                button4.Text = "O";
                button4.ForeColor = System.Drawing.Color.Blue;
            }
            SwitchTurn();
            return;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (gameover) return;
            if (button9.Text != "-") return;
            if (turn == TURN_X)
            {
                button9.Text = "X";
                button9.ForeColor = System.Drawing.Color.Red;
            }
            else if (turn == TURN_O)
            {
                button9.Text = "O";
                button9.ForeColor = System.Drawing.Color.Blue;
            }
            SwitchTurn();
            return;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (gameover) return;
            if (button8.Text != "-") return;
            if (turn == TURN_X)
            {
                button8.Text = "X";
                button8.ForeColor = System.Drawing.Color.Red;
            }
            else if (turn == TURN_O)
            {
                button8.Text = "O";
                button8.ForeColor = System.Drawing.Color.Blue;
            }
            SwitchTurn();
            return;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (gameover) return;
            if (button7.Text != "-") return;
            if (turn == TURN_X)
            {
                button7.Text = "X";
                button7.ForeColor = System.Drawing.Color.Red;
            }
            else if (turn == TURN_O)
            {
                button7.Text = "O";
                button7.ForeColor = System.Drawing.Color.Blue;
            }
            SwitchTurn();
            return;
        }

        public void SwitchTurn()
        {
            if(turn == TURN_X)
            {
                turn = TURN_O;
                label3.Text = "O";
                label3.ForeColor = System.Drawing.Color.Blue;
                label2.Text = "O";
                label2.ForeColor = System.Drawing.Color.Blue;
            }
            else
            {
                turn = TURN_X;
                label3.Text = "X";
                label3.ForeColor = System.Drawing.Color.Red;
                label2.Text = "X";
                label2.ForeColor = System.Drawing.Color.Red;
            }
            CheckWinner();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            gameover = false;

            button1.Text = "-";
            button1.ForeColor = System.Drawing.Color.Black;
            button2.Text = "-";
            button2.ForeColor = System.Drawing.Color.Black;
            button3.Text = "-";
            button3.ForeColor = System.Drawing.Color.Black;
            button4.Text = "-";
            button4.ForeColor = System.Drawing.Color.Black;
            button5.Text = "-";
            button5.ForeColor = System.Drawing.Color.Black;
            button6.Text = "-";
            button6.ForeColor = System.Drawing.Color.Black;
            button7.Text = "-";
            button7.ForeColor = System.Drawing.Color.Black;
            button8.Text = "-";
            button8.ForeColor = System.Drawing.Color.Black;
            button9.Text = "-";
            button9.ForeColor = System.Drawing.Color.Black;

        }

        public void CheckWinner()
        {
            /*
             button1, button2, button3
             button4, button5, button6
             button7, button8, button9
             */

            if(
                button1.Text == "X" && button2.Text == "X" && button3.Text == "X" ||
                button4.Text == "X" && button5.Text == "X" && button6.Text == "X" ||
                button7.Text == "X" && button8.Text == "X" && button9.Text == "X" ||
                
                button1.Text == "X" && button4.Text == "X" && button7.Text == "X" ||
                button2.Text == "X" && button5.Text == "X" && button8.Text == "X" ||
                button3.Text == "X" && button6.Text == "X" && button9.Text == "X" ||

                button1.Text == "X" && button5.Text == "X" && button9.Text == "X" ||
                button3.Text == "X" && button5.Text == "X" && button7.Text == "X"

                ){
                //winner x
                label1.Text = "Winner!";
                label3.Text = "X";
                label3.ForeColor = System.Drawing.Color.Red;
                label2.Text = "X";
                label2.ForeColor = System.Drawing.Color.Red;
                gameover = true;
                return;
            }
            else if(
                button1.Text == "O" && button2.Text == "O" && button3.Text == "O" ||
                button4.Text == "O" && button5.Text == "O" && button6.Text == "O" ||
                button7.Text == "O" && button8.Text == "O" && button9.Text == "O" ||
                
                button1.Text == "O" && button4.Text == "O" && button7.Text == "O" ||
                button2.Text == "O" && button5.Text == "O" && button8.Text == "O" ||
                button3.Text == "O" && button6.Text == "O" && button9.Text == "O" ||

                button1.Text == "O" && button5.Text == "O" && button9.Text == "O" ||
                button3.Text == "O" && button5.Text == "O" && button7.Text == "O"

                ){
                // winner o
                label1.Text = "Winner!";
                label3.Text = "O";
                label3.ForeColor = System.Drawing.Color.Blue;
                label2.Text = "O";
                label2.ForeColor = System.Drawing.Color.Blue;
                gameover = true;

                return;
            }

            if(
                button1.Text != "-" &&
                button2.Text != "-" &&
                button3.Text != "-" &&
                button4.Text != "-" &&
                button5.Text != "-" &&
                button6.Text != "-" &&
                button7.Text != "-" &&
                button8.Text != "-" &&
                button9.Text != "-"
                )
            {
                label1.Text = "Draw!";
                label3.Text = "O";
                label3.ForeColor = System.Drawing.Color.Blue;
                label2.Text = "X";
                label2.ForeColor = System.Drawing.Color.Red;
                gameover = true;
            }

            return;
        }
    }
}
