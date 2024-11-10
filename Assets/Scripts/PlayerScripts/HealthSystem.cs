using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public int health = 10;
    public int maxHealth = 10;

    public void setMaxHealth(int amount)
    {
        maxHealth += amount;
    }

    void Awake()
    {
        health = maxHealth;
    }



    public void TakeDamage(int amount)
    {
        health -= amount;  
        if (health < 0)
        {
            Destroy(gameObject);
        }
    }

}
