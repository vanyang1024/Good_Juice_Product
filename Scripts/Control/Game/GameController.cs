using UnityEngine;

namespace Demo
{
    public class GameController : MonoBehaviour
    {
        private void Awake(){
            GameStartEvent.Register(OnGameStart);
        }

        private void OnGameStart(){
            if (GameModel.enemyCount.Value == 0) {
                new EndGameCommand().Execute();
            } else {
                for (int i=0;i<GameModel.enemyCount.Value;i++){
                    transform.Find("Enemies").GetChild(i).gameObject.SetActive(true);
                }
            }
        
        }
        private void OnDestroy(){
            GameStartEvent.UnResgiter(OnGameStart);
        }

    }

}
