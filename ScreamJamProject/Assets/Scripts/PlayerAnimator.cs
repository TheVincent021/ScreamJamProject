using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerAnimator : MonoBehaviour
{
    Vector2 movement;

    Animator m_animator;

    void Awake () {
        MakeReferences();
    }

    void Update () {
        ReadInput();
        Animate();
    }

    void MakeReferences () {
        m_animator = GetComponent<Animator>();
    }

    void ReadInput () {
        movement = PlayerInput.actions.Default.Movement.ReadValue<Vector2>();
    }

    void Animate () {
        m_animator.SetBool("MoveUp", movement.y > 0f);
        m_animator.SetBool("MoveDown", movement.y < 0f);
        m_animator.SetBool("MoveRight", movement.x > 0f);
        m_animator.SetBool("MoveLeft", movement.x < 0f);
    }
}
