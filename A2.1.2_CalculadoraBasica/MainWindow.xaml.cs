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

namespace A2._1._2_CalculadoraBasica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            textBoxResultado.IsReadOnly = true;
        }
        private void textBoxOperador_TextChanged(object sender, EventArgs e)
        {
            switch (textBoxOperador.Text)
            {
                case "+":
                case "-":
                case "*":
                case "/":
                    buttonCalcular.IsEnabled = true;
                    break;
                default:
                    buttonCalcular.IsEnabled = false;
                    break;
            }
        }

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            switch (textBoxOperador.Text)
            {
                case "+":
                    textBoxResultado.Text = (int.Parse(textBoxNumero1.Text) + int.Parse(textBoxNumero2.Text)).ToString();
                    break;
                case "-":
                    textBoxResultado.Text = (int.Parse(textBoxNumero1.Text) - int.Parse(textBoxNumero2.Text)).ToString();
                    break;
                case "*":
                    textBoxResultado.Text = (int.Parse(textBoxNumero1.Text) * int.Parse(textBoxNumero2.Text)).ToString();
                    break;
                case "/":
                    textBoxResultado.Text = (int.Parse(textBoxNumero1.Text) / int.Parse(textBoxNumero2.Text)).ToString();
                    break;
                default:
                    Console.Error.WriteLine("Introduce un operador válido.");
                    break;
            }
        }

        private void LimpiarButton_Click(object sender, RoutedEventArgs e)
        {
            textBoxNumero1.Text = "";
            textBoxNumero2.Text = "";
            textBoxOperador.Text = "";
            textBoxResultado.Text = "";
        }
    }
}