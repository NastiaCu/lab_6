# lab_6!
> Anastasia Cunev

> FAF-211

In this laboratory work I tried to make the simulation following the SOLID principles. 

SOLID stands for:
- Single Responsability principle
- Open-Closed principle
- Liskov Subsitution principle
- Interface Segregation principle 
- Dependency Inversion principle


I also tried to implement the MVC pattern in my simulation.

All data and bussines logic is in the Model. The data is transmitted in the Controller. The Controller updates the View and we can see the output. 

I tried to make a simulation of a restaurant, where different classes can make differen actions and that will have an impact on the simulation. For example, I added the rating and the profit of the restaurant, which will change based on such factors as client's level of happiness, number of clients and tables, and number of clients and waiters. If we will have more tables and waiters in our simulation, the rating and profit will be bigger. We can play with the number of waiters, tables and customers and see what will happen.

Class `Person` is the intermediate class, which has the properties for all actors in my system. It also has child classes `HighLevel` and `LowLevel`, which inheritate properties and methods of the class `Person`. 

`HighLevel` is the class parent for the classes, that have a value in the system, such as `Administrator`, `Client` and `Security`. The `LowLevel` class is the class parent for the service stuff such as `Waiter`, `Chief`, `Barman` and `Cleaners`.

To use the polymorphism in this laboratory work I added interfaces, which are implemeted in classes. I used overriding for some methods to make them more speciefic for different classes. Parent class `Person` has a method `speak` which is inherited by all the child classes. I overrided this method for different classes to clearly identify the roles. Also I made a `WhatSalary` method in the `HighLevel` class, which is inherited and overrided in `Administrator` class. Root has a `Menu` child class, which has `Orders` as a child class.

Short description of the system componemts: 

`Waiter` will have methods to `serve the client`, to `take orders`, to `bring the bill` and to `send orders to the chief`.

The `Chief` will have the methods to `cook the meal` and to `send it to the waiter`.

`Barman` has the method to serve drinks.

The `Client` will have the methods to `order` food and drinks and to `pay` for them. Also the client will have the `level of happiness` depending on how satisfied he is of the service or how happy he is because of some drinks. That's why I introduces `Security` and `Administrator` classes, which will help to manage the level of happiness and quietness in the restaurant.

The `Cleaners` will influence client's level of happiness by cleaning the tables.

`Tables` have the raiting, which is randomly distributes. That raiting also influences the client's happiness.

`Menu` class has methods to make menus for main dish, supplies and drinks with prices. It has such functions as `createMain`, `createSup` and `createDrink`.

`Orders` is the class which has such methods as `pickMain`, `pickSup` and `pickDrink`, which create orders randomly. 
