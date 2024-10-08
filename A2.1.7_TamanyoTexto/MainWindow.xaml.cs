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

namespace A2._1._7_TamanyoTexto
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

        private void buttonPequeño_Checked(object sender, RoutedEventArgs e)
        {
            texto.FontSize = 36;
        }

        private void buttonMediano_Checked(object sender, RoutedEventArgs e)
        {
            texto.FontSize = 48;
        }

        private void buttonGrande_Checked(object sender, RoutedEventArgs e)
        {
            texto.FontSize = 72;
        }
    }
}