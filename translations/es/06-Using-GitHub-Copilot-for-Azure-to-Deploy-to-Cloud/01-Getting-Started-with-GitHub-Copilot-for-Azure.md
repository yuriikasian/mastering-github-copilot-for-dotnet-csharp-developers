# Introducción a GitHub Copilot para Azure

Desbloquea un flujo de trabajo más eficiente y aumenta tu productividad con GitHub Copilot para Azure Preview. Esta guía rápida te llevará paso a paso por todo lo que necesitas saber, desde preparar los requisitos previos hasta instalar la extensión de GitHub Copilot para Azure en Visual Studio Code. Al final, estarás listo para crear tu primer prompt y aprovechar al máximo el potencial de la plataforma Azure.

![GitHub Copilot para Azure](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/intro.gif "GitHub Copilot para Azure")

- **¿Para quién es esto?**: Desarrolladores, personal de Operaciones (ITPRO) e Ingenieros de IA.
- **Lo que aprenderás**: Pasos para configurar y empezar con GitHub Copilot para Azure.
- **Lo que construirás**: Configurarás con confianza tu espacio de trabajo habilitado con IA.

## Lectura previa:

- [¿Qué es GitHub Copilot para Azure Preview?](https://learn.microsoft.com/azure/developer/github-copilot-azure/introduction)

## 👉 Requisitos previos

Para completar los pasos en este laboratorio, asegúrate de tener:

1. Una cuenta de Azure y acceso a una suscripción de Azure. Para más detalles sobre cómo configurarlas, consulta la [página de precios de cuentas de Azure.](https://azure.microsoft.com/pricing/purchase-options/azure-account)

1. Una cuenta de GitHub. Los pasos para crear una se encuentran aquí: [Crear una cuenta en GitHub](https://docs.github.com/en/get-started/start-your-journey/creating-an-account-on-github)

1. Una suscripción a GitHub Copilot. Los detalles sobre cómo habilitar GitHub Copilot están aquí: [Inicio rápido para GitHub Copilot](https://docs.github.com/en/copilot/quickstart)

1. Visual Studio Code. Para más detalles sobre cómo descargarlo e instalarlo, consulta [Configuración de Visual Studio Code.](https://code.visualstudio.com/docs/setup/setup-overview)

1. Las extensiones GitHub Copilot y GitHub Copilot Chat. Las instrucciones para instalar estas extensiones están aquí: [Configurar GitHub Copilot en VS Code.](https://marketplace.visualstudio.com/items?itemName=GitHub.copilot)

## 💪🏽 Ejercicio

### 🛠 Paso 1: Autenticarte en GitHub e iniciar sesión en GitHub Copilot Chat para habilitar Copilot para Azure Preview

1. Al abrir VS Code, en el lado derecho, haz clic en **"Iniciar sesión con una cuenta de GitHub.com"**.

    1. Visual Studio Code mostrará un mensaje que dice **"La extensión 'GitHub Copilot Chat' desea iniciar sesión usando GitHub."** Haz clic en **Permitir**.

    1. Necesitarás autorizar Visual Studio Code para continuar con el usuario que ha iniciado sesión. Haz clic en el botón **Continuar**.

    1. Completa la autorización haciendo clic en el botón **Authorize Visual-Studio-Code**.

    1. Aparecerá un mensaje emergente solicitando abrir VS Code. Haz clic en **Abrir**. Serás redirigido a VS Code, autenticado en GitHub y con acceso a **GitHub Copilot**.

1. En Visual Studio Code, selecciona el ícono de **Extensiones**.

1. Verifica que tienes las siguientes extensiones instaladas:
    1. **Azure Tools**
    1. **GitHub Copilot**
    1. **GitHub Copilot Chat**
    1. **GitHub Copilot para Azure**
    1. **C# Dev Kit**

1. Si falta alguna, instálala desde el marketplace.

### ✍️ Paso 2: Escribe tu primer prompt

1. Ahora que las extensiones están instaladas, que has iniciado sesión correctamente y que la extensión funciona correctamente.

1. En la barra de actividades, selecciona el ícono de **Chat** si el panel **Ask Copilot** está cerrado.

1. En el área de texto del chat en la parte inferior del panel, introduce el siguiente prompt:

```prompt
@azure Do I have any resources currently running?
```
> En la siguiente sección se te pedirá autorizar aplicaciones y servicios varias veces. Esto es por tu seguridad y solo se hará una vez. Estamos autorizando a **GitHub**, **VS Code** y **Azure** para confiar en los prompts con las credenciales proporcionadas.

1. Es posible que recibas un mensaje en el panel de GitHub Copilot Chat que indique "necesitas iniciar sesión en tu cuenta de Microsoft para usar GitHub Copilot para Azure (@Azure)".

    1. Si es así, haz clic en el enlace en la línea **"¿Ya tienes una cuenta? Inicia sesión"**.
    1. Visual Studio Code mostrará un mensaje que dice **"La extensión 'GitHub Copilot para Azure' desea iniciar sesión usando Microsoft."** Haz clic en **Permitir**.
    1. Inicia sesión utilizando las credenciales de la sesión existente o las credenciales proporcionadas en la pestaña de recursos de las instrucciones del laboratorio. Son las mismas credenciales que las de las suscripciones de Azure.
    1. Cierra la pestaña, pero no el navegador.
    1. Regresa a VS Code. Visual Studio Code mostrará un mensaje que dice **"La extensión 'GitHub Copilot para Azure' desea acceder a los modelos de lenguaje proporcionados por GitHub Copilot Chat."** Haz clic en **Permitir**.
    1. Visual Studio Code mostrará otro mensaje que dice **"La extensión 'GitHub Copilot para Azure' desea iniciar sesión usando GitHub."** Haz clic nuevamente en **Permitir**.
        1. Necesitarás autorizar Visual Studio Code para continuar con el usuario que ha iniciado sesión. Haz clic en el botón **Continuar**.
        1. Completa la autorización haciendo clic en el botón **Authorize Visual-Studio-Code**.
        1. Aparecerá un mensaje emergente solicitando abrir VS Code. Haz clic en **Abrir**. Serás redirigido a VS Code, autenticado en GitHub y con acceso a **GitHub Copilot**.

1. La extensión Copilot para Azure consultará el gráfico de recursos de Azure, te proporcionará la consulta de recursos y te dará la respuesta. En este punto debería ser **Actualmente no tienes ningún recurso en ejecución en todas tus suscripciones.**

### Conclusión

¡Felicidades! A través de este ejercicio, has configurado VS Code para usar GitHub Copilot para Azure y lo has consultado para informarte sobre los recursos en ejecución en tu suscripción de Azure.

**Descargo de responsabilidad**:  
Este documento ha sido traducido utilizando servicios de traducción automática basados en inteligencia artificial. Si bien nos esforzamos por lograr precisión, tenga en cuenta que las traducciones automáticas pueden contener errores o imprecisiones. El documento original en su idioma nativo debe considerarse la fuente autorizada. Para información crítica, se recomienda una traducción profesional realizada por humanos. No nos hacemos responsables de malentendidos o interpretaciones erróneas que surjan del uso de esta traducción.