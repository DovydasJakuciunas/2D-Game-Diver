using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public PowerUpEffect powerupEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Only player object can collide with it
        if(collision.gameObject.CompareTag("Player"))
        {
            powerupEffect.Apply(collision.gameObject);
            Destroy(gameObject);
        }
       
    }
}
