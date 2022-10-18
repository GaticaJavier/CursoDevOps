# CursoDevOps
## Net Core approach
La aplicacion se encuentra dividida en dos containers, uno para la API y el otro para la base de datos (MongoDb).
### API
Primero se debe compilar utilizando el Dockerfile con el siguiente comando: `docker build .`
Para poder crear el container y ejecutar la API debemos ejecutar el siguiente comando: `docker run -d -p 8080:80 --name playersapi playersapp`
Para las posteriores ejecuciones, cuando el container ya se encuentra creado, debemos ejecutar el siguiente comando: `docker start playersapi`

Este es un ejemplo de la respuesta de la API:

![image](https://user-images.githubusercontent.com/114956468/196462605-e7b820ac-b9d7-4e22-8ff4-891c9b1ffc59.png)

### Base de datos[^note]
Para poder crear el container y ejeutar la base de datos debemos ejecutar el siguiente comando: `docker run -d -p 27017:27017 --name players-mongo mongo`
Para las posteriores ejecuciones, cuando el container ya se encuentra cread, debemos ejecutar el siguiente comando: `docker start players-mongo`

[^note]: Para poder descargar la imagen correspondiente a MongoDb debe ejecutar el siguiente comando (previo a los mencionados anteriormente): `docker pull mongo`.
