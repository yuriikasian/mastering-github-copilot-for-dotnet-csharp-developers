# Introdução ao GitHub Copilot para Azure

Desbloqueie um fluxo de trabalho mais eficiente e aumente sua produtividade com o GitHub Copilot para Azure Preview. Este guia rápido vai te levar por tudo o que você precisa saber, desde a preparação dos pré-requisitos até a instalação da extensão GitHub Copilot para Azure no Visual Studio Code. Ao final, você estará pronto para criar seu primeiro prompt e aproveitar todo o potencial da plataforma Azure.

![GitHub Copilot para Azure](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/intro.gif "GitHub Copilot para Azure")

- **Para quem é**: Desenvolvedores, profissionais de operações (ITPRO) e engenheiros de IA.
- **O que você vai aprender**: Etapas de configuração para começar a usar o GitHub Copilot para Azure.
- **O que você vai construir**: Um ambiente de trabalho habilitado para IA configurado com confiança.

## Leitura prévia:
- [O que é o GitHub Copilot para Azure Preview?](https://learn.microsoft.com/azure/developer/github-copilot-azure/introduction)

## 👉 Pré-requisitos

Para concluir as etapas deste laboratório, certifique-se de que você tem:

1. Uma conta Azure e acesso a uma assinatura Azure. Para detalhes sobre como configurá-las, veja a [página de preços para contas Azure.](https://azure.microsoft.com/pricing/purchase-options/azure-account)

1. Uma conta GitHub. As etapas para configurar uma estão disponíveis aqui: [Criando uma conta no GitHub](https://docs.github.com/en/get-started/start-your-journey/creating-an-account-on-github)

1. Assinatura do GitHub Copilot. Detalhes sobre como habilitar o GitHub Copilot podem ser encontrados aqui: [Início rápido para GitHub Copilot](https://docs.github.com/en/copilot/quickstart)

1. Visual Studio Code. Para detalhes sobre como baixá-lo e instalá-lo, veja [Configurando o Visual Studio Code.](https://code.visualstudio.com/docs/setup/setup-overview)

1. As extensões GitHub Copilot e GitHub Copilot Chat. Para instruções sobre como instalar essas extensões, veja [Configurar o GitHub Copilot no VS Code.](https://marketplace.visualstudio.com/items?itemName=GitHub.copilot)

## 💪🏽 Exercício

### 🛠 Etapa 1: Autentique-se no GitHub e faça login no GitHub Copilot Chat para habilitar o Copilot para Azure Preview

1. Ao abrir o VS Code, no lado direito, clique em **"Sign in with a GitHub.com account"**.

    1. O Visual Studio Code exibirá uma mensagem perguntando **"The extension 'GitHub Copilot Chat' wants to sign in using GitHub."** Clique em **Allow**.

    1. Você precisará autorizar o Visual Studio Code para continuar com o usuário conectado. Clique no botão **Continue**.

    1. Conclua a autorização clicando no botão **Authorize Visual-Studio-Code**.

    1. Uma mensagem pop-up pedirá para abrir o VS Code. Clique em **Open**. Você será retornado ao VS Code, autenticado no GitHub e com acesso ao **GitHub Copilot**.

1. No Visual Studio Code, selecione o ícone **Extensions**.

1. Verifique se você tem as seguintes extensões instaladas:
    1. **Azure Tools**
    1. **GitHub Copilot**
    1. **GitHub Copilot Chat**
    1. **GitHub Copilot for Azure**
    1. **C# Dev Kit**

1. Se alguma estiver faltando, instale-a no marketplace.

### ✍️ Etapa 2: Escreva seu primeiro prompt

1. Agora que as extensões estão instaladas, que você está devidamente autenticado e que a extensão está funcionando corretamente.

1. Na Barra de Atividades, selecione o ícone **Chat** caso o painel **Ask Copilot** esteja fechado.

1. Na área de texto de chat na parte inferior do painel, insira o seguinte prompt:

```prompt
@azure Do I have any resources currently running?
```
> Na próxima seção, você será solicitado a autorizar aplicativos e serviços várias vezes. Isso é para sua proteção e será feito apenas uma vez. Estamos autorizando **GitHub**, **VS Code** e **Azure** a confiar nos prompts com as credenciais fornecidas.

1. Você pode receber uma mensagem no painel do GitHub Copilot Chat que informa "you need to sign in your Microsoft account to use GitHub Copilot for Azure (@Azure)".

    1. Se isso acontecer, clique no link na linha **"Already have an account? Sign in"**.
    1. O Visual Studio Code exibirá uma mensagem perguntando **"The extension 'GitHub Copilot for Azure' wants to sign in using Microsoft."** Clique em **Allow**.
    1. Faça login usando as credenciais da sessão existente ou as credenciais encontradas na aba de Recursos das instruções do laboratório. As mesmas credenciais da assinatura Azure.
    1. Feche a aba, mas não o navegador.
    1. Retorne ao VS Code. O Visual Studio Code exibirá uma mensagem perguntando **"The extension 'GitHub Copilot for Azure' wants to access the language models provided by GitHub Copilot Chat."** Clique em **Allow**.
    1. O Visual Studio Code exibirá outra mensagem perguntando **"The extension 'GitHub Copilot for Azure' wants to sign in using GitHub."** Clique em **Allow** novamente.
        1. Você precisará autorizar o Visual Studio Code para continuar com o usuário conectado. Clique no botão **Continue**.
        1. Conclua a autorização clicando no botão **Authorize Visual-Studio-Code**.
        1. Uma mensagem pop-up pedirá para abrir o VS Code. Clique em **Open**. Você será retornado ao VS Code, autenticado no GitHub e com acesso ao **GitHub Copilot**.

1. A extensão Copilot para Azure consultará o gráfico de recursos do Azure, fornecerá a consulta de recursos e apresentará a resposta. Neste ponto, a resposta deve ser **You currently do not have any running resources across all your subscriptions.**

### Conclusão

Parabéns! Ao longo do exercício, você configurou o VS Code para usar o GitHub Copilot para Azure e o consultou para verificar se há recursos em execução em sua assinatura Azure.

**Aviso Legal**:  
Este documento foi traduzido utilizando serviços de tradução baseados em IA. Embora nos esforcemos para garantir a precisão, esteja ciente de que traduções automáticas podem conter erros ou imprecisões. O documento original em seu idioma nativo deve ser considerado a fonte oficial. Para informações críticas, recomenda-se a tradução humana profissional. Não nos responsabilizamos por quaisquer mal-entendidos ou interpretações incorretas decorrentes do uso desta tradução.