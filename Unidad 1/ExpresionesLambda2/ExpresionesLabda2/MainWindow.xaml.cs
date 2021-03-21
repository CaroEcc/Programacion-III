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

namespace ExpresionesLabda2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public delegate bool Agrega(char caracter);
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public string filtrar(string cadena, Agrega agrega)
        {
            StringBuilder cadenaNueva = new StringBuilder();
            foreach (var caracter in cadena)
            {
                if (agrega(caracter))
                {
                    cadenaNueva.Append(caracter);
                }
            }
            return cadenaNueva.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ltsLista.Items.Clear();
            string cadena = txtCadena.Text;
            ltsLista.Items.Add("Vocales:");    
            ltsLista.Items.Add(filtrar(cadena, caracter => caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u' ||
                                                           caracter == 'A' || caracter == 'E' || caracter == 'I' || caracter == 'O' || caracter == 'U'));
            
            ltsLista.Items.Add("Digitos:");
            ltsLista.Items.Add(filtrar(cadena, caracter => char.IsDigit(caracter)));

            ltsLista.Items.Add("Minusculas:");
            ltsLista.Items.Add(filtrar(cadena, caracter => char.IsLower(caracter)));

            ltsLista.Items.Add("Caracteres y numeros:");
            ltsLista.Items.Add(filtrar(cadena, caracter => char.IsLetter(caracter) || char.IsNumber(caracter)));

            txtCadena.Clear();
        }
    }
}
