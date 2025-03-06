- **Para quem é este curso**: Desenvolvedores, Engenheiros DevOps, Gerentes de desenvolvimento de software, Testadores.
- **O que você vai aprender**: Utilizar o GitHub Copilot para criar código e adicionar comentários ao seu trabalho.
- **O que você vai construir**: Arquivos C# que terão código gerado pela IA do Copilot para sugestões de código e comentários.
- **Pré-requisitos**: O GitHub Copilot está disponível gratuitamente, inscreva-se em [GitHub Copilot](https://gh.io/copilot).
- **Duração**: Este curso pode ser concluído em menos de uma hora.

Ao final deste módulo, você terá adquirido as habilidades para:

- Experimentar o GitHub Codespaces como ambiente de desenvolvimento.
- Desenvolver rotinas de entrada e saída em uma aplicação de console em C#.
- Usar o GitHub Copilot como assistente.

## Leitura prévia:
- [Introdução à engenharia de prompts com o GitHub Copilot](https://learn.microsoft.com/training/modules/introduction-prompt-engineering-with-github-copilot/)
- [Projeto desafiador - Crie um minigame com GitHub Copilot e C#](https://learn.microsoft.com/training/modules/challenge-project-create-mini-game-with-copilot-dotnet/)

## Requisitos

- Ative seu [serviço GitHub Copilot](https://github.com/github-copilot/signup)

## 💪🏽 Exercício

[![Abrir no GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/mastering-github-copilot-for-dotnet-csharp-developers?devcontainer_path=.devcontainer%2Fmini-game%2Fdevcontainer.json)

Você já aprendeu um pouco sobre o GitHub Codespaces e o GitHub Copilot e como eles funcionam. Neste exercício desafiador, seu objetivo é desenvolver um minigame em C# usando o GitHub Copilot.

#### Testando seu GitHub Codespace

1. Abra o **Solution Explorer** e você encontrará um projeto chamado **MiniGame**.
1. Abra `Program.cs`

1. Execute a aplicação na opção **Run and Debug** ou no canto superior direito do arquivo Program.cs com o botão Play. Verifique se o resultado é semelhante à seguinte mensagem no console:

   ```bash
   Hello, World!
   ```
   
### Criando a lógica do jogo

Agora que você verificou que o Codespaces está funcionando com o GitHub Copilot, o próximo passo é desenvolver a lógica do minigame em C# com a ajuda do GitHub Copilot, com base nas seguintes especificações:

O vencedor do jogo é determinado por três regras simples:

- **Pedra** vence tesoura.
- **Tesoura** vence papel.
- **Papel** vence pedra.

#### Considerações sobre a interação do jogo

O computador será seu oponente e poderá escolher aleatoriamente um dos elementos (**pedra**, **papel** ou **tesoura**). A interação do jogo será feita pelo console (Terminal).

- O jogador pode escolher uma das três opções: pedra, papel ou tesoura, e deve ser avisado se inserir uma opção inválida.
- A cada rodada, o jogador deve inserir uma das opções da lista e ser informado se venceu, perdeu ou empatou com o oponente.
- Ao final de cada rodada, o jogador pode optar por jogar novamente.
- Exiba a pontuação do jogador ao final do jogo.
- O minigame deve tratar as entradas do usuário, convertendo-as para letras minúsculas e informando ao usuário se a opção for inválida.

No seu GitHub Codespaces, siga as instruções fornecidas para configurar prompts que o GitHub Copilot possa entender e usar para ajudá-lo a construir o minigame. Lembre-se de que o GitHub Copilot depende de comentários para entender o contexto e oferecer sugestões úteis enquanto você trabalha no seu projeto.

#### Verifique seu trabalho

1. Execute o minigame no console com o comando *dotnet run*.
2. No prompt, digite uma das opções do jogo: *pedra*, *papel* ou *tesoura*.
3. O minigame deve informar ao jogador se ele venceu, perdeu ou empatou com o oponente.
4. Escolha continuar jogando.
5. No prompt, digite *tela*.
6. O minigame deve informar ao jogador se a opção inserida é inválida.
7. Repita os passos 2 e 4 para jogar algumas rodadas e escolha não continuar jogando.
8. Verifique se o minigame é encerrado e se exibe sua pontuação, informando o número de vitórias e rodadas.

Parabéns por concluir este exercício desafiador! Você criou um minigame de console em C# usando o GitHub Copilot.

**Aviso Legal**:  
Este documento foi traduzido utilizando serviços de tradução baseados em IA. Embora nos esforcemos para garantir a precisão, esteja ciente de que traduções automáticas podem conter erros ou imprecisões. O documento original em seu idioma nativo deve ser considerado a fonte oficial. Para informações críticas, recomenda-se a tradução profissional feita por humanos. Não nos responsabilizamos por quaisquer mal-entendidos ou interpretações equivocadas decorrentes do uso desta tradução.