
using UnityEngine;

public class Coins : MonoBehaviour
{
   
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            MoneyText.Coin += 1;
            Destroy(gameObject);
        }
    }
}
