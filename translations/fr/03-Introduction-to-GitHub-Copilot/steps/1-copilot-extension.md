## Étape 1 : Utiliser Codespaces avec VS Code pour Copilot

_Bienvenue dans "Développez avec des suggestions de code alimentées par l'IA grâce à GitHub Copilot et VS Code"! :wave:_

GitHub Copilot est un copilote de programmation alimenté par l'IA qui vous aide à écrire du code plus rapidement et avec moins d'effort. Il utilise le contexte des commentaires et du code pour suggérer instantanément des lignes individuelles ou des fonctions complètes. GitHub Copilot est propulsé par OpenAI Codex, un modèle de langage génératif pré-entraîné créé par OpenAI.

**Copilot fonctionne avec de nombreux éditeurs de code, y compris VS Code, Visual Studio, JetBrains IDE et Neovim.**

De plus, GitHub Copilot est formé sur tous les langages présents dans les dépôts publics. Pour chaque langage, la qualité des suggestions que vous recevez peut dépendre du volume et de la diversité des données d'entraînement pour ce langage.

Utiliser Copilot dans un Codespace montre à quel point il est facile de commencer à travailler avec la suite d'outils [Collaborative Coding](https://github.com/features#features-collaboration) de GitHub.

> **Note**
> Cet exercice de compétences se concentrera sur l'utilisation de GitHub Codespace. Il est recommandé de compléter la compétence GitHub, [Codespaces](https://github.com/skills/code-with-codespaces), avant de poursuivre cet exercice.

### ⌨️ Activité : Activer Copilot dans un Codespace

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/mastering-github-copilot-for-dotnet-csharp-developers?devcontainer_path=.devcontainer%2Fintroduction%2Fdevcontainer.json)

**Nous vous recommandons d'ouvrir un autre onglet de navigateur pour réaliser les activités suivantes afin de garder ces instructions accessibles pour référence.**

Avant d'ouvrir un Codespace sur un dépôt, vous pouvez créer un conteneur de développement et définir des extensions ou des configurations spécifiques qui seront utilisées ou installées dans votre Codespace. Créons ce conteneur de développement et ajoutons Copilot à la liste des extensions.

1. Notez dans le corps du fichier **.devcontainer/introduction/devcontainer.json** le contenu suivant :
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

Si vous rencontrez des problèmes à tout moment, vous pouvez créer un nouveau Codespace :

1. Revenez à la page d'accueil de votre dépôt en cliquant sur l'onglet **Code** situé en haut à gauche de l'écran.
1. Cliquez sur le bouton **Code** situé au milieu de la page.
1. Cliquez sur l'onglet **Codespaces** dans la boîte qui s'affiche.
1. Cliquez sur le bouton **Create codespace on main** et sélectionnez Introduction to Copilot.

   **Attendez environ 2 minutes que le Codespace se configure.**

1. Vérifiez que votre Codespace fonctionne. Le navigateur devrait afficher un éditeur web basé sur VS Code et un terminal devrait être présent, comme ci-dessous :
   ![Screen Shot 2023-03-09 at 9 09 07 AM](../../../../translated_images/1-skills-0.1c00cff1473d07e185dbb26d6fb869697436c85fbfb7166f9cfc394f08e77776.fr.png)
1. L'extension `copilot` devrait apparaître dans la liste des extensions de VS Code. Cliquez sur l'onglet de la barre latérale des extensions. Vous devriez voir ce qui suit :
   ![Screen Shot 2023-03-09 at 9 04 13 AM](../../../../translated_images/1-skills-1.86911486a2a6c46d5195718017ae3e4e45be73c900914136d779693e75394d3c.fr.png)

Passez à [la Partie 2 de l'Exercice](./2-skills-dotnet.md)

**Avertissement** :  
Ce document a été traduit à l'aide de services de traduction automatisés basés sur l'intelligence artificielle. Bien que nous fassions de notre mieux pour garantir l'exactitude, veuillez noter que les traductions automatiques peuvent contenir des erreurs ou des inexactitudes. Le document original dans sa langue d'origine doit être considéré comme la source faisant autorité. Pour des informations critiques, il est recommandé de recourir à une traduction humaine professionnelle. Nous déclinons toute responsabilité en cas de malentendus ou de mauvaises interprétations résultant de l'utilisation de cette traduction.