using UnityEngine;
using UnityEngine.InputSystem;

public class DiaryEntry : MonoBehaviour, IInteractable
{
    #region Fields
    [SerializeField] string id = "Entry #0";
    [SerializeField] string diary;
    #endregion

    public string ID () {
        return id;
    }

    public string DiaryText () {
        return diary;
    }

    public void Activate () {
        PlayerHUD.instance.EnableDiaryPanel(diary);
        PlayerInput.actions.UIPanel.CancelSelect.performed += DiaryIsRead;
    }

    void DiaryIsRead (InputAction.CallbackContext ctx) {
        PlayerHUD.instance.DisableDiaryPanel();
        GameObject.FindWithTag("Player").GetComponent<Inventory>().AddEntry(this);
        PlayerInput.actions.UIPanel.CancelSelect.performed -= DiaryIsRead;
        Destroy(this.gameObject);
    }
}
