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

namespace Evaluacion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Window2 window2 = new Window2();

            window2.Eve += new Window2.Evento<int>(ejecutar);

            window2.Show();
        }

        public void ejecutar(int valor1, int valor2, string op)
        {
            Operaciones<int> oper = new Operaciones<int>();
            MessageBox.Show(op);
            if (op == "Suma")
            {
                lbResultado.Content = oper.Suma(valor1, valor2, (ope) => op == "Suma", op);
            }
            else if (op == "Resta")
            {
                lbResultado.Content = oper.Resta(valor1, valor2, (ope) => op == "Resta", op);
            }
            else if (op == "Multiplicacion")
            {
                lbResultado.Content = oper.Multiplicacion(valor1, valor2, (ope) => op == "Multiplicacion", op);
            }
            else
            {
                lbResultado.Content = oper.Division(valor1, valor2, (ope) => op == "Division", op);
            }
        }

    }
}
