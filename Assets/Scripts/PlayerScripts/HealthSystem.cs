using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    [SerializeField]
    private int health;
    [SerializeField]
    private int maxHealth = 10;

    //For Health Bar to Work
    public static event Action OnPlayerDamaged;
    public static event Action OnPlayerHeal;

    public GameOverScreen gameOverScreen;

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
        if (health >= maxHealth){}
        else
        {
            health += amount;
            OnPlayerHeal?.Invoke();
        }
       
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
            gameOverScreen.Setup();
            Destroy(gameObject);
            
        }
    }

}
