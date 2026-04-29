using System;
using EstructuraDatos.Listas;

class Program
{
    static void Main(string[] args)
    {
        ListaSimple miLista = new ListaSimple();
        
        Console.WriteLine("=== SISTEMA DE GESTIÓN DE LISTA SIMPLE ===");

        // Aquí es de dónde sale el parámetro
        Console.Write("Por favor, ingresa un número para el primer nodo: ");
        string entrada = Console.ReadLine();
        int numeroIngresado = int.Parse(entrada);

        // AQUÍ SE ENVÍA EL PARÁMETRO
        miLista.Insertar(numeroIngresado);

        Console.Write("Ingresa otro número para el segundo nodo: ");
        miLista.Insertar(int.Parse(Console.ReadLine())); // Versión corta

        Console.WriteLine("\n--- Estado actual de la memoria ---");
        miLista.Mostrar();

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
