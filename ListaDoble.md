# Estructura de Datos: Listas Enlazadas Dobles

* **Nombre:** Moises Gabriel Malpartida Zabaleta
* **Rama:** GaboMz/practica01/002-lista-doble

### LISTAS ENLAZADAS DOBLES

Una lista doblemente enlazada es una estructura donde cada elemento (nodo) está conectado con dos enlaces: uno que apunta al siguiente y otro al anterior, lo que permite moverse en ambas direcciones. Por ejemplo, si tenemos una secuencia como: Messi - Miguelito - Cristiano, el nodo de Miguelito sabe que MESSI está antes que él y CRISTIANO después de el (MIGUELITO), así puedes recorrer la lista hacia adelante (Messi - Miguelito - Cristiano) o hacia atrás (Cristiano - Miguelito - Messi). 

### Representación Conceptual

Cada elemento (Nodo) conoce tanto su origen como su destino, la estructura se visualiza asi:

       [CABEZA]                                                 [COLA]
       +---------------+      +---------------+      +---------------+
NULL <-| Anterior: NULL|<-----| Anterior: <---|<-----| Anterior: <---|
       | Dato:MESSI    |      | Dato:MIGUELITO|      | Dato:CRISTIANO|
       | Siguiente: -> |----->| Siguiente: -> |----->| Sig: NULL     |
       +---------------+      +---------------+      +---------------+

## Interpretación
NULL = Ningun nodo conectado 
MESSI es el inicio (no tiene anterior - NULL).
CRISTIANO es el final (no tiene siguiente - NULL).
MIGUELITO está en medio y conecta con ambos lados.
