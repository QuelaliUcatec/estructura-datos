using System;

namespace EstructuraDatos
{
    
    public class Nodo
    {
        public string Dato { get; set; }
        public Nodo Anterior { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(string dato)
        {
            Dato = dato;
            Anterior = null;
            Siguiente = null;
        }
    }

    public class ListaDoble
    {
        public Nodo Cabeza { get; set; }
        public Nodo Cola { get; set; }

        public ListaDoble()
        {
            Cabeza = null;
            Cola = null;
        }

        //Método para insertar al final de la lista
        public void Insertar(string dato)
        {
            Nodo nuevoNodo = new Nodo(dato);

            if (Cabeza == null)
            {
                Cabeza = nuevoNodo;
                Cola = nuevoNodo;
            }
            else
            {
                nuevoNodo.Anterior = Cola;
                Cola.Siguiente = nuevoNodo;
                Cola = nuevoNodo;
            }
        }

        //Método para recorrer desde Messi hasta Cristiano
        public void MostrarHaciaAdelante()
        {
            Console.Write("Recorrido Adelante: NULL - ");
            Nodo actual = Cabeza;

            while (actual != null)
            {
                Console.Write(actual.Dato + " -> ");
                actual = actual.Siguiente;
            }
            Console.WriteLine("NULL");
        }

        // 5. Método para recorrer desde Cristiano hasta Messi
        public void MostrarHaciaAtras()
        {
            Console.Write("Recorrido Atrás:  NULL - ");
            Nodo actual = Cola;

            while (actual != null)
            {
                Console.Write(actual.Dato + " - ");
                actual = actual.Anterior;
            }
            Console.WriteLine("NULL");
        }
    }

    // Clase principal para ejecutar el programa
    class Program
    {
        static void Main(string[] args)
        {
            ListaDoble miLista = new ListaDoble();

            // Insertamos la nueva alineación
            miLista.Insertar("MESSI");
            miLista.Insertar("MIGUELITO");
            miLista.Insertar("CRISTIANO");

            Console.WriteLine("LISTA DOBLE");
            miLista.MostrarHaciaAdelante();
            miLista.MostrarHaciaAtras();
        }
    }
}