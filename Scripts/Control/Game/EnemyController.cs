using UnityEngine;

namespace Demo
{
    public class EnemyController : MonoBehaviour
    {

        private void OnMouseDown() {
            Destroy(gameObject);
            new KillEnemyCommand().Execute();
        }

    }

}
