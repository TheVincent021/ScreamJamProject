using System.Collections;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    #region Fields
    [SerializeField] float duration = 1f;
    [SerializeField] float magnitude = 1f;
    #endregion

    public void Shake () {
        StartCoroutine(StartShake());
    }

    IEnumerator StartShake () {

        Vector3 originPosition = transform.localPosition;

        float elapsed = 0f;
        while (elapsed < duration) {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;
            transform.localPosition = new Vector3(x, y, originPosition.z);
            elapsed += Time.deltaTime;
            yield return null;
        }

        transform.localPosition = originPosition;
    }
}
