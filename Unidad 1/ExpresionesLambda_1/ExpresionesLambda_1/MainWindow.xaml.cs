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

namespace ExpresionesLambda_1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int contador = 0;
        Curso curso = new Curso();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nombre = txtNombre.Text;
            int nota = int.Parse(txtNota.Text);

            curso.Cargar(contador, new Estudiante { Nombre = nombre, Nota = nota });
            contador++;
            if(contador > 4)
            {
                btnEnvio.IsEnabled = false;
                MessageBox.Show("Ya no se permiten mas registros. Imprima los datos en pantalla");
            }

            txtNombre.Clear();
            txtNota.Clear();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<Estudiante> datos = curso.ImprimirTodo();
            //Listado completo de alumnos
            foreach (var elemento in datos)
                lstLista1.Items.Add(elemento.Nombre+ " " +elemento.Nota);

            List<Estudiante> datosCondicionales = curso.ImprimirSi((nota) => nota >= 51);
            //Listado con notas mayores o iguales a 7
            foreach (var elemento in datosCondicionales)
                lstLista2.Items.Add(elemento.Nombre + " " + elemento.Nota);

            //Listado de estudiantes con un dos
            List<Estudiante> datosCondicionales2 = curso.ImprimirSi((nota) => nota == 50);
            foreach (var elemento in datosCondicionales2)
                lstLista3.Items.Add(elemento.Nombre + " " + elemento.Nota);

            //Listado comleto de estudiantes con el metodo condicional
            //List<Estudiante> datosCondicionales3 = curso.ImprimirSi((nota => true));
            //foreach (var elemento in datos)
            //    lstLista3.Items.Add(elemento.Nombre + " " + elemento.Nota);

        }
    }
}
