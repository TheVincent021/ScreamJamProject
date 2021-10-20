using System.Collections;
using UnityEngine;

public class Trap : MonoBehaviour
{
    [SerializeField] int damage = 1;
    [SerializeField] bool continuous = false;
    [SerializeField] float delay = 1f;

    bool isUsed = false;
    bool isOnTrap = false;

    PlayerHealth player;

    void Awake () {
        MakeReferences();
    }

    void MakeReferences () {
        player = GameObject.FindWithTag("Player").GetComponent<PlayerHealth>();
    }

    void OnTriggerEnter2D (Collider2D col) {
        if (col.CompareTag("Player") && !isUsed) {
            player.Damage(damage);
            isOnTrap = true;

            if (!continuous) {
                isUsed = true;
            } else {
                StartCoroutine(ContinuousDamage());
            }
        }
    }

    void OnTriggerExit2D (Collider2D col) {
        if (col.CompareTag("Player")) {
            isOnTrap = false;
        }
    }

    IEnumerator ContinuousDamage () {
        yield return new WaitForSeconds(delay);
        if (isOnTrap && !isUsed) {
            player.Damage(damage);
            StartCoroutine(ContinuousDamage());
        } else {
            yield return null;
        }
    }
}
