package reproductor;

class Nodo {
    String titulo;
    String artista;
    int duracionSegundos;
    Nodo siguiente;
    Nodo anterior;

    public Nodo(String titulo, String artista, int duracionSegundos) {
        this.titulo = titulo;
        this.artista = artista;
        this.duracionSegundos = duracionSegundos;
        this.siguiente = null;
        this.anterior = null;
    }

    public String duracionFormateada() {
        return String.format("%d:%02d", duracionSegundos / 60, duracionSegundos % 60);
    }
}
