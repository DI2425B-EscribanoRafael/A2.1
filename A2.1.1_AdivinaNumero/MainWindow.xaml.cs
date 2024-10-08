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

namespace A2._1._1_AdivinaNumero
{
    public partial class MainWindow : Window
    {
        private int numeroRan;
        public MainWindow()
        {
            InitializeComponent();
            numeroRan = GeneraNumRandom(100 );
        }

        public int GeneraNumRandom(int maximo)
        {
            Random random = new Random();
            return random.Next(0, maximo + 1);
        }
        private void Button_Comprobar_Click(object sender, RoutedEventArgs e)
        {
            if(int.Parse(numeroTextBox.Text) < numeroRan)
            {
                mensajeTextBlock.Text = "Te has quedado corto";
            } else if (int.Parse(numeroTextBox.Text) > numeroRan)
            {
                mensajeTextBlock.Text = "Te has pasado";
            } else mensajeTextBlock.Text = "HAS ACERTADO";
        }

        private void Button_Reiniciar_Click(object sender, RoutedEventArgs e)
        {
            numeroRan = GeneraNumRandom(100);
            mensajeTextBlock.Text = "";
        }

        
    }
}