using System;
using EstructuraDatos.Listas; // Esto conecta con tu clase de arriba

class Program
{
    static void Main(string[] args)
    {
        // 1. Creamos la lista en memoria
        ListaSimple miLista = new ListaSimple();

        Console.WriteLine("=== PRUEBA DE ESTRUCTURA DE DATOS: LISTA SIMPLE ===");
        
        // 2. Insertamos datos para demostrar que funciona
        Console.WriteLine("Insertando valores: 10, 20, 30...");
        miLista.Insertar(10);
        miLista.Insertar(20);
        miLista.Insertar(30);

        // 3. Mostramos la lista en consola
        Console.WriteLine("\nResultado de la lista enlazada:");
        miLista.Mostrar();

        Console.WriteLine("\n================================================");
        Console.WriteLine("Presiona cualquier tecla para finalizar la prueba.");
        Console.ReadKey();
    }
}
