namespace Demo
{
    public struct SubCommand : ICommand{
        public void Execute(){
            GameModel.enemyCount.Value--;
        }
    }
}
