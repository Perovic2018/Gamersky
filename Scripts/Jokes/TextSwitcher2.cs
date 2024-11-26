using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class TextSwitcher2 : MonoBehaviour
{
    public Text dialogueText; 
    public Button nextButton;  

    private int currentIndex; 

    [System.Serializable]
    public class DialogueNode
    {
        public string text; 
    }

    private DialogueNode[] dialogueNodes = new DialogueNode[]
    {

        new DialogueNode { text = "�� ������?" },
        new DialogueNode { text = "..." },
        new DialogueNode { text = "� ������ �� ����� ������� � �����" },
         new DialogueNode { text = "..." }
    };

    void Start()
    {
        currentIndex = 0; 
        UpdateDialogue(); 

         
        nextButton.onClick.AddListener(OnNextButtonClicked);
    }

    void UpdateDialogue()
    {
        if (currentIndex < dialogueNodes.Length)
        {
            dialogueText.text = dialogueNodes[currentIndex].text; 
        }
        else
        {
            dialogueText.text = "������ �����, ����� ��������� � �����"; 
            nextButton.interactable = false; 

            
            Invoke("LoadNextScene", 2f); 
        }
    }

    void OnNextButtonClicked()
    {
        currentIndex++; 
        UpdateDialogue(); 
    }

    void LoadNextScene()
    {
        
        SceneManager.LoadScene("Win");
    }
}