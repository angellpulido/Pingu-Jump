using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    [SerializeField] AudioSource SFXSource;

    public AudioClip death;
    public AudioClip TestSfx;
    public AudioClip Beep;

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
