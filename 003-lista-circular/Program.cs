using System;

class Program
{
    static void Main()
    {
        ListaCircular lista = new ListaCircular();
        int opcion, valor;

        do
        {
            Console.WriteLine("\n--- MENU LISTA CIRCULAR ---");
            Console.WriteLine("1. Insertar");
            Console.WriteLine("2. Mostrar");
            Console.WriteLine("3. Buscar");
            Console.WriteLine("4. Eliminar");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese valor: ");
                    valor = int.Parse(Console.ReadLine());
                    lista.Insertar(valor);
                    break;

                case 2:
                    lista.Mostrar();
                    break;

                case 3:
                    Console.Write("Ingrese valor a buscar: ");
                    valor = int.Parse(Console.ReadLine());
                    Console.WriteLine(lista.Buscar(valor) ? "Encontrado" : "No encontrado");
                    break;

                case 4:
                    Console.Write("Ingrese valor a eliminar: ");
                    valor = int.Parse(Console.ReadLine());
                    lista.Eliminar(valor);
                    break;

                case 0:
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }

        } while (opcion != 0);
    }
}