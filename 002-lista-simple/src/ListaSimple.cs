using System;

namespace EstructuraDatos.Listas
{
    public class ListaSimple
    {
        // 'cabeza' (head) es el ancla. Si perdemos esta referencia, perdemos toda la lista.
        private Nodo cabeza;

        public ListaSimple()
        {
            this.cabeza = null; // Inicialmente, la lista no existe en memoria (está vacía)
        }

        /// <summary>
        /// Agrega un nuevo elemento al final de la estructura.
        /// Complejidad temporal: O(n) - debe recorrer toda la lista.
        /// </summary>
        public void Insertar(int valor)
        {
            Nodo nuevoNodo = new Nodo(valor); // 1. Creamos el nuevo objeto en el Heap

            // Caso A: Si la lista está vacía, el nuevo nodo se convierte en la cabeza
            if (cabeza == null)
            {
                cabeza = nuevoNodo;
            }
            else
            {
                // Caso B: Recorrer hasta el final
                Nodo actual = cabeza; // Usamos un 'puntero auxiliar' para no perder la cabeza
                
                // Mientras el nodo actual tenga a alguien después de él...
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente; // Saltamos al siguiente eslabón
                }
                
                // Una vez que llegamos al último (donde Siguiente era null), conectamos
                actual.Siguiente = nuevoNodo;
            }
        }

        /// <summary>
        /// Imprime los elementos de forma secuencial.
        /// </summary>
        public void Mostrar()
        {
            if (cabeza == null)
            {
                Console.WriteLine("Lista vacía.");
                return;
            }

            Nodo temp = cabeza; // Iniciamos en el origen
            while (temp != null) // Mientras el nodo actual exista
            {
                Console.Write($"[{temp.Dato}] -> ");
                temp = temp.Siguiente; // Desplazamiento lógico
            }
            Console.WriteLine("NULL");
        }
    }
}