using UnityEngine;
using UnityEngine.InputSystem;

public class DiaryEntry : MonoBehaviour, IInteractable
{
    #region Fields
    [SerializeField] string id = "Entry #0";
    [SerializeField] string diary;
    [SerializeField] int diaryIndex = 0;
    #endregion

    public string ID () {
        return id;
    }

    public string DiaryText () {
        return diary;
    }

    public int Index () {
        return diaryIndex;
    }

    public void Activate () {
        PlayerHUD.instance.EnableDiaryPanel(diary);
        PlayerInput.actions.UIPanel.CancelSelect.performed += DiaryIsRead;
    }

    void DiaryIsRead (InputAction.CallbackContext ctx) {
        PlayerHUD.instance.AddDiaryEntry(this);
        PlayerInput.actions.UIPanel.CancelSelect.performed -= DiaryIsRead;
        Destroy(this.gameObject);
    }
}
