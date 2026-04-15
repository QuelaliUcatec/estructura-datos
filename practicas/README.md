# Reproductor de Música — Lista Circular Doble en Java

Proyecto educativo que implementa un **reproductor de música** usando una **lista circular doblemente enlazada** como estructura de datos subyacente.

---

## ¿Qué es una lista circular doble?

Una **lista circular doblemente enlazada** es una estructura de datos en la que cada elemento (nodo) conoce tanto a su vecino siguiente como a su vecino anterior, y el último nodo está conectado de vuelta al primero, formando un ciclo cerrado sin extremos.

### Anatomía de un nodo

```
┌──────────┬──────────┬──────────┐
│ anterior │  datos   │ siguiente│
└──────────┴──────────┴──────────┘
```

- `anterior` → apunta al nodo de atrás
- `datos`    → la información almacenada (título, artista, duración)
- `siguiente`→ apunta al nodo de adelante

### Cómo se ve en memoria (3 nodos: A, B, C)

```
    ┌─────────────────────────────────────────┐
    ▼                                         │
┌───────┐   next    ┌───────┐   next    ┌───────┐
│   A   │ ────────► │   B   │ ────────► │   C   │
│       │ ◄──────── │       │ ◄──────── │       │
└───────┘   prev    └───────┘   prev    └───────┘
    │                                         ▲
    └─────────────────────────────────────────┘
```

No hay `null` en ningún extremo. Todos los nodos están conectados en ambas direcciones formando un ciclo.

### Características principales

| Característica | Detalle |
|---|---|
| Recorrido | En ambas direcciones (adelante y atrás) |
| Circularidad | El último nodo apunta al primero y viceversa |
| Inserción / eliminación | O(1) si se tiene referencia al nodo |
| Sin extremos nulos | Nunca se llega a `null` recorriendo la lista |

### Ventajas

- Navegación bidireccional natural
- Al llegar al final, vuelve automáticamente al inicio
- Insertar y eliminar nodos es eficiente
- Ideal para estructuras que se repiten en ciclo

### Desventajas

- Más memoria por nodo (dos punteros en vez de uno)
- Más compleja de implementar que una lista simple
- Hay que mantener siempre la circularidad al insertar o eliminar

---

## Aplicación en este reproductor

El reproductor mapea directamente las operaciones de un reproductor de música a las operaciones de la lista:

| Acción del reproductor | Operación en la lista |
|---|---|
| ▶ Reproducir canción | Acceder al nodo `actual` |
| ⏭ Siguiente canción | Seguir el puntero `siguiente` |
| ⏮ Anterior canción | Seguir el puntero `anterior` |
| Al llegar a la última y dar siguiente | `siguiente` del último apunta al primero → circularidad |
| Al estar en la primera y dar anterior | `anterior` del primero apunta al último → circularidad |
| ➕ Agregar canción | Insertar nodo al final y cerrar el círculo |
| 🗑 Eliminar canción | Reconectar los nodos vecinos y liberar el nodo |

La **circularidad** es lo que permite que la lista de reproducción vuelva al inicio sin ninguna condición especial: simplemente se sigue el puntero `siguiente` del último nodo y se llega al primero.

---

## Estructura del proyecto

```
reproductor-musica/
│
├── src/
│   └── reproductor/
│       ├── Nodo.java               ← Representa cada canción
│       ├── ListaReproduccion.java  ← Lógica de la lista circular doble
│       └── Reproductor.java        ← Punto de entrada (main)
│
└── README.md
```

---

## Requisitos

- **Java JDK 8** o superior
- Terminal / línea de comandos

Verificar instalación:

```bash
java -version
javac -version
```

---

## Instalación y ejecución

### 1. Clonar el repositorio

```bash
https://github.com/QuelaliUcatec/estructura-datos.git
cd reproductor-musica
```

### 2. Compilar

Desde la raíz del proyecto:

```bash
javac -d out src/reproductor/*.java
```

Esto genera los `.class` compilados dentro de la carpeta `out/`.

### 3. Ejecutar

```bash
java -cp out reproductor.Reproductor
```

### Alternativa sin paquetes (más simple)

Si se prefiere sin estructura de paquetes, colocar los tres archivos en una sola carpeta y eliminar la línea `package reproductor;` de cada uno:

```bash
# Compilar
javac *.java

# Ejecutar
java Reproductor
```

---

## Salida esperada en consola

```
╔══════════════════════════════╗
║   🎧 REPRODUCTOR DE MÚSICA   ║
╚══════════════════════════════╝

── Cargando canciones ──
✅ Agregada: "Bohemian Rhapsody" de Queen
✅ Agregada: "Hotel California" de Eagles
✅ Agregada: "Stairway to Heaven" de Led Zeppelin
✅ Agregada: "Imagine" de John Lennon
✅ Agregada: "Smells Like Teen Spirit" de Nirvana

📋 Lista de reproducción (5 canciones):
──────────────────────────────────────────────────
  1. Bohemian Rhapsody - Queen          [5:54] ◄ REPRODUCIENDO
  2. Hotel California - Eagles          [6:31]
  3. Stairway to Heaven - Led Zeppelin  [8:02]
  4. Imagine - John Lennon              [3:07]
  5. Smells Like Teen Spirit - Nirvana  [5:01]
──────────────────────────────────────────────────
  🔁 (La lista vuelve al inicio automáticamente)

── Iniciando reproducción ──
🎵 Reproduciendo ahora:
   Título  : Bohemian Rhapsody
   Artista : Queen
   Duración: 5:54

── Presionando SIGUIENTE 3 veces ──
🎵 Hotel California - Eagles
🎵 Stairway to Heaven - Led Zeppelin
🎵 Imagine - John Lennon

── Presionando ANTERIOR ──
🎵 Stairway to Heaven - Led Zeppelin

── Probando circularidad (desde última canción) ──
🎵 Smells Like Teen Spirit - Nirvana
🎵 Bohemian Rhapsody - Queen   ← volvió al inicio

── Eliminando 'Imagine' ──
🗑️  Eliminada: "Imagine"
```

---

## Descripción de cada clase

### `Nodo.java`
Representa una canción individual. Contiene los datos (`titulo`, `artista`, `duracionSegundos`) y los dos punteros (`siguiente`, `anterior`) que conectan cada canción con sus vecinas en la lista.

### `ListaReproduccion.java`
Implementa la lista circular doble. Expone los métodos:

| Método | Descripción |
|---|---|
| `agregarCancion(titulo, artista, duracion)` | Inserta una canción al final y cierra el círculo |
| `eliminarCancion(titulo)` | Busca y elimina una canción reconectando los vecinos |
| `siguiente()` | Avanza al nodo `siguiente` del actual |
| `anterior()` | Retrocede al nodo `anterior` del actual |
| `reproducirActual()` | Muestra los datos de la canción actual |
| `mostrarLista()` | Recorre toda la lista e imprime cada canción |

### `Reproductor.java`
Clase principal (`main`). Crea una lista, carga canciones de ejemplo y demuestra todas las operaciones: agregar, navegar, probar la circularidad y eliminar.

---

## Casos de uso reales de listas circulares dobles

- **Reproductores de música** — la lista vuelve al inicio al terminar
- **Planificador de procesos (round-robin)** — los sistemas operativos rotan entre procesos en ciclo
- **Turnos en videojuegos** — cada jugador cede el turno al siguiente en ciclo
- **Buffers circulares** — almacenamiento temporal de datos en streaming de audio/video
- **Historial de navegación** — avanzar y retroceder entre páginas visitadas
