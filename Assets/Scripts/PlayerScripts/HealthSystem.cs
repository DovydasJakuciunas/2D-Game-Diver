using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public int health;
    public int maxHealth = 10;

    //For Health Bar to Work
    public static event Action OnPlayerDamaged;

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
        OnPlayerDamaged?.Invoke();
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

}
