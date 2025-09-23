using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Platformermovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb2d;

    private float _movement;
    private Animator animator;

    public FoodManager fm;

   
        
    public Player_Combat player_combat;

    private void Update()
    {
        if (Input.GetButtonDown("Slash"))
        {

            player_combat.Attack();
            
        }

    }


    public void FixedUpdate()
    {
        rb2d.linearVelocityX = _movement;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }



    public void Move(InputAction.CallbackContext ctx)
    {
        animator.SetBool("IsWalking", true);
        if (ctx.canceled)
        {
            animator.SetBool("IsWalking", false);
            animator.SetFloat("InputX", _movement);
        }
        _movement = ctx.ReadValue<Vector2>().x * moveSpeed;
        animator.SetFloat("InputX", _movement);
        if (Input.GetKey(KeyCode.A))
        {
            rb2d.transform.localScale = new Vector3(-1, 0, 1);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Food"))
        {
            Destroy(other.gameObject);
            fm.foodCount++;
        }
    }
}
