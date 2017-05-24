<h2>Definition</h2>

<b>The Singleton Pattern</b> ensures a class has only one instance, and provides a global point of access to it.

<br />

<h2>The Singleton Pattern class diagram</h2>

![alt text](https://github.com/vegasuay/DesignPatterns/blob/master/AbstractFactoryPattern/images/diagram1.PNG)

<h2>Server Balancer Loader Class Structure</h2>

![alt text](https://github.com/vegasuay/DesignPatterns/blob/master/AbstractFactoryPattern/images/diagram2.PNG)

<h2>Resumen</h2>

<b>Pattern Name:</b> Singleton Factory.<br />
<b>Type:</b> creational pattern.<br />
<b>Used when:</b> Varios clientes distintos precisan referenciar a un mismo elemento y queremos asegurarnos de que no hay más de una instancia de ese elemento. <br />
<b>Ventajas:</b> Ocultar el constructor de la clase Singleton, para que los clientes no puedan crear instancias. Declarar en la clase Singleton una variable miembro privada que contenga la referencia a la instancia única que queremos gestionar. Proveer en la clase Singleton una función o propiedad que brinde acceso a la única instancia gestionada por el Singleton. Los clientes acceden a la instancia a través de esta función o propiedad.<br />
<b>Similar pattern:</b> singleton.<br />
