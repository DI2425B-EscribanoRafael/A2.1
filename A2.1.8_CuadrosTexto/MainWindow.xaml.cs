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

namespace A2._1._8_CuadrosTexto
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

        private void textBoxNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                txtNombreAyuda.Visibility = txtNombreAyuda.Visibility == Visibility.Hidden ? Visibility.Visible : Visibility.Hidden; //manera corta de hacer la condición

            }
        }

        private void textBoxApellido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                if (txtApellidoAyuda.Visibility == Visibility.Hidden)
                {
                    txtApellidoAyuda.Visibility = Visibility.Visible; //manera mas normal de hacer la condición
                }
                else
                {
                    txtApellidoAyuda.Visibility = Visibility.Hidden;
                }
            }

        }

        private void textBoxEdad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F2)
            {
                if (!int.TryParse(textBoxEdad.Text,out _)) //out _ sirve para que no me devuelva el número parseado, simplemente quiero saber si sepuede parsear
                {
                    txtEdadIncorrecta.Visibility = Visibility.Visible;
                }
                else
                {
                    txtEdadIncorrecta.Visibility = Visibility.Hidden;
                }
            }
        }

    }
}