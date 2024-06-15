# Banco 💎

## `Descripción`
Banco es una solución de software diseñada para la gestión integral de operaciones bancarias. Esta solución sigue una arquitectura de microservicios para promover la escalabilidad y el mantenimiento eficiente.

## `Componentes`

- **Banco.Api**: Sirve como la interfaz principal para las interacciones con el cliente, procesando las solicitudes y respuestas entre el usuario y los servicios del banco.
- **Banco.Application**: Contiene la lógica de negocio central y las operaciones del banco. Es el núcleo que procesa las transacciones y mantiene las reglas del negocio.
- **Banco.Domain**: Define los objetos de dominio y las reglas de negocio que representan las entidades bancarias fundamentales como cuentas, transacciones y clientes.
- **Banco.Infrastructure**: Proporciona la implementación técnica necesaria para conectar con bases de datos, servicios externos y otras integraciones necesarias para el funcionamiento del banco.
- **Banco.Web**: Es la capa de presentación que proporciona la interfaz de usuario para interactuar con los servicios bancarios a través de un navegador web.
- **Banco.WebApi**: Expone los servicios web del banco, permitiendo la integración con otras aplicaciones y servicios a través de APIs.

## `Uso`
Para comenzar a utilizar los proyectos, clona el repositorio y abre `Banco.sln` en Visual Studio. Configura las cadenas de conexión y cualquier otra configuración específica antes de ejecutar la solución.

## `Contribuir`
Las contribuciones son bienvenidas. Por favor, lee `CONTRIBUTING.md` para más detalles sobre cómo contribuir al proyecto.

## `Licencia`
Este proyecto está bajo la licencia MIT. Consulta el archivo `LICENSE.md` para más detalles.
