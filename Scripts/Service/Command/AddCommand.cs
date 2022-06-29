namespace Demo
{
    public struct AddCommand : ICommand{
        public void Execute(){
            GameModel.enemyCount.Value++;
        }
    }
}
