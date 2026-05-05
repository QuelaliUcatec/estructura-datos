# 📚 Estructura de Datos I: Listas Enlazadas Simples
**Práctica #01 - Unidad de Memoria Dinámica**

---

## 👤 Información del Autor
* **Nombre:** Fernando Saavedra
* **Carrera:** Ingeniería en Sistemas
* **Materia:** Estructura de Datos I
* **Repositorio:** `fsaavedra/practica01/002-lista-simple`

---

## 🎯 Objetivo de la Práctica
Documentar e implementar una estructura de datos lineal que permita la gestión eficiente de memoria dinámica mediante el uso de nodos y punteros, superando las limitaciones de tamaño fijo de los arreglos estáticos.

## 🧠 Justificación Técnica: ¿Por qué Listas Simples?
A diferencia de los arreglos (`arrays`), las listas enlazadas:
1.  **No requieren memoria contigua:** Pueden aprovechar fragmentos de memoria dispersos.
2.  **Crecimiento Dinámico:** El tamaño no necesita definirse al principio; la lista crece según la necesidad del programa en tiempo de ejecución.
3.  **Inserción/Eliminación Eficiente:** No es necesario "desplazar" todos los elementos al insertar uno nuevo en medio; solo se reasignan los punteros.

---

## 🛠️ Guía de Compilación y Ejecución

Para trabajar con este proyecto en sistemas Linux (Arch/Garuda) o Windows con el SDK de .NET instalado, siga estos pasos:

### 1. Preparación del Entorno
Asegúrese de estar en la raíz de la carpeta `002-lista-simple`. Si el archivo de proyecto `.csproj` no existe, puede generarlo con:
## bash
----------------------------------------------------------------------
dotnet new console --force
----------------------------------------------------------------------
2. Restauración de Dependencias

Antes de compilar, es una buena práctica asegurar que todas las librerías necesarias estén listas:
## Bash
----------------------------------------------------------------------
dotnet restore
----------------------------------------------------------------------
3. Compilación (Build)

Para compilar el código y verificar que no existan errores de sintaxis o de referencia:
## Bash
-----------------------------------------------------------------------
dotnet build
-----------------------------------------------------------------------
Esto generará los archivos binarios dentro de la carpeta ./bin/Debug/netX.X/.
4. Ejecución

Para compilar (si hubo cambios) y ejecutar el programa de prueba inmediatamente:
## Bash
-------------------------------------------------------------------------
dotnet run
-------------------------------------------------------------------------

---
## 💻 Explicación del Funcionamiento (Lógica del Código)

El funcionamiento del sistema se divide en la gestión de memoria y el recorrido de punteros:
1. Definición de la Unidad (El Nodo)

Cada elemento de la lista es una instancia de Nodo.cs. Técnicamente, no es solo un contenedor de datos, sino un objeto que guarda una referencia de memoria.

    Dato: El valor útil (ej. un int).

    Siguiente: Una variable de tipo Nodo que almacena la dirección del próximo elemento.

2. Gestión de la Lista (ListaSimple.cs)

La lista funciona mediante un "ancla" llamada cabeza. La lógica principal de los métodos es:

    Inserción: * Si la cabeza es nula, el nuevo nodo se asigna directamente allí.

        Si ya hay datos, el programa realiza un recorrido lineal. Se crea un nodo temporal (puntero) que empieza en la cabeza y salta de uno en uno (actual = actual.Siguiente) hasta que encuentra un nodo cuyo Siguiente sea null. Ahí es donde se "enlaza" el nuevo nodo.

    Recorrido/Lectura: * Es un proceso de O(n). El código inicia en la cabeza y utiliza un ciclo while que continúa mientras el nodo actual no sea nulo. En cada paso, extrae el valor del dato y se mueve a la siguiente posición de memoria.

3. Ejecución (Program.cs)

En el punto de entrada, se orquesta el ciclo de vida:

    Se instancia ListaSimple.

    Se puebla la memoria dinámica mediante llamadas sucesivas a Insertar().

    Se invoca el método de impresión para verificar que los enlaces se realizaron correctamente en la memoria RAM.


## 📊 Representación Conceptual
Debido a que cada nodo solo conoce la ubicación del siguiente, la estructura se visualiza de la siguiente manera:

```text
[ CABEZA ]
    |
    v
  +-----------+      +-----------+      +-----------+
  | Dato: 10  |      | Dato: 20  |      | Dato: 30  |
  | Sig: ---->|----->| Sig: ---->|----->| Sig: NULL |
  +-----------+      +-----------+      +-----------+
```
```mermaid
flowchart LR
    subgraph "Lista Enlazada Simple - Memoria Dinámica"
        Head["Cabeza<br/>(Referencia al primer nodo)"] 
        --> Node1["Nodo 1<br/>Dato = 10<br/>Siguiente = Dirección Nodo 2"]
        Node1 --> Node2["Nodo 2<br/>Dato = 20<br/>Siguiente = Dirección Nodo 3"]
        Node2 --> Node3["Nodo 3<br/>Dato = 30<br/>Siguiente = null"]
        Node3 --> Null["null"]
    end

    classDef head fill:#1e40af, stroke:#93c5fd, color:white, stroke-width:3px;
    classDef node fill:#14532d, stroke:#4ade80, color:white, stroke-width:2px;
    classDef nullNode fill:#7f1d1d, stroke:#f87171, color:white;

    class Head head
    class Node1,Node2,Node3 node
    class Null nullNode```