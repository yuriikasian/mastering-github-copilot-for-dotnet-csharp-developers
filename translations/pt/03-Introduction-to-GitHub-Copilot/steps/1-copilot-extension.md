## Etapa 1: Aproveite o Codespaces com VS Code para o Copilot

_Bem-vindo(a) ao "Desenvolva com Sugestões de Código Alimentadas por IA Usando GitHub Copilot e VS Code"! :wave:_

O GitHub Copilot é um programador parceiro de IA que ajuda você a escrever código mais rápido e com menos esforço. Ele utiliza o contexto de comentários e código para sugerir linhas individuais e funções inteiras instantaneamente. O GitHub Copilot é alimentado pelo OpenAI Codex, um modelo de linguagem generativa pré-treinado criado pela OpenAI.

**O Copilot funciona com muitos editores de código, incluindo VS Code, Visual Studio, JetBrains IDE e Neovim.**

Além disso, o GitHub Copilot é treinado em todas as linguagens que aparecem em repositórios públicos. Para cada linguagem, a qualidade das sugestões que você recebe pode depender do volume e da diversidade dos dados de treinamento para essa linguagem.

Usar o Copilot dentro de um Codespace mostra como é fácil começar a usar a suíte de ferramentas de [Colaboração em Código](https://github.com/features#features-collaboration) do GitHub.

> **Nota**
> Este exercício de habilidades se concentrará em aproveitar o GitHub Codespace. É recomendável que você complete a habilidade do GitHub, [Codespaces](https://github.com/skills/code-with-codespaces), antes de prosseguir com este exercício.

### ⌨️ Atividade: Ative o Copilot dentro de um Codespace

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/mastering-github-copilot-for-dotnet-csharp-developers?devcontainer_path=.devcontainer%2Fintroduction%2Fdevcontainer.json)

**Recomendamos abrir outra aba do navegador para realizar as atividades a seguir, para que você possa manter estas instruções abertas como referência.**

Antes de abrir um codespace em um repositório, você pode criar um contêiner de desenvolvimento e definir extensões ou configurações específicas que serão usadas ou instaladas no seu codespace. Vamos criar este contêiner de desenvolvimento e adicionar o copilot à lista de extensões.

1. Observe no corpo do arquivo **.devcontainer/introduction/devcontainer.json** o seguinte conteúdo:
   ```
   {
       // Name this configuration
       "name": "Introduction to Copilot",
       "customizations": {
           "vscode": {
               "extensions": [
                   "GitHub.copilot",
                   "ms-dotnettools.csdevkit"
               ]
           }
       }
   }
   ```

Se você encontrar problemas a qualquer momento, pode criar um novo codespace:

1. Navegue de volta para a página inicial do seu repositório clicando na aba **Code** localizada no canto superior esquerdo da tela.
1. Clique no botão **Code** localizado no meio da página.
1. Clique na aba **Codespaces** na caixa que aparecer.
1. Clique no botão **Create codespace on main** e selecione Introduction to Copilot.

   **Aguarde cerca de 2 minutos para que o codespace seja configurado.**

1. Verifique se o seu codespace está funcionando. O navegador deve conter um editor baseado na web do VS Code e um terminal deve estar presente, como abaixo:
   ![Screen Shot 2023-03-09 at 9 09 07 AM](../../../../translated_images/1-skills-0.1c00cff1473d07e185dbb26d6fb869697436c85fbfb7166f9cfc394f08e77776.pt.png)
1. A extensão `copilot` deve aparecer na lista de extensões do VS Code. Clique na aba lateral de extensões. Você deve ver o seguinte:
   ![Screen Shot 2023-03-09 at 9 04 13 AM](../../../../translated_images/1-skills-1.86911486a2a6c46d5195718017ae3e4e45be73c900914136d779693e75394d3c.pt.png)

Vá para a [Parte 2 do Exercício](./2-skills-dotnet.md)

**Aviso Legal**:  
Este documento foi traduzido utilizando serviços de tradução baseados em IA. Embora nos esforcemos para garantir a precisão, esteja ciente de que traduções automáticas podem conter erros ou imprecisões. O documento original em seu idioma nativo deve ser considerado a fonte oficial. Para informações críticas, recomenda-se a tradução profissional feita por humanos. Não nos responsabilizamos por quaisquer mal-entendidos ou interpretações equivocadas decorrentes do uso desta tradução.