package reproductor;

public class Reproductor {
    public static void main(String[] args) {

        ListaReproduccion playlist = new ListaReproduccion();

        System.out.println("╔══════════════════════════════╗");
        System.out.println("║   🎧 REPRODUCTOR DE MÚSICA   ║");
        System.out.println("╚══════════════════════════════╝\n");

        // Cargar canciones
        System.out.println("── Cargando canciones ──");
        playlist.agregarCancion("Bohemian Rhapsody", "Queen", 354);
        playlist.agregarCancion("Hotel California", "Eagles", 391);
        playlist.agregarCancion("Stairway to Heaven", "Led Zeppelin", 482);
        playlist.agregarCancion("Imagine", "John Lennon", 187);
        playlist.agregarCancion("Smells Like Teen Spirit", "Nirvana", 301);

        // Ver lista completa
        playlist.mostrarLista();

        // Reproducir primera
        System.out.println("\n── Iniciando reproducción ──");
        playlist.reproducirActual();

        // Navegar hacia adelante
        System.out.println("\n── Presionando SIGUIENTE 3 veces ──");
        playlist.siguiente();
        playlist.siguiente();
        playlist.siguiente();

        // Navegar hacia atrás
        System.out.println("\n── Presionando ANTERIOR ──");
        playlist.anterior();

        // Ver lista actualizada
        playlist.mostrarLista();

        // Probar circularidad (avanzar desde la última canción)
        System.out.println("\n── Probando circularidad (desde última canción) ──");
        playlist.siguiente(); // Smells Like Teen Spirit
        playlist.siguiente(); // Debe volver a Bohemian Rhapsody !!

        // Eliminar una canción
        System.out.println("\n── Eliminando 'Imagine' ──");
        playlist.eliminarCancion("Imagine");
        playlist.mostrarLista();
    }
}