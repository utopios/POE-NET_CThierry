## Exécuter une image Docker
docker run <CONTAINER_ID ou CONTAINER_NAME>
    # -t ou --tty : Allouer un pseudo TTY
    # --interactive ou -i : Garder un STDIN ouvert
    # --detach ou -d : Exécuter le conteneur en arrière-plan
    # --name : Attribuer un nom au conteneur
    # --expose: Exposer un port ou une plage de ports
    # -p ou --publish : Mapper un port  "<PORT_CIBLE:PORT_SOURCE>"
    # --rm : Supprimer automatiquement le conteneur quand on le quitte

## Lister des conteneurs en état running Docker
docker container ls
# ou
docker ps
    #-a ou --all : Afficher tous les conteneurs peut-importe leur état

## Supprimer un conteneur Docker
docker rm <CONTAINER_ID ou CONTAINER_NAME>
    # -f ou --force : forcer la suppression

## Supprimer tous les conteneurs Docker
docker rm -f $(docker ps -aq)

## Exécuter une commande dans un conteneur Docker
docker exec <CONTAINER_ID ou CONTAINER_NAME> <COMMAND_NAME>
    # -t ou --tty : Allouer un pseudo TTY
    # -i ou --interactive : Garder un STDIN ouvert
    # -d ou --detach : lancer la commande en arrière plan

## sorties/erreurs d'un conteneur
docker logs <CONTAINER_ID ou CONTAINER_NAME>
    # -f : suivre en permanence les logs du conteneur
    # -t : afficher la date et l'heure de la réception de la ligne de log
    # --tail <NOMBRE DE LIGNE> = nombre de lignes à afficher à partir de la fin (par défaut "all")


## Transformer un conteneur en image
docker commit <CONTAINER_NAME ou CONTAINER_ID> <NEW IMAGENAME>
    # -a ou --author <string> : Nom de l'auteur (ex "John Hannibal Smith <hannibal@a-team.com>")
    # -m ou --message <string> : Message du commit