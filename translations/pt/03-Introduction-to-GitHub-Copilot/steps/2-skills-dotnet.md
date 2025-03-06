## Etapa 2: Visualizando sugestões de código do Copilot em um arquivo C#!

_Bom trabalho! :tada: Você criou um Codespace usando um arquivo devcontainer que instalou o Copilot!_

O GitHub Copilot oferece sugestões para diversas linguagens e uma ampla variedade de frameworks, mas funciona especialmente bem com Python, JavaScript, TypeScript, Ruby, Go, C# e C++. Os exemplos a seguir estão em C#, mas outras linguagens funcionarão de forma semelhante.

Vamos experimentar isso utilizando C# com o Copilot.

> **Note**:
> Se você fechou o Codespace criado anteriormente, reabra-o ou crie um novo Codespace.

### ⌨️ Atividade: Adicionar um arquivo C# e começar a escrever código

> **Note**:
> Certifique-se de abrir o **Solution Explorer** para ver uma visão organizada que facilita a adição de novos projetos e a execução deles.

1. Crie um novo projeto .NET utilizando o comando `.NET: New Project...` e selecionando `Console App`.
1. Selecione a pasta **code** e nomeie o projeto como **Skills**.
1. Abra `Program.cs`.
1. Verifique se o seu novo arquivo está assim:
   ![VS code com um novo Program.cs](../../../../03-Introduction-to-GitHub-Copilot/steps/img/2-skills-dotnet-0.png)

1. No arquivo `Program.cs`, remova qualquer código existente e, em seguida, digite o seguinte cabeçalho de função.

   ```csharp
   void CalculateNumbers(int var1, int var2)
   {
   ```

   O GitHub Copilot sugerirá automaticamente um corpo inteiro de função em texto cinza. Abaixo está um exemplo do que você provavelmente verá, mas a sugestão exata pode variar.
   ![VS Code com sugestões de código](../../../../03-Introduction-to-GitHub-Copilot/steps/img/2-skills-dotnet-1.png)

5. Pressione `Tab` para aceitar a sugestão.

### ⌨️ Atividade: Enviar o código para o seu repositório a partir do Codespace

Vamos usar o GitHub Copilot para resumir nossas alterações e, em seguida, fazer o commit do código.

1. Abra a aba **Source Control**.
2. Clique no botão ✨ na entrada **Message** para que o Copilot gere sua mensagem.

![Aba de commit aberta para gerar mensagem com o Copilot](../../../../03-Introduction-to-GitHub-Copilot/steps/img/2-skills-commit.png)

3. Clique no botão **Commit**.

Vá para [Parte 3 do Exercício](./3-copilot-hub.md)

**Aviso Legal**:  
Este documento foi traduzido usando serviços de tradução baseados em IA. Embora nos esforcemos para alcançar precisão, esteja ciente de que traduções automáticas podem conter erros ou imprecisões. O documento original em seu idioma nativo deve ser considerado a fonte autoritativa. Para informações críticas, recomenda-se a tradução profissional realizada por humanos. Não nos responsabilizamos por quaisquer mal-entendidos ou interpretações equivocadas decorrentes do uso desta tradução.