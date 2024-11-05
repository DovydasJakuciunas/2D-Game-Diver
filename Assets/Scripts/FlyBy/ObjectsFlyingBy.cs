using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsFlyingBy : MonoBehaviour
{

    [SerializeField]
    [Range(0f, 10f)]
    private float speed = 1.0f;
    
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if(transform.position.x <-10f)
        {
            Destroy(gameObject);
        }
    }
}
