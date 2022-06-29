namespace Demo
{
    public struct StartGameCommand : ICommand{
        public void Execute(){
            GameModel.State = GameState.STARTED;
            GameStartEvent.Trigger();
        }
    }
}
