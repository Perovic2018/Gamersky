using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI; 

public class SceneSwitcherButton : MonoBehaviour
{
    public string sceneToLoad; 

    
    public void OnButtonClick()
    {
        LoadScene();
    }

    private void LoadScene()
    {
        
        if (Application.CanStreamedLevelBeLoaded(sceneToLoad))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
        else
        {
            Debug.LogError("—цена не найдена: " + sceneToLoad);
        }
    }
}