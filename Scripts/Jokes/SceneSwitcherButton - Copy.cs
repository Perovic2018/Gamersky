using UnityEngine;
using UnityEngine.SceneManagement; // Подключаем пространство имен для работы со сценами  
using UnityEngine.UI; // Подключаем пространство имен для работы с UI  

public class SceneSwitcherButton : MonoBehaviour
{
    public string sceneToLoad; // Имя сцены, на которую будет переключение  

    // Этот метод будет привязан к событию нажатия кнопки  
    public void OnButtonClick()
    {
        LoadScene();
    }

    private void LoadScene()
    {
        // Проверка, существует ли сцена перед загрузкой  
        if (Application.CanStreamedLevelBeLoaded(sceneToLoad))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
        else
        {
            Debug.LogError("Сцена не найдена: " + sceneToLoad);
        }
    }
}