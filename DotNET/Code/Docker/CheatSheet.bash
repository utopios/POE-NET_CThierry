# Afficher les indormation sur docker
$ docker info

# Afficher les images docker
$ docker images
$ docker image ls

# Supprimmer une image docker
$ docker rmi <id ou nom> 

# Construire une image
$ docker build -t <nom-de-image> .

# Instancier un conteneur docker
$ docker run -d --name <nom-conteneur> -p 8080:80 <nom-image-source>