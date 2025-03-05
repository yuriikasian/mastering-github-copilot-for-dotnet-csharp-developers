## Étape 2 : Voir les suggestions de code AI dans un fichier C# !

_Bien joué ! :tada: Vous avez créé un Codespace en utilisant un fichier devcontainer qui a installé Copilot !_

GitHub Copilot fournit des suggestions pour de nombreux langages et une grande variété de frameworks, mais fonctionne particulièrement bien avec Python, JavaScript, TypeScript, Ruby, Go, C# et C++. Les exemples suivants sont en C#, mais les autres langages fonctionneront de manière similaire.

Essayons cela en utilisant C# pour Copilot.

> **Note** :
> Si vous avez fermé le Codespace précédent, veuillez le rouvrir ou en créer un nouveau.

### ⌨️ Activité : Ajouter un fichier C# et commencer à écrire du code

> **Note** :
> Assurez-vous d’ouvrir l’**Explorateur de solutions** pour avoir une vue organisée et ajouter facilement de nouveaux projets, puis les exécuter.

1. Créez un nouveau projet .NET en utilisant la commande `.NET: New Project...` et en sélectionnant `Console App`.  
1. Sélectionnez le dossier **code** et nommez le projet **Skills**.  
1. Ouvrez `Program.cs`.  
1. Vérifiez que votre nouveau fichier ressemble à ceci :  
   ![VS code avec un nouveau Program.cs](../../../../03-Introduction-to-GitHub-Copilot/steps/img/2-skills-dotnet-0.png)

1. Dans le fichier `Program.cs`, supprimez tout code existant, puis tapez l’en-tête de fonction suivant.

   ```csharp
   void CalculateNumbers(int var1, int var2)
   {
   ```

   GitHub Copilot suggérera automatiquement un corps de fonction complet en texte grisé. Voici un exemple de ce que vous verrez probablement, mais la suggestion exacte peut varier.  
   ![VS Code avec des suggestions](../../../../03-Introduction-to-GitHub-Copilot/steps/img/2-skills-dotnet-1.png)

5. Appuyez sur `Tab` pour accepter la suggestion.

### ⌨️ Activité : Pousser le code vers votre dépôt depuis le Codespace

Utilisons GitHub Copilot pour résumer nos modifications, puis valider le code.

1. Ouvrez l’onglet **Source Control**.  
2. Cliquez sur le bouton ✨ dans le champ **Message** pour que Copilot génère votre message.  

![Onglet Commit ouvert pour générer un message avec Copilot](../../../../03-Introduction-to-GitHub-Copilot/steps/img/2-skills-commit.png)

3. Cliquez sur le bouton **Commit**.

Rendez-vous à la [Partie 3 de l'exercice](./3-copilot-hub.md)

**Avertissement** :  
Ce document a été traduit à l'aide de services de traduction automatique basés sur l'intelligence artificielle. Bien que nous nous efforcions d'assurer l'exactitude, veuillez noter que les traductions automatisées peuvent contenir des erreurs ou des inexactitudes. Le document original dans sa langue d'origine doit être considéré comme la source faisant autorité. Pour des informations critiques, il est recommandé de recourir à une traduction humaine professionnelle. Nous déclinons toute responsabilité en cas de malentendus ou d'interprétations erronées découlant de l'utilisation de cette traduction.