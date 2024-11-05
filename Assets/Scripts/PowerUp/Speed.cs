using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/speedUp")]

public class Speed : PowerUpEffect
{
    public float amount;
    public override void Apply(GameObject target)
    {
       target.GetComponent<PlayerMovement>().speed += amount;
    }
}
