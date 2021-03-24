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
using System.Windows.Shapes;

namespace Evaluacion
{
    /// <summary>
    /// Lógica de interacción para Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public delegate void Evento<T>(T valor1, T valor2, string operacion);
        public event Evento<int> Eve;
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int valor1 = int.Parse(txtValor1.Text);
            int valor2 = int.Parse(txtValor2.Text);
            string op = cbxOper.Text;

            Eve(valor1, valor2, op);
        }
    }
}
