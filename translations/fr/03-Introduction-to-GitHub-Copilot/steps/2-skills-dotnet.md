## Étape 2 : Voir les suggestions de code AI dans un fichier C# !

_Bien joué ! :tada: Vous avez créé un Codespace à l'aide d'un fichier devcontainer qui a installé Copilot !_

GitHub Copilot propose des suggestions pour de nombreux langages et une grande variété de frameworks, mais fonctionne particulièrement bien avec Python, JavaScript, TypeScript, Ruby, Go, C# et C++. Les exemples suivants sont en C#, mais les autres langages fonctionneront de manière similaire.

Essayons cela en utilisant C# avec Copilot.

> **Note** :
> Si vous avez fermé le Codespace ci-dessus, veuillez le rouvrir ou en créer un nouveau.

### ⌨️ Activité : Ajouter un fichier C# et commencer à coder

> **Note** :
> Assurez-vous d'ouvrir l'**Explorateur de solutions** pour voir une vue organisée afin d'ajouter facilement de nouveaux projets et de les exécuter.

1. Créez un nouveau projet .NET en utilisant la commande `.NET: New Project...` et en sélectionnant `Console App`.
1. Sélectionnez le dossier **code** et nommez le projet **Skills**.
1. Ouvrez `Program.cs`
1. Vérifiez que votre nouveau fichier ressemble à ceci :
   ![VS code avec un nouveau Program.cs](../../../../translated_images/2-skills-dotnet-0.7dee6cf1b3d7c8ea2b24bc26157d342f8611dee7fd6887a15e9a0b17735da2b0.fr.png)

1. Dans le fichier `Program.cs`, supprimez tout code existant et tapez l'en-tête de fonction suivant.

   ```csharp
   void CalculateNumbers(int var1, int var2)
   {
   ```

   GitHub Copilot suggérera automatiquement un corps de fonction complet en texte grisé. Voici un exemple de ce que vous verrez probablement, bien que la suggestion exacte puisse varier.
   ![VS Code avec des complétions](../../../../translated_images/2-skills-dotnet-1.eb8d703219b8ff9ab5530aa74a9475a80ccbaf81be7cea04f3fc460431789f99.fr.png)

5. Appuyez sur `Tab` pour accepter la suggestion.

### ⌨️ Activité : Pousser du code dans votre dépôt depuis le Codespace

Utilisons GitHub Copilot pour résumer nos modifications et ensuite valider le code.

1. Ouvrez l'onglet **Source Control**.
2. Cliquez sur le bouton ✨ dans le champ **Message** pour que Copilot génère votre message.

![Onglet Commit ouvert pour générer un message avec Copilot](../../../../translated_images/2-skills-commit.a21070faad74ea7fda9187f6f246c0dedc9bfc02d1c89dfe0554c9f0b28f2994.fr.png)

3. Cliquez sur le bouton **Commit**.

Rendez-vous à la [Partie 3 de l'exercice](./3-copilot-hub.md)

**Avertissement** :  
Ce document a été traduit à l'aide de services de traduction automatisée basés sur l'intelligence artificielle. Bien que nous fassions de notre mieux pour garantir l'exactitude, veuillez noter que les traductions automatisées peuvent contenir des erreurs ou des inexactitudes. Le document original dans sa langue d'origine doit être considéré comme la source faisant autorité. Pour des informations critiques, il est recommandé de recourir à une traduction humaine professionnelle. Nous déclinons toute responsabilité en cas de malentendus ou d'interprétations erronées résultant de l'utilisation de cette traduction.