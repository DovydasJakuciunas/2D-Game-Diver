using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : AttributeManager
{

    [SerializeField]
    private int maxHealth = 10;

    private void Start()
    {
        playerHealth = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        playerHealth -= amount;
        Debug.Log("Player Damaged");
        if (playerHealth < 0)
        {

            Destroy(gameObject);
        }
    }

}
