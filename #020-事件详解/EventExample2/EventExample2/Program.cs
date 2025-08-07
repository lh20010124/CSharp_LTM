using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyForm form = new MyForm();
            form.Click += form.FormClicked;
            form.ShowDialog();
        }
    }

    class MyForm : Form  // 派生、继承
    {
        internal void FormClicked(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
        }
    }
}
