using UnityEngine;

public class EnemyInteractions : MonoBehaviour
{
    public HealthSystem healthSystem;
    
    //Damage Amount
    [SerializeField]
    private int damage = 1;

    void Start()
    {
        GameObject player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            healthSystem = player.GetComponent<HealthSystem>();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Once the tag "Player" Touches
        if (collision.gameObject.tag == "Player")
        {
            healthSystem.TakeDamage(damage);
            Destroy(gameObject);

        }

    }


}
