<header>

# Introdução ao GitHub Codespaces

Bem-vindo ao mundo do GitHub Codespaces—sua porta de entrada para codificação baseada na nuvem. Neste módulo, exploraremos o poder transformador de ambientes de desenvolvimento instantâneos e hospedados na nuvem que redefinem a forma como você aborda a programação. O GitHub Codespaces oferece uma experiência integrada e fluida, fornecendo um contêiner completo com todas as linguagens, ferramentas e utilitários essenciais para que você codifique de forma eficiente.

Ao longo desta jornada de aprendizado, você descobrirá o ciclo de vida completo do Codespaces e aprenderá a personalizar sua configuração para atender às suas preferências e necessidades específicas. Para reforçar seu entendimento, o módulo termina com um exercício prático, onde você poderá aplicar suas habilidades diretamente no ambiente do GitHub Codespaces.

Imagine um ambiente de desenvolvimento totalmente configurado, pronto para uso e acessível de qualquer computador com conexão à internet. O GitHub Codespaces permite que você abrace uma nova era de codificação colaborativa e flexível. Vamos mergulhar de cabeça e desbloquear todo o potencial do desenvolvimento baseado na nuvem juntos!!

</header>


- **Para quem é este curso**: Desenvolvedores, Engenheiros DevOps, Gerentes de Engenharia, Gerentes de Produto.
- **O que você aprenderá**: Como criar um codespace, enviar código a partir de um codespace, selecionar uma imagem personalizada e personalizar um codespace.
- **O que você construirá**: Um codespace com arquivos devcontainer.json, customizações e personalizações.
- **Pré-requisitos**: Você precisará saber o seguinte:
  - Uso do Visual Studio Code, [Documentação do Visual Studio Code](https://code.visualstudio.com/docs).
  - Compreensão do uso do GitHub ou conclusão do módulo anterior [Introdução ao GitHub](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/01-Introduction-to-GitHub/README.md).
- **Duração**: Este curso pode ser concluído em menos de uma hora.

Ao final deste módulo, você será capaz de:

1. Descrever o GitHub Codespaces.
2. Explicar o ciclo de vida do GitHub Codespaces e como realizar cada etapa.
3. Definir as diferentes personalizações que você pode ajustar no GitHub Codespaces.


## Leitura pré-requisito:

- [Codifique com o GitHub Codespaces](https://learn.microsoft.com/training/modules/code-with-github-codespaces/)
- O que é o GitHub Codespaces? (Playlist de vídeos abaixo)
- [![O que é Codespaces](https://img.youtube.com/vi/ozuDPmcC1io/0.jpg)](https://www.youtube.com/watch?v=ozuDPmcC1io&list=PLmsFUfdnGr3wTl-NCblzcrEv2lFSX975-)



### Como iniciar este curso

<!-- Para iniciar o curso, execute em JavaScript:
'https://github.com/new?' + new URLSearchParams({
  template_owner: 'skills',
  template_name: 'code-with-codespaces',
  owner: '@me',
  name: 'skills-code-with-codespaces',
  description: 'Meu repositório clonado',
  visibility: 'public',
}).toString()
-->

[![iniciar-curso](https://user-images.githubusercontent.com/1221423/235727646-4a590299-ffe5-480d-8cd5-8194ea184546.svg)](https://github.com/new?template_owner=skills&template_name=code-with-codespaces&owner=%40me&name=skills-code-with-codespaces&description=My+clone+repository&visibility=public)

1. Clique com o botão direito em **Iniciar curso** e abra o link em uma nova aba.
2. Na nova aba, a maioria dos campos será preenchida automaticamente.
   - Para o proprietário, escolha sua conta pessoal ou uma organização para hospedar o repositório.
   - Recomendamos criar um repositório público, pois repositórios privados [consumirão minutos do Actions](https://docs.github.com/billing/managing-billing-for-github-actions/about-billing-for-github-actions).
   - Role para baixo e clique no botão **Criar repositório** na parte inferior do formulário.
3. Após a criação do novo repositório, aguarde cerca de 20 segundos e, em seguida, atualize a página. Siga as instruções passo a passo no README do novo repositório.

<footer>

<!--
  <<< Author notes: Footer >>>
  Adicione um link para obter suporte, página de status do GitHub, código de conduta, link da licença.
-->

---

Obtenha ajuda: [Publique no nosso fórum de discussão](https://github.com/orgs/skills/discussions/categories/introduction-to-github) • [Consulte a página de status do GitHub](https://www.githubstatus.com/)

**Aviso Legal**:  
Este documento foi traduzido utilizando serviços de tradução automática baseados em IA. Embora nos esforcemos para alcançar precisão, esteja ciente de que traduções automatizadas podem conter erros ou imprecisões. O documento original em seu idioma nativo deve ser considerado a fonte oficial. Para informações críticas, recomenda-se a tradução humana profissional. Não nos responsabilizamos por quaisquer mal-entendidos ou interpretações incorretas decorrentes do uso desta tradução.