using System;
using System.Data;
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

namespace Итоговое_задание
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach (UIElement el in MainGrid.Children) // перебор элементов управления
            {
                if (el is Button)//проверка кнопки
                {
                    ((Button)el).Click += Button_Click;// условие принадлежности 
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)// метод
        {
            string str = (string)((Button)e.OriginalSource).Content;
            if (str == "AC")
                textlabel.Text = "";
            else if (str == "=")
            {
                string value = new DataTable().Compute(textlabel.Text, null).ToString();
                textlabel.Text = value;
            }
            else
                textlabel.Text += str;
        }
    }
}
