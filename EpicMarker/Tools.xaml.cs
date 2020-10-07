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
using System.Windows.Shapes;

namespace EpicMarker
{
    /// <summary>
    /// Interaction logic for Tools.xaml
    /// </summary>
    public partial class Tools : Window
    {
        public Tools()
        {
            InitializeComponent();
        }
        private void Move(object sender, RoutedEventArgs e)
        {

            this.DragMove();
            e.Handled = true;
        }
        private void button_1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.Hide();
        }
        private void button0_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.Show();
            mainWindow.inkCanvas1.DefaultDrawingAttributes.Color = Colors.SpringGreen;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.inkCanvas1.Strokes.Clear();
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.Close();
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
