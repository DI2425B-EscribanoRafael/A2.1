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

namespace A2._1._6_Opacidad
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

        private void imagen_MouseEnter(object sender, MouseEventArgs e)
        {
            var imagen = sender as Image; //esto hace que el programa sepa a que objeto le estoy haciendo el mouse enter sin tener que hacer un metodo para cada una
            imagen.Opacity = 1;
        }

        private void imagen_MouseLeave(object sender, MouseEventArgs e)
        {
            var imagen = sender as Image; 
            imagen.Opacity = 0.5;
        }
    }
}