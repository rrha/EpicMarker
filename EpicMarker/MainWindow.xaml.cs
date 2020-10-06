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

namespace EpicMarker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Tools toolsWindow = new Tools();
        public MainWindow()
        {
            InitializeComponent();
            toolsWindow.Topmost = true;
            toolsWindow.Show();
        }
        private void inkCanvas1_Gesture(object sender, InkCanvasGestureEventArgs e)
        {

        }

    }
}
