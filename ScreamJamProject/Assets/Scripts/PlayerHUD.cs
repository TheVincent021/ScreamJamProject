using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

// SINGLETON //
[RequireComponent(typeof(DialogueEngine))]
public class PlayerHUD : MonoBehaviour
{
    #region Fields
    [SerializeField] bool isWindowed = false;
    [SerializeField] Animator fadeScreen;
    [SerializeField] GameObject defaultPanel;
    [SerializeField] TextMeshProUGUI interactionText;
    [SerializeField] UIPositionLerp diaryPanel;
    [SerializeField] Vector3[] diaryPanelPositions;
    [SerializeField] TextMeshProUGUI diaryText;
    [SerializeField] UIPositionLerp dialoguePanel;
    [SerializeField] PortraitEntry[] portraitsTable;
    [SerializeField] Image dialoguePortrait;
    [SerializeField] Vector3[] dialoguePanelPositions;
    [SerializeField] TextMeshProUGUI dialogueText;
    [SerializeField] TextMeshProUGUI speakerText;
    [SerializeField] GameObject dialogueOptionsPanel;
    [SerializeField] GameObject[] dialogueOptions;
    [SerializeField] TypewriterPro typewriter;
    [SerializeField] RectTransform health;
    [SerializeField] Animator redScreen;
    [SerializeField] UIPositionLerp diariesBookPanel;
    [SerializeField] Transform diaryEntryButtonsPanel;
    [SerializeField] GameObject diaryEntryButton;
    [SerializeField] Transform inventoryIconsPanel;
    [SerializeField] GameObject itemIcon;

    public static PlayerHUD instance;

    DialogueEngine dialogueEngine;
    Inventory inventory;
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
        inventory = GetComponentInParent<Inventory>();
    }

    void DefaultPanel (bool state) {
        defaultPanel.SetActive(state);
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
        PlayerInput.actions.UIPanel.CancelSelect.performed += DisableDiaryPanel;
        PlayerInput.actions.UIPanel.Cancel.performed -= DisableDiariesBookPanel;
        DefaultPanel(false);
        diaryPanel.SetTargetPosition(diaryPanelPositions[1]);
        diaryText.text = text;
    }

    public void DisableDiaryPanel (InputAction.CallbackContext ctx) {
        PlayerInput.actions.UIPanel.CancelSelect.performed -= DisableDiaryPanel;
        if (!isWindowed) {
            PlayerInput.actions.UIPanel.Disable();
            PlayerInput.actions.Default.Enable();
            DefaultPanel(true);
        } else {
            PlayerInput.actions.UIPanel.Cancel.performed += DisableDiariesBookPanel;
        }
        diaryPanel.SetTargetPosition(diaryPanelPositions[0]);
        diaryText.text = "";
    }

    public void AddDiaryEntry (DiaryEntry entry) {
        GameObject entryButton = Instantiate(diaryEntryButton, diaryEntryButtonsPanel);
        entryButton.GetComponent<Button>().onClick.AddListener(delegate  {EnableDiaryPanel(entry.DiaryText());});
        entryButton.GetComponentInChildren<TextMeshProUGUI>().text = "#" + entry.Index();
    }

    public void EnableDiariesBookPanel (string text) {
        PlayerInput.actions.Default.Disable();
        PlayerInput.actions.UIPanel.Enable();
        PlayerInput.actions.UIPanel.Cancel.performed += DisableDiariesBookPanel;
        isWindowed = true;
        DefaultPanel(false);
        diariesBookPanel.SetTargetPosition(diaryPanelPositions[1]);
    }

    public void DisableDiariesBookPanelEvent () {DisableDiariesBookPanel(new InputAction.CallbackContext());}

    public void DisableDiariesBookPanel (InputAction.CallbackContext ctx) {
        PlayerInput.actions.UIPanel.Disable();
        PlayerInput.actions.Default.Enable();
        PlayerInput.actions.UIPanel.Cancel.performed -= DisableDiariesBookPanel;
        isWindowed = false;
        DefaultPanel(true);
        diariesBookPanel.SetTargetPosition(diaryPanelPositions[0]);
    }

    public void EnableDialoguePanel () {
        PlayerInput.actions.Default.Disable();
        PlayerInput.actions.UIPanel.Enable();
        DefaultPanel(false);
        dialoguePanel.SetTargetPosition(dialoguePanelPositions[1]);
    }

    public void DisableDialoguePanel () {
        PlayerInput.actions.UIPanel.Disable();
        PlayerInput.actions.Default.Enable();
        DefaultPanel(true);
        dialoguePanel.SetTargetPosition(dialoguePanelPositions[0]);
        dialoguePortrait.enabled = false;
    }

    public void WriteDialogue (string speaker, string text) {
        Sprite portrait = null;
        foreach (var entry in portraitsTable) {
            if (speaker == entry.key) {portrait = entry.value; break;}
        }

        speakerText.text = speaker;
        typewriter.StartWriting(text);
        dialoguePortrait.enabled = portrait == null ? false : true;
        dialoguePortrait.sprite = portrait;
        dialoguePortrait.color = speaker == "Radio" ? Color.black : Color.white;
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

    public void UpdateIcons () {
        foreach (var iconObject in inventoryIconsPanel.GetComponentsInChildren<Transform>()) {
            if (iconObject != inventoryIconsPanel)
                Destroy(iconObject.gameObject);
        }

        foreach (var item in inventory.items) {
            var newIconObject = Instantiate(itemIcon, inventoryIconsPanel);
            newIconObject.GetComponent<Image>().sprite = item.GetComponent<PickupIcon>().icon;
        }
    }

    public void FadeScreen () {
        fadeScreen.SetTrigger("Fade");
    }

    public void RedScreenFlash () {
        redScreen.SetTrigger("Flash");
    }

    public bool IsTypewriterWriting () {
        return typewriter.isWriting;
    }

    public void UpdateHealthBar (float amount) {
        health.localScale -= new Vector3(amount, 0f, 0f);
    }
}
