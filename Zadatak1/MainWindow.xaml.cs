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

namespace Zadatak1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //private int brL = 0;
        //private int brR = 0;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.LeftButton.Click += new RoutedEventHandler(LeftButton_Click);
            this.RightButton.Click += new RoutedEventHandler(RightButton_Click);
        }

        void RightButton_Click(object sender, RoutedEventArgs e)
        {
            this.napraviR();

            //this.brR++;
        }

        private void napraviR()
        {
            var rectangle = new Rectangle()
            {
                Width = 300,
                Height = 30,
                Fill = Brushes.Red,
                Margin = new Thickness(5),
            };

            this.Container2.Children.Add(rectangle);
        }

        private void napraviL()
        {
            var rectangle = new Rectangle()
            {
                Width = 40,
                Height = 40,
                Fill = Brushes.Orange,
                Margin = new Thickness(5),
            };

            this.Container1.Children.Add(rectangle);
        }

        void LeftButton_Click(object sender, RoutedEventArgs e)
        {
            this.napraviL();
        }
    }
}
