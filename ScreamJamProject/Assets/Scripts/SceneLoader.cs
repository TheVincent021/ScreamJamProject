using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public Animator fadeScreen;

    public void LoadScene (string name) {
        StartCoroutine(LoadSceneDelayed(name));
    }

    IEnumerator LoadSceneDelayed (string name) {
        fadeScreen.SetTrigger("Fade");
        yield return new WaitForSeconds((1f/60f) * 20f);
        SceneManager.LoadScene(name);
    }
}
