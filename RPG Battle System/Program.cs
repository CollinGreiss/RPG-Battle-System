
// Builder Pattern Example
var director = new CharacterDirector();

var warrior = director.Construct(new WarriorBuilder(), "Thor");
warrior.DisplayStats();

var mage = director.Construct(new MageBuilder(), "Gandalf");
mage.DisplayStats();

