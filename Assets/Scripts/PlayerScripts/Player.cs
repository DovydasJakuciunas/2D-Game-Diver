using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;

    //Player Movement
    [SerializeField]
    private float speed ;
    [SerializeField]
    private float maxDistance = 5f;
    private Vector3 startPosition;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // Record the starting position
        startPosition = transform.position;
    }

    void Update()
    {
        // Inputs
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Movement Getter
        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0) * speed * Time.deltaTime;

        // Move the Character
        Vector3 newPosition = transform.position + movement;

        // Check if Characters Within the MaxDistance
        if (Vector3.Distance(startPosition, newPosition) <= maxDistance)
        {
            // Move if Allowed
            transform.position = newPosition;
        }
    }

    // Allow speed to be accessible to other classes
    public float Speed
    {
        get { return speed; }
        set { speed = value; }
    }
}
