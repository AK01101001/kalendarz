using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kalendarz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string day;
        string date;
        public MainWindow()
        {
            InitializeComponent();
            day = DateTimeOffset.Now.ToString("dd");
            date = DateTimeOffset.Now.ToString("MM");
            for (int i = 1; i < 24; i++)
            {
                int poz = kalendarz.Children.Add(new Button());
                Button but = kalendarz.Children[poz] as Button;
                but.SetValue(Grid.RowProperty, (int)(i-1)/4);
                but.SetValue(Grid.ColumnProperty, (int)(i-1)/6);
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (int.TryParse(button.Content.ToString(), out int i))
            {
                string number;
                if (i < 10) { number = "0" + i.ToString(); }
                else { number = i.ToString(); }
                if (number.Equals(day)&&date.Equals("12"))
                {
                    button.Content = new Image();
                    Image image = button.Content as Image;
                    image.Source = new BitmapImage(new Uri("", UriKind.Relative));
                }
            }
        }
    }
}
