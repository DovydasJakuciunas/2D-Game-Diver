using UnityEngine;

public class EnemyFlyBy : AttributeManager
{

    [SerializeField]
    [Tooltip("This is the base speed for enemies. They get speed increased with score of the player")]
    private float speedEnemy;

    [SerializeField]
    private SharedSpeed sharedSpeed;

    [SerializeField]
    private EnemyType enemyType;

    public override void speedSetter()
    {
        speedEnemy = sharedSpeed.GetSpeed(enemyType); 
        transform.position += speedEnemy * Time.deltaTime * Vector3.left; 
        // Destroy if its Beyond This
        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        speedSetter();
    }
}
