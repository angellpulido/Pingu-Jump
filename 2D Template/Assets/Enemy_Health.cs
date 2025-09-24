using UnityEngine;

public class Enemy_Health : MonoBehaviour
{

    SoundEffect soundEffect;

    public int currentHealth;
    public int maxHealth;

    public void Awake()
    {
        soundEffect = GameObject.FindGameObjectWithTag("Audio").GetComponent<SoundEffect>();
    }

    private void Start()
    {

        currentHealth = maxHealth;
    }

    public void ChangeHealth(int amount)
    {
        currentHealth += amount;

        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }

        else if ( currentHealth <= 0)
        {
            soundEffect.PlaySFX(soundEffect.death);
            Destroy(gameObject);
        }
    
    
    }



}
