public class MoveCommand : ICommand {

    private readonly Character _character;
    private readonly int _deltaX;
    private readonly int _deltaY;

    public MoveCommand( Character character, int deltaX, int deltaY ) {

        _character = character;
        _deltaX = deltaX;
        _deltaY = deltaY;

    }

    public void Execute() {
        _character.Move( _deltaX, _deltaY );
    }

}