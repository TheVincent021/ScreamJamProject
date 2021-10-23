using UnityEngine;

public class DialogueInitiator : MonoBehaviour, IInteractable
{
    #region Fields
    [SerializeField] string id = "Survivor";
    [SerializeField] Dialogue dialogueTree;
    #endregion

    public string ID () {
        return id;
    }

    public void Activate () {
        GameObject.FindObjectOfType<DialogueEngine>().StartDialogueTree(dialogueTree);
    }
}
