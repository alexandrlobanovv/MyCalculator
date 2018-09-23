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

namespace MyCalculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bt_Click(object sender, RoutedEventArgs e)
        {
            Button bt = sender as Button;
            WriteToTextBox(bt.Content.ToString());
        }

        private void WriteToTextBox(string value)
        {
            switch (value)
            {
                case "+":
                    break;
                case "-":
                    break;
                case "/":
                    break;
                case "x":
                    break;
                case "%":
                    break;
                case ".":
                    tb_Output.AppendText(value);
                    break;
                case "AC":
                    tb_Output.Clear();
                    break;
                case "+/-":
                    break;
                case "=":
                    break;
                default:
                    if (Char.IsDigit(value[0]))
                    {
                        tb_Output.AppendText(value);
                    }
                    break;
            }
            if (tb_Output.Text.Length > 20)
                tb_Output.Text = tb_Output.Text.Remove(20);
        }
    }
}
