using UnityEngine;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    #region Fields
    [SerializeField] int limit = 6;
    public List<GameObject> items;
    #endregion

    #region Callbacks
    void Start () {
        Initialization();
    }
    #endregion

    void Initialization () {
        items = new List<GameObject>();
    }

    public bool AddItem (GameObject item) {
        if (items.Count < limit) {
            items.Add(item);
            return true;
        }
        // Display a message saying that inventory is full
        return false;
    }

    public void RemoveItem (GameObject item) {
        if (items.Contains(item)) {
            items.Remove(item);
        }
    }
}
