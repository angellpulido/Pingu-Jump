using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadRandomScenes : MonoBehaviour {

    public void LoadRandomScene()
    {
        //By Using The Random.Range method to load random scenes
        int index = Random.Range(1, 5);
        SceneManager.LoadScene(index);
        Debug.Log("Scene Loaded");
    }
}
