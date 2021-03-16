# QueuedBackgroundEvents

En este repositorio encontraras una simple WebApi con una implementación de una cola de tareas que se ejecutaran en segundo plano en un BackgroundService.

En la api, durante el hilo de alguna solicitud HTTP, se agrega el evento en la cola.

El evento es representado por una clase cuyo tipo es utilizado para identificar que evento es y para pasar información (payload) al BackgroundService.

Cuando el BackgroundService desencola un evento se busca el handler para ese evento y se ejecuta de forma asincrónica. Para esto se utiliza la librería Mediatr.

Esta implementación es muy útil para ejecutar tareas de larga duración y que no se espere una respuesta de esta.

Me ayude bastante con la siguiente [documentación](https://docs.microsoft.com/aspnet/core/fundamentals/host/hosted-services?view=aspnetcore-5.0&tabs=visual-studio#queued-background-tasks)
 

## TODO:
 - Agregar logging
