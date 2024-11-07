using UnityEngine;

public class ObjectsFlyingBy : MonoBehaviour
{
    private float speed ;

    private void Start()
    {
        //Finding Random Variable for Speed
        speed = Random.Range(3.0f, 10.0f);
    }

    void Update()
    {
        // Move Object Based on Speed
        transform.position += speed * Time.deltaTime * Vector3.left;

        // Destroy if its Beyond This
        if(transform.position.x <-10f)
        {
            Destroy(gameObject);
        }
    }
}
