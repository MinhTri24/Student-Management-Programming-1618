using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventDrivenProgramming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void increaseButton_Click(object sender, EventArgs e)
        {
            int counterValue = int.Parse(counter.Text);
            counterValue = counterValue + 1;
            counter.Text = counterValue.ToString(); 
        }

        private void decreaseButton_Click(object sender, EventArgs e)
        {
            int counterValue = int.Parse(counter.Text);
            counterValue = counterValue - 1;
            counter.Text = counterValue.ToString();
        }
    }
}
