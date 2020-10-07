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
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.inkCanvas1.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString("#00FF18");

        }
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.inkCanvas1.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString("#00f0ff");

        }
        private void button5_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.inkCanvas1.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString("#ff0000");

        }
        private void button6_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.inkCanvas1.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString("#f55096");

        }
        private void button7_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.inkCanvas1.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString("#fff36a");

        }
        private void button8_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.inkCanvas1.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString("#ff7800");

        }
        private void button9_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.inkCanvas1.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString("#402b56");

        }
        private void button10_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.inkCanvas1.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString("#595b5c");

        }
        private void button11_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.inkCanvas1.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString("#ffffff");

        }
        private void button12_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.inkCanvas1.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString("#bdc3c7");

        }
        private void button13_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.inkCanvas1.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString("#000000");

        }
        private void button14_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.inkCanvas1.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString("#502d1d");

        }
        private void button20_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.inkCanvas1.DefaultDrawingAttributes.Width = 5f;
            mainWindow.inkCanvas1.DefaultDrawingAttributes.Height = 5f;
        }
        private void button21_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.inkCanvas1.DefaultDrawingAttributes.Width = 8f;
            mainWindow.inkCanvas1.DefaultDrawingAttributes.Height = 8f;
        }
        private void button22_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.inkCanvas1.DefaultDrawingAttributes.Width = 10f;
            mainWindow.inkCanvas1.DefaultDrawingAttributes.Height = 10f;
        }
        private void button23_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.inkCanvas1.DefaultDrawingAttributes.Width = 13f;
            mainWindow.inkCanvas1.DefaultDrawingAttributes.Height = 13f;
        }
    }
}
