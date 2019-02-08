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
        static bool arg1Entered = false;
        static bool opEntered = false;
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Screen.Text += (sender as Button).Content;
            arg1Entered = true;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Screen.Text = "";
            arg1 = 0;
            arg2 = 0;
            opt = "";
            arg1Entered = false;
            opEntered = false;
        }

        private void Operator_Click(object sender, RoutedEventArgs e)
        {
            if (arg1Entered) {
                arg1 = int.Parse(Screen.Text);
                opt = (sender as Button).Content.ToString();
                Screen.Text += opt;
                opEntered = true;
            }
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            string txtOnScrn = Screen.Text;
            int index = txtOnScrn.IndexOf(opt);
            string ag2 = txtOnScrn.Substring(index);
            if (opEntered)
            {
                arg2 = int.Parse(txtOnScrn.Substring(index + 1));
            }
            else
            {
                arg1 = int.Parse(Screen.Text); 
            }
            
            Screen.Text = Operation(opt, arg1, arg2).ToString();

            opEntered = false;
            arg2 = 0;
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
                    return x;
            }
        }

        
    }
}
