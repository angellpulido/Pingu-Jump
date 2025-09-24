using JetBrains.Annotations;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadRandomScenes : MonoBehaviour {
    
    public void LoadRandomScene()
    {
        //By Using The Random.Range method to load random scene
        
        int index = Random.Range(1, 5);
        SceneManager.LoadScene(1);
        Debug.Log("Scene Loaded");
    }
}
