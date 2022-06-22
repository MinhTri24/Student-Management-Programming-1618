using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string turn = "Player 1";

        private void button00_Click(object sender, EventArgs e)
        {
            if (turn.Equals("Player 1"))
            {
                button00.Text = "X";
                turn = "Player 2";
            }
            else
            {
                button00.Text = "O";
                turn = "Player 1";
            }
        }
    }
}
