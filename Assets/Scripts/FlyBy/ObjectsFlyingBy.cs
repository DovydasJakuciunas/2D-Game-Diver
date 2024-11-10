using UnityEngine;

public class ObjectsFlyingBy : MonoBehaviour
{
    
    [SerializeField]
    [Tooltip("This is the base speed for enemies. They get speed increased with score of the player")]
    private float speed ;

    private void Start()
    {
        //Finding Random Variable for Speed
        speed = Random.Range(3.0f, 10.0f);
    }

    void Update()
    {
        if(tag == " Score")
        {
            // Move Object Based on Speed
            transform.position += speed * Time.deltaTime * Vector3.left;

            // Destroy if its Beyond This
            if (transform.position.x < -10f)
            {
                Destroy(gameObject);
            }
        }

        if (tag == "Enemy")
        {

        }
    }
}
