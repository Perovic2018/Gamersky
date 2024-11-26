using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class TextSwitcher1 : MonoBehaviour
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
    
        new DialogueNode { text = "ј¬’ј’¬ј’¬ј’¬’ј’¬ј’¬ј’¬ј" },
        new DialogueNode { text = "¬ы замечаете, что не можете перестать сме€тьс€, и умираете от смеха" }
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
            dialogueText.text = "¬ам уже не спастись"; 
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
        
        SceneManager.LoadScene("Fail");
    }
}