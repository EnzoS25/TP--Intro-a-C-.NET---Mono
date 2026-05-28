# TP Especial: Intro a C# / .NET - Mono

Trabajo práctico basado en el proyecto de ejemplo de métodos virtuales visto en clases teóricas.
Compilado y ejecutado en Linux (Ubuntu) con Mono.

---

## Compilación y ejecución

```bash
# Instalación de Mono
sudo apt update
sudo apt install mono-complete

# Compilación
xbuild ExMetodosVirtuales.csproj

# Ejecución
bin/Debug/ExMetodosVirtuales.exe
```

---

## Segunda parte: modificaciones

### A — Figuras en trazo rojo

Se modificó el `Pen` para utilizar `Color.Red` en todas las figuras.

### B — Cada figura en un color distinto

Se asignó un color diferente a cada figura, manteniendo la generalización del código mediante el uso de `Pen` con color por figura.

### C — Colores aleatorios

#### C.1 — Tres colores aleatorios

Se utilizó la clase `Random` junto con `Color.FromArgb()` para generar un color aleatorio por figura en cada ejecución.

#### C.2 — Contraste mínimo sobre fondo blanco

Se implementó un método `GenerarColorConContraste()` que descarta colores demasiado claros usando la fórmula de luminosidad perceptual:

```
luminosidad = 0.299*R + 0.587*G + 0.114*B
```

Si la luminosidad supera 200 (sobre 255), se regenera el color hasta obtener uno visible sobre fondo blanco.


<img width="709" height="377" alt="C_-_Random_1" src="https://github.com/user-attachments/assets/3897bff6-d139-4c10-9325-06425686abfc" />

<img width="720" height="397" alt="C_-_Random_2" src="https://github.com/user-attachments/assets/038b13fc-97a7-4ccc-b80e-136dcb626660" />

---

### D — Tamaños proporcionalmente crecientes

Las figuras se muestran de izquierda a derecha con tamaños crecientes, usando un `tamBase` multiplicado por un factor distinto para cada figura (`x1`, `x2`, `x3`). Esto garantiza proporcionalidad: si se cambia `tamBase`, todas las figuras escalan juntas.

<img width="723" height="397" alt="D_-_Creciente" src="https://github.com/user-attachments/assets/d239a509-bb99-4b73-8d4d-6ae1b0ffd8d0" />


---

### E — Nuevas figuras: triángulos

Se agregaron dos nuevas clases al modelo, ambas heredando de `Figura`.

#### E.1 — Triángulo isósceles

Definido por `base` y `altura` independientes. El vértice superior se calcula como el punto central de la base.

#### E.2 — Triángulo equilátero

Definido por el `lado`. La altura se calcula automáticamente como `lado * √3 / 2`.

<img width="741" height="192" alt="E_-_Triangulos" src="https://github.com/user-attachments/assets/edd83701-5615-4234-b743-3ecfac5051a4" />
