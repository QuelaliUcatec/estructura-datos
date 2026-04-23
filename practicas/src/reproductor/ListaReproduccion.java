package reproductor;

class ListaReproduccion {
    private Nodo cabeza;
    private Nodo actual; // canción que está sonando ahora
    private int totalCanciones;

    public ListaReproduccion() {
        this.cabeza = null;
        this.actual = null;
        this.totalCanciones = 0;
    }

    // --- Agregar canción al final ---
    public void agregarCancion(String titulo, String artista, int duracion) {
        Nodo nuevo = new Nodo(titulo, artista, duracion);

        if (cabeza == null) {
            // Primera canción: apunta a sí misma
            nuevo.siguiente = nuevo;
            nuevo.anterior = nuevo;
            cabeza = nuevo;
            actual = nuevo; // empieza reproduciendo la primera
        } else {
            Nodo ultimo = cabeza.anterior;
            ultimo.siguiente = nuevo;
            nuevo.anterior = ultimo;
            nuevo.siguiente = cabeza;
            cabeza.anterior = nuevo;
        }
        totalCanciones++;
        System.out.println("✅ Agregada: \"" + titulo + "\" de " + artista);
    }

    // --- Eliminar canción por título ---
    public void eliminarCancion(String titulo) {
        if (cabeza == null) {
            System.out.println("❌ La lista está vacía.");
            return;
        }

        Nodo temp = cabeza;
        do {
            if (temp.titulo.equalsIgnoreCase(titulo)) {
                if (totalCanciones == 1) {
                    // Era la única canción
                    cabeza = null;
                    actual = null;
                } else {
                    temp.anterior.siguiente = temp.siguiente;
                    temp.siguiente.anterior = temp.anterior;
                    if (temp == cabeza)
                        cabeza = temp.siguiente;
                    if (temp == actual)
                        actual = temp.siguiente; // saltar a la siguiente
                }
                totalCanciones--;
                System.out.println("🗑️  Eliminada: \"" + titulo + "\"");
                return;
            }
            temp = temp.siguiente;
        } while (temp != cabeza);

        System.out.println("⚠️  Canción \"" + titulo + "\" no encontrada.");
    }

    // --- Siguiente canción (circular) ---
    public void siguiente() {
        if (actual == null) {
            System.out.println("❌ No hay canciones en la lista.");
            return;
        }
        actual = actual.siguiente;
        reproducirActual();
    }

    // --- Canción anterior (circular) ---
    public void anterior() {
        if (actual == null) {
            System.out.println("❌ No hay canciones en la lista.");
            return;
        }
        actual = actual.anterior;
        reproducirActual();
    }

    // --- Mostrar la canción actual ---
    public void reproducirActual() {
        if (actual == null) {
            System.out.println("❌ No hay canciones.");
            return;
        }
        System.out.println("\n🎵 Reproduciendo ahora:");
        System.out.println("   Título  : " + actual.titulo);
        System.out.println("   Artista : " + actual.artista);
        System.out.println("   Duración: " + actual.duracionFormateada());
    }

    // --- Mostrar toda la lista de reproducción ---
    public void mostrarLista() {
        if (cabeza == null) {
            System.out.println("📭 La lista de reproducción está vacía.");
            return;
        }
        System.out.println("\n📋 Lista de reproducción (" + totalCanciones + " canciones):");
        System.out.println("─".repeat(50));
        Nodo temp = cabeza;
        int numero = 1;
        do {
            String marcador = (temp == actual) ? " ◄ REPRODUCIENDO" : "";
            System.out.printf("  %d. %-30s [%s]%s%n",
                    numero++, temp.titulo + " - " + temp.artista,
                    temp.duracionFormateada(), marcador);
            temp = temp.siguiente;
        } while (temp != cabeza);
        System.out.println("─".repeat(50));
        System.out.println("  🔁 (La lista vuelve al inicio automáticamente)");
    }
}
