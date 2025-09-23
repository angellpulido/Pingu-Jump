using UnityEngine;

public class Player_Combat : MonoBehaviour
{
    public Transform attackPoint;
    public float weaponRange = 1;
    public LayerMask enemyLayer;
    public int damage = 1;


    public Animator anim;

    public float cooldown = 1;
    private float timer;


    private void Update()
    {
        if (timer > 0)
        {
           timer -= Time.deltaTime;
        }
    }

    public void Attack ()
    {
        if(timer <= 0)
        {
            anim.SetBool("IsAttacking", true);
            //timer = cooldown;
        }
        

        Collider2D[] enemies = Physics2D.OverlapCircleAll(attackPoint.position, weaponRange, enemyLayer);
        if(enemies.Length > 0)
        {
            enemies[0].GetComponent<Enemy_Health>().ChangeHealth(-damage);
        }
    }

    public void FinishAttacking()
    {
        anim.SetBool("IsAttacking", false);
    }

}