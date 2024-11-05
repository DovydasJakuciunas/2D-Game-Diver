using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public PowerUpEffect powerupEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
            powerupEffect.Apply(collision.gameObject);
            Destroy(gameObject);
        
       
    }
}