using UnityEngine;

public class Pickup : MonoBehaviour, IInteractable
{
    #region Fields
    [SerializeField] GameObject prefab;

    Inventory playerInventory;
    #endregion

    #region Callbacks
    void Awake () {
        MakeReferences();
    }
    #endregion

    void MakeReferences () {
        playerInventory = GameObject.FindWithTag("Player").GetComponent<Inventory>();
    }

    public void Activate () {
        if (playerInventory.AddItem(prefab)) {
            Destroy(this.gameObject);
        }
    }
}
