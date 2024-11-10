using UnityEngine;

public class ObjectsFlyingBy : AttributeManager
{
    [SerializeField]
    private float speed=3;
  

    private void Start()
    {
        //Finding Random Variable for Speed
        speed = Random.Range(3.0f, 10.0f);
    }

    void Update()
    {
        speedSetter();
    }

    public override void speedSetter()
    {

        // Move Object Based on Speed
        transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);

        // Destroy if its Beyond This
        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
    }

}
