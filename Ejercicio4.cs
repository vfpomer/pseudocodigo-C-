using System;
using System.Text;

namespace Ejercicios
{
    // Puedes usar una clase estática o no estática como quieras.
    public static class Ejercicio4
    {
        private static readonly int[] precios = { 100, 90, 120, 80, 110, 140, 60, 110 };

        /// <summary>
        /// Dada la lista 'precios', que representa el valor en € de un objeto cada 
        /// día durante un periodo de 8 días, devolver el máximo beneficio en € que 
        /// podemos obtener al comprar el objeto en un día X y venderlo en otro día X + n.
        /// No se puede vender el objeto antes de comprarlo.
        /// </summary>
        public static int MaximoBeneficio()
        {
            // Inicializamos el precio mínimo con el primer valor del array de precios.
            int minPrecio = precios[0];
            int maxBeneficio = 0;

            // Recorremos el array de precios desde el segundo día en adelante.
            for (int i = 1; i < precios.Length; i++)
            {
                // Calculamos el beneficio si compramos al precio mínimo y vendemos en el día actual.
                int beneficioActual = precios[i] - minPrecio;

                // Actualizamos el máximo beneficio si encontramos uno mejor.
                maxBeneficio = Math.Max(maxBeneficio, beneficioActual);

                // Actualizamos el precio mínimo si encontramos un precio más bajo.
                minPrecio = Math.Min(minPrecio, precios[i]);
            }

            return maxBeneficio;
        }
    }

    // Aquí es donde debes agregar el punto de entrada (método Main)
    class Program
    {
        static void Main(string[] args)
        {
            // Establecer la codificación de la consola a UTF-8
            Console.OutputEncoding = Encoding.UTF8;

            // Llamamos al método MaximoBeneficio de Ejercicio4
            int beneficio = Ejercicio4.MaximoBeneficio();

            // Mostramos el resultado en consola (incluyendo el símbolo del euro)
            Console.WriteLine($"El máximo beneficio es: {beneficio}€");

            // Esperamos a que el usuario presione una tecla antes de cerrar la consola
            Console.ReadKey();
        }
    }
}