using UnityEngine;
using UnityEngine.UI;

public class TextSwitcher : MonoBehaviour
{
    public Text dialogueText;   
    public Button nextButton; 
    public Button button1; 
    public Button button2; 

    private int currentIndex; 

    [System.Serializable]
    public class DialogueNode
    {
        public string text; 
    }

    private DialogueNode[] dialogueNodes = new DialogueNode[]
    {
        new DialogueNode { text = "������ �������� �������?" },
             new DialogueNode { text = "������� ������" },
        new DialogueNode { text = "������ ����� ����� ������" },
        new DialogueNode { text = "������ ����������: � �� ���, ������?" },
        new DialogueNode { text = "�� ����, ��� ������ ������ �����!" },

    };

    void Start()
    {
        currentIndex = 0;  
        UpdateDialogue(); 

         
        nextButton.onClick.AddListener(OnNextButtonClicked);

        
        button1.gameObject.SetActive(false);
        button2.gameObject.SetActive(false);
    }

    void UpdateDialogue()
    {
        if (currentIndex < dialogueNodes.Length)
        {
            dialogueText.text = dialogueNodes[currentIndex].text; 
        }
        else
        {
            dialogueText.text = " "; 
            nextButton.interactable = false;  

            
            button1.gameObject.SetActive(true);
            button2.gameObject.SetActive(true);
        }
    }

    void OnNextButtonClicked()
    {
        currentIndex++; 
        UpdateDialogue(); 
    }
}