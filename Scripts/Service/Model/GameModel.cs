namespace Demo{

    public enum GameState {
        LOADED,
        STARTED,
        PAUSED,
        OVER
    }
    public static class GameModel
    {
        public static GameState State = GameState.LOADED;
        public static BindableProperty<int> enemyCount = new BindableProperty<int>() {Value = 0};
    }
}