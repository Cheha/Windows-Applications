using Example_4_MVP.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_4_MVP
{
    public partial class Form1 : Form, IView
    {
        public Form1()
        {
            InitializeComponent();
        }

        public event EventHandler<EventArgs> UpdateUserList;
        public event EventHandler<EventArgs> TryLogin;

        string IView.GetUser() {
            return textBox1.Text;
        }

        string IView.GetPassword()
        {
            return maskedTextBox1.Text;
        }

        void IView.UpdateUsers(List<string> users)
        {
            listBox1.Items.Clear();
            foreach (var user in users) {
                listBox1.Items.Add(user);
            }
        }

        void IView.ShowMessage(string message) {
            MessageBox.Show(message, "Login Result", MessageBoxButtons.OK);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateUserList(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TryLogin(sender, e);
        }

    }
}
