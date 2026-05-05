namespace EstructuraDatos.Listas
{
    /// <summary>
    /// Representa un elemento individual (nodo) dentro de la lista enlazada.
    /// Funciona como un contenedor que guarda el dato y la dirección de memoria del siguiente eslabón.
    /// </summary>
    public class Nodo
    {
        /// <summary>
        /// Obtiene o establece el valor numérico almacenado en el nodo.
        /// </summary>
        public int Dato { get; set; }

        /// <summary>
        /// Obtiene o establece la referencia (puntero) al siguiente nodo en la estructura.
        /// Si este es el último nodo de la lista, su valor será null.
        /// </summary>
        public Nodo Siguiente { get; set; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase Nodo.
        /// Al crearse, se aísla de la lista (Siguiente = null) hasta que sea enlazado explícitamente.
        /// </summary>
        /// <param name="valor">El número entero que se guardará en este nodo.</param>
        public Nodo(int valor)
        {
            this.Dato = valor;
            this.Siguiente = null;
        }
    }
}
