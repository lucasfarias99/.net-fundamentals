using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow() => InitializeComponent();

        private void Window_Activated(object sender, EventArgs e)
        {
            // Continue playing media if window is activated
            mediaElement.Play();
        }

        private void Window_Deactivated(object sender, EventArgs e)
        {
            // Pause playing if media is being played and window is deactivated
            mediaElement.Pause();
        }
    }
}