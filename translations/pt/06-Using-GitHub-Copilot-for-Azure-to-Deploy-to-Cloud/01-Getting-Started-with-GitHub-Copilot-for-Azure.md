# Introdução ao GitHub Copilot para Azure

Desbloqueie um fluxo de trabalho mais eficiente e aumente sua produtividade com o GitHub Copilot para Azure Preview. Este guia rápido irá te mostrar tudo o que você precisa saber, desde a preparação dos pré-requisitos até a instalação da extensão GitHub Copilot para Azure no Visual Studio Code. Ao final, você estará preparado para criar seu primeiro prompt e aproveitar ao máximo o potencial da plataforma Azure.

![GitHub Copilot para Azure](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/intro.gif "GitHub Copilot para Azure")

- **Para quem é**: Desenvolvedores, Profissionais de Operações (ITPRO) e Engenheiros de IA.  
- **O que você aprenderá**: Passos para configurar e começar a usar o GitHub Copilot para Azure.  
- **O que você criará**: Um ambiente de trabalho com IA configurado com confiança.

## Leitura prévia:  
- [O que é o GitHub Copilot para Azure Preview?](https://learn.microsoft.com/azure/developer/github-copilot-azure/introduction)

## 👉 Pré-requisitos

Para completar os passos deste laboratório, certifique-se de que você tem:

1. Uma conta no Azure e acesso a uma assinatura do Azure. Para detalhes sobre como configurá-las, veja a [página de preços para contas do Azure.](https://azure.microsoft.com/pricing/purchase-options/azure-account)

1. Uma conta no GitHub. Os passos para criar uma conta podem ser encontrados aqui: [Criando uma conta no GitHub](https://docs.github.com/en/get-started/start-your-journey/creating-an-account-on-github)

1. Assinatura do GitHub Copilot. Detalhes sobre como habilitar o GitHub Copilot podem ser encontrados aqui: [Guia rápido para GitHub Copilot](https://docs.github.com/en/copilot/quickstart)

1. Visual Studio Code. Para detalhes sobre como baixá-lo e instalá-lo, veja [Configurando o Visual Studio Code.](https://code.visualstudio.com/docs/setup/setup-overview)

1. As extensões GitHub Copilot e GitHub Copilot Chat. Para instruções sobre como instalar essas extensões, veja [Configurar o GitHub Copilot no VS Code.](https://marketplace.visualstudio.com/items?itemName=GitHub.copilot)

## 💪🏽 Exercício

### 🛠 Passo 1: Autentique-se no GitHub e faça login no chat do GitHub Copilot para habilitar o Copilot para Azure Preview

1. Ao abrir o VS Code, no lado direito, clique em **"Sign in with a GitHub.com account"**.

    1. O Visual Studio Code exibirá uma mensagem informando **"The extension 'GitHub Copilot Chat' wants to sign in using GitHub."** Clique em **Allow**.

    1. Será necessário autorizar o Visual Studio Code a continuar com o usuário conectado. Clique no botão **Continue**.

    1. Conclua a autorização clicando no botão **Authorize Visual-Studio-Code**.

    1. Uma mensagem pop-up pedirá para abrir o VS Code. Clique em **Open**. Você será redirecionado ao VS Code, autenticado no GitHub e terá acesso ao **GitHub Copilot**.

1. No Visual Studio Code, selecione o ícone de **Extensões**.

1. Verifique se você possui as seguintes extensões instaladas:
    1. **Azure Tools**
    1. **GitHub Copilot**
    1. **GitHub Copilot Chat**
    1. **GitHub Copilot for Azure**
    1. **C# Dev Kit**

1. Caso alguma esteja faltando, instale-a no marketplace.

### ✍️ Passo 2: Escreva seu primeiro prompt

1. Agora que as extensões estão instaladas, que você está devidamente autenticado e que a extensão está funcionando corretamente.

1. Na Barra de Atividades, selecione o ícone **Chat** se o painel **Ask Copilot** estiver fechado.

1. Na área de texto do chat, na parte inferior do painel, insira o seguinte prompt:

```prompt
@azure Do I have any resources currently running?
```  
> Na próxima seção, você será solicitado a autorizar aplicativos e serviços várias vezes. Isso é para sua proteção e será feito apenas uma vez. Estamos autorizando **GitHub**, **VS Code** e **Azure** a confiar nos prompts com as credenciais fornecidas.

1. Você pode receber uma mensagem no painel do GitHub Copilot Chat informando "you need to sign in your Microsoft account to use GitHub Copilot for Azure (@Azure)".

    1. Se isso ocorrer, clique no link na linha **"Already have an account? Sign in"**.  
    1. O Visual Studio Code exibirá uma mensagem informando **"The extension 'GitHub Copilot for Azure' wants to sign in using Microsoft."** Clique em **Allow**.  
    1. Faça login usando as credenciais da sessão existente ou as credenciais fornecidas na aba de Recursos das instruções do laboratório. As mesmas credenciais da assinatura do Azure.  
    1. Feche a aba. Não o navegador.  
    1. Volte ao VS Code. O Visual Studio Code exibirá uma mensagem informando **"The extension 'GitHub Copilot for Azure' wants to access the language models provided by GitHub Copilot Chat."** Clique em **Allow**.  
    1. O Visual Studio Code exibirá outra mensagem informando **"The extension 'GitHub Copilot for Azure' wants to sign in using GitHub."** Clique em **Allow** novamente.  
        1. Será necessário autorizar o Visual Studio Code a continuar com o usuário conectado. Clique no botão **Continue**.  
        1. Conclua a autorização clicando no botão **Authorize Visual-Studio-Code**.  
        1. Uma mensagem pop-up pedirá para abrir o VS Code. Clique em **Open**. Você será redirecionado ao VS Code, autenticado no GitHub e terá acesso ao **GitHub Copilot**.

1. A extensão Copilot para Azure consultará o Azure Resource Graph, fornecerá a consulta de recursos e apresentará a resposta. Neste ponto, a resposta deve ser **Você atualmente não possui recursos em execução em nenhuma das suas assinaturas.**

### Conclusão

Parabéns! Ao longo deste exercício, você configurou o VS Code para usar o GitHub Copilot para Azure e o utilizou para consultar sobre recursos em execução na sua assinatura do Azure.

**Aviso Legal**:  
Este documento foi traduzido utilizando serviços de tradução automática baseados em IA. Embora nos esforcemos para garantir a precisão, esteja ciente de que traduções automatizadas podem conter erros ou imprecisões. O documento original em seu idioma nativo deve ser considerado a fonte oficial. Para informações críticas, recomenda-se a tradução profissional feita por humanos. Não nos responsabilizamos por quaisquer mal-entendidos ou interpretações equivocadas decorrentes do uso desta tradução.