using Unity.VisualScripting;
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Hitting But not activating");
        //Once the tag "Player" Touches
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("TagGot");
            healthSystem.TakeDamage(damage);

        }

    }

    
}
