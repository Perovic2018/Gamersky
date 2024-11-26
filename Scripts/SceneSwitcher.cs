using UnityEngine;
using UnityEngine.SceneManagement; 

namespace Assets.Scripts
{
    public class SceneSwitcher : MonoBehaviour
    {
        public string sceneToLoad; 

        private void OnTriggerEnter2D(Collider2D collision)
        {
             
            if (collision.CompareTag("Player"))
            {
                LoadScene();
            }
        }

        private void LoadScene()
        {
            
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}