using System;

namespace EstructuraDatos.Listas
{
    public class ListaSimple
    {
        // El ancla principal de la lista. Privado para mantener el encapsulamiento.
        private Nodo cabeza;

        /// <summary>
        /// Inicializa una nueva instancia de la clase ListaSimple, empezando vacía.
        /// </summary>
        public ListaSimple()
        {
            this.cabeza = null;
        }

        /// <summary>
        /// Inserta un nuevo nodo al final de la estructura enlazada.
        /// Complejidad temporal: O(n) - requiere recorrer la lista hasta el último elemento.
        /// </summary>
        /// <param name="valor">El dato de tipo entero que se encapsulará en el nuevo nodo.</param>
        public void Insertar(int valor)
        {
            Nodo nuevoNodo = new Nodo(valor);

            // Caso A: La lista está vacía. El nuevo nodo es la cabeza.
            if (cabeza == null)
            {
                cabeza = nuevoNodo;
                return; // Salimos prematuramente para mantener el código limpio sin usar 'else'
            }

            // Caso B: Recorrer hasta el final usando un puntero auxiliar.
            Nodo actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            
            // Enlazamos el último nodo con el recién creado.
            actual.Siguiente = nuevoNodo;
        }

        /// <summary>
        /// Recorre secuencialmente la lista e imprime sus valores en la consola.
        /// </summary>
        public void Mostrar()
        {
            if (cabeza == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Nodo actual = cabeza;
            while (actual != null)
            {
                Console.Write($"[{actual.Dato}] -> ");
                actual = actual.Siguiente;
            }
            Console.WriteLine("NULL");
        }
    }
}
