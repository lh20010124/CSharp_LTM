using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventExample4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.button3.Click += this.button1_Click;
            this.button4.Click += new EventHandler(this.button1_Click);
            //匿名方法
            this.button5.Click += delegate (object sender, EventArgs e)
            {
                this.textBox1.Text = "5";
            };
            //lamada表达式
            this.button6.Click += (object sender, EventArgs e) =>
            {
                this.textBox1.Text = "6";
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender == this.button1)
            {
                this.textBox1.Text = "Hello";
            }
             if (sender == this.button2)
            {
                this.textBox1.Text = "World!";
            }
            if (sender == this.button3)
            {
                this.textBox1.Text = "3";
            }
            if (sender == this.button4)
            {
                this.textBox1.Text = "4";
            }
        }
    }
}
