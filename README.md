# Sistema de Gestión para el Hospital de Apoyo de Coracora

Este proyecto es un sistema de gestión web desarrollado en ASP.NET Core MVC para el Hospital de Apoyo de Coracora. La plataforma busca modernizar y optimizar los procesos internos, facilitando la administración de pacientes, doctores, citas médicas y el inventario de productos farmacéuticos.

## ✨ Características Principales

El sistema cuenta con las siguientes funcionalidades:

*   **Gestión de Pacientes:** Registro de nuevos pacientes, listado, modificación de datos y vista detallada del historial.
*   **Gestión de Doctores:** Administración del personal médico, incluyendo registro y listado.
*   **Agendamiento de Citas:** Permite a los pacientes solicitar citas médicas con especialistas disponibles.
*   **Control de Inventario:** Gestión de productos farmacéuticos y otros suministros, incluyendo registro y listado de stock.
*   **Registro FUA:** Creación y almacenamiento del Formato Único de Atención para cada consulta.
*   **Autenticación:** Sistema de inicio de sesión para pacientes y personal administrativo.

## 🛠️ Tecnologías Utilizadas

*   **Backend:** C# con ASP.NET Core MVC
*   **Frontend:** HTML, CSS, JavaScript
*   **Base de Datos:** (Por definir, ej. SQL Server con Entity Framework Core)
*   **Entorno de Desarrollo:** Visual Studio

## 🚀 Cómo Empezar

Para ejecutar este proyecto en tu entorno local, sigue estos pasos:

1.  **Clonar el repositorio:**
    ```bash
    git clone https://github.com/AlejandroMY190106/TF-DBP-HospitalDeApoyoDeCoraCora.git
    ```

2.  **Abrir en Visual Studio:**
    *   Abre el archivo de solución (`.sln`) con Visual Studio.

3.  **Configurar la Base de Datos:**
    *   Asegúrate de tener un servidor de base de datos (como SQL Server) en ejecución.
    *   Modifica la cadena de conexión (`ConnectionString`) en el archivo `appsettings.json` para que apunte a tu base de datos.

4.  **Aplicar Migraciones (si usas Entity Framework Core):**
    *   Abre la Consola del Administrador de Paquetes en Visual Studio.
    *   Ejecuta el siguiente comando para crear las tablas en la base de datos:
    ```powershell
    Update-Database
    ```

5.  **Ejecutar el proyecto:**
    *   Presiona `F5` o el botón de inicio para compilar y lanzar la aplicación. Tu navegador se abrirá automáticamente en la página de inicio.

## 👤 Autor

*   **Alejandro Mendoza Yauri** - [AlejandroMY190106](https://github.com/AlejandroMY190106)

---
*Este README fue generado con la ayuda de GitHub Copilot.*
