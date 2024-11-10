using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public int health;
    [SerializeField]
    protected int maxHealth = 10;

    void Start()
    {
        Debug.Log("HealthActivate");
        health = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        Debug.Log("Player Damaged: "+ amount);
        if (health < 0)
        {
            Destroy(gameObject);
        }
    }

}
