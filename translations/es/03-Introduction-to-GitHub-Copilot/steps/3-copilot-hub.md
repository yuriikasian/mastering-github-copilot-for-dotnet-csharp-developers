## Paso 3: Ver la pestaña de GitHub Copilot con múltiples sugerencias

_¡Buen trabajo! Acabas de usar sugerencias de código generadas por IA dentro de un archivo C# utilizando GitHub Copilot :sparkles:_

Ten en cuenta que, a medida que sigas utilizando Copilot, puede que no desees algunas de las sugerencias que ofrece. GitHub Copilot te mostrará múltiples sugerencias en una nueva pestaña.

### ⌨️ Actividad: Agregar otro método en C# y ver todas las sugerencias

1. Desde el codespace en el Explorador de Soluciones, haz clic derecho sobre el proyecto y crea un nuevo archivo.

> Nota: Si cerraste el Codespace anteriormente, vuelve a abrirlo o crea uno nuevo.

2. Selecciona **Class** y nombra el archivo `Members.cs`.
3. En el archivo `Members.cs`, escribe la siguiente función dentro de la clase `Member`.  
   ```
   public strin
   ```
4. Deja de escribir y observa la sugerencia de Copilot pasando el cursor sobre el texto rojo con subrayado ondulado, selecciona `...`
5. Click `Open Completions Panel`. 

   > **Note**
   > If you don't see the copilot code block suggestion or the red squiggly and the three dots `...`, you can type `control + enter` to bring up the GitHub Copilot completions panel.

6. Copilot will synthesize around 10 different code suggestions or press CTRL+Enter. You should see something like this:
   ![VS Code showing pop up with Completions Panel](../../../../03-Introduction-to-GitHub-Copilot/steps/img/3-copilot-hub-0.png)
7. Find a solution you like and click `Accept Solution`.
8. Your ``. El archivo `Member.cs` se actualizará con tu solución.

### ⌨️ Actividad: Subir código a tu repositorio desde el codespace

Usemos GitHub Copilot para resumir nuestros cambios y luego realizar el commit del código.

1. Abre la pestaña **Source Control**.  
2. Haz clic en el botón ✨ en el campo de **Message** para que Copilot genere tu mensaje.

![Pestaña de Commit abierta para generar mensaje con Copilot](../../../../03-Introduction-to-GitHub-Copilot/steps/img/2-skills-commit.png)

3. Haz clic en el botón **Commit**.

Ve a [Parte 4 del Ejercicio](./4-copilot-comment.md).

**Descargo de responsabilidad**:  
Este documento ha sido traducido utilizando servicios de traducción automática basados en inteligencia artificial. Si bien nos esforzamos por garantizar la precisión, tenga en cuenta que las traducciones automatizadas pueden contener errores o imprecisiones. El documento original en su idioma nativo debe considerarse la fuente autorizada. Para información crítica, se recomienda una traducción profesional realizada por humanos. No nos hacemos responsables de ningún malentendido o interpretación errónea que surja del uso de esta traducción.