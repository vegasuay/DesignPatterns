<h2>Definition</h2>

<b>The Factory Method Pattern</b> defines an interface for creating an object, but lets subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.

<br />

<h2>The Factory Method Pattern class diagram</h2>

![alt text](https://github.com/vegasuay/DesignPatterns/blob/master/FactoryMethodPattern/images/diagram1.PNG)

<h2>The Pizza Store Class Structure</h2>

![alt text](https://github.com/vegasuay/DesignPatterns/blob/master/FactoryPattern/images/diagram5.PNG)

![alt text](https://github.com/vegasuay/DesignPatterns/blob/master/FactoryMethodPattern/images/diagram2.PNG)

![alt text](https://github.com/vegasuay/DesignPatterns/blob/master/FactoryMethodPattern/images/diagram3.PNG)

<h2>Resumen</h2>

<b>Pattern Name:</b> Factory Method.<br />
<b>Type:</b> creational pattern.<br />
<b>Used when:</b> Una clase no puede anticipar el tipo de objeto que debe crear y quiere que sus subclases especifiquen dichos objetos.
Hay clases que delegan responsabilidades en una o varias subclases. Una aplicación es grande y compleja y posee muchos patrones creacionales.<br />
<b>Ventajas:</b> elimina la necesidad de introducir clases específicas en el código del creador. Solo maneja la interfaz Product, por lo que permite añadir cualquier clase ConcretProduct definida por el usuario.<br />
<b>Similar pattern:</b> singleton.<br />
