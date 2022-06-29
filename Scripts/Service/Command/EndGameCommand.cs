namespace Demo
{
    public struct EndGameCommand : ICommand{
        public void Execute(){
            GameModel.State = GameState.OVER;
            GameOverEvent.Trigger();
        }
    }
}
