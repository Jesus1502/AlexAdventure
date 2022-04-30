using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Animator animator;
  
   

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }
    }

    void Attack()
    {
        animator.SetTrigger("Attack");
    }
}
