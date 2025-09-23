using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int health;
    public Slider slider;

 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = maxHealth;
        slider.maxValue = maxHealth;
        slider.value = health;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        slider.value = health;

        if (health <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(0);
        }
    }
}
