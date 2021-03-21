using System;

namespace MetodoAnonimo
{
    delegate int Aleatorio(int max);
    class Program
    {
        static void Main(string[] args)
        {
            Aleatorio alea = delegate (int max)
            {
                int promedio=0;
                int[] array = new int[5];
                Random random = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(0, max);
                }

                for (int i = 0; i < array.Length; i++)
                {
                    promedio = promedio + array[i];
                }
                promedio = promedio * array.Length;
                return promedio;
            };

            
            Console.WriteLine("El promedio es:" + alea(6));

        }
    }
}
