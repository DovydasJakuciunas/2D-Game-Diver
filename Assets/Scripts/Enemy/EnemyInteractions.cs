using UnityEngine;

public class EnemyInteractions : MonoBehaviour
{
    private HealthSystem healthSystem;
    
    //Damage Amount
    [SerializeField]
    [Range(0f, 5f)]
    private int damage;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Once the tag "Player" Touches
        if (collision.gameObject.tag == "Player")
        {
            healthSystem.TakeDamage(damage);
            Destroy(collision.gameObject);
        }

    }

}
