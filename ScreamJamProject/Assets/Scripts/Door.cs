using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    #region Fields
    [SerializeField] string id = "Door";
    [SerializeField] bool isLocked = false;
    [SerializeField] GameObject key;

    Inventory inventory;
    #endregion

    void Awake () {
        MakeReferences();
    }

    void MakeReferences () {
        inventory = GameObject.FindWithTag("Player").GetComponent<Inventory>();
    }

    public void Activate () {
        if (isLocked) {
            if (inventory.items.Contains(key)) {
                Open();
                inventory.RemoveItem(key);
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
