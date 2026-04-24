# Estructura de Datos: Listas Enlazadas Dobles

* **Nombre:** Moises Gabriel Malpartida Zabaleta
* **Rama:** GaboMz/practica01/002-lista-doble

### LISTAS ENLAZADAS DOBLES

Una lista doblemente enlazada es una estructura donde cada elemento (nodo) está conectado con dos enlaces: uno que apunta al siguiente y otro al anterior, lo que permite moverse en ambas direcciones. Por ejemplo, si tenemos una secuencia como: Messi - Miguelito - Cristiano, el nodo de Miguelito sabe que MESSI está antes que él y CRISTIANO después de el (MIGUELITO), así puedes recorrer la lista hacia adelante (Messi - Miguelito - Cristiano) o hacia atrás (Cristiano - Miguelito - Messi). 

### Descripcion de lo utilizado : 

* Navegación Bidireccional: Cada nodo cuenta con punteros Anterior y Siguiente, permitiendo recorrer la lista en ambos sentidos.
* Inserción en Extremos (O(1)): Las funciones InsertarInicio e InsertarFinal operan de forma instantánea al tener referencias directas a la cabeza y la cola.
* Eliminación en Extremos (O(1)): Las funciones EliminarInicio y EliminarFinal permiten dar de baja nodos de forma eficiente sin recorrer toda la estructura.
* Recursividad Aplicada: Se utiliza recursividad pura para la búsqueda de elementos (BuscarRecursivo) y para mostrar los datos en pantalla (MostrarAdelanteRec y MostrarAtrasRec).


## Interpretación
VACIO ó NULL = Ningun nodo conectado 
MESSI es el inicio (no tiene anterior - NULL).
CRISTIANO es el final (no tiene siguiente - NULL).
MIGUELITO está en medio y conecta con ambos lados.

### EJECUCION 

* Para ejecutar el codigo abre la carpeta ´ListasDobles´ y el archivo .sln ó  sigue los siguientes pasos: 
Abre tu terminal (PowerShell).

* 1. Crea un proyecto de consola vacío escribiendo este comando y presionando Enter:
Bash
dotnet new console -n MiListaDoble

* 2. Entra a la nueva carpeta que se acaba de crear:
Bash
cd MiListaDoble

**Ve a esa carpeta en tu explorador de archivos de Windows, borra el archivo Program.cs que se generó por defecto y pega ahí tu archivo ListaDoble.cs.**

* 3. Vuelve a la terminal y arranca tu programa con:
Bash
dotnet run
**LA CONSOLA DEBERIA FUNCIONAR COMO EN VISUAL STUDIO**

### **Ejemplo:**
Si tenemos una secuencia como: `Messi` <-> `Miguelito` <-> `Cristiano`
* El nodo de **Miguelito** sabe que **Messi** está antes que él y **Cristiano** está después de él.
* Se puede recorrer la lista hacia adelante (Messi -> Miguelito -> Cristiano) o hacia atrás (Cristiano -> Miguelito -> Messi). 

### Representación en Memoria
```text
       [CABEZA]                                                 [COLA]
       -----------------      +---------------+      -----------------
NULL <-| Anterior: NULL|<-----| Anterior: <---|<-----| Anterior: <---|
       | Dato: MESSI   |      | Dato: MIGUELITO|     | Dato: CRISTIANO|
       | Siguiente: -> |----->| Siguiente: -> |----->| Sig: NULL     |
       +---------------+      +---------------+      +---------------+

* Del mismo modo podemos agregar valores de lista al inicio, al final ó eliminarlos respectivamente