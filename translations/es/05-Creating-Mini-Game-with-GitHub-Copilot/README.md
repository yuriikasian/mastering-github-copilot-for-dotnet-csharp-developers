- **Para quién es esto**: Desarrolladores, Ingenieros DevOps, Gerentes de desarrollo de software, Testers.
- **Qué aprenderás**: Aprovechar GitHub Copilot para crear código y añadir comentarios a tu trabajo.
- **Qué construirás**: Archivos en C# que tendrán código generado por la IA de Copilot para sugerencias de código y comentarios.
- **Requisitos previos**: GitHub Copilot está disponible de forma gratuita, regístrate en [GitHub Copilot](https://gh.io/copilot).
- **Duración**: Este curso se puede completar en menos de una hora.

Al final de este módulo, habrás adquirido las habilidades para:

- Experimentar GitHub Codespaces como un entorno de desarrollo.
- Desarrollar rutinas de entrada y salida en una aplicación de consola en C#.
- Utilizar GitHub Copilot como asistente.

## Lecturas previas:
- [Introducción a la ingeniería de prompts con GitHub Copilot](https://learn.microsoft.com/training/modules/introduction-prompt-engineering-with-github-copilot/)
- [Proyecto de desafío - Crear un minijuego con GitHub Copilot y C#](https://learn.microsoft.com/training/modules/challenge-project-create-mini-game-with-copilot-dotnet/)

## Requisitos

- Habilitar tu [servicio de GitHub Copilot](https://github.com/github-copilot/signup)

## 💪🏽 Ejercicio

[![Abrir en GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/mastering-github-copilot-for-dotnet-csharp-developers?devcontainer_path=.devcontainer%2Fmini-game%2Fdevcontainer.json)

Ya has aprendido un poco sobre GitHub Codespaces y GitHub Copilot y cómo funcionan. En este ejercicio de desafío, tu objetivo es desarrollar un minijuego en C# utilizando GitHub Copilot.

#### Probando tu GitHub Codespace

1. Abre el **Explorador de Soluciones** y encontrarás un proyecto llamado **MiniGame**.
1. Abre `Program.cs`

1. Ejecuta la aplicación en la opción **Run and Debug** o en la parte superior derecha del archivo Program.cs con el botón de Play. Verifica si el resultado es similar al siguiente mensaje en la consola:

   ```bash
   Hello, World!
   ```
   
### Creando la lógica del juego

Ahora que has verificado que Codespaces funciona con GitHub Copilot, tu siguiente paso es desarrollar la lógica del minijuego en C# con la ayuda de GitHub Copilot según las siguientes especificaciones:

El ganador del juego se determina por tres reglas simples:

- **Piedra** vence a tijeras.
- **Tijeras** vencen a papel.
- **Papel** vence a piedra.

#### Consideraciones para la interacción del juego

La computadora será tu oponente y puede elegir aleatoriamente uno de los elementos (**piedra**, **papel** o **tijeras**). Tu interacción con el juego será a través de la consola (Terminal).

- El jugador puede elegir una de las tres opciones: piedra, papel o tijeras, y debe ser advertido si introduce una opción inválida.
- En cada ronda, el jugador debe ingresar una de las opciones de la lista y se le informará si ganó, perdió o empató con el oponente.
- Al final de cada ronda, el jugador puede elegir si quiere jugar nuevamente.
- Muestra el puntaje del jugador al final del juego.
- El minijuego debe manejar las entradas del usuario, convirtiéndolas a minúsculas e informando al usuario si la opción es inválida.

En tu GitHub Codespaces, sigue las instrucciones dadas para configurar prompts que GitHub Copilot pueda entender y usar para ayudarte a construir el minijuego. Ten en cuenta que GitHub Copilot se basa en comentarios para comprender el contexto y ofrecerte sugerencias útiles mientras trabajas en tu proyecto.

#### Verifica tu trabajo

1. Ejecuta el minijuego en la consola con el comando *dotnet run*.
2. En el prompt, escribe una de las opciones del juego: *piedra*, *papel* o *tijeras*.
3. El minijuego debe informar al jugador si ganó, perdió o empató con el oponente.
4. Elige continuar jugando.
5. En el prompt, escribe *pantalla*.
6. El minijuego debe informar al jugador si la opción ingresada es inválida.
7. Repite los pasos 2 y 4 para jugar algunas rondas y elige no continuar jugando.
8. Verifica si el minijuego se termina y muestra tu puntaje, informándote del número de victorias y rondas.

¡Felicidades por completar este ejercicio de desafío! Has creado un minijuego de consola en C# utilizando GitHub Copilot.

**Descargo de responsabilidad**:  
Este documento ha sido traducido utilizando servicios de traducción automática basados en inteligencia artificial. Si bien nos esforzamos por garantizar la precisión, tenga en cuenta que las traducciones automatizadas pueden contener errores o imprecisiones. El documento original en su idioma nativo debe considerarse como la fuente autorizada. Para información crítica, se recomienda una traducción profesional realizada por humanos. No nos hacemos responsables de malentendidos o interpretaciones erróneas que puedan surgir del uso de esta traducción.