# Obtén respuestas a tus preguntas sobre servicios y recursos de Azure

Si no estás familiarizado con Azure y cómo puedes usarlo para tu aplicación, puedes pedir ayuda a GitHub Copilot for Azure Preview. Usa este laboratorio como una novela de *Elige tu propia aventura*. Explora los diversos ejemplos de indicaciones a continuación y trata de crear tus propias indicaciones basándote en lo que crees que necesitas que la extensión @azure haga por ti.

## Mejores prácticas

El uso de copilotos puede aumentar la productividad de los desarrolladores respondiendo preguntas, ejecutando tareas y generando código. Sin embargo, recuerda estas reglas esenciales:

- Revisa todas las respuestas generadas por IA. Valida su precisión, aplicabilidad y posibles consecuencias (como costos y seguridad) antes de tomar decisiones basadas en esas respuestas.
- Nunca guardes secretos de la aplicación o credenciales en el código fuente.
- Nunca envíes secretos de la aplicación o credenciales en preguntas o en el código al hacer consultas.

Cuando trabajes con cualquier herramienta basada en modelos de lenguaje de gran escala, utiliza buenas técnicas de ingeniería de indicaciones para obtener los mejores resultados. Los siguientes consejos provienen del artículo [Escribe indicaciones efectivas para Microsoft Copilot en Azure](https://learn.microsoft.com/azure/copilot/write-effective-prompts), que ofrece recomendaciones para la ingeniería de indicaciones en el contexto de Azure.

- Sé claro y específico
- Establece expectativas
- Añade contexto sobre tu escenario
- Divide tus solicitudes
- Personaliza tu código
- Usa la terminología de Azure
- Utiliza el ciclo de retroalimentación

## Aprende sobre servicios de Azure usando GitHub Copilot for Azure

En este ejercicio, usaremos GitHub Copilot for Azure Preview para aprender cómo usar Azure para tu aplicación. Comenzaremos con una pregunta o solicitud abierta. Luego, añade detalles como servicios y tecnologías específicos para obtener mejores resultados. Prueba los siguientes ejemplos de indicaciones.

## Aprende sobre arquitectura de sistemas en Azure

1. "@azure ¿Cómo puedo crear una arquitectura altamente disponible en Azure?"
1. "@azure Explica el Marco de Arquitectura Bien Diseñada de Azure."
1. "@azure ¿Qué tipos de soluciones de alojamiento de aplicaciones tiene Azure?"
1. "@azure Ayúdame a orquestar y automatizar mis flujos de trabajo de procesamiento de datos."
1. "@azure ¿Cómo puedo integrar SignalR con Azure Application Gateway y Azure API Management?"
1. "@azure ¿Cuántas unidades recomiendas?"
1. "@azure ¿Cuáles son los beneficios y aplicaciones de usar Terraform?"

## Aprende sobre inteligencia artificial en Azure

8. "@azure Quiero construir una aplicación de IA. ¿Qué servicios puedo usar?"

## Aprende sobre alojamiento de aplicaciones web en Azure

9. "@azure ¿Qué servicio de Azure es mejor para alojar una aplicación web escalable?"
1. "@azure ¿Qué servicio debería usar para crear un sitio web?"
1. "@azure ¿Cómo puedo usar Azure para construir una aplicación web escalable?"
1. "@azure ¿Para qué escenarios son mejores Azure Functions que Web Apps?"

## Aprende sobre contenedores en Azure

- "@azure ¿Qué tipos de aplicaciones en contenedores soporta Azure?"
- "@azure ¿Cuáles son las opciones para gestionar contenedores en Azure?"
- "@azure ¿Cuándo debería usar Azure Kubernetes Service en lugar de Azure Container Apps?"
- "@azure ¿Cuál es la diferencia entre Azure Container Apps y AKS?"
- "@azure ¿Por qué elegiría Azure Container Apps en lugar de AKS?"

### Aprende cómo usar servicios de Azure para tu aplicación

|Servicio o tecnología|Ejemplos de indicaciones para aprender|
|---|---|
|Azure AI Search|<ul><li>"@azure ¿Qué es Azure AI Search y por qué debería usarlo?"</li><li>"@azure ¿Cómo funciona el precio de Azure AI Search?"</li><li>"@azure ¿Cómo se integra Azure AI Search con Azure OpenAI?"</li><li>"@azure ¿Cómo se integra Azure AI Search con Azure Machine Learning?"</li><li>"@azure ¿Cuándo debería usar búsqueda híbrida o búsqueda vectorial frente al clasificador semántico en Azure AI Search?"</li><li>"@azure ¿Es Azure AI Search una base de datos vectorial? ¿Cómo asegura Azure AI Search la precisión y relevancia de los resultados de búsqueda vectorial?"</li><li>"@azure ¿Qué soporte tienen para aplicaciones multicliente de alta escala en Azure AI Search?"</li><li>"@azure ¿Qué es la función de vectorización integrada en Azure AI Search? ¿De qué fuentes de datos puedo extraer datos y usar la vectorización integrada?"</li><li>"@azure ¿Qué es el enriquecimiento de IA en Azure AI Search? ¿Cómo funciona? ¿Cuáles son los beneficios de usarlo?"</li><li>"@azure ¿Qué es el clasificador semántico en Azure AI Search? ¿En qué se diferencia de la búsqueda vectorial?"</li><li>"@azure ¿Cuáles son los principales ejemplos de código o aceleradores de soluciones recomendados para Azure AI Search?"</li><li>"@azure ¿Cuáles son algunos ejemplos del mundo real de empresas que usan Azure AI Search?"</li></ul>|
|Azure API Management|<ul><li>"@azure ¿Cuáles son los beneficios y aplicaciones de Azure API Management?"</li></ul>|
|Azure App Service|<ul><li>"@azure ¿Cómo despliego una aplicación web en Azure?"</li><li>"@azure ¿Cómo creo una aplicación en App Service y despliego código en un entorno de pruebas usando la CLI?"</li><li>"@azure Crea un script para desplegar una aplicación web que se ejecute en C#."</li><li>"@azure ¿Qué opciones de base de datos tiene Azure para aplicaciones web?"</li><li>"@azure ¿Qué opciones serverless tiene Azure para aplicaciones web?"</li><li>"@azure Crea una guía para maximizar Azure App Service."</li></ul>|
|Azure Cache for Redis|<ul><li>"@azure Demuestra cómo configurar un Redis cache en Azure para alta disponibilidad y recuperación ante desastres."</li></ul>|
|Azure Container Apps|<ul><li>"@azure ¿Qué es el servicio Azure Container Apps?"</li><li>"@azure Dime la diferencia entre una aplicación de contenedor y un entorno de aplicaciones de contenedor."</li></ul>|
|Azure Cosmos DB|<ul><li>"@azure ¿Por qué usaría Azure Cosmos DB en lugar de Azure SQL?"</li><li>"@azure Quiero usar Azure Cosmos DB para almacenar mis datos."</li><li>"@azure ¿Por qué usaría una cuenta de Azure Cosmos DB sobre una base de datos SQL?"</li></ul>|
|Azure Data Factory|<ul><li>"@azure ¿Cómo creo canalizaciones de datos con Azure Data Factory?"</li></ul>|
|Azure Developer CLI (`azd`)|<ul><li>"@azure ¿Tienes modelos de despliegue de ejemplo para Azure? SaaS, PaaS, etc."</li><li>"@azure ¿Cuál es la mejor infraestructura para mi aplicación?"</li><li>"@azure ¿Cómo configuro mi entorno de Azure?"</li><li>"@azure ¿Qué son las plantillas de Azure Resource Manager y cómo las uso?"</li><li>"@azure ¿Cómo gestiono entornos con Azure Developer CLI?"</li><li>"@azure ¿Qué es Azure Developer CLI?"</li><li>"@azure ¿Cuál es la diferencia entre Bicep y plantillas ARM?"</li><li>"@azure ¿Cómo me aseguro de que mis entornos tengan los mejores patrones de seguridad?"</li><li>"@azure ¿Cómo hago un despliegue usando mi pipeline CI/CD?"</li></ul>|
|Azure Functions|<ul><li>"@azure ¿Cómo creo una nueva función de Azure?"</li><li>"@azure ¿Cuál es la diferencia entre Azure Functions y Azure Logic Apps?"</li><li>"@azure Crea una guía para integrar Azure Logic Apps con Azure Functions."</li><li>"@azure Quiero crear una función de Azure en Node.js."</li></ul>|
|Azure Key Vault|<ul><li>"@azure Explica cómo y por qué debería usar Azure Key Vaults."</li></ul>|
|Azure Kubernetes Service (AKS)|<ul><li>"@azure ¿Cómo obtengo el estado de todos los nodos en mi clúster AKS?"</li><li>"@azure ¿Cuál es el comando para establecer un contexto para mi clúster AKS?"</li></ul>|
|Azure Machine Learning|<ul><li>"@azure Genera un script de PowerShell para crear un nuevo espacio de trabajo de Azure Machine Learning."</li><li>"@azure ¿Cuál es la diferencia entre los servicios de Azure AI y Azure Machine Learning?"</li></ul>|
|Azure Monitor|<ul><li>"@azure Crea una guía para usar Azure Logic Apps para automatizar respuestas a alertas de Azure Monitor."</li></ul>|
|Azure Virtual Network|<ul><li>"@azure ¿Cómo equilibro el tráfico de red entrante a mi aplicación?"</li></ul>|
|Azure OpenAI Service|<ul><li>"@azure ¿Qué servicios proporciona Azure OpenAI?"</li><li>"@azure ¿Dónde está disponible GPT-4o mini?"</li><li>"@azure ¿Cuáles son los requisitos previos para integrar Azure OpenAI?"</li><li>"@azure Crea una guía para crear y usar recursos de Azure OpenAI."</li><li>"@azure ¿Qué tipos de modelos de Azure OpenAI están disponibles?"</li></ul>|
|Azure SDK|<ul><li>"@azure ¿Puedo usar Azure SDKs en el navegador?"</li><li>"@azure ¿El SDK de almacenamiento en C# soporta cargas y descargas de blobs en fragmentos?"</li></ul>|
|Azure SignalR Service|<ul><li>"@azure ¿Cómo alojo y escalo SignalR en múltiples servidores?"</li><li>"@azure ¿Cómo hago comunicación en tiempo real en .NET?"</li><li>"@azure ¿Cómo envío actualizaciones en tiempo real a los clientes?"</li><li>"@azure ¿Cómo sincronizo datos entre clientes?"</li><li>"@azure ¿Cómo transmito datos a los clientes?"</li><li>"@azure ¿Cómo gestiono y escalo conexiones WebSocket?"</li><li>"@azure ¿Cómo alojo y escalo Socket.IO?"</li><li>"@azure ¿Qué necesito hacer para configurar mi código SignalR para que funcione con Azure SignalR Service?"</li><li>"@azure Evalúa mi uso de SignalR. ¿Está siguiendo las mejores prácticas de seguridad?"</li><li>"@azure ¿Cómo hago pruebas de estrés en SignalR?"</li><li>"@azure ¿Cómo configuro la red en Azure SignalR Service?"</li><li>"@azure ¿Cómo configuro un controlador de eventos de Azure Web PubSub?"</li>|
|Azure SQL|<ul><li>"@azure Crea una configuración de Terraform para desplegar una base de datos Azure SQL."</li><li>"@azure Diseña una estrategia para migrar bases de datos SQL Server locales a Azure SQL Managed Instance."</li></ul>|
|Azure Static Web Apps|<ul><li>"@azure ¿Las aplicaciones web estáticas soportan direcciones IP estáticas?"</li></ul>|
|Azure Storage|<ul><li>"@azure ¿Por qué usaría un almacenamiento de blobs?"</li><li>"@azure ¿Cómo obtengo datos de un blob de almacenamiento en React?"</li><li>"@azure Enumera los pasos para asegurar Azure Blob Storage con endpoints privados y Azure Private Link."</li><li>"@azure Genera un script de CLI de Azure para crear una nueva cuenta de almacenamiento."</li><li>"@azure Dame el código para crear una nueva cuenta de almacenamiento con una CLI."</li><li>"@azure ¿Puedes ayudarme a elegir la solución de almacenamiento de Azure adecuada?"</li></ul>|
|Azure Web PubSub|<ul><li>"@azure ¿Cómo autentico con Web PubSub?"</li><li>"@azure ¿Qué necesito hacer para alojar mi aplicación Socket.IO en Azure?"</li><li>"@azure ¿Cómo hago pruebas de estrés en Web PubSub?"</li></ul>|

**Descargo de responsabilidad**:  
Este documento ha sido traducido utilizando servicios de traducción automática basados en inteligencia artificial. Si bien nos esforzamos por garantizar la precisión, tenga en cuenta que las traducciones automatizadas pueden contener errores o inexactitudes. El documento original en su idioma nativo debe considerarse la fuente autorizada. Para información crítica, se recomienda una traducción profesional realizada por humanos. No nos hacemos responsables de malentendidos o interpretaciones erróneas que puedan surgir del uso de esta traducción.