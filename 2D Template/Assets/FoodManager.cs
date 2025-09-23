using UnityEngine;
using UnityEngine.UI;

public class FoodManager : MonoBehaviour
{

    public int foodCount;
    public Text foodText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foodText.text = ": " + foodCount.ToString();
    }
}
