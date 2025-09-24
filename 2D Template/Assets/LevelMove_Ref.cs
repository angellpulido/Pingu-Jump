using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMove_Ref : MonoBehaviour
{

    public int sceneBuildIndex;

    private void OnTriggerEnter2D(Collider2D other)
    {
        print("Trigger Entered");

        if (other.tag == "Player")
        {
            print("Switching Scene to End Credits");
            SceneManager.LoadScene(4);
        }
    }
}
