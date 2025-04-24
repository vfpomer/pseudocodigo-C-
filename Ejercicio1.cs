using System;
using System.Collections.Generic;
//Lenguaje C#
namespace Ejercicios
{
    public static class Ejercicio1
    {
        /// <summary>
        /// Este método elimina de una lista los elementos en las posiciones indicadas en otra lista.
        /// </summary>
        /// <param name="lista">Lista principal que será modificada</param>
        /// <param name="posicionesAEliminar">Lista de posiciones a eliminar de la lista principal</param>
        public static void eliminarPosiciones(List<int> lista, List<int> posicionesAEliminar)
        {
            // Validación: Si la lista de posiciones está vacía, no hacemos nada
            if (posicionesAEliminar == null || posicionesAEliminar.Count == 0)
                return;

            // Ordenamos las posiciones a eliminar en orden descendente
            // para evitar que los índices cambien al eliminar elementos.
            posicionesAEliminar.Sort();
            posicionesAEliminar.Reverse();

            // Creamos una lista de posiciones únicas para eliminar
            HashSet<int> posicionesÚnicas = new HashSet<int>(posicionesAEliminar);

            // Iteramos sobre las posiciones únicas a eliminar
            foreach (int posicion in posicionesÚnicas)
            {
                // Validamos que la posición sea válida para evitar errores
                if (posicion >= 0 && posicion < lista.Count)
                {
                    lista.RemoveAt(posicion); // Eliminamos el elemento en la posición especificada
                }
            }
        }

        // Método de prueba para verificar el funcionamiento
        public static void Main(string[] args)
        {
            // Ejemplo 1
            List<int> lista1 = new List<int> { 3, 1, 2 };
            List<int> posiciones1 = new List<int> { 0, 1, 2 };
            eliminarPosiciones(lista1, posiciones1);
            Console.WriteLine("Ejemplo 1: " + string.Join(", ", lista1)); // Debería imprimir: []

            // Ejemplo 2
            List<int> lista2 = new List<int> { 3, 1, 2 };
            List<int> posiciones2 = new List<int> { 0, 1 };
            eliminarPosiciones(lista2, posiciones2);
            Console.WriteLine("Ejemplo 2: " + string.Join(", ", lista2)); // Debería imprimir: [2]

            // Ejemplo 3
            List<int> lista3 = new List<int> { 3, 1, 2 };
            List<int> posiciones3 = new List<int> { 0, 0 };
            eliminarPosiciones(lista3, posiciones3);
            Console.WriteLine("Ejemplo 3: " + string.Join(", ", lista3)); // Debería imprimir: [1, 2]
        }
    }
}
