- **Pour qui est-ce destiné** : Développeurs, ingénieurs DevOps, responsables du développement logiciel, testeurs.  
- **Ce que vous apprendrez** : Exploiter GitHub Copilot pour créer du code et ajouter des commentaires à votre travail.  
- **Ce que vous construirez** : Des fichiers C# contenant du code généré par l'IA Copilot pour des suggestions de code et de commentaires.  
- **Prérequis** : GitHub Copilot est disponible gratuitement, inscrivez-vous sur [GitHub Copilot](https://gh.io/copilot).  
- **Durée** : Ce cours peut être terminé en moins d'une heure.  

À la fin de ce module, vous aurez acquis les compétences nécessaires pour :  

- Découvrir GitHub Codespaces en tant qu'environnement de développement.  
- Développer des routines d'entrée et de sortie dans une application console en C#.  
- Utiliser GitHub Copilot comme assistant.  

## Lecture préalable :  
- [Introduction à l'ingénierie des prompts avec GitHub Copilot](https://learn.microsoft.com/training/modules/introduction-prompt-engineering-with-github-copilot/)  
- [Projet challenge - Créer un mini-jeu avec GitHub Copilot et C#](https://learn.microsoft.com/training/modules/challenge-project-create-mini-game-with-copilot-dotnet/)  

## Exigences  

- Activez votre [service GitHub Copilot](https://github.com/github-copilot/signup)  

## 💪🏽 Exercice  

[![Ouvrir dans GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/mastering-github-copilot-for-dotnet-csharp-developers?devcontainer_path=.devcontainer%2Fmini-game%2Fdevcontainer.json)  

Vous avez déjà appris un peu sur GitHub Codespaces et GitHub Copilot et leur fonctionnement. Dans cet exercice de challenge, votre objectif est de développer un mini-jeu en C# en utilisant GitHub Copilot.  

#### Tester votre GitHub Codespace  

1. Ouvrez l'**Explorateur de solutions**, où vous trouverez un projet nommé **MiniGame**.  
1. Ouvrez `Program.cs`  

1. Exécutez l'application dans l'option **Exécuter et déboguer** ou en haut à droite du fichier Program.cs avec le bouton Play. Vérifiez si le résultat est similaire au message de console suivant :  

   ```bash
   Hello, World!
   ```  

### Créer la logique du jeu  

Maintenant que vous avez vérifié que Codespaces fonctionne avec GitHub Copilot, votre prochaine étape est de développer la logique du mini-jeu C# avec l'aide de GitHub Copilot, en vous basant sur les spécifications suivantes :  

Le gagnant du jeu est déterminé par trois règles simples :  

- **Pierre** bat les ciseaux.  
- **Ciseaux** battent la feuille.  
- **Feuille** bat la pierre.  

#### Considérations sur l'interaction du jeu  

L'ordinateur sera votre adversaire et pourra choisir aléatoirement l'un des éléments (**pierre**, **feuille**, ou **ciseaux**). L'interaction avec le jeu se fera via la console (Terminal).  

- Le joueur peut choisir une des trois options : pierre, feuille ou ciseaux, et doit être averti s'il entre une option invalide.  
- À chaque tour, le joueur doit entrer une des options de la liste et être informé s'il a gagné, perdu ou fait égalité avec l'adversaire.  
- À la fin de chaque tour, le joueur peut choisir de rejouer.  
- Affichez le score du joueur à la fin du jeu.  
- Le mini-jeu doit gérer les saisies utilisateur, les mettre en minuscules et informer l'utilisateur si l'option est invalide.  

Dans votre GitHub Codespaces, suivez les instructions données pour configurer des prompts que GitHub Copilot pourra comprendre et utiliser pour vous aider à construire le mini-jeu. Gardez à l'esprit que GitHub Copilot s'appuie sur les commentaires pour comprendre le contexte et vous fournir des suggestions utiles pendant que vous travaillez sur votre projet.  

#### Vérifiez votre travail  

1. Exécutez le mini-jeu dans la console avec la commande *dotnet run*.  
2. À l'invite, tapez une des options du jeu : *pierre*, *feuille*, ou *ciseaux*.  
3. Le mini-jeu doit informer le joueur s'il a gagné, perdu ou fait égalité avec l'adversaire.  
4. Choisissez de continuer à jouer.  
5. À l'invite, tapez *écran*.  
6. Le mini-jeu doit informer le joueur si l'option entrée est invalide.  
7. Répétez les étapes 2 et 4 pour jouer quelques tours, puis choisissez de ne pas continuer à jouer.  
8. Vérifiez si le mini-jeu se termine et s'il affiche votre score, en vous informant du nombre de victoires et de tours.  

Félicitations pour avoir terminé cet exercice de challenge ! Vous avez créé un mini-jeu console en C# en utilisant GitHub Copilot.  

**Avertissement** :  
Ce document a été traduit à l'aide de services de traduction automatique basés sur l'intelligence artificielle. Bien que nous nous efforcions d'assurer l'exactitude, veuillez noter que les traductions automatisées peuvent contenir des erreurs ou des inexactitudes. Le document original dans sa langue d'origine doit être considéré comme la source faisant autorité. Pour des informations critiques, il est recommandé de recourir à une traduction professionnelle humaine. Nous déclinons toute responsabilité en cas de malentendus ou de mauvaises interprétations résultant de l'utilisation de cette traduction.