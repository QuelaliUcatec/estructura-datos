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
    N2 --> NULL[/NULL/]
    struct Nodo {
    int dato;
    struct Nodo* siguiente;
};