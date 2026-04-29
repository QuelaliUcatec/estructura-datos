# Nomenclatura

1. Nombre de la rama

```
gquelali/practica01/001-lista-simple
```

1. Diagrama de la operación paso a paso (recomendado)

```mermaid
flowchart TD
    A[Inicio] --> B{¿Lista vacía?}
    B -- Sí --> C[Crea nuevo nodo<br>head = newNode<br>newNode.next = null]
    B -- No --> D[Recorrer hasta el último nodo<br>temp = head]
    D --> E{Mientras temp.next != null}
    E --> F[temp = temp.next]
    F --> E
    E -- No más --> G[Enlazar: temp.next = newNode]
    G --> H[newNode.next = null]
    C --> I[Fin]
    H --> I[Fin]

    style A fill:#e3f2fd
    style I fill:#e8f5e9
```

2. Representación visual de la lista antes y después

```mermaid
flowchart LR
    subgraph Antes
        direction LR
        N1["Nodo 1<br>(data=10)"] --> N2["Nodo 2<br>(data=20)"] --> N3["Nodo 3<br>(data=30)"] --> NULL1["null"]
    end

    Ins["Insertar 40 al final"] 

    subgraph Después
        direction LR
        M1["Nodo 1<br>(data=10)"] --> M2["Nodo 2<br>(data=20)"] --> M3["Nodo 3<br>(data=30)"] --> M4["Nodo 4<br>(data=40)"] --> NULL2["null"]
    end

    NULL1 -.->|antes| Ins
    Ins -.->|después| NULL2
```

3. Versión más detallada con nodos individuales (estilo clásico)

```mermaid
flowchart LR
    Head["head"] --> Node1["10 | next"] 
    Node1 --> Node2["20 | next"]
    Node2 --> Node3["30 | next"]
    Node3 --> Null["null"]

    New["Nuevo nodo: 40 | null"]

    style Head fill:#fff3e0
    style New fill:#e8f5e9, stroke:#2e7d32
```
