using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
   
    public void Back()
    {

        SceneManager.LoadScene(0);
    }
}
