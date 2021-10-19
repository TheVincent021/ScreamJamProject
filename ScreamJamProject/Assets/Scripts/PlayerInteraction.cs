using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    #region Fields
    [SerializeField] GameObject objectOfInterest;
    #endregion

    #region Callbacks
    void OnTriggerEnter2D (Collider2D col) {
        if (col.tag == "Interactable")
            objectOfInterest = col.gameObject;
    }

    void OnTriggerExit2D (Collider2D col) {
        if (col.gameObject == objectOfInterest)
            objectOfInterest = null;
    }

    void Start () {
        RegisterInput();
    }

    void Update () {
        UpdateInteractionText();
    }
    #endregion

    void RegisterInput () {
        PlayerInput.actions.Default.Interaction.performed += context => Interact();
    }

    void Interact () {
        if (objectOfInterest != null)
            objectOfInterest.GetComponent<IInteractable>().Activate();
    }

    void UpdateInteractionText () {
        if (objectOfInterest != null) {
            PlayerHUD.instance.SetInteractionText(objectOfInterest.GetComponent<IInteractable>().ID());
        } else {
            PlayerHUD.instance.SetInteractionText("");
        }
    }
}
