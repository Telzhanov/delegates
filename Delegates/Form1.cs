using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegates
{
      public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Sum
    {
             
        public string Plus(int x, int y)
        {
            int sum = x + y;
            return sum.ToString();
        }
    }
    public delegate string Show1(int x, int y);
    class Sum1
    {
       
    }
   

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sum sm = new Sum();
            Show1 sh1 = sm.Plus;
            int a, b;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            textBox3.Text = Operation(sh1, a, b);
        }
        public string Operation(Show1 invoker, int a, int b)
        {

            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(1000);
                dialog.Text = i.ToString();
                Refresh();
            }
            return invoker( a, b);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }

}
