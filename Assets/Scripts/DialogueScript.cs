using UnityEngine;

[CreateAssetMenu(fileName = "DialogueScript", menuName = "Scriptable Objects/DialogueScript")]
public class DialogueScript : ScriptableObject
{
    public DialogueLine[] lines;
}


[System.Serializable]
public class DialogueLine
{
    public string speakerName;
    [TextArea(2, 5)]
    public string lineText;
}