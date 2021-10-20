using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] int health = 3;
    [SerializeField] float shakeDuration = 0.5f;
    [SerializeField] float shakeMagnitude = 4f;

    int maxHealth = 0;

    void Start () {
        SetMaxHealth();
    }

    void SetMaxHealth () {
        maxHealth = health;
    }

    public void Damage (int damage) {
        health -= damage;
        Camera.main.GetComponent<CameraShake>().Shake();
        PlayerHUD.instance.UpdateHealthBar((1f/maxHealth) * damage);
    }
}
