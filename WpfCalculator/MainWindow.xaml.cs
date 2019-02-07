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

namespace WpfCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static int arg1 = 0;
        static int arg2 = 0;
        static string opt = "";
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Screen.Text += (sender as Button).Content;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Screen.Text = "";
        }

        private void Operator_Click(object sender, RoutedEventArgs e)
        {
            arg1 = int.Parse(Screen.Text);
            opt = (sender as Button).Content.ToString();
            Screen.Text += opt;
            
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            string txtOnScrn = Screen.Text;
            int index = txtOnScrn.IndexOf(opt);
            string ag2 = txtOnScrn.Substring(index);
            arg2 = int.Parse(txtOnScrn.Substring(index+1));
            Screen.Text = Operation(opt, arg1, arg2).ToString();
        }

        public int Operation(string op, int x, int y) {
            switch (op)
            {
                case "+":
                    return x + y;
                case "-":
                    return x - y;
                case "*":
                    return x * y;
                case "/":
                    return x / y;
                default:
                    return 0;
            }
        }

        
    }
}
