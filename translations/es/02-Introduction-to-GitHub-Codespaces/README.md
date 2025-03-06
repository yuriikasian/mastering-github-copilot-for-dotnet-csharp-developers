<header>

# Introducción a GitHub Codespaces

Bienvenido al mundo de GitHub Codespaces, tu puerta de entrada a la programación en la nube. En este módulo, exploraremos el poder transformador de los entornos de desarrollo instantáneos y alojados en la nube, que redefinen cómo abordas la programación. GitHub Codespaces ofrece una experiencia integrada y fluida, proporcionando un contenedor completamente equipado con todos los lenguajes, herramientas y utilidades esenciales que necesitas para programar de manera efectiva.

A lo largo de este viaje de aprendizaje, descubrirás el ciclo de vida completo de Codespaces y obtendrás conocimientos sobre cómo personalizar tu configuración para que se adapte a tus preferencias y necesidades específicas. Para reforzar tu comprensión, el módulo concluye con un ejercicio práctico donde podrás aplicar tus habilidades directamente en el entorno de GitHub Codespaces.

Imagina un entorno de desarrollo completamente configurado, listo para usar y accesible desde cualquier computadora con conexión a internet. GitHub Codespaces te permite abrazar una nueva era de programación colaborativa y flexible. ¡Adentrémonos y desbloqueemos juntos todo el potencial del desarrollo en la nube!

</header>


- **Para quién es esto**: Desarrolladores, Ingenieros DevOps, Gerentes de Ingeniería, Gerentes de Producto.
- **Lo que aprenderás**: Cómo crear un codespace, enviar código desde un codespace, seleccionar una imagen personalizada y personalizar un codespace.
- **Lo que construirás**: Un codespace con archivos devcontainer.json, personalizaciones y configuraciones personalizadas.
- **Requisitos previos**: Necesitarás saber lo siguiente:
  - Uso de Visual Studio Code, [Documentación de Visual Studio Code](https://code.visualstudio.com/docs).
  - Conocimientos sobre el uso de GitHub o haber completado el módulo anterior [Introducción a GitHub](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/01-Introduction-to-GitHub/README.md).
- **Duración**: Este curso se puede completar en menos de una hora.

Al final de este módulo, podrás:

1. Describir qué es GitHub Codespaces.
2. Explicar el ciclo de vida de GitHub Codespaces y cómo realizar cada paso.
3. Definir las diferentes personalizaciones que puedes aplicar en GitHub Codespaces.


## Lecturas previas: 

- [Programar con GitHub Codespaces](https://learn.microsoft.com/training/modules/code-with-github-codespaces/)
- ¿Qué es GitHub Codespaces? (Lista de reproducción de videos a continuación)
- [![Qué es Codespaces](https://img.youtube.com/vi/ozuDPmcC1io/0.jpg)](https://www.youtube.com/watch?v=ozuDPmcC1io&list=PLmsFUfdnGr3wTl-NCblzcrEv2lFSX975-)



### Cómo iniciar este curso

<!-- Para iniciar el curso, ejecuta en JavaScript:
'https://github.com/new?' + new URLSearchParams({
  template_owner: 'skills',
  template_name: 'code-with-codespaces',
  owner: '@me',
  name: 'skills-code-with-codespaces',
  description: 'Mi repositorio clonado',
  visibility: 'public',
}).toString()
-->

[![iniciar-curso](https://user-images.githubusercontent.com/1221423/235727646-4a590299-ffe5-480d-8cd5-8194ea184546.svg)](https://github.com/new?template_owner=skills&template_name=code-with-codespaces&owner=%40me&name=skills-code-with-codespaces&description=Mi+repositorio+clonado&visibility=public)

1. Haz clic derecho en **Iniciar curso** y abre el enlace en una nueva pestaña.
2. En la nueva pestaña, la mayoría de los campos se completarán automáticamente.
   - Para propietario, elige tu cuenta personal o una organización para alojar el repositorio.
   - Recomendamos crear un repositorio público, ya que los repositorios privados [utilizarán minutos de Actions](https://docs.github.com/billing/managing-billing-for-github-actions/about-billing-for-github-actions).
   - Desplázate hacia abajo y haz clic en el botón **Crear repositorio** al final del formulario.
3. Una vez que tu nuevo repositorio esté creado, espera unos 20 segundos y luego actualiza la página. Sigue las instrucciones paso a paso en el README del nuevo repositorio.

<footer>

<!--
  <<< Notas del autor: Footer >>>
  Agrega un enlace para obtener soporte, página de estado de GitHub, código de conducta, enlace de licencia.
-->

---

Obtén ayuda: [Publica en nuestro foro de discusión](https://github.com/orgs/skills/discussions/categories/introduction-to-github) • [Revisa la página de estado de GitHub](https://www.githubstatus.com/)

**Descargo de responsabilidad**:  
Este documento ha sido traducido utilizando servicios de traducción automática basados en inteligencia artificial. Si bien nos esforzamos por garantizar la precisión, tenga en cuenta que las traducciones automatizadas pueden contener errores o imprecisiones. El documento original en su idioma nativo debe considerarse la fuente autorizada. Para información crítica, se recomienda una traducción profesional realizada por humanos. No nos hacemos responsables de malentendidos o interpretaciones erróneas que surjan del uso de esta traducción.