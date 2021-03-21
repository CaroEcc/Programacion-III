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

namespace Eventos19_21
{
    /// <summary>
    /// Lógica de interacción para Window2.xaml
    /// </summary>
    
    public partial class Window2 : Window
    {
        public delegate void CambiarTitulo(string dato);
        public event CambiarTitulo Cambiar;

        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)

        {
            string titulo = txtTitulo.Text;

            Cambiar(txtTitulo.Text); 

        }


    }
}
