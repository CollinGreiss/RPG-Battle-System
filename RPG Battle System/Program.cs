
// Builder Pattern Example
var director = new CharacterDirector();

var warrior = director.Construct(new WarriorBuilder(), "Thor");
warrior.DisplayStats();

var mage = director.Construct(new MageBuilder(), "Gandalf");
mage.DisplayStats();

Console.WriteLine( "\nMoving Warrior..." );

var invoker = new Invoker();
invoker.ExecuteCommand( new MoveCommand( warrior, 5, 10 ) );
warrior.DisplayStats();

