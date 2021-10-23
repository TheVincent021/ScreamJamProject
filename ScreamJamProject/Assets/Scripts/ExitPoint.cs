using System.Collections;
using UnityEngine;

public class ExitPoint : MonoBehaviour, IInteractable
{
    [SerializeField] string id;
    [SerializeField] Vector3 newPosition;

    Transform player;
    Transform cameraHolder;

    void Awake () {
        MakeReferences();
    }

    void MakeReferences () {
        player = GameObject.FindWithTag("Player").transform;
        cameraHolder = GameObject.FindWithTag("CameraHolder").transform;
    }

    public void Activate () {
        StartCoroutine(Transport());
    }

    public string ID () {
        return id;
    }

    IEnumerator Transport () {
        PlayerHUD.instance.FadeScreen();
        yield return new WaitForSeconds((1f/60f) * 20f);
        player.position = newPosition;
        cameraHolder.position = newPosition - new Vector3(0f, 0f, 10f);
    }
}
