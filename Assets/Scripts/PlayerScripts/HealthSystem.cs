using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    private int health;
    private int maxHealth = 10;

    //For Health Bar to Work
    public static event Action OnPlayerDamaged;
    public static event Action OnPlayerHeal;

    public  int getMaxHealth()
    {
        return maxHealth;
    }

    public int getHealth()
    {
        return health;
    }

    public void Heal(int amount)
    {

        health += amount;
        OnPlayerHeal?.Invoke();
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
