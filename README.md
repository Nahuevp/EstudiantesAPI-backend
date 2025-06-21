# estudiantes-api

Backend de la aplicación Estudiantes App. API RESTful desarrollada con ASP.NET Core y Entity Framework Core. Permite realizar operaciones CRUD sobre un listado de estudiantes y está diseñada para ser consumida por el frontend desarrollado en Angular.

##  Tecnologías utilizadas

- .NET 8
- ASP.NET Core
- Entity Framework Core
- C#
- Swagger / OpenAPI
- SQL Server

##  Objetivo

Proveer una API robusta y escalable para manejar el registro de estudiantes, utilizando buenas prácticas como la arquitectura por capas, validaciones y documentación automática.

##  Funcionalidades

- Listar todos los estudiantes
- Obtener un estudiante por ID
- Crear nuevo estudiante
- Editar estudiante existente
- Eliminar estudiante
- Validaciones en el modelo (atributos como `[Required]`, `[MinLength]`, etc.)
- Documentación interactiva con Swagger

##  Estructura principal

- `/Controllers`: Definen los endpoints de la API y delegan la lógica a los servicios.
- `/Services`: Contienen la lógica de negocio de la aplicación.
- `/Data`: Configuración de la base de datos y clase `DbContext`.
- `/Models`: Clases del dominio como `Estudiante`.
- `/DTOs`: Objetos de transferencia de datos para recibir y enviar información.
- `/Mappings`: Configuración de mapeos entre modelos y DTOs (si aplica).
