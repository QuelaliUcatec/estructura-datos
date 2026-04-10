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