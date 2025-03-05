# Comenzando con GitHub Copilot para Azure

Desbloquea un flujo de trabajo más eficiente y aumenta tu productividad con GitHub Copilot para Azure Preview. Esta guía rápida te llevará a través de todo lo que necesitas saber, desde preparar los requisitos previos hasta instalar la extensión de GitHub Copilot para Azure en Visual Studio Code. Al final, estarás listo para crear tu primer prompt y aprovechar al máximo el potencial de la plataforma Azure.

![GitHub Copilot para Azure](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/intro.gif "GitHub Copilot para Azure")

- **¿Para quién es esto?**: Desarrolladores, personal de operaciones (ITPRO) e ingenieros de inteligencia artificial.
- **Lo que aprenderás**: Los pasos para comenzar con GitHub Copilot para Azure.
- **Lo que construirás**: Configurarás con confianza tu espacio de trabajo habilitado para IA.

## Lecturas previas necesarias:
- [¿Qué es GitHub Copilot para Azure Preview?](https://learn.microsoft.com/azure/developer/github-copilot-azure/introduction)

## 👉 Requisitos previos

Para completar los pasos de este laboratorio, asegúrate de tener:

1. Una cuenta de Azure y acceso a una suscripción de Azure. Para más detalles sobre cómo configurarlas, consulta la [página de precios de cuentas de Azure.](https://azure.microsoft.com/pricing/purchase-options/azure-account)

1. Una cuenta de GitHub. Los pasos para crear una están aquí: [Crear una cuenta en GitHub](https://docs.github.com/en/get-started/start-your-journey/creating-an-account-on-github)

1. Suscripción a GitHub Copilot. Los detalles sobre cómo habilitar GitHub Copilot se encuentran aquí: [Inicio rápido para GitHub Copilot](https://docs.github.com/en/copilot/quickstart)

1. Visual Studio Code. Para más detalles sobre cómo descargarlo e instalarlo, consulta [Configuración de Visual Studio Code.](https://code.visualstudio.com/docs/setup/setup-overview)

1. La extensión de GitHub Copilot y la extensión de GitHub Copilot Chat. Las instrucciones para instalar estas extensiones están aquí: [Configurar GitHub Copilot en VS Code.](https://marketplace.visualstudio.com/items?itemName=GitHub.copilot)

## 💪🏽 Ejercicio

### 🛠 Paso 1: Autenticarte en GitHub e iniciar sesión en GitHub Copilot Chat para habilitar Copilot para Azure Preview

1. Al abrir VS Code, en el lado derecho, haz clic en **"Iniciar sesión con una cuenta de GitHub.com"**.

    1. Visual Studio Code mostrará un mensaje que dice **"La extensión 'GitHub Copilot Chat' quiere iniciar sesión usando GitHub."** Haz clic en **Permitir**.

    1. Necesitarás autorizar Visual Studio Code para continuar con el usuario que inició sesión. Haz clic en el botón **Continuar**.

    1. Completa la autorización haciendo clic en el botón **Authorize Visual-Studio-Code**.

    1. Aparecerá un mensaje emergente que pedirá abrir VS Code. Haz clic en **Abrir**. Serás redirigido a VS Code, donde estarás autenticado en GitHub y tendrás acceso a **GitHub Copilot**.

1. En Visual Studio Code, selecciona el ícono de **Extensiones**.

1. Verifica que tengas instaladas las siguientes extensiones:
    1. **Azure Tools**
    1. **GitHub Copilot**
    1. **GitHub Copilot Chat**
    1. **GitHub Copilot para Azure**
    1. **C# Dev Kit**

1. Si falta alguna, instálala desde el marketplace.

### ✍️ Paso 2: Escribe tu primer prompt

1. Ahora que las extensiones están instaladas, que estás autenticado correctamente y que la extensión funciona correctamente.

1. En la barra de actividades, selecciona el ícono de **Chat** si el panel de **Ask Copilot** está cerrado.

1. En el área de texto de chat en la parte inferior del panel de chat, introduce el siguiente prompt:

```prompt
@azure Do I have any resources currently running?
```
> En la siguiente sección se te pedirá autorizar aplicaciones y servicios varias veces. Esto es por tu seguridad y solo se hará una vez. Estamos autorizando a **GitHub**, **VS Code** y **Azure** para confiar en los prompts con las credenciales proporcionadas.

1. Podrías recibir un mensaje en el panel de GitHub Copilot Chat que diga "necesitas iniciar sesión en tu cuenta de Microsoft para usar GitHub Copilot para Azure (@Azure)".

    1. Si es así, haz clic en el enlace de la línea **"¿Ya tienes una cuenta? Iniciar sesión"**.
    1. Visual Studio Code mostrará un mensaje que dice **"La extensión 'GitHub Copilot para Azure' quiere iniciar sesión usando Microsoft."** Haz clic en **Permitir**.
    1. Inicia sesión utilizando las credenciales de la sesión existente o las credenciales proporcionadas en la pestaña de recursos de las instrucciones del laboratorio. Las mismas credenciales que la suscripción de Azure.
    1. Cierra la pestaña. No el navegador.
    1. Regresa a VS Code. Visual Studio Code mostrará un mensaje que dice **"La extensión 'GitHub Copilot para Azure' quiere acceder a los modelos de lenguaje proporcionados por GitHub Copilot Chat."** Haz clic en **Permitir**.
    1. Visual Studio Code mostrará otro mensaje que dice **"La extensión 'GitHub Copilot para Azure' quiere iniciar sesión usando GitHub."** Haz clic en **Permitir** nuevamente.
        1. Necesitarás autorizar Visual Studio Code para continuar con el usuario que inició sesión. Haz clic en el botón **Continuar**.
        1. Completa la autorización haciendo clic en el botón **Authorize Visual-Studio-Code**.
        1. Aparecerá un mensaje emergente que pedirá abrir VS Code. Haz clic en **Abrir**. Serás redirigido a VS Code, donde estarás autenticado en GitHub y tendrás acceso a **GitHub Copilot**.

1. La extensión Copilot para Azure consultará el gráfico de recursos de Azure, te proporcionará la consulta de recursos y te dará la respuesta. En este punto, debería ser **Actualmente no tienes ningún recurso en ejecución en todas tus suscripciones.**

### Conclusión

¡Felicidades! A través del ejercicio, has configurado VS Code para usar GitHub Copilot para Azure y lo has consultado para que te informe sobre cualquier recurso en ejecución en tu suscripción de Azure.

**Descargo de responsabilidad**:  
Este documento ha sido traducido utilizando servicios de traducción automática basados en inteligencia artificial. Si bien nos esforzamos por lograr precisión, tenga en cuenta que las traducciones automatizadas pueden contener errores o inexactitudes. El documento original en su idioma nativo debe considerarse la fuente autorizada. Para información crítica, se recomienda una traducción profesional realizada por humanos. No nos hacemos responsables por malentendidos o interpretaciones erróneas que surjan del uso de esta traducción.