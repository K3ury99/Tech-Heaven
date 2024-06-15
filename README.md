# TechHeaven 💻

## `Descripción`
TechHeaven es una plataforma de comercio electrónico diseñada para la venta en línea de productos tecnológicos. Esta solución sigue una arquitectura de microservicios para promover la escalabilidad y el mantenimiento eficiente.

## `Componentes`

- **Tienda.Api**: Sirve como la interfaz principal para las interacciones con el cliente, procesando las solicitudes y respuestas entre el usuario y los servicios de la tienda.
- **Tienda.Application**: Contiene la lógica de negocio central y las operaciones de la tienda. Es el núcleo que procesa las órdenes y mantiene las reglas del negocio.
- **Tienda.Domain**: Define los objetos de dominio y las reglas de negocio que representan las entidades fundamentales como productos, órdenes y clientes.
- **Tienda.Infrastructure**: Proporciona la implementación técnica necesaria para conectar con bases de datos, servicios externos y otras integraciones necesarias para el funcionamiento de la tienda.
- **Tienda.Web**: Es la capa de presentación que proporciona la interfaz de usuario para interactuar con los servicios de la tienda a través de un navegador web.
- **Tienda.Ioc**: Gestiona las dependencias e inyecciones de control entre los diferentes componentes y servicios del proyecto.

## `Uso`
Para comenzar a utilizar los proyectos, clona el repositorio y abre `TechHeaven.sln` en Visual Studio. Configura las cadenas de conexión y cualquier otra configuración específica antes de ejecutar la solución.

## `Contribuir`
Las contribuciones son bienvenidas. Por favor, lee `CONTRIBUTING.md` para más detalles sobre cómo contribuir al proyecto.

## `Licencia`
Este proyecto está bajo la licencia MIT. Consulta el archivo `LICENSE.md` para más detalles.
