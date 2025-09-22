using UnityEngine;

public class Playerr : MonoBehaviour
{
    public static Rigidbody2D rb;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }
    public static void DoJump(float JumpForce)

    {
        rb.AddForce(Vector2.up * JumpForce);

    }

}