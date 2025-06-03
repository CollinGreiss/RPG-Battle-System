public class PartyGroup : Character {

    private readonly List<Character> _members = new List<Character>();
    public string Name { get; }

    public PartyGroup( string name ) {
        Name = name;
    }

    public void Add( Character unit ) => _members.Add( unit );

    public void Remove( Character unit ) => _members.Remove( unit );

    public override void Move( float deltaX, float deltaY ) {

        foreach ( var member in _members ) member.Move( deltaX, deltaY );
        
    }

    public void DisplayStats() {

        Console.WriteLine( $"\nTroupe: {Name}" );
        foreach ( var member in _members ) member.DisplayStats();

    }

}