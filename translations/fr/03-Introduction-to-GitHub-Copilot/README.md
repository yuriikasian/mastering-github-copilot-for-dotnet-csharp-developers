<header>

# Introduction à GitHub Copilot

Dans ce module d'apprentissage, nous allons explorer les avantages de l'utilisation de GitHub Copilot, le tout premier outil de développement alimenté par l'IA conçu pour fonctionner à grande échelle. Copilot améliore votre expérience de codage en vous assistant dans des tâches comme les tests, le refactoring, l'explication et la suggestion de code.

GitHub Copilot est un assistant de codage basé sur l'IA qui vous aide à écrire du code plus rapidement et avec moins d'effort, libérant ainsi plus de temps et d'énergie pour la résolution de problèmes et la collaboration.

À la fin de ce module, vous serez non seulement capable d'expliquer ce qu'est GitHub Copilot et ses avantages, mais également de comprendre sa disponibilité pour les particuliers et les entreprises. Vous découvrirez l'avenir de GitHub Copilot et participerez à des exercices pratiques pour maîtriser son utilisation avec Visual Studio Code.

En exploitant Copilot, les développeurs ont pu augmenter leur productivité et accélérer le développement logiciel. Pour en savoir plus, consultez l'article de blog GitHub : [Quantifier l'impact de GitHub Copilot sur la productivité et le bien-être des développeurs.](https://github.blog/2022-09-07-research-quantifying-github-copilots-impact-on-developer-productivity-and-happiness)

Note : Bien que ce module utilise [Codespaces](https://github.com/codespaces), vous pouvez utiliser GitHub Copilot dans divers autres environnements, y compris localement avec Visual Studio Code.
</header>


- **Pour qui** : Développeurs, Ingénieurs DevOps, Managers en développement logiciel, Testeurs.
- **Ce que vous apprendrez** : Comment installer Copilot dans un Codespace, accepter des suggestions de code, accepter des suggestions basées sur des commentaires.
- **Ce que vous construirez** : Des fichiers C# contenant du code généré par l'IA de Copilot pour des suggestions de code et de commentaires.
- **Prérequis** : GitHub Copilot est disponible gratuitement. Inscrivez-vous sur [GitHub Copilot](https://gh.io/copilot).
- **Durée** : Ce cours peut être complété en moins d'une heure.

À la fin de ce module, vous serez capable de :

- Expliquer ce qu'est GitHub Copilot et les avantages qu'il offre.
- Comprendre la disponibilité de GitHub Copilot pour les particuliers et les entreprises.
- Discuter de l'avenir de GitHub Copilot.
- Apprendre à démarrer avec GitHub Copilot et certaines configurations courantes.
- Développer avec GitHub Copilot dans Visual Studio Code grâce à des exercices pratiques.

## Lectures préalables :
- [Introduction à GitHub Copilot](https://learn.microsoft.com/en-us/training/modules/introduction-to-github-copilot/)
- Qu'est-ce que GitHub Copilot ? (Playlist vidéo ci-dessous)
- [![Qu'est-ce que GitHub Copilot](https://img.youtube.com/vi/QG1E0SCqqW8/0.jpg)](https://learn.microsoft.com/shows/introduction-to-github-copilot/what-is-github-copilot-1-of-6/)

### Comment commencer ce cours

[![Ouvrir dans GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/mastering-github-copilot-for-dotnet-csharp-developers?devcontainer_path=.devcontainer%2Fintroduction%2Fdevcontainer.json)

Maintenant que vous avez découvert GitHub Codespaces et GitHub Copilot, passons à l'étape suivante et utilisons Codespaces pour réaliser des laboratoires pratiques avec GitHub Copilot. Faites un clic droit sur **Ouvrir dans GitHub Codespaces** et ouvrez le lien dans un nouvel onglet.

### 🗃️ Leçons
|       |              Lien de la leçon              |                       Concepts enseignés                       |                     Objectif d'apprentissage                 |                             
| :---: | :-----------------------------------------: | :------------------------------------------------------------: | ------------------------------------------------------------ |
| 01 | [Exploiter Codespaces avec VS Code pour Copilot](./steps/1-copilot-extension.md) | Apprenez à configurer et activer GitHub Copilot dans un Codespace en utilisant VS Code en configurant un conteneur de développement et en installant les extensions nécessaires. | Ce guide permet aux développeurs d'exploiter GitHub Codespaces et VS Code pour intégrer et utiliser efficacement GitHub Copilot pour des suggestions de code alimentées par l'IA. |
| 02 | [Voir des suggestions de code IA dans un fichier C#!](./steps/2-skills-dotnet.md) | Configurer un Codespace avec GitHub Copilot, créer un projet C#, utiliser Copilot pour des suggestions de code, et pousser du code dans un dépôt en utilisant Git. | Familiarisez-vous avec les suggestions de code alimentées par l'IA de GitHub Copilot en C# en créant un projet .NET, en générant des complétions de code et en poussant les modifications dans un dépôt avec Git. | 
| 03 | [Afficher l'onglet GitHub Copilot avec plusieurs suggestions](./steps/3-copilot-hub.md) | Apprenez à utiliser GitHub Copilot pour des suggestions de code alimentées par l'IA en C#, gérer un Codespace, récupérer le code le plus récent, créer et modifier des fichiers, examiner les complétions de code générées par l'IA, et pousser les modifications dans un dépôt Git à l'aide de commandes dans VS Code. | Familiarisez-vous avec les suggestions de code de GitHub Copilot, apprenez à examiner et accepter les complétions générées par l'IA, et gérez les modifications de code dans un Codespace GitHub à l'aide des commandes Git. | 
| 04 | [Utiliser des commentaires pour générer du code avec Copilot](./steps/4-copilot-comment.md) | Comprendre comment utiliser GitHub Copilot pour générer du code à partir de commentaires, naviguer dans les suggestions de Copilot, et gérer le versioning du code avec des commandes Git dans un environnement Codespace. | Utiliser des commentaires pour générer du code suggéré par l'IA avec GitHub Copilot dans VS Code. | 


## 📚 Ressources et apprentissages supplémentaires

- [Qu'est-ce que GitHub Copilot](https://docs.github.com/en/copilot/about-github-copilot/what-is-github-copilot)
- [À propos des comptes entreprise pour Copilot Business](https://docs.github.com/en/enterprise-cloud@latest/admin/copilot-business-only/about-enterprise-accounts-for-copilot-business)
- [Commencer avec Copilot](https://docs.github.com/en/copilot/getting-started-with-github-copilot/getting-started-with-github-copilot-in-visual-studio-code)
- [Configurer les paramètres de Copilot](https://docs.github.com/en/copilot/configuring-github-copilot/configuring-github-copilot-settings-on-githubcom)

### Et après ?

- [Nous aimerions connaître votre avis sur ce cours](https://github.com/orgs/skills/discussions/categories/code-with-copilot).
- [Apprenez une autre compétence GitHub](https://github.com/skills).
- [Consultez la documentation pour démarrer avec GitHub](https://docs.github.com/en/get-started).
- Pour trouver des projets auxquels contribuer, explorez [GitHub Explore](https://github.com/explore).
   
<footer>

---

Obtenez de l'aide : [Publiez sur notre forum de discussion](https://github.com/orgs/skills/discussions/categories/code-with-copilot) • [Consultez la page d'état de GitHub](https://www.githubstatus.com/)

**Avertissement** :  
Ce document a été traduit à l'aide de services de traduction basés sur l'intelligence artificielle. Bien que nous nous efforcions d'assurer l'exactitude, veuillez noter que les traductions automatisées peuvent contenir des erreurs ou des inexactitudes. Le document original dans sa langue d'origine doit être considéré comme la source faisant autorité. Pour des informations critiques, il est recommandé de recourir à une traduction humaine professionnelle. Nous déclinons toute responsabilité en cas de malentendus ou d'interprétations erronées résultant de l'utilisation de cette traduction.