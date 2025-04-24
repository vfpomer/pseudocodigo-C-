using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios
{
    public static class Ejercicio2
    {
        public static int variable { get; set; }

        // Método auxiliar que simula lentitud y devuelve la diferencia entre el día actual y 15.
        private static int métodoAuxiliar()
        { 
            System.Threading.Thread.Sleep(1000); // Simulamos lentitud en la ejecución: 1 segundo de espera
            return DateTime.Now.Day - 15;  // Devuelve el día del mes actual menos 15
        }

        /// <summary>
        /// Sin modificar el contenido de métodoAuxiliar(), optimizar lo máximo posible el siguiente método
        /// </summary>
        public static void método()
        {
            // Llamada única al métodoAuxiliar
            int resultado = métodoAuxiliar(); 

            // Comprobaciones basadas en el único valor calculado
            if (resultado < 0)
            {
                variable = -1;  // Si el valor calculado es menor que 0, se asigna -1
            }
            else if (resultado == 0)
            {
                variable = 0;   // Si el valor calculado es 0, se asigna 0
            }
            else if (resultado >= 1)
            {
                variable = 1;   // Si el valor calculado es mayor o igual a 1, se asigna 1
            }
        }

        // Método Main que es el punto de entrada de la aplicación
        public static void Main(string[] args)
        {
            // Llamamos al método optimizado
            método();
            
            // Mostramos el valor de la variable para verificar el resultado
            Console.WriteLine("El valor de la variable es: " + variable);
        }
    }
}
