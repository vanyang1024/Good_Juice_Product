using UnityEngine;

namespace Demo
{
    public class UIController : MonoBehaviour
    {
        private void Awake(){
            GameOverEvent.Register(OnGameOver);
        }

        private void OnGameOver(){
            transform.Find("GameOverPanel").gameObject.SetActive(true);
        }

        private void OnDestroy(){
            GameOverEvent.UnResgiter(OnGameOver);
        }

    }

}
