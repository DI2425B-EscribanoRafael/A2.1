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

namespace A2._1._4_CaracteresLimitados
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

        private void textBoxLimitePalabras_TextChanged(object sender, TextChangedEventArgs e)
        {
            int contador = textBoxLimitePalabras.Text.Length;
            if(contador == 140)
            {
                textBoxLimitePalabras.IsReadOnly = true;
            }
            contadorPalabras.Text = contador.ToString() + "/140";
        }
    }
}