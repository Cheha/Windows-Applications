using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_3_Events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            textBox1.Text = rand.Next(1, 200).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
