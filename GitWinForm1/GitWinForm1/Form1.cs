using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitWinForm1
{
    /*So I added this comment just for the sake of things*/
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Whats up " + textBox1.Text + ". Welcome!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            textBox1.Text = "";
        }
    }
}
