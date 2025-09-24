using UnityEngine;

public class TestSfx : MonoBehaviour
{
    SoundEffect soundEffect;

    private void Awake()
    {
       soundEffect = GameObject.FindGameObjectWithTag("Audio").GetComponent<SoundEffect>(); 
    }

    public void Test()
    {
        soundEffect.PlaySFX(soundEffect.TestSfx);
    }
}
