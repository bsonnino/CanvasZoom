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

namespace CanvasZoom
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

        private void maisZoom_Click(object sender, RoutedEventArgs e)
        {
            canvasZoom.ScaleX += 0.1;
            canvasZoom.ScaleY += 0.1;
            textZoom.Text = string.Format("Zoom: {0:N0}%", canvasZoom.ScaleX * 100);
        }

        private void menosZoom_Click(object sender, RoutedEventArgs e)
        {
            canvasZoom.ScaleX -= 0.1;
            canvasZoom.ScaleY -= 0.1;
            textZoom.Text = string.Format("Zoom: {0:N0}%", canvasZoom.ScaleX * 100);
        }
    }
}
