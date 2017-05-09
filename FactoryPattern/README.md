<h2>Definition</h2>

<b>The Simple Factory Pattern</b> isn´t actually a design pattern, it´s more of a programming idiom.

<br />

<h2>The Simple Factory Pattern class diagram</h2>

![alt text](https://github.com/vegasuay/DesignPatterns/blob/master/FactoryPattern/images/diagram3.PNG)

<h2>What Problem Factory Solve</h2>

![alt text](https://github.com/vegasuay/DesignPatterns/blob/master/FactoryPattern/images/diagram1.PNG)

<h2>The Pizza Store</h2>

![alt text](https://github.com/vegasuay/DesignPatterns/blob/master/FactoryPattern/images/diagram5.PNG)

<h2>Resumen</h2>

<b>Pattern Name:</b> Decorator.<br />
<b>Type:</b> structural pattern.<br />
<b>Used when:</b> necesitamos añadir funcionalidades a una clase de forma dinámica, evitando las jerarquías de clases que se tienen construir en tiempo de compilación.<br />
<b>Ventajas:</b> podemos añadir responsabilidades a un objeto de forma progresiva y dinámica. Más flexibilidad que con la herencia.<br />
<b>Desventajas:</b> la principal es que el objeto Decorator no es exactamente igual que la clase que está decorando, por lo que tenemos que tener cuidado. Además nos podemos encontrar con un diseño de clases muy pequeñas, pero en gran cantidad.<br />
<b>Similar pattern:</b> Adapter o Facade.<br />
