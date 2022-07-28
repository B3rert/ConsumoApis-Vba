# ConsumoApis-Vba
El objetivo es construir un proceso capaz de hacer uso de los datos almacenados en una base de datos SQL a través de servicios REST para lograr certificar y anular un DTE independientemente del certificador.

## Arquitectura del proyecto
El proyecto está construido con VBA .NET 4.5, es necesaria esta versión o versiones posteriores para ejecutar el proyecto.

## Configuración
En el archivo web.config agregar la propiedad
```bash
<appSettings>
<add key="serverApi" value="http://localhost:9096/api/"/>
</appSettings>
```
Esta propiedad deberá tener el nombre serverApi y deberá contener la url inicial del servidor donde se encuentran alojados los servicios encargados de obtener el catálogo de apis y todos los datos relacionados.

## Como usar en ambiente de desarrollo
* Clone el repositorio.
* Restaure los paqutes NuGet.

## Diagrama de proceso general
![ConsumoApis](https://user-images.githubusercontent.com/62106542/181526032-5a12678c-f895-44b6-b0d5-c9645e96b801.png)

## Notas
* Es posible que el proyecto no funcione si no cuenta con la base de datos necesaria.
