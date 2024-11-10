using UnityEngine;

public class ObjectsFlyingBy : AttributeManager
{
    private float speed;
    public override void speedSetter()
    {
        // Move Object Based on Speed
        transform.position += speed * Time.deltaTime * Vector3.left;

        // Destroy if its Beyond This
        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        //Finding Random Variable for Speed
        speed = Random.Range(3.0f, 10.0f);
        
    }

    void Update()
    {   
         speedSetter();
    }

}
