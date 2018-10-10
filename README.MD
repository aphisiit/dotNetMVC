# Readme
## Update Project package
```sh
$ dotnet restore
```
## Run project
```sh
$ dotnet run
```
## Build Project
```sh
$ dotnet build
```
## Release Project
```sh
$ dotnet publish -f netcoreapp2.1 -c Releas
```
## Create docker image
```sh
$ docker build -t dotnetapi:v1 .
```
## Run docker image
```sh
$ docker run -it -p 8080:80 --name dotnetapi -d dotnetapi:v1
```