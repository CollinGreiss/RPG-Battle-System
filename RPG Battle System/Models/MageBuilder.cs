class MageBuilder : ICharacterBuilder {

    private Character _character = new Character();

    public void SetName( string name ) => _character.Name = name;
    public void SetClass() => _character.Class = "Mage";
    public void SetStats() {

        _character.Health = 50;
        _character.Attack = 75;
        _character.Defense = 0;

    }

    public Character GetResult() => _character;

}