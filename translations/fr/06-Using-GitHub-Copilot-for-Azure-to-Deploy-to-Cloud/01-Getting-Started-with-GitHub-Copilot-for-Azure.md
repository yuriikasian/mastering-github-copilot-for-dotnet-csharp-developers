# Prise en main avec GitHub Copilot pour Azure

Optimisez votre flux de travail et augmentez votre productivité grâce à GitHub Copilot pour Azure Preview. Ce guide rapide vous explique tout ce que vous devez savoir, depuis la préparation des prérequis jusqu'à l'installation de l'extension GitHub Copilot pour Azure dans Visual Studio Code. À la fin, vous serez prêt à créer votre première requête et à exploiter pleinement le potentiel de la plateforme Azure.

![GitHub Copilot pour Azure](../../../06-Using-GitHub-Copilot-for-Azure-to-Deploy-to-Cloud/images/intro.gif "GitHub Copilot pour Azure")

- **À qui s'adresse ce guide** : Développeurs, équipes IT (ITPRO) et ingénieurs en IA.  
- **Ce que vous apprendrez** : Les étapes pour configurer GitHub Copilot pour Azure.  
- **Ce que vous allez réaliser** : Configurer un espace de travail optimisé par l'IA en toute confiance.  

## Lecture préalable :
- [Qu'est-ce que GitHub Copilot pour Azure Preview ?](https://learn.microsoft.com/azure/developer/github-copilot-azure/introduction)

## 👉 Prérequis

Pour suivre les étapes de ce laboratoire, assurez-vous de disposer de :

1. Un compte Azure et un accès à un abonnement Azure. Pour savoir comment les configurer, consultez la [page des tarifs pour les comptes Azure.](https://azure.microsoft.com/pricing/purchase-options/azure-account)

1. Un compte GitHub. Les étapes pour en créer un se trouvent ici : [Créer un compte GitHub](https://docs.github.com/en/get-started/start-your-journey/creating-an-account-on-github)

1. Un abonnement à GitHub Copilot. Les détails pour activer GitHub Copilot sont disponibles ici : [Guide de démarrage rapide pour GitHub Copilot](https://docs.github.com/en/copilot/quickstart)

1. Visual Studio Code. Pour savoir comment le télécharger et l'installer, consultez [Configurer Visual Studio Code.](https://code.visualstudio.com/docs/setup/setup-overview)

1. L'extension GitHub Copilot et l'extension GitHub Copilot Chat. Pour des instructions sur leur installation, consultez [Configurer GitHub Copilot dans VS Code.](https://marketplace.visualstudio.com/items?itemName=GitHub.copilot)

## 💪🏽 Exercice

### 🛠 Étape 1 : Authentifiez-vous sur GitHub et connectez-vous à GitHub Copilot Chat pour activer Copilot pour Azure Preview

1. En ouvrant VS Code, sur la partie droite, cliquez sur **"Se connecter avec un compte GitHub.com"**.

    1. Visual Studio Code affichera un message demandant **"L'extension 'GitHub Copilot Chat' souhaite se connecter à l'aide de GitHub."** Cliquez sur **Autoriser**.

    1. Vous devrez autoriser Visual Studio Code à continuer avec l'utilisateur connecté. Cliquez sur le bouton **Continuer**.

    1. Finalisez l'autorisation en cliquant sur le bouton **Autoriser Visual-Studio-Code**.

    1. Un message contextuel vous demandera d'ouvrir VS Code. Cliquez sur **Ouvrir**. Vous serez renvoyé à VS Code, où vous serez authentifié sur GitHub et aurez accès à **GitHub Copilot**.

1. Dans Visual Studio Code, sélectionnez l'icône **Extensions**.

1. Vérifiez que vous avez les extensions suivantes installées :
    1. **Azure Tools**  
    1. **GitHub Copilot**  
    1. **GitHub Copilot Chat**  
    1. **GitHub Copilot pour Azure**  
    1. **C# Dev Kit**

1. Si l'une d'entre elles manque, installez-la depuis le marketplace.

### ✍️ Étape 2 : Rédigez votre première requête

1. Maintenant que les extensions sont installées, que vous êtes correctement authentifié et que l'extension fonctionne correctement.

1. Dans la barre d'activité, sélectionnez l'icône **Chat** si le panneau **Ask Copilot** est fermé.

1. Dans la zone de texte en bas du panneau de chat, entrez la requête suivante :

```prompt
@azure Do I have any resources currently running?
```

> Dans la section suivante, il vous sera demandé d'autoriser plusieurs fois des applications et des services. Cela est fait pour votre protection et ne sera effectué qu'une seule fois. Nous autorisons **GitHub**, **VS Code** et **Azure** à faire confiance aux requêtes avec les informations d'identification fournies.

1. Vous pourriez recevoir un message dans le panneau GitHub Copilot Chat indiquant "vous devez vous connecter avec votre compte Microsoft pour utiliser GitHub Copilot pour Azure (@Azure)".

    1. Si c'est le cas, cliquez sur le lien dans la ligne **"Vous avez déjà un compte ? Connectez-vous"**.  
    1. Visual Studio Code affichera un message demandant **"L'extension 'GitHub Copilot pour Azure' souhaite se connecter à l'aide de Microsoft."** Cliquez sur **Autoriser**.  
    1. Connectez-vous en utilisant les informations d'identification de la session existante ou celles trouvées dans l'onglet Ressources des instructions du laboratoire. Les mêmes informations que pour les abonnements Azure.  
    1. Fermez l'onglet, mais pas le navigateur.  
    1. Retournez à VS Code. Visual Studio Code affichera un message demandant **"L'extension 'GitHub Copilot pour Azure' souhaite accéder aux modèles de langage fournis par GitHub Copilot Chat."** Cliquez sur **Autoriser**.  
    1. Visual Studio Code affichera un autre message demandant **"L'extension 'GitHub Copilot pour Azure' souhaite se connecter à l'aide de GitHub."** Cliquez à nouveau sur **Autoriser**.  
        1. Vous devrez autoriser Visual Studio Code à continuer avec l'utilisateur connecté. Cliquez sur le bouton **Continuer**.  
        1. Finalisez l'autorisation en cliquant sur le bouton **Autoriser Visual-Studio-Code**.  
        1. Un message contextuel vous demandera d'ouvrir VS Code. Cliquez sur **Ouvrir**. Vous serez renvoyé à VS Code, où vous serez authentifié sur GitHub et aurez accès à **GitHub Copilot**.

1. L'extension Copilot pour Azure interrogera le graphe des ressources Azure, vous fournira la requête de ressource et affichera la réponse. À ce stade, cela devrait être **Vous n'avez actuellement aucune ressource en cours d'exécution dans vos abonnements.**

### Conclusion

Félicitations, grâce à cet exercice, vous avez configuré VS Code pour utiliser GitHub Copilot pour Azure et vous l'avez interrogé pour savoir si des ressources sont actives dans votre abonnement Azure.

**Avertissement** :  
Ce document a été traduit à l'aide de services de traduction basés sur l'intelligence artificielle. Bien que nous nous efforcions d'assurer l'exactitude, veuillez noter que les traductions automatisées peuvent contenir des erreurs ou des inexactitudes. Le document original dans sa langue d'origine doit être considéré comme la source faisant autorité. Pour des informations critiques, il est recommandé de faire appel à une traduction humaine professionnelle. Nous déclinons toute responsabilité en cas de malentendus ou d'interprétations erronées résultant de l'utilisation de cette traduction.