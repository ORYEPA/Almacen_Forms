# Gestión de Inventarios y Reportes  

Este es un programa desarrollado en **C# utilizando Windows Forms**, diseñado para conectar con una base de datos y ofrecer funcionalidades clave como la generación de reportes, consulta de stock de artículos, y visualización de marcas y categorías.  

## Características  
- **Gestión de Stock:** Consulta en tiempo real las existencias de cada artículo.  
- **Clasificación Avanzada:** Visualiza los artículos organizados por marcas y categorías.  
- **Generación de Reportes:** Crea reportes personalizados y exportables.  
- **Interfaz Intuitiva:** Basado en Windows Forms, con controles como DataGridView para una experiencia amigable.  

## Tecnologías Utilizadas  
- **Lenguaje:** C#  
- **Framework:** .NET Framework  
- **Base de Datos:** SQL Server  
- **Librerías Adicionales:**  
  - ADO.NET para la interacción con la base de datos.  
  - [Opcional] Crystal Reports o Report Viewer para generación de reportes.  

## Estructura de la Base de Datos  
El programa utiliza una base de datos bien estructurada con las siguientes tablas principales:  
- **Artículos:** Contiene información básica de los productos.  
- **Stock:** Registra las cantidades disponibles.  
- **Marcas:** Almacena las diferentes marcas asociadas a los artículos.  
- **Categorías:** Clasifica los artículos por tipo o categoría.  

## Instalación  
1. **Clonar el Repositorio:**  
   ```bash  
   git clone https://github.com/tuusuario/gestion-inventarios.git  
   cd gestion-inventarios  
   ```  
2. **Configurar la Base de Datos:**  
   - Importa el script SQL incluido en el proyecto para crear la estructura de la base de datos.  
   - Configura la conexión a la base de datos en el archivo `App.config`:  
     ```xml  
     <connectionStrings>  
         <add name="DatabaseConnection" connectionString="Server=TU_SERVIDOR;Database=TU_BASE_DATOS;User Id=USUARIO;Password=CONTRASEÑA;" />  
     </connectionStrings>  
     ```  

3. **Compilar el Proyecto:**  
   Abre el archivo `.sln` en Visual Studio y compila la solución.  

4. **Ejecutar la Aplicación:**  
   Inicia el programa desde Visual Studio o ejecuta el archivo `.exe` generado en la carpeta `bin`.  

## Uso  
- **Consultas de Stock:** Filtra artículos por marca o categoría y revisa las existencias actuales.  
- **Generación de Reportes:** Accede a la sección de reportes, selecciona los filtros deseados y genera un informe en formato PDF o Excel.  

