
using UnityEngine;

public class ColisionDamage : MonoBehaviour
{
    public int colisionDamage = 10;
    public string colisionTag;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == colisionTag)
        {
            Health health = collision.gameObject.GetComponent<Health>();
            health.TakeHit(colisionDamage);
        }
    }
}
