<h2>Definition</h2>

The Decorator Pattern attaches additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.

<br />

<h2>The Decorator Pattern class diagram</h2>

![alt text](https://github.com/vegasuay/DesignPatterns/blob/master/DecoratorPattern/diagram1.PNG)

<h2>The Startbuzz Coffe</h2>

![alt text](https://github.com/vegasuay/DesignPatterns/blob/master/DecoratorPattern/diagram2.PNG)

![alt text](https://github.com/vegasuay/DesignPatterns/blob/master/DecoratorPattern/diagram3.PNG)

<h2>Resumen</h2>

Pattern Name: Decorator.<br />
Type: structural pattern.<br />
Used when: necesitamos añadir funcionalidades a una clase de forma dinámica, evitando las jerarquías de clases que se tienen construir en tiempo de compilación.<br />
Ventajas: podemos añadir responsabilidades a un objeto de forma progresiva y dinámica. Más flexibilidad que con la herencia.<br />
Desventajas: la principal es que el objeto Decorator no es exactamente igual que la clase que está decorando, por lo que tenemos que tener cuidado. Además nos podemos encontrar con un diseño de clases muy pequeñas, pero en gran cantidad.<br />
Patrones similares o relacionados: Adapter o Facade.<br />
