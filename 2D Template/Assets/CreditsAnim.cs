using UnityEngine;

public class CreditsAnim : MonoBehaviour
{
    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator.Play("CreditsAnimation", 0, 133f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
