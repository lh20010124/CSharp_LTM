using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EventExample5
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.button2.Click += Button_Click;
            this.button3.Click += new RoutedEventHandler(this.Button_Click);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (sender == button1)
            {
                this.textBox1.Text = "1";
            }
            if (sender == button2)
            {
                this.textBox1.Text = "2";
            }
            if (sender == button3)
            {
                this.textBox1.Text = "3";
            }
        }
    }
}
