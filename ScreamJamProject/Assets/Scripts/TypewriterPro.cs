using System.Collections;
using System.Diagnostics;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class TypewriterPro : MonoBehaviour
{
    #region Fields
    [SerializeField] float delay = 0.1f;
    public bool isWriting;

    Coroutine currentProcess;

    TextMeshProUGUI textComponent;
    #endregion

    #region Callbacks
    void Awake () {
        MakeReferences();
    }
    #endregion

    void MakeReferences () {
        textComponent = GetComponent<TextMeshProUGUI>();
    }

    public void StartWriting (string text) {
        if (isWriting == false) {
            textComponent.text = "";
            isWriting = true;
            currentProcess = StartCoroutine(Write(text));
        }
    }

    IEnumerator Write (string text) {
        foreach (var c in text) {
            textComponent.text += c;
            yield return new WaitForSeconds(delay);
        }
        isWriting = false;
    }
}
