
// Builder Pattern Example
var director = new CharacterDirector();

var warrior = director.Construct(new WarriorBuilder(), "Thor");
warrior.DisplayStats();

var warrior2 = director.Construct(new WarriorBuilder(), "Odin");
warrior.DisplayStats();

var mage = director.Construct(new MageBuilder(), "Gandalf");
mage.DisplayStats();

var mage2 = director.Construct(new MageBuilder(), "Loki");
mage.DisplayStats();




Console.WriteLine( "\nMoving Warrior..." );

var invoker = new Invoker();
invoker.ExecuteCommand( new MoveCommand( warrior, 5, 10 ) );
warrior.DisplayStats();

invoker.ExecuteCommand( new MoveCommand( warrior2, -3, 4 ) );
warrior2.DisplayStats();


Console.WriteLine( "\nCreating Group Asgard..." );

var asgard = new PartyGroup( "Asgard" );
asgard.Add( warrior );
asgard.Add( warrior2 );
asgard.Add( mage2 );

asgard.DisplayStats();



Console.WriteLine( "\nMoving Asgard..." );

invoker.ExecuteCommand( new MoveCommand( asgard, 3, -2 ) );
asgard.DisplayStats();