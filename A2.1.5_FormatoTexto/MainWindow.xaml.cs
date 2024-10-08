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

namespace A2._1._5_FormatoTexto
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

        private void textBoxPalabras_TextChanged(object sender, TextChangedEventArgs e)
        {
            textBlockYellow.Text = textBoxPalabras.Text;
        }

        // Variable para almacenar el último RadioButton seleccionado
        private RadioButton ultimoBotonChecked = null;
        private void Negrita_Click(object sender, RoutedEventArgs e)
        {
            textBlockYellow.FontWeight = FontWeights.Bold;
            if (Negrita.IsChecked == true && ultimoBotonChecked == Negrita)
            {
                Negrita.IsChecked = false;
                ultimoBotonChecked = null; //cuando uncheckeamos un boton lo ponemos a null
                textBlockYellow.FontWeight = FontWeights.Normal;
            }
            else
            {
                // Guardamos el RadioButton chequeado
                Negrita.IsChecked = true;
                ultimoBotonChecked = Negrita;
            }
        }

        private void Cursiva_Click(object sender, RoutedEventArgs e)
        {
            textBlockYellow.FontStyle = FontStyles.Italic;
            if (Cursiva.IsChecked == true && ultimoBotonChecked == Cursiva)
            {
                Cursiva.IsChecked = false;
                ultimoBotonChecked = null;
                textBlockYellow.FontStyle= FontStyles.Normal;
            }
            else
            {
                // Guardamos el RadioButton chequeado
                Cursiva.IsChecked = true;
                ultimoBotonChecked = Cursiva;
            }
        }

        private void buttonAzul_Checked(object sender, RoutedEventArgs e)
        {
            textBlockYellow.Foreground = new SolidColorBrush(Colors.Blue);
        }

        private void buttonRojo_Checked(object sender, RoutedEventArgs e)
        {
            textBlockYellow.Foreground = new SolidColorBrush(Colors.Red);
        }

        private void buttonVerde_Checked(object sender, RoutedEventArgs e)
        {
            textBlockYellow.Foreground = new SolidColorBrush(Colors.Green);
        }
    }
}