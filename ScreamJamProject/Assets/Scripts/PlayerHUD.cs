using TMPro;
using UnityEngine;
using UnityEngine.UI;

// SINGLETON //
[RequireComponent(typeof(DialogueEngine))]
public class PlayerHUD : MonoBehaviour
{
    #region Fields
    [SerializeField] TextMeshProUGUI interactionText;
    [SerializeField] UIPositionLerp diaryPanel;
    [SerializeField] Vector3[] diaryPanelPositions;
    [SerializeField] TextMeshProUGUI diaryText;
    [SerializeField] UIPositionLerp dialoguePanel;
    [SerializeField] Vector3[] dialoguePanelPositions;
    [SerializeField] TextMeshProUGUI dialogueText;
    [SerializeField] TextMeshProUGUI speakerText;
    [SerializeField] GameObject dialogueOptionsPanel;
    [SerializeField] GameObject[] dialogueOptions;
    [SerializeField] TypewriterPro typewriter;

    public static PlayerHUD instance;

    DialogueEngine dialogueEngine;
    #endregion

    #region Callbacks
    void Awake () {
        SingletonCheck();
        MakeReferences();
    }

    void Start () {
        DisableInterfaceInputPatterns();
    }
    #endregion

    void SingletonCheck () {
        if (instance == null) instance = this; else Destroy(this.gameObject);
    }

    void MakeReferences () {
        dialogueEngine = GetComponent<DialogueEngine>();
    }

    public void SetInteractionText (string text) {
        interactionText.text = text;
    }

    public void DisableInterfaceInputPatterns () {
        PlayerInput.actions.UIPanel.Disable();
    }

    public void EnableDiaryPanel (string text) {
        PlayerInput.actions.Default.Disable();
        PlayerInput.actions.UIPanel.Enable();
        diaryPanel.SetTargetPosition(diaryPanelPositions[1]);
        diaryText.text = text;
    }

    public void DisableDiaryPanel () {
        PlayerInput.actions.UIPanel.Disable();
        PlayerInput.actions.Default.Enable();
        diaryPanel.SetTargetPosition(diaryPanelPositions[0]);
        diaryText.text = "";
    }

    public void EnableDialoguePanel () {
        PlayerInput.actions.Default.Disable();
        PlayerInput.actions.UIPanel.Enable();
        dialoguePanel.SetTargetPosition(dialoguePanelPositions[1]);
    }

    public void DisableDialoguePanel () {
        PlayerInput.actions.UIPanel.Disable();
        PlayerInput.actions.Default.Enable();
        dialoguePanel.SetTargetPosition(dialoguePanelPositions[0]);
    }

    public void WriteDialogue (string speaker, string text) {
        speakerText.text = speaker;
        typewriter.StartWriting(text);
    }

    public void ShowDialogueOptions(Dialogue[] options) {
        dialogueOptionsPanel.SetActive(true);
        for (int i = 0; i < options.Length; i++) {
               SetUpDialogueOption(dialogueOptions[i], options[i]);
        }
    }

    void SetUpDialogueOption(GameObject dialogueOption, Dialogue option) {
        Button button = dialogueOption.GetComponent<Button>();
        TextMeshProUGUI textComponent = dialogueOption.GetComponentInChildren<TextMeshProUGUI>();

        button.onClick.AddListener(delegate {dialogueEngine.SetCurrentDialogue(option);});
        textComponent.text = option.text;
    }

    public void HideDialogueOptions () {
        dialogueOptionsPanel.SetActive(false);
    }

    public bool IsTypewriterWriting () {
        return typewriter.isWriting;
    }
}
