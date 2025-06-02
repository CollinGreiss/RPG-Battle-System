class WarriorBuilder : ICharacterBuilder {

    private Character _character = new Character();

    public void SetName( string name ) => _character.Name = name;
    public void SetClass() => _character.Class = "Warrior";
    public void SetStats() {

        _character.Health = 150;
        _character.Attack = 25;
        _character.Defense = 10;

    }

    public Character GetResult() => _character;

}