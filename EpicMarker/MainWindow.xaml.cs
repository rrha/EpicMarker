using System.Windows;
using System.Windows.Controls;
namespace EpicMarker
{
    public partial class MainWindow : Window
    {
        Tools toolsWindow = new Tools();
        public MainWindow()
        {
            InitializeComponent();
            toolsWindow.Topmost = true;
            toolsWindow.Show();
            this.Hide();
        }
        private void inkCanvas1_Gesture(object sender, InkCanvasGestureEventArgs e)
        {
        }
    }
}
