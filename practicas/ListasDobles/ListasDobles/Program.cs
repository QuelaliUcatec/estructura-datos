using System;

namespace EstructuraDatos
{
    class Program
    {
        static void Main()
        {
            //GENERO LA LISTA Y AGREGO DATOS  
            ListaDoble miLista = new ListaDoble();
            miLista.InsertarFinal("MESSI");
            miLista.InsertarFinal("MIGUELITO");
            miLista.InsertarFinal("CRISTIANO");
            string opcion = "";

            while (opcion != "8")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("LISTA DOBLE");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Total elementos" + miLista.ObtenerTamano());
                Console.WriteLine("1. Insertar al Inicio");
                Console.WriteLine("2. Insertar al Final");
                Console.WriteLine("3. Eliminar al Inicio");
                Console.WriteLine("4. Eliminar al Final");
                Console.WriteLine("5. Buscar Elemento Recursividad");
                Console.WriteLine("6. Mostrar Elementos desde adelante");
                Console.WriteLine("7. Mostrar Elementos desde atras");
                Console.WriteLine("8. Salir");
                Console.Write("Elige una opción: ");
                opcion = Console.ReadLine();

                //SELECCION DE OPCIONES MEDIANTE UN SWITCH
                switch (opcion)
                {
                    case "1":
                        LlamarInsertarInicio(miLista);
                        break;
                    case "2":
                        LlamarInsertarFinal(miLista);
                        break;
                    case "3":
                        LlamarEliminarInicio(miLista);
                        break;
                    case "4":
                        LlamarEliminarFinal(miLista);
                        break;
                    case "5":
                        LlamarBuscar(miLista);
                        break;
                    case "6":
                        LlamarMostrarAdelante(miLista);
                        break;
                    case "7":
                        LlamarMostrarAtras(miLista);
                        break;
                    case "8":
                        Console.WriteLine("Saliendo");
                        break;
                    default:
                        Console.WriteLine("No valido, intenta de nuevo");
                        EsperarTecla();
                        break;
                }
            }
        }

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

        // CLASE LISTA DOBLE

        public class ListaDoble
        {
            private Nodo cabeza;
            private Nodo cola;
            private int tamano;

            public ListaDoble()
            {
                cabeza = null;
                cola = null;
                tamano = 0;
            }

            // 1. INSERTAR DATOS AL INICIO
            public void InsertarInicio(string dato)
            {
                Nodo nuevo = new Nodo(dato);
                if (EstaVacia()) cabeza = cola = nuevo;
                else
                {
                    nuevo.Siguiente = cabeza;
                    cabeza.Anterior = nuevo;
                    cabeza = nuevo;
                }
                tamano++;
            }
            // 2. INSERTAR DATOS AL FINAL
            public void InsertarFinal(string dato)
            {
                Nodo nuevo = new Nodo(dato);
                if (EstaVacia()) cabeza = cola = nuevo;
                else
                {
                    nuevo.Anterior = cola;
                    cola.Siguiente = nuevo;
                    cola = nuevo;
                }
                tamano++;
            }

            // 3. ELIMINACIONES DE DATOS AL INICIO
            public void EliminarInicio()
            {
                if (EstaVacia()) return;
                if (cabeza == cola) cabeza = cola = null;
                else
                {
                    cabeza = cabeza.Siguiente;
                    cabeza.Anterior = null;
                }
                tamano--;
            }
            // 4. ELIMINACIONES DE DATOS AL FINAL
            public void EliminarFinal()
            {
                if (EstaVacia()) return;
                if (cabeza == cola) cabeza = cola = null;
                else
                {
                    cola = cola.Anterior;
                    cola.Siguiente = null;
                }
                tamano--;
            }

            // 5. BÚSCAR DATOS
            public bool BuscarRecursivo(string valor)
            {
                return BuscarRec(cabeza, valor);
            }

            private bool BuscarRec(Nodo actual, string valor)
            {
                if (actual == null) return false; // Si llega al final y se encuentra
                if (actual.Dato.Equals(valor, StringComparison.OrdinalIgnoreCase)) return true; // Si se encuentra
                return BuscarRec(actual.Siguiente, valor); // Llamada recursiva saltando al siguiente
            }

            // 6. MOSTRAR DATOS DE ADELANTE
            public void MostrarAdelante()
            {
                Console.Write(" Desde adelante -> ");
                MostrarAdelanteRec(cabeza);
                Console.WriteLine(", VACIO");
            }

            private void MostrarAdelanteRec(Nodo actual)
            {
                if (actual == null) return;
                Console.Write(actual.Dato + " ");
                MostrarAdelanteRec(actual.Siguiente);
            }

            // 7. MOSTRAR DATOS DE ATRAS
            public void MostrarAtras()
            {
                Console.Write("Desde atras -> ");
                MostrarAtrasRec(cola);
                Console.WriteLine(", VACIO");
            }

            private void MostrarAtrasRec(Nodo actual)
            {
                if (actual == null) return;
                Console.Write(actual.Dato + " ");
                MostrarAtrasRec(actual.Anterior);
            }

            // ESTADO DE LA LISTA
            public bool EstaVacia() => cabeza == null;
            public int ObtenerTamano() => tamano;
        }
        // --- MÉTODOS PARA EL SWITCH (Mantienen el Main limpio) ---

        static void LlamarInsertarInicio(ListaDoble lista)
        {
            Console.Write("Ingresa el nombre a insertar al INICIO: ");
            string dato = Console.ReadLine().ToUpper();
            lista.InsertarInicio(dato);
            Console.WriteLine(dato + " Insertado correctamente");
            EsperarTecla();
        }

        static void LlamarInsertarFinal(ListaDoble lista)
        {
            Console.Write("Ingresa el nombre a insertar al FINAL: ");
            string dato = Console.ReadLine().ToUpper();
            lista.InsertarFinal(dato);
            Console.WriteLine(dato + "Insertado correctamente");
            EsperarTecla();
        }

        static void LlamarEliminarInicio(ListaDoble lista)
        {
            if (lista.EstaVacia())
            {
                Console.WriteLine("La lista ya esta vacia");
            }
            else
            {
                lista.EliminarInicio();
                Console.WriteLine("Primer elemento eliminado");
            }
            EsperarTecla();
        }

        static void LlamarEliminarFinal(ListaDoble lista)
        {
            if (lista.EstaVacia())
            {
                Console.WriteLine("La lista ya esta vacia");
            }
            else
            {
                lista.EliminarFinal();
                Console.WriteLine("Último elemento eliminado");
            }
            EsperarTecla();
        }

        static void LlamarBuscar(ListaDoble lista)
        {
            Console.Write("Ingresa el nombre que deseas buscar: ");
            string dato = Console.ReadLine().ToUpper();

            bool encontrado = lista.BuscarRecursivo(dato);

            if (encontrado)
                Console.WriteLine(dato + " Si se encuentra en la lista");
            else
                Console.WriteLine(dato + " No existe en la lista");

            EsperarTecla();
        }

        static void LlamarMostrarAdelante(ListaDoble lista)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" DESDE ADELANTE");
            Console.ForegroundColor = ConsoleColor.White;
            lista.MostrarAdelante();
            EsperarTecla();
        }

        static void LlamarMostrarAtras(ListaDoble lista)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("DESDE ATRAS");
            Console.ForegroundColor = ConsoleColor.White;
            lista.MostrarAtras();
            EsperarTecla();
        }

// VOLVER AL MENU
        static void EsperarTecla()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Presiona cualuier tecla para volver al menu principal");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }
    }
}