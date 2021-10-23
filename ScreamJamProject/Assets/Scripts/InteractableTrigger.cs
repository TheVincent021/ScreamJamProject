using UnityEngine;

public class InteractableTrigger : MonoBehaviour
{
    void OnTriggerEnter2D (Collider2D col) {
        if (col.CompareTag("Player")) GetComponent<IInteractable>().Activate();
        Destroy(this.gameObject);
    }
}
