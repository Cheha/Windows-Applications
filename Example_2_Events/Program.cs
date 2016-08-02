using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_2_Events
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyConsoleForm());
        }
    }

    class MyConsoleForm : Form
    {
        public MyConsoleForm()
        {
            Text = "My console form";
            BackColor = Color.Cyan;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics grafics = e.Graphics;
            grafics.DrawString("Hello, Its Console Windows Forms", Font, Brushes.DarkRed, 0, 0);
        }
    }
}
