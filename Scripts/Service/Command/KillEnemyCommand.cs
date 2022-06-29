namespace Demo
{
    public struct KillEnemyCommand : ICommand{
        public void Execute(){
            new SubCommand().Execute();
            if(GameModel.enemyCount.Value == 0){
                GameOverEvent.Trigger();
            }
        }
    }
}
