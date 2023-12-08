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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            {
                InitializeComponent();
            }

           
            
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
                double s = 0;
                int k = 0;

                for (int i = 0; i <= 2; i++)
                {
                    int m = Convert.ToInt32(DataListBox.Items[i]);
                    if (m > 99 && m < 1000)
                    {
                        s += m;
                        k++;
                    }
                }

                if (k > 0)
                {
                    AnswerTextBox.Text += $"{s / k}";
                }
                else
                {
                    AnswerTextBox.Text += "NO";
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

        private void ClearButton2_Click(object sender, RoutedEventArgs e)
        {
            DataListBox.Items.Clear();
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            NumberTextBox.Clear();
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
    }
}
