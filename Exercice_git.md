# Mémo git utilisation simple : 
- Créer un repo sur github (nommez le comme vous voulez) pensez à mettre cocher la case Ajouter un Readme
- Cloner ce repo en local avec la commande git clone. N'oubliez pas le espace point.
``` git clone CopierCollerDuLienIci . ```
- Ajoutez un nouveau fichier avec le contenu que vous voulez
``` echo "Contenu a ajouter" > nomfichier.extension ```
- Ajoutez un fichier .gitignore (vide pour l'instant, l'objectif est d'y mettre les éléments qui ne doivent pas être envoyés sur le repo public. Fichier d'environnement avec les variables, dossier / fichier de build et medias (vidéos, images,...))
``` echo "" > .gitignore ```
- Vérifier le statut du répertoire local (états des fichiers)
``` git status ```
- Voir l'historique des commits (Si vous avez pris les alias, faites git lg)
``` git log --oneline --graph --all ```
- Utiliser la commande add puis commit avec un message. (git add . | git commit -m "Message")
``` git add . ```
``` git commit -m "Message" ```
- Enfin, utiliser la commande git push pour envoyer sur le repertoire distant (git push origin main)
``` git push origin main ```
- Pour mettre à jour notre local par rapport au distant 
``` git remote update ```
- Pour récupérer la version du repo distant (github) en local 
``` git pull origin main ```
