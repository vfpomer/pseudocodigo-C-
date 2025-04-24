using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios
{
    public class AsignarTrabajos
    {
        // Estructura para almacenar nombre y el número de veces que se asignará al trabajador.
        private struct trabajador
        {
            public string nombre { get; set; }
            public int veces { get; set; }
        }

        private List<trabajador> trabajadores;  // Lista de trabajadores
        private int index = 0;  // Índice del trabajador actual a asignar
        private int asignacionesRestantes;  // Cuántas veces falta asignar al trabajador actual

        public AsignarTrabajos()
        {
            // Inicializamos la lista de trabajadores con el nombre y las veces que debe asignarse
            trabajadores = new List<trabajador>
            {
                new trabajador() { nombre = "Antonio", veces = 2 },
                new trabajador() { nombre = "Jesús", veces = 1 }
            };

            // Iniciamos el primer trabajador (Antonio) y el número de asignaciones restantes
            asignacionesRestantes = trabajadores[index].veces;
        }

        public string getTrabajadorAsignado()
        {
            // Obtenemos el nombre del trabajador actual
            string nombreTrabajador = trabajadores[index].nombre;

            // Decrementamos el número de asignaciones restantes
            asignacionesRestantes--;

            // Si ya hemos asignado al trabajador el número de veces que corresponde
            if (asignacionesRestantes == 0)
            {
                // Pasamos al siguiente trabajador. Si llegamos al final, volvemos al principio
                index = (index + 1) % trabajadores.Count;

                // Reiniciamos el contador de asignaciones del trabajador
                asignacionesRestantes = trabajadores[index].veces;
            }

            // Retornamos el nombre del trabajador asignado
            return nombreTrabajador;
        }
    }

    class Program
    {
        static void Main()
        {
            // Establecer la codificación UTF-8 para la salida de consola
            Console.OutputEncoding = Encoding.UTF8;

            AsignarTrabajos asignar = new AsignarTrabajos();

            // Prueba de la asignación de trabajadores con codificación UTF-8
            Console.WriteLine(asignar.getTrabajadorAsignado()); // Debería imprimir: Antonio
            Console.WriteLine(asignar.getTrabajadorAsignado()); // Debería imprimir: Antonio
            Console.WriteLine(asignar.getTrabajadorAsignado()); // Debería imprimir: Jesús
            Console.WriteLine(asignar.getTrabajadorAsignado()); // Debería imprimir: Antonio
            Console.WriteLine(asignar.getTrabajadorAsignado()); // Debería imprimir: Antonio
            Console.WriteLine(asignar.getTrabajadorAsignado()); // Debería imprimir: Jesús
        }
    }
}
