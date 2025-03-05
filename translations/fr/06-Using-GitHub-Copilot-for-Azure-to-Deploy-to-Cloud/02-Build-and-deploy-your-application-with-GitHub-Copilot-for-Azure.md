# Créer et déployer votre application avec GitHub Copilot pour Azure

Ce module est une continuation du module 1 et fournit un guide pas-à-pas pour utiliser GitHub Copilot pour Azure Preview afin de créer et déployer un nouveau site web sur Azure.

Il met en avant une méthode pour intégrer de manière fluide GitHub Copilot pour Azure dans votre flux de travail de développement et de déploiement.

## Prérequis

Avoir terminé [Module 1 - Premiers pas avec GitHub Copilot pour Azure](./01-Getting-Started-with-GitHub-Copilot-for-Azure.md)

## Créer et déployer un site web en utilisant GitHub Copilot pour Azure Preview

1. Créez un nouveau dossier sur votre ordinateur local où vous pourrez créer un clone local d’un dépôt GitHub.
    1. Dans VS Code, cliquez sur **Fichier**, puis sur "Ouvrir un dossier".
    1. Dans la boîte de dialogue **Ouvrir un dossier**, cliquez sur **Nouveau dossier**, donnez un nom au dossier, sélectionnez-le, puis cliquez sur **Sélectionner un dossier**.

1. VS Code vous demandera **Faites-vous confiance aux auteurs des fichiers dans ce dossier ?**
    1. Cliquez sur **Oui, je fais confiance aux auteurs**.

1. Dans Visual Studio Code, sélectionnez **Affichage** > **Terminal**. Dans le volet terminal, accédez au nouveau dossier.

1. Dans la barre d'état, sélectionnez l'icône **Chat** (GitHub) pour ouvrir le volet de discussion.

1. Démarrez une nouvelle session de discussion en sélectionnant l'icône plus (**+**) dans la barre de titre du volet.

   ![Capture d'écran montrant le volet de discussion GitHub Copilot](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat.png "Démarrer une nouvelle session de discussion")

> Si vous avez fermé le Chat GitHub Copilot après le dernier module, cliquez sur l'icône GitHub dans la barre d'état, en bas à droite de votre écran VS Code. Puis sélectionnez **"GitHub Copilot Chat"** dans le menu des options.
>
> ![Capture d'écran montrant le volet de discussion GitHub Copilot](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat-2.png "Démarrer une nouvelle session de discussion")

6. Dans la zone de texte du chat, tapez l'invite suivante. Ensuite, sélectionnez **Envoyer** (icône d'avion en papier) ou appuyez sur Entrée sur votre clavier.

   ```prompt
   @azure can you help me deploy a C# api with mongodb and a web front end?
   ```

    > **IMPORTANT**
La formulation exacte de la réponse peut varier à chaque fois que GitHub Copilot pour Azure répond, en raison du fonctionnement des modèles de langage.

   Après un moment, GitHub Copilot pour Azure suggérera probablement une commande `azd` template to use.  Or in some cases will provide an answer like the following:

    ![Screenshot that shows the GitHub Copilot chat pane](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat-3.png "Screenshot that shows a response from GitHub Copilot for Azure with instructions for using a template to create a website in Azure.")

    Just Remember that the Large Language Model will understand what you tell it.  Therefore, just have the conversation with it.

1. If the answer provides a command that begins with `azd init` in a code fence, hover over the code fence to reveal a small pop-up action menu.

    ![Screenshot that shows the GitHub Copilot chat pane](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat-4.png "Screenshot that shows a pop-up menu with an option to insert a code-fenced command into the Visual Studio Code terminal.")

    Select **Insert into Terminal** to insert the command into the terminal.

    ![Screenshot that shows the GitHub Copilot chat pane](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat-5.png "Screenshot that shows the Visual Studio Code terminal after insertion of a code-fenced command.")

1. Before you run the `azd init`. Vous pourriez avoir des questions sur son impact sur votre ordinateur local et votre abonnement Azure.

   Utilisez l'invite suivante :

   ```prompt
   @azure Before I execute azd init, what does it do?
   ```

   Vous pourriez voir une réponse ressemblant à la capture d'écran suivante.

   ![Capture d'écran montrant le volet de discussion GitHub Copilot](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat-6.png "Capture d'écran montrant une réponse de GitHub Copilot pour Azure expliquant ce que fait la commande d'initialisation.")

1. Utilisez l'invite suivante pour en savoir plus sur le modèle `azd` :

   ```prompt
   @azure What resources are created with this template?
   ```

   Vous pourriez voir une réponse ressemblant à la capture d'écran suivante.

    ![Capture d'écran montrant le volet de discussion GitHub Copilot](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat-7.png "Capture d'écran montrant une réponse de GitHub Copilot pour Azure expliquant les ressources créées par le modèle suggéré.")

1. Posez des questions sur les services utilisés par le modèle avec une invite comme :

   ```prompt
   @azure What are the capabilities of Azure App Service?
   ```

   Vous pourriez voir une réponse ressemblant à la capture d'écran suivante.

    ![Capture d'écran montrant le volet de discussion GitHub Copilot](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat-8.png "Capture d'écran montrant une réponse de GitHub Copilot pour Azure expliquant les capacités d'Azure App Service.")

1. Une fois satisfait, exécutez l'outil `azd init` command in the terminal. Answer its prompts. If you're unsure what to answer for a prompt, ask GitHub Copilot for Azure for help.

1. Before you can continue, you must authenticate the `azd` en exécutant la commande suivante dans le terminal :

    ```cmd
    azd auth login
    ```

    1. Cela ouvrira un navigateur qui vous demandera de vous authentifier sur Azure. Sélectionnez les mêmes identifiants qu'auparavant.

1. Une fois le nouveau projet initialisé et que vous êtes authentifié sur Azure, utilisez la commande **azd up** pour déployer l'application sur votre abonnement. Dans le terminal, exécutez la commande conformément aux instructions de la réponse de l'invite originale.

    ```
    azd up
    ```

1. La commande `azd up` demande des informations sur votre abonnement, l'emplacement de déploiement des ressources, et d'autres détails.

    Si vous ne savez pas comment répondre, vous pouvez demander de l'aide à GitHub Copilot pour Azure. Par exemple, vous pourriez demander :

    ```prompt
    @azure azd up is asking me what location I want to deploy the website into. How should I respond?
    ```

    Vous pourriez voir une réponse ressemblant à la capture d'écran suivante.

    ![Capture d'écran montrant le volet de discussion GitHub Copilot](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/mod2-CopilotChat-9.png "Capture d'écran montrant une réponse de GitHub Copilot pour Azure expliquant ce que sont les emplacements Azure et comment en choisir un.")

5. Continuez à répondre aux invites de `azd up`. Ask GitHub Copilot for Azure questions as needed.

    1. When asked the location select **Canada East (canadaeast)**.

    Depending on the `azd` template that you're deploying and the location that you selected, the template might take 10 minutes (or more) to deploy. But we can Move on to [Module 3](./03-Get-Answers-to-your-Questions-about-Azure-Services-and-Resources.md) while it completes

1. If `azd up` experiences an error, ask GitHub Copilot for Azure about the error and how you can resolve it.

    > **TIP**
    > For an easy way to attach the last terminal command results, use the paperclip icon at the bottom left of the chat pane. GitHub Copilot for Azure doesn't know the terminal command results unless they are copy/pasted or attached via the paperclip.


1. When you are done run `azd down` pour supprimer toutes les ressources.

**Avertissement** :  
Ce document a été traduit à l'aide de services de traduction automatisée par intelligence artificielle. Bien que nous nous efforcions d'assurer l'exactitude, veuillez noter que les traductions automatisées peuvent contenir des erreurs ou des inexactitudes. Le document original dans sa langue d'origine doit être considéré comme la source faisant autorité. Pour des informations critiques, il est recommandé de recourir à une traduction humaine professionnelle. Nous déclinons toute responsabilité en cas de malentendus ou d'interprétations erronées résultant de l'utilisation de cette traduction.