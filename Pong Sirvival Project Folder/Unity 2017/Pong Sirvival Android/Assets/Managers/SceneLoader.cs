using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    public void LoadSceneAsyn (string sceneName)
    {
        StartCoroutine(LoadAsynchronously(sceneName));
    }

    IEnumerator LoadAsynchronously(string sceneName)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);

        while(!operation.isDone)
        {
            Debug.Log(operation.progress);

            yield return null;
        }
    }
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void LoadAdditiveSceneUI (string sceneName)
    {

        SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
        
    }
    public void UnloadAdditiveSceneUI(string sceneName)
    {

        SceneManager.UnloadScene(sceneName);

    }

}
