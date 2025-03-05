<header>

# Introduction à GitHub Copilot

Dans ce module d'apprentissage, nous explorerons les avantages de l'utilisation de GitHub Copilot, le tout premier outil de développement basé sur l'IA conçu pour fonctionner à grande échelle. Copilot améliore votre expérience de codage en vous aidant avec des tâches comme les tests, le refactoring, l'explication et la suggestion de code.

GitHub Copilot est un assistant de codage alimenté par l'IA qui vous aide à écrire du code plus rapidement et avec moins d'effort, libérant ainsi plus de temps et d'énergie pour la résolution de problèmes et la collaboration.

À la fin de ce module, vous serez non seulement capable d'expliquer ce qu'est GitHub Copilot et ses avantages, mais vous comprendrez également sa disponibilité pour les particuliers et les entreprises. Découvrez l'avenir de GitHub Copilot et plongez dans des exercices pratiques pour maîtriser son utilisation avec Visual Studio Code.

En utilisant Copilot, les développeurs ont pu augmenter leur productivité et accélérer le développement logiciel. Pour en savoir plus, consultez l'article du blog GitHub : [Quantifying GitHub Copilot’s Impact on Developer Productivity and Happiness.](https://github.blog/2022-09-07-research-quantifying-github-copilots-impact-on-developer-productivity-and-happiness)

Note : Bien que ce module utilise [Codespaces](https://github.com/codespaces), vous pouvez utiliser GitHub Copilot dans divers autres environnements, y compris localement avec Visual Studio Code.
</header>

- **Pour qui** : Développeurs, ingénieurs DevOps, responsables de développement logiciel, testeurs.
- **Ce que vous apprendrez** : Comment installer Copilot dans un Codespace, accepter des suggestions de code, accepter des suggestions à partir de commentaires.
- **Ce que vous construirez** : Des fichiers C# contenant du code généré par l'IA de Copilot pour des suggestions de code et de commentaires.
- **Prérequis** : GitHub Copilot est disponible gratuitement, inscrivez-vous sur [GitHub Copilot](https://gh.io/copilot).
- **Durée** : Ce cours peut être complété en moins d'une heure.

À la fin de ce module, vous serez capable de :

- Expliquer ce qu'est GitHub Copilot et les avantages qu'il offre.
- Comprendre la disponibilité de GitHub Copilot pour les particuliers et les entreprises.
- Discuter de l'avenir de GitHub Copilot.
- Apprendre à commencer à utiliser GitHub Copilot et quelques configurations courantes.
- Développer avec GitHub Copilot dans Visual Studio Code grâce à des exercices pratiques.

## Lecture préalable :
- [Introduction à GitHub Copilot](https://learn.microsoft.com/en-us/training/modules/introduction-to-github-copilot/)
- Qu'est-ce que GitHub Copilot ? (Playlist vidéo ci-dessous)
- [![Qu'est-ce que GitHub Copilot](https://img.youtube.com/vi/QG1E0SCqqW8/0.jpg)](https://learn.microsoft.com/shows/introduction-to-github-copilot/what-is-github-copilot-1-of-6/)

### Comment commencer ce cours

[![Ouvrir dans GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/mastering-github-copilot-for-dotnet-csharp-developers?devcontainer_path=.devcontainer%2Fintroduction%2Fdevcontainer.json)

Maintenant que vous avez appris à connaître GitHub Codespaces et GitHub Copilot, passons à l'étape suivante et utilisons Codespaces pour réaliser des travaux pratiques avec GitHub Copilot. Faites un clic droit sur **Ouvrir dans GitHub Codespaces** et ouvrez le lien dans un nouvel onglet.

### 🗃️ Leçons
|       |              Lien vers la leçon              |                       Concepts enseignés                       |                     Objectif pédagogique                 |                             
| :---: | :-------------------------------------------: | :------------------------------------------------------------: | ----------------------------------------------------------- |
| 01 | [Exploiter Codespaces avec VS Code pour Copilot](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/03-Introduction-to-GitHub-Copilot/steps/1-copilot-extension.md) | Apprenez à configurer et activer GitHub Copilot dans un Codespace à l'aide de VS Code en configurant un conteneur de développement et en installant les extensions nécessaires. | Ce guide permet aux développeurs de tirer parti de GitHub Codespaces et VS Code pour intégrer et utiliser efficacement GitHub Copilot pour des suggestions de code alimentées par l'IA. |
| 02 | [Voir les suggestions de code IA dans un fichier C# !](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/03-Introduction-to-GitHub-Copilot/steps/2-skills-dotnet.md) | Configurer un Codespace avec GitHub Copilot, créer un projet C#, utiliser Copilot pour des suggestions de code et pousser du code vers un dépôt avec Git. | Familiarisez-vous avec les suggestions de code alimentées par l'IA de GitHub Copilot en C# en créant un projet .NET, en générant des complétions de code et en poussant des modifications vers un dépôt avec Git. |
| 03 | [Afficher l'onglet GitHub Copilot avec plusieurs suggestions](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/03-Introduction-to-GitHub-Copilot/steps/3-copilot-hub.md) | Apprenez à utiliser GitHub Copilot pour des suggestions de code alimentées par l'IA en C#, gérer un Codespace, récupérer le dernier code, créer et éditer des fichiers, examiner les complétions de code générées par l'IA et pousser des modifications vers un dépôt Git en utilisant les commandes Git dans VS Code. | Familiarisez-vous avec les suggestions de code de GitHub Copilot, comment examiner et accepter les complétions générées par l'IA, et comment gérer les modifications de code dans un Codespace GitHub à l'aide des commandes Git. |
| 04 | [Utiliser des commentaires pour générer du code avec Copilot](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/03-Introduction-to-GitHub-Copilot/steps/4-copilot-comment.md) | Comprendre comment utiliser GitHub Copilot pour générer du code à partir de commentaires, naviguer dans les suggestions de Copilot et gérer le versionnage du code avec les commandes Git dans un environnement Codespace. | Utiliser des commentaires pour générer du code suggéré par l'IA avec GitHub Copilot dans VS Code. |

## 📚 Ressources et apprentissage supplémentaires

- [Qu'est-ce que GitHub Copilot](https://docs.github.com/en/copilot/about-github-copilot/what-is-github-copilot)
- [À propos des comptes entreprise pour Copilot Business](https://docs.github.com/en/enterprise-cloud@latest/admin/copilot-business-only/about-enterprise-accounts-for-copilot-business)
- [Démarrer avec Copilot](https://docs.github.com/en/copilot/getting-started-with-github-copilot/getting-started-with-github-copilot-in-visual-studio-code)
- [Configurer les paramètres de Copilot](https://docs.github.com/en/copilot/configuring-github-copilot/configuring-github-copilot-settings-on-githubcom)

### Et après ?

- [Nous serions ravis de savoir ce que vous avez pensé de ce cours](https://github.com/orgs/skills/discussions/categories/code-with-copilot).
- [Apprenez une autre compétence GitHub](https://github.com/skills).
- [Lisez la documentation Commencer avec GitHub](https://docs.github.com/en/get-started).
- Pour trouver des projets auxquels contribuer, consultez [GitHub Explore](https://github.com/explore).
   
<footer>

---

Obtenez de l'aide : [Postez sur notre forum de discussion](https://github.com/orgs/skills/discussions/categories/code-with-copilot) • [Consultez la page de statut GitHub](https://www.githubstatus.com/)

**Avertissement** :  
Ce document a été traduit à l'aide de services de traduction automatique basés sur l'IA. Bien que nous nous efforcions d'assurer l'exactitude, veuillez noter que les traductions automatisées peuvent contenir des erreurs ou des inexactitudes. Le document original dans sa langue d'origine doit être considéré comme la source faisant autorité. Pour des informations critiques, il est recommandé de recourir à une traduction humaine professionnelle. Nous déclinons toute responsabilité en cas de malentendus ou d'interprétations erronées résultant de l'utilisation de cette traduction.