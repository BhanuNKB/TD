using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public DialogueScript currentDialogue;
    public TextMeshProUGUI speakerNameText;
    public TextMeshProUGUI dialogueText;
    //public GameObject dialoguePanel;
    public Button continueBtn;

    private int currentLineIndex = 0;

    void Start()
    {
        //dialoguePanel.SetActive(false);
        continueBtn.onClick.AddListener(OnContinueBtnClicked);
        StartDialogue();
    }
    private void OnDestroy()
    {
        continueBtn.onClick.RemoveListener(OnContinueBtnClicked);

    }

    public void StartDialogue()
    {
        //currentDialogue = dialogue;
        currentLineIndex = 0;
        //dialoguePanel.SetActive(true);
        ShowLine();
    }

    public void OnContinueBtnClicked()
    {
        currentLineIndex++;

        if (currentLineIndex < currentDialogue.lines.Length)
        {
            ShowLine();
        }
        //else
        //{
        //    EndDialogue();
        //}
    }

    void ShowLine()
    {
        var line = currentDialogue.lines[currentLineIndex];
        speakerNameText.text = line.speakerName;
        dialogueText.text = line.lineText;
    }

    //void EndDialogue()
    //{
    //    dialoguePanel.SetActive(false);
    //}
}
