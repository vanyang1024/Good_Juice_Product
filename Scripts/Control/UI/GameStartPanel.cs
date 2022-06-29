using UnityEngine;
using UnityEngine.UI;

namespace Demo{
    public class GameStartPanel : MonoBehaviour
    {   
        // Start is called before the first frame update
        void Start(){
            
            GameModel.enemyCount.OnValueChanged += onCountChanged;
            
            transform.Find("Button").GetComponent<Button>()
                .onClick.AddListener(() => {
                    gameObject.SetActive(false);
                    new StartGameCommand().Execute();
                });

            transform.Find("Counter/AddBtn").GetComponent<Button>()
                .onClick.AddListener(() => {
                    if(GameModel.enemyCount.Value<5){new AddCommand().Execute();}
                });

            
            transform.Find("Counter/SubBtn").GetComponent<Button>()
                .onClick.AddListener(() => {
                    if(GameModel.enemyCount.Value>0){new SubCommand().Execute();}
                });

        }

        void onCountChanged(int count){
            transform.Find("Counter/Count")
                     .GetComponent<TMPro.TextMeshProUGUI>().text = count.ToString();
        }

        private void OnDestroy(){
            GameModel.enemyCount.OnValueChanged -= onCountChanged;
        }

    }
}

