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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
          
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(null);
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            AnswerTextBox.Clear();
            try
            {
                int n = Convert.ToInt32(DataListBox.Items[0]);
                int max = 0;
                string s = "NO";
                for (int i = 1; i <= n; i++)
                {
                    int m = Convert.ToInt32(DataListBox.Items[i]);
                    if (m > max)
                    {
                        max = m;
                    }
                    if (m == 0)
                    {
                        s = "YES";
                    }
                }
                AnswerTextBox.Text += $"{max}\n{s}";
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

        private void ClearButton2_Click(object sender, RoutedEventArgs e)
        {
            DataListBox.Items.Clear();
        }

        private void AddNumberButton_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(NumberTextBox.Text))
            {
                return;
            }
            try
            {
                int n = int.Parse(NumberTextBox.Text);
                DataListBox.Items.Add(NumberTextBox.Text);
            }
            catch (FormatException)
            {
                AnswerTextBox.Clear();
                AnswerTextBox.Text += "Введены не корректные данные";
            }
            catch (OverflowException)
            {
                MessageBox.Show("Слишком большое число, возможно у вас залипла клавиша");
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            NumberTextBox.Clear();
        }
    }
}
    

