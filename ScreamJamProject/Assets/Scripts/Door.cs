using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    #region Fields
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

    void Open () {
        Destroy(this.gameObject);
    }
}
