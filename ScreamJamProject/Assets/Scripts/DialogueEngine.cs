using UnityEngine;
using UnityEngine.InputSystem;

public class DialogueEngine : MonoBehaviour
{
    #region Fields
    Dialogue currentDialogue;
    #endregion

    public void StartDialogueTree (Dialogue treeRoot) {
        PlayerInput.actions.UIPanel.Select.performed += ShowNextDialogue;
        currentDialogue = treeRoot;
        PlayerHUD.instance.EnableDialoguePanel();
        PlayerHUD.instance.WriteDialogue(currentDialogue.speaker, currentDialogue.text);
    }

    void ShowNextDialogue (InputAction.CallbackContext ctx) {
        if (!PlayerHUD.instance.IsTypewriterWriting()) {
            if (currentDialogue.nextDialogues.Length == 0) {
                EndDialogueTree();
            } else if (currentDialogue.nextDialogues.Length == 1) {
                var nextDialogue = currentDialogue.nextDialogues[0];
                currentDialogue = nextDialogue;
                PlayerHUD.instance.WriteDialogue(currentDialogue.speaker, currentDialogue.text);
            } else {
                PlayerHUD.instance.ShowDialogueOptions(currentDialogue.nextDialogues);
            }
        }
    }

    public void SetCurrentDialogue (Dialogue dialogue) {
        PlayerHUD.instance.HideDialogueOptions();
        currentDialogue = dialogue;
        PlayerHUD.instance.WriteDialogue(dialogue.speaker, dialogue.text);
    }

    void EndDialogueTree() {
        PlayerHUD.instance.DisableDialoguePanel();
        PlayerInput.actions.UIPanel.Select.performed -= ShowNextDialogue;
    }
}

[System.Serializable]
public struct Dialogue {
    public string speaker;
    public string text;
    public Sprite portrait;
    public Dialogue[] nextDialogues;
}

[System.Serializable]
public struct PortraitEntry {
    public string key;
    public Sprite value;
}