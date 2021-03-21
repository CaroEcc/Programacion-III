using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ExpresionesLambda_1
{
    public delegate bool Comparacion(int elemento);

    class Curso
    {
        private Estudiante[] estudiante = new Estudiante[5];

        public void Cargar(int lugar, Estudiante alumno)
        {
            estudiante[lugar] = alumno;
        }

        public List<Estudiante> ImprimirTodo()
        {
            List<Estudiante> datos = new List<Estudiante>();

            foreach (var elemento in estudiante)
                datos.Add(new Estudiante() { Nombre = elemento.Nombre, Nota = elemento.Nota });
            return datos;
        }

        public List<Estudiante> ImprimirSi(Comparacion compara)
        {
            List<Estudiante> datos = new List<Estudiante>();

            foreach (var elemento in estudiante)
                if (compara(elemento.Nota))
                    datos.Add(new Estudiante() { Nombre = elemento.Nombre, Nota = elemento.Nota });
            return datos;
        }
    }
}
