using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;

    //Max Distance
    [SerializeField]
    private float maxDistance = 5f;
    private Vector3 startPosition;

    AttributeManager player;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GetComponent<AttributeManager>();
        // Record the starting position
        startPosition = transform.position;
    }

    void Update()
    {
        // Inputs
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Movement Getter
        Vector3 movement = player.getSpeed() * Time.deltaTime * new Vector3(moveHorizontal, moveVertical, 0);

        // Move the Character
        Vector3 newPosition = transform.position + movement;

        // Check if Characters Within the MaxDistance
        if (Vector3.Distance(startPosition, newPosition) <= maxDistance)
        {
            // Move if Allowed
            transform.position = newPosition;
        }
       
    }

}
