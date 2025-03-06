## Paso 2: ¡Ver sugerencias de código de AI en un archivo C#!

_¡Buen trabajo! :tada: Creaste un Codespace utilizando un archivo devcontainer que instaló Copilot._

GitHub Copilot ofrece sugerencias para numerosos lenguajes y una amplia variedad de frameworks, pero funciona especialmente bien con Python, JavaScript, TypeScript, Ruby, Go, C# y C++. Los siguientes ejemplos están en C#, pero otros lenguajes funcionarán de manera similar.

Probemos esto utilizando C# con Copilot.

> **Nota**:  
> Si cerraste el Codespace anterior, por favor vuelve a abrirlo o crea uno nuevo.

### ⌨️ Actividad: Agregar un archivo C# y comenzar a escribir código

> **Nota**:  
> Asegúrate de abrir el **Explorador de Soluciones** para ver una vista organizada que te permita agregar nuevos proyectos y ejecutarlos fácilmente.

1. Crea un nuevo proyecto .NET usando el comando `.NET: New Project...` y seleccionando `Console App`.
1. Selecciona la carpeta **code** y nombra el proyecto **Skills**.
1. Abre `Program.cs`.
1. Verifica que tu nuevo archivo se vea así:  
   ![VS code con un nuevo Program.cs](../../../../03-Introduction-to-GitHub-Copilot/steps/img/2-skills-dotnet-0.png)

1. En el archivo `Program.cs`, elimina cualquier código y escribe el siguiente encabezado de función.

   ```csharp
   void CalculateNumbers(int var1, int var2)
   {
   ```

   GitHub Copilot sugerirá automáticamente el cuerpo completo de la función en texto gris. A continuación, se muestra un ejemplo de lo que probablemente verás, aunque la sugerencia exacta puede variar.  
   ![VS Code con sugerencias de autocompletado](../../../../03-Introduction-to-GitHub-Copilot/steps/img/2-skills-dotnet-1.png)

5. Presiona `Tab` para aceptar la sugerencia.

### ⌨️ Actividad: Subir el código a tu repositorio desde el Codespace

Utilicemos GitHub Copilot para resumir nuestros cambios y luego confirmar el código.

1. Abre la pestaña **Control de Código Fuente**.  
2. Haz clic en el botón ✨ en el campo **Message** para que Copilot genere tu mensaje.

![Pestaña de Commit abierta para generar un mensaje con Copilot](../../../../03-Introduction-to-GitHub-Copilot/steps/img/2-skills-commit.png)

3. Haz clic en el botón **Commit**.

Dirígete a [Parte 3 del Ejercicio](./3-copilot-hub.md)

**Descargo de responsabilidad**:  
Este documento ha sido traducido utilizando servicios de traducción automática basados en inteligencia artificial. Si bien nos esforzamos por lograr precisión, tenga en cuenta que las traducciones automatizadas pueden contener errores o inexactitudes. El documento original en su idioma nativo debe considerarse como la fuente autorizada. Para información crítica, se recomienda una traducción profesional realizada por humanos. No nos hacemos responsables de malentendidos o interpretaciones erróneas que surjan del uso de esta traducción.