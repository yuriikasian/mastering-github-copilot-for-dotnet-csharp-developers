<header>

# Introduction à GitHub Codespaces

Bienvenue dans l'univers de GitHub Codespaces—votre porte d'entrée vers le codage dans le cloud. Dans ce module, nous explorerons la puissance transformatrice des environnements de développement instantanés et hébergés dans le cloud, qui redéfinissent votre approche du codage. GitHub Codespaces offre une expérience fluide et intégrée, avec un conteneur entièrement équipé comprenant tous les langages, outils et utilitaires essentiels pour coder efficacement.

Au fil de ce parcours d'apprentissage, vous découvrirez le cycle de vie complet de Codespaces et apprendrez à personnaliser votre configuration en fonction de vos préférences et besoins spécifiques. Pour renforcer votre compréhension, le module se termine par un exercice pratique où vous pourrez appliquer vos compétences directement dans l'environnement GitHub Codespaces.

Imaginez un environnement de développement entièrement configuré, prêt à l'emploi et accessible depuis n'importe quel ordinateur connecté à Internet. GitHub Codespaces vous permet d'adopter une nouvelle ère de codage collaboratif et flexible. Plongeons ensemble pour libérer tout le potentiel du développement basé sur le cloud !!

</header>

- **Pour qui est-ce destiné** : Développeurs, ingénieurs DevOps, managers techniques, chefs de produit.
- **Ce que vous apprendrez** : Comment créer un codespace, pousser du code depuis un codespace, choisir une image personnalisée, et personnaliser un codespace.
- **Ce que vous construirez** : Un codespace avec des fichiers devcontainer.json, des personnalisations et des ajustements.
- **Prérequis** : Vous devez avoir les connaissances suivantes :
  - Utilisation de Visual Studio Code, [Documentation Visual Studio Code](https://code.visualstudio.com/docs).
  - Compréhension de l'utilisation de GitHub ou avoir complété le module précédent [Introduction à GitHub](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/01-Introduction-to-GitHub/README.md).
- **Durée** : Ce cours peut être complété en moins d'une heure.

À la fin de ce module, vous serez capable de :

1. Décrire GitHub Codespaces.
2. Expliquer le cycle de vie de GitHub Codespaces et comment effectuer chaque étape.
3. Définir les différentes personnalisations que vous pouvez apporter avec GitHub Codespaces.

## Lecture préalable :

- [Coder avec GitHub Codespaces](https://learn.microsoft.com/training/modules/code-with-github-codespaces/)
- Qu'est-ce que GitHub Codespaces ? (Playlist vidéo ci-dessous)
- [![Qu'est-ce que Codespaces](https://img.youtube.com/vi/ozuDPmcC1io/0.jpg)](https://www.youtube.com/watch?v=ozuDPmcC1io&list=PLmsFUfdnGr3wTl-NCblzcrEv2lFSX975-)

### Comment démarrer ce cours

<!-- Pour démarrer le cours, exécutez en JavaScript :
'https://github.com/new?' + new URLSearchParams({
  template_owner: 'skills',
  template_name: 'code-with-codespaces',
  owner: '@me',
  name: 'skills-code-with-codespaces',
  description: 'My clone repository',
  visibility: 'public',
}).toString()
-->

[![démarrer-le-cours](https://user-images.githubusercontent.com/1221423/235727646-4a590299-ffe5-480d-8cd5-8194ea184546.svg)](https://github.com/new?template_owner=skills&template_name=code-with-codespaces&owner=%40me&name=skills-code-with-codespaces&description=My+clone+repository&visibility=public)

1. Faites un clic droit sur **Démarrer le cours** et ouvrez le lien dans un nouvel onglet.
2. Dans le nouvel onglet, la plupart des champs seront automatiquement remplis pour vous.
   - Pour le propriétaire, choisissez votre compte personnel ou une organisation pour héberger le dépôt.
   - Nous recommandons de créer un dépôt public, car les dépôts privés [utiliseront des minutes Actions](https://docs.github.com/billing/managing-billing-for-github-actions/about-billing-for-github-actions).
   - Faites défiler jusqu'en bas et cliquez sur le bouton **Créer un dépôt**.
3. Une fois votre nouveau dépôt créé, attendez environ 20 secondes, puis actualisez la page. Suivez les instructions pas à pas dans le README du nouveau dépôt.

<footer>

---

Obtenez de l'aide : [Postez sur notre forum de discussion](https://github.com/orgs/skills/discussions/categories/introduction-to-github) • [Consultez la page de statut de GitHub](https://www.githubstatus.com/)

**Avertissement** :  
Ce document a été traduit à l'aide de services de traduction automatisée basés sur l'intelligence artificielle. Bien que nous nous efforcions d'assurer l'exactitude, veuillez noter que les traductions automatisées peuvent contenir des erreurs ou des inexactitudes. Le document original dans sa langue d'origine doit être considéré comme la source faisant autorité. Pour des informations critiques, il est recommandé de recourir à une traduction humaine professionnelle. Nous déclinons toute responsabilité en cas de malentendus ou d'interprétations erronées résultant de l'utilisation de cette traduction.