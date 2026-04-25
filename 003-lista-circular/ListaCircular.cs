using System;

public class ListaCircular
{
    private Nodo cabeza = null;

    public void Insertar(int dato)
    {
        Nodo nuevo = new Nodo(dato);

        if (cabeza == null)
        {
            cabeza = nuevo;
            cabeza.Siguiente = cabeza;
        }
        else
        {
            Nodo actual = cabeza;

            while (actual.Siguiente != cabeza)
            {
                actual = actual.Siguiente;
            }

            actual.Siguiente = nuevo;
            nuevo.Siguiente = cabeza;
        }
    }

    public void Mostrar()
    {
        if (cabeza == null)
        {
            Console.WriteLine("Lista vacía");
            return;
        }

        Nodo actual = cabeza;

        do
        {
            Console.Write(actual.Dato + " -> ");
            actual = actual.Siguiente;
        } while (actual != cabeza);

        Console.WriteLine("(inicio)");
    }

    public bool Buscar(int valor)
    {
        if (cabeza == null) return false;

        Nodo actual = cabeza;

        do
        {
            if (actual.Dato == valor)
                return true;

            actual = actual.Siguiente;

        } while (actual != cabeza);

        return false;
    }

    public void Eliminar(int valor)
    {
        if (cabeza == null) return;

        Nodo actual = cabeza;
        Nodo anterior = null;

        do
        {
            if (actual.Dato == valor)
            {
                if (actual == cabeza && actual.Siguiente == cabeza)
                {
                    cabeza = null;
                }
                else if (actual == cabeza)
                {
                    Nodo ultimo = cabeza;

                    while (ultimo.Siguiente != cabeza)
                    {
                        ultimo = ultimo.Siguiente;
                    }

                    cabeza = cabeza.Siguiente;
                    ultimo.Siguiente = cabeza;
                }
                else
                {
                    anterior.Siguiente = actual.Siguiente;
                }

                Console.WriteLine("Elemento eliminado");
                return;
            }

            anterior = actual;
            actual = actual.Siguiente;

        } while (actual != cabeza);

        Console.WriteLine("Elemento no encontrado");
    }
}