using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toepassing
{
    class Program
    {
        static void Main(string[] args)
        {
            Button b1 = new Button();
            b1.Text = "Click me!";
            b1.Location = new Point { X = 50,  Y = 100 };
            b1.Click += ClickMe;

            Form f1 = new Form();
            f1.Text = "Hoi App";
            f1.Controls.Add(b1);


            f1.ShowDialog();

            Console.ReadLine();
        }

        private static void ClickMe(object sender, EventArgs e)
        {
            Button b = sender as Button;
            b.BackColor = Color.Green;

            Console.WriteLine("Hello Click!");
        }
    }
}
