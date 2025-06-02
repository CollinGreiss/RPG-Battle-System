class CharacterDirector {

    public Character Construct( ICharacterBuilder builder, string name ) {

        builder.SetName( name );
        builder.SetClass();
        builder.SetStats();

        return builder.GetResult();

    }

}