using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Platformermovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb2d;

    private float _movement;
    private Animator animator; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.linearVelocityX = _movement;

        
    }

    public void Move(InputAction.CallbackContext ctx)
    {
        animator.SetBool("IsWalking", true);
        if (ctx.canceled) 
        {
            animator.SetBool("IsWalking", false);
            animator.SetFloat("lastinputX", _movement);
        }
        _movement = ctx.ReadValue<Vector2>().x * moveSpeed;
        animator.SetFloat("InputX", _movement);
    
    }
}
