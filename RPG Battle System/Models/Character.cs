
// Basic Character Model for RPG Battle System
using System.Numerics;

public class Character {

    public string Name;
    public int Health;
    public int Attack;
    public int Defense;
    public string Class;
    public Vector2 Position { get; private set; }

    public virtual void Move( float deltaX, float deltaY ) {
        Position = new Vector2( Position.X + deltaX, Position.Y + deltaY );
    }

    public void DisplayStats() => Console.WriteLine( $"{Name} [{Class}] | HP:{Health} ATK:{Attack} DEF:{Defense} X:{Position.X} Y:{Position.Y}" );

}
