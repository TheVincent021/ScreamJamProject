using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    #region Fields
    [SerializeField] float speed;

    Vector2 movementVector;

    PlayerActions actions;
    Rigidbody2D m_rigidbody;
    #endregion

    #region Callbacks
    void OnEnable () {
        Initialization();
    }

    void Awake () {
        MakeReferences();
    }

    void Update () {
        ReadInputs();
    }

    void FixedUpdate () {
        UpdateMovement();
    }
    #endregion

    void Initialization () {
        actions.Enable();
    }

    void MakeReferences () {
        actions = new PlayerActions();
        m_rigidbody = GetComponent<Rigidbody2D>();
    }

    void ReadInputs () {
        movementVector = PlayerInput.actions.Default.Movement.ReadValue<Vector2>();
    }

    void UpdateMovement () {
        m_rigidbody.velocity = movementVector * speed;
    }


}
