using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    #region Fields
    [SerializeField] string id = "Door";
    [SerializeField] bool isLocked = false;
    [SerializeField] GameObject key;
    #endregion

    public void Activate () {
        if (isLocked) {
            if (GameObject.FindWithTag("Player").GetComponent<Inventory>().items.Contains(key)) {
                Open();
            } else {
                // Display a message telling that door is locked!
            }
        }  else {
            Open();
        }
    }

    public string ID () {
        return id;
    }

    void Open () {
        Destroy(this.gameObject);
    }
}
