# ESTRUCTURA DE DATOS - LISTAS
# 🔗 Práctica 01: Listas Enlazadas Simples
**Rama:** `fsaavedra/practica01/002-lista-simple`
**Autor:** Fernando Saavedra

## 📝 Introducción
Una **Lista Enlazada Simple** es una estructura de datos lineal donde los elementos, llamados nodos, se conectan a través de punteros. A diferencia de los arreglos, las listas no requieren memoria contigua, lo que permite una gestión dinámica del espacio.

## ❓ ¿Para qué sirven?
Son esenciales en sistemas donde el volumen de datos varía constantemente. Permiten insertar y eliminar elementos de forma eficiente sin necesidad de mover el resto de los datos en memoria.

## 📊 Representación Visual del Nodo

```mermaid
graph LR
    subgraph Nodo
    D[Dato] --> P[Puntero Siguiente]
    end
    P --> N2[Siguiente Nodo...]
    N2 --> NULL[/NULL/]​```

​```c
struct Nodo {
    int dato;
    struct Nodo* siguiente;
};
​```

## 🛠️ Operaciones a Implementar
1. **Insertar al Inicio:** Crea un nuevo nodo y lo pone a la cabeza de la lista.
2. **Insertar al Final:** Recorre la lista hasta el último elemento para enlazar el nuevo.
3. **Mostrar Lista:** Recorrido secuencial para imprimir los datos.

## 💡 Conclusión Personal
El manejo de punteros en listas simples es la base para estructuras más complejas como pilas y colas dinámicas. La clave está en no perder la referencia de la 'Cabeza' de la lista.
