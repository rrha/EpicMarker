using System;
using System.Drawing;
using System.Linq;
using System.Windows;
using System.Windows.Forms;

namespace EpicMarker
{
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
            MainWindow mainWindow = System.Windows.Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.Hide();
        }
        private void button0_Click(object sender, RoutedEventArgs e)
        {

            MainWindow mainWindow = System.Windows.Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.Show();

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = System.Windows.Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.inkCanvas1.Strokes.Clear();
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mainWindow = System.Windows.Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.Close();
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = System.Windows.Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.inkCanvas1.DefaultDrawingAttributes.Color = (System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#00FF18");

        }
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = System.Windows.Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.inkCanvas1.DefaultDrawingAttributes.Color = (System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#00f0ff");

        }
        private void button5_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = System.Windows.Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.inkCanvas1.DefaultDrawingAttributes.Color = (System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#ff0000");

        }
        private void button6_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = System.Windows.Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.inkCanvas1.DefaultDrawingAttributes.Color = (System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#f55096");

        }
        private void button7_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = System.Windows.Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.inkCanvas1.DefaultDrawingAttributes.Color = (System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#fff36a");

        }
        private void button8_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = System.Windows.Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.inkCanvas1.DefaultDrawingAttributes.Color = (System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#ff7800");

        }
        private void button9_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = System.Windows.Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.inkCanvas1.DefaultDrawingAttributes.Color = (System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#402b56");

        }
        private void button10_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = System.Windows.Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.inkCanvas1.DefaultDrawingAttributes.Color = (System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#595b5c");

        }
        private void button11_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = System.Windows.Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.inkCanvas1.DefaultDrawingAttributes.Color = (System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#ffffff");

        }
        private void button12_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = System.Windows.Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.inkCanvas1.DefaultDrawingAttributes.Color = (System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#bdc3c7");

        }
        private void button13_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = System.Windows.Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.inkCanvas1.DefaultDrawingAttributes.Color = (System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#000000");

        }
        private void button14_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = System.Windows.Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.inkCanvas1.DefaultDrawingAttributes.Color = (System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#502d1d");

        }
        private void button20_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = System.Windows.Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.inkCanvas1.DefaultDrawingAttributes.Width = 5f;
            mainWindow.inkCanvas1.DefaultDrawingAttributes.Height = 5f;
        }
        private void button21_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = System.Windows.Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.inkCanvas1.DefaultDrawingAttributes.Width = 8f;
            mainWindow.inkCanvas1.DefaultDrawingAttributes.Height = 8f;
        }
        private void button22_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = System.Windows.Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.inkCanvas1.DefaultDrawingAttributes.Width = 10f;
            mainWindow.inkCanvas1.DefaultDrawingAttributes.Height = 10f;
        }
        private void button23_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = System.Windows.Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.inkCanvas1.DefaultDrawingAttributes.Width = 13f;
            mainWindow.inkCanvas1.DefaultDrawingAttributes.Height = 13f;
        }
        private void button24_Click(object sender, RoutedEventArgs e)
        {
            int screenLeft = SystemInformation.VirtualScreen.Left;
            int screenTop = SystemInformation.VirtualScreen.Top;
            int screenWidth = SystemInformation.VirtualScreen.Width;
            int screenHeight = SystemInformation.VirtualScreen.Height;

            using (Bitmap bmp = new Bitmap(screenWidth, screenHeight))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    String path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
                    DateTime.Now.ToString("ddMMyyyy-hhmmss") + ".png");
                    Opacity = .0;
                    g.CopyFromScreen(screenLeft, screenTop, 0, 0, bmp.Size);
                    bmp.Save(path);
                    Opacity = 1;
                }
            }
        }
    }
}
