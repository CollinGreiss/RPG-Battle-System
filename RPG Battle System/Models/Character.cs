
// Basic Character Model for RPG Battle System
class Character {

    public string Name;
    public int Health;
    public int Attack;
    public int Defense;
    public string Class;

    public void DisplayStats() => Console.WriteLine( $"{Name} [{Class}] | HP:{Health} ATK:{Attack} DEF:{Defense}" );

}
