<h2>Definition</h2>

<b>The Command Pattern</b> encapsulates a request as an object, thereby letting you parameterize other objects with different requests, queue or log requests, and support undoable operations.
<br />
Sometimes, you don’t want to do execute your functions immediately.

You can use the Command pattern to add work to a queue, to be done later. You can use it to retry, if a command cannot execute properly. You might be able to use this to add “undo” capabilities to a program.

<br />

![alt text](https://github.com/vegasuay/DesignPatterns/blob/master/CommandPattern/images/Diagram1.PNG)

<h2>Parts of the Command Design Pattern</h2>

There are four parts to the Command pattern.

<b>Command:</b> Classes that execute an action (perform a function).

<b>Receiver:</b> Business objects that “receive” the action from the Command.

<b>Invoker:</b> This class tells the Commands to execute their actions. The Invoker can sometimes be a queue (when it holds commands to be executed later), a pool (when it holds commands that can be executed by different programs/computers), or let you do more things with your commands (retry failed commands, undo commands that were executed, etc.)

<b>Client:</b> The main program that uses the other parts.

<h2>Program for a Bank</h2>

We want to deposit money, withdraw money, and do transfers between accounts

<br />

![alt text](https://github.com/vegasuay/DesignPatterns/blob/master/CommandPattern/images/Diagram2.PNG)


<h2>Resumen</h2>

<b>Pattern Name:</b> Command Pattern.<br />
<b>Type:</b> Behavioral pattern.<br />
<b>Used when:</b> Need to implement callback functionalities. Need to support Redo and Undo functionality for commands. Sending requests to different receivers which can handle it in different ways. Need for auditing and logging of all changes via commands. <br />
<b>Ventajas:</b> Encapsular un mensaje como un objeto, con lo que podemos gestionar colas o registros de mensajes y deshacer operaciones. .<br />
<b>Similar pattern:</b> Iterator, Observer.<br />
