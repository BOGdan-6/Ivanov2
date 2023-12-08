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

namespace Ivanov2
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            AnswerTextBox.Clear();
            if (String.IsNullOrEmpty(NumberTextBox.Text))
            {
                return;
            }
            try
            {
                double n = double.Parse(NumberTextBox.Text);
                double? price = null;

                for (double i = 1; i <= 2; i += 0.2)
                {
                    price = n * i;
                    AnswerTextBox.Text += $"Цена за {i}кг конфет - {price}\n";
                }
            }
            catch (FormatException)
            {
                AnswerTextBox.Text += "Введены некорректные данные";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
