# Guia Paso a Paso - Flujo de Trabajo Git en el Proyecto

## 1. Ser Nominado Colaborador

Cuando el propietario del repositorio te agrega como colaborador:

1. **Recibe y acepta la invitacion** por correo o desde GitHub.
2. **Clona el repositorio** (si es la primera vez):
   ```bash
   git clone https://github.com/Usuario/estructura-datos.git
   cd estructura-datos
   ```
3. **Configura tu identidad** (una sola vez por maquina):
   ```bash
   git config user.name "Tu Nombre"
   git config user.email "tu@email.com"
   ```

---

## 2. Crear tu Rama de Trabajo y Subir Cambios

Nunca trabajes directamente sobre `main`. Crea una rama por cada practica o funcionalidad.

```bash
# Asegurate de estar actualizado
git pull origin main

# Crea y cambia a tu nueva rama
git checkout -b tuusuario/practicaXX/XXX-NombreEstructura

# Ejemplo real:
git checkout -b rheredia/practica01/005-SkipList
```

### Estructura recomendada para nombres de rama:
`usuario/practicaNN/NNN-NombreTema`

- `usuario`: tu identificador (ej: `rheredia`)
- `practicaNN`: numero de practica (ej: `practica01`)
- `NNN-NombreTema`: tema con numero de tema (ej: `005-SkipList`)

---

## 3. Hacer Commits y Push

Despues de editar o crear archivos:

```bash
# Ver el estado de los cambios
git status

# Agregar archivos nuevos o modificados
git add .
# o archivos especificos:
git add README.md SkipList.java

# Hacer commit con mensaje descriptivo
git commit -m "Implementa SkipList con sistema de hospital"

# Subir tu rama al remoto por primera vez
git push -u origin nombre-de-tu-rama

# Ejemplo:
git push -u origin rheredia/practica01/005-SkipList
```

### Para subir cambios posteriores:
```bash
git add .
git commit -m "Corrige metodo insert y agrega documentacion"
git push
```

---

## 4. Ser Asignado como Revisor Cero

Cuando te nombran **revisor cero** de otra rama, debes revisar el codigo de un companero.

### Pasos para revisar:

```bash
# Actualiza las ramas remotas
git fetch origin

# Cambia a la rama que debes revisar
git checkout rama-del-companero

# O crea una copia local de seguimiento:
git checkout -b revision-companero origin/rama-del-companero
```

### Revisar en GitHub (Pull Request):
1. Ve a la seccion **Pull Requests** del repositorio.
2. Abre la PR de tu companero.
3. Revisa los archivos cambiados en la pestana **Files changed**.
4. Deja comentarios linea por linea si encuentras errores.
5. Al finalizar, selecciona:
   - **Request changes** si hay correcciones por hacer.
   - **Approve** si todo esta correcto.

---

## 5. Asignar a tu Revisor Cero

Cuando tu rama esta lista para revision, necesitas que alguien te revise.

### Opcion A: Por GitHub (recomendado)
1. Ve a tu Pull Request.
2. En la columna derecha, haz clic en **Reviewers**.
3. Selecciona a tu companero asignado como revisor cero.
4. Agrega una descripcion clara de que hiciste para facilitar la revision.

### Opcion B: Por comando (notificar)
```bash
# Asegurate de que tu rama este actualizada y limpia
git status
git push
```
Luego notifica por el canal acordado (WhatsApp, Discord, etc.) con el enlace a tu PR.

---

## 6. Proceso de Revision Cruzada

Este es el ciclo tipico cuando ambos se revisan mutuamente:

### Escenario:
- **Tu** eres revisor cero de **Juan**.
- **Juan** es tu revisor cero.

### Flujo:

```
1. Juan sube su rama y te pide revision
   -> Tu revisas, dejas comentarios y pides cambios (Request changes)

2. Juan corrige y sube los cambios
   -> Tu revisas de nuevo y apruebas (Approve)

3. Tu subes tu rama y le pides revision a Juan
   -> Juan revisa, deja comentarios y pide cambios

4. Tu corriges y subes los cambios
   -> Juan revisa de nuevo y aprueba
```

### Comandos para revisar y volver a subir:
```bash
# Edita los archivos segun las revisiones indicadas

# Ver que cambiaste
git diff

# Agregar, commitear y subir
git add .
git commit -m "Aplica revisiones: arregla nombre de variable y agrega validacion"
git push
```

**Nota:** Cada vez que subas cambios despues de una revision, los revisores reciben notificacion automatica en GitHub.

---

## 7. Merge Final

Cuando **ambas partes** han aprobado las PRs mutuamente, se procede a integrar (`merge`) a `main`.

### Requisitos antes de mergear:
- [ ] Tu PR tiene al menos 1 aprobacion (de tu revisor cero).
- [ ] No hay conflictos con la rama `main`.
- [ ] Los checks automatizados pasan (si los hay).

### Como hacer el merge:

**Opcion A: Por GitHub (mas facil)**
1. En tu Pull Request, aparecera el boton verde **Merge pull request**.
2. Selecciona el tipo de merge:
   - **Create a merge commit**: conserva todo el historial.
   - **Squash and merge**: combina todos tus commits en uno solo (recomendado para practicas).
3. Haz clic en **Confirm merge**.
4. Borra la rama remota si te lo sugiere GitHub.

**Opcion B: Por linea de comandos**
```bash
# Cambia a main
git checkout main

# Trae los ultimos cambios
git pull origin main

# Mergea tu rama
git merge rheredia/practica01/005-SkipList

# Sube el merge
git push origin main

# (Opcional) Borra tu rama local
git branch -d rheredia/practica01/005-SkipList

# (Opcional) Borra tu rama remota
git push origin --delete rheredia/practica01/005-SkipList
```

---

## Resumen Grafico del Flujo

```
+----------------+     +----------------+     +----------------+
|  1. Colaborador | --> | 2. Crear Rama  | --> | 3. Commit/Push |
|   acepta invit. |     |    y trabajar   |     |   al remoto    |
+----------------+     +----------------+     +----------------+
                                                        |
+----------------+     +----------------+              v
| 6. Revisar     | <-- | 5. Asignar      |     +----------------+
|    y aprobar   |     |   revisor       | <-- | 4. Abrir Pull  |
|    mutuamente  |     |   cero          |     |    Request     |
+----------------+     +----------------+     +----------------+
       |
       v
+----------------+     +----------------+
| 7. Merge a     | --> | 8. Borrar rama |
|    main        |     |    (opcional)  |
+----------------+     +----------------+
```

---

## Comandos Rapidos de Referencia

| Accion | Comando |
|--------|---------|
| Ver estado | `git status` |
| Ver ramas | `git branch -a` |
| Cambiar de rama | `git checkout nombre-rama` |
| Crear rama nueva | `git checkout -b nombre-rama` |
| Agregar cambios | `git add .` |
| Guardar cambios | `git commit -m "mensaje"` |
| Subir rama nueva | `git push -u origin nombre-rama` |
| Subir cambios | `git push` |
| Traer cambios | `git pull` |
| Ver historial | `git log --oneline` |
| Renombrar rama | `git branch -m nombre-nuevo` |
| Borrar rama remota | `git push origin --delete nombre-rama` |
| Borrar rama local | `git branch -d nombre-rama` |

---

## Tips Importantes

1. **Siempre haz `git pull origin main` antes de crear una nueva rama** para partir desde la version mas actual.
2. **No trabajes en `main` directamente.** Eso evita conflictos y mantiene el historial ordenado.
3. **Escribe mensajes de commit claros.** Describe que cambiaste y por que.
4. **Revisa tu codigo antes de pedir revision.** Asegurate de que compila y funciona.
5. **Comunicate con tu revisor.** Si no entiendes una revision, pregunta en los comentarios de la PR.
6. **Mantén tus PRs pequenas.** Es mas facil revisar 200 lineas que 2000.
