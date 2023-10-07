# Mediator Pattern
In this work, through the usage of three Console Apps, Mediator design pattern was discovered. <br><br>
In the future, CQRS using the Mediatr package will also be implemented. <br><br>
Simply choosing the desired project to run and starting it up will work. <br><br>
___
# What Is the Mediator Pattern?
Mediator Pattern is the act of eliminating the dependency of objects from one another using a single Mediator object. <br><br>
The example that Mediator Pattern is usually depicted by is the Planes Problem. <br><br>
This example addresses the landing and takeoff communications of multiple aerial vehicles. Through the usage of a communications tower, <br>
their communications are directly tied to one point and not to one another. Mediator also means Middleman. Duh! <br><br>
The main goal of this system is to centralize dependencies. Instead of having hundreds of different members <br>
communicating with one another; one object is given the responsibility of all dependencies. <br><br>
Perhaps the closest example from game development to it is the Singleton Pattern, also used as the Observer Pattern. <br>
A basic example would be the team a player is in. Even though in a database these would have a middleman-like-table <br>
for the job, when coding the process is easily managed by using a GameManager object.
