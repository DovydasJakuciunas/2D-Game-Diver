using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField]
    private PlayerMovement speed;

    //Boundery Finder
    private Vector2 screenBounds;
    private float playerHalfWidth;
    private float playerHalfHeight;

    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = GetComponent<PlayerMovement>();

        // Finds out the Screen size       
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        playerHalfWidth = GetComponent<SpriteRenderer>().bounds.extents.x;
        playerHalfHeight = GetComponent<SpriteRenderer>().bounds.extents.y;

        MusicManager.Instance.PlayMusic("Playing");
    }

    void Update()
    {
        // Inputs
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Movement Getter
        Vector2 movement = speed.getSpeed() * Time.deltaTime * new Vector2(moveHorizontal, moveVertical);

        // Move the Character
        transform.Translate(movement);

        //Finding the Boarder for the screen Vertical and Horizontal
        float clampedX = Mathf.Clamp(transform.position.x, -screenBounds.x + playerHalfWidth, screenBounds.x -playerHalfWidth);
        float clampedY = Mathf.Clamp(transform.position.y, -screenBounds.y + playerHalfHeight, screenBounds.y - playerHalfHeight);
        Vector2 pos = transform.position;   //Get players current position
        pos.x = clampedX;   //Re-assign the X value to the clamped position
        pos.y = clampedY;
        transform.position = pos;   //Re-assign the clamped value back to the player
    }


    
}
