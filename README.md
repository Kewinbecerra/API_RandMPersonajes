### Rick and Morty Personajes - Blazor App

Aplicación web desarrollada en Blazor WebAssembly que consume la API pública de Rick and Morty para listar personajes, mostrar su información y permitir votar con likes o dislikes.

###  Tecnologías utilizadas

- .NET 9.0
- Blazor WebAssembly
- C#
- API REST (https://rickandmortyapi.com)
- Bootstrap
---
### como ejecutar la App
paso 1: Como primer paso en tener en funcionamiento la API (Api_RandMpersonajesback)
paso 2: Abrir inciar la aplicación de blazor.
listo esos serians los pasos para ejecutar la APP
### como se consumio la API
La aplicación consume datos de la API pública [https://rickandmortyapi.com](https://rickandmortyapi.com) desde un controlador intermedio en el backend (ASP.NET Core).
---
### Flujo de consumo
- Desde el front (webAssembly de Blazor) se hace un petición http al backend (controlador)
- el backend (Api ASP.NET CORE) actua como proxy y hace la llamada a la API publica.
- La respuestas en formato jason es deserualizada a un Modelo ("personajes.cs") y enviada al front
- en blazor se renderiza la información que llegan en cartas con su información.
###  Estructura del Código

El proyecto está dividido en dos partes principales:

---

###  1. Modelos (Biblioteca de Clases)

En la carpeta de modelos se encuentran las clases que representan los datos traídos desde la API pública de Rick and Morty:

- **`Personaje.cs`**: modelo que representa un personaje individual, con propiedades como `name`, `status`, `species`, `image`, entre otros.

- **`Personajes.cs`**: modelo contenedor que agrupa una lista de personajes (`List<Personaje>`) y metadatos de la API como:
  - Total de personajes (`count`)
  - Número de páginas (`pages`)
  - Enlace a la siguiente (`next`) y anterior (`prev`) página

---

###  2. Controlador (ASP.NET Core API)

En el backend se encuentra el controlador `PersonajesController`, que maneja la solicitud desde el frontend y se comunica con la API externa

### 3. Frontend (Blazor WebAssembly)
En la página Home.razor del proyecto Blazor, se implementan dos métodos principales:

OnInitializedAsync(): se ejecuta al cargar la página e invoca a GetPersonajes() para obtener los datos.

GetPersonajes(): realiza una solicitud HTTP al backend (/Api/Personajes/Personajes), obtiene el listado de personajes y lo guarda en una variable del tipo Personajes.

Luego, se utiliza un @foreach para recorrer los personajes y mostrarlos en tarjetas visuales, junto con botones de Like y Dislike que permiten votar a cada personaje. El puntaje es dinámico (no persistente).

### Funcionalidad adiccionales
-imagenes de like y dislike
-Puntaje visual de likes y dislikes dinamico
-Guardado de contador de likes,dislikes y puntaje con localstorage
---
### Decisiones tecnicas
¿Por qué utilicé ASP.NET Core?
Elegí ASP.NET Core para construir el controlador y conector hacia la API pública porque es multiplataforma, tiene buena adaptabilidad a diferentes sistemas operativos y es muy eficiente para crear APIs REST. Además, quería usar Blazor como frontend, y ambos se integran perfectamente.

¿Por qué utilicé una biblioteca de clases para los modelos?
Usé una biblioteca de clases (Class Library) para definir los modelos y compartirlos entre el proyecto del backend y el frontend. Esta decisión permite tener una única definición de datos que sirve como "puente" entre ambos, evitando duplicación y facilitando el mantenimiento.

¿Por qué utilicé Blazor WebAssembly?
Elegí Blazor WebAssembly para el frontend porque permite crear aplicaciones web interactivas usando solo C#, sin depender de JavaScript. Me pareció ideal por su dinamismo, capacidad responsiva y por mi afinidad con el lenguaje C#.
