using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/speedUp")]

public class Speed : PowerUpEffect
{
    public int amount;
    public override void Apply(GameObject target)
    {
       AttributeManager speed = target.GetComponent<AttributeManager>();
        if (speed != null)
        {
            speed.setSpeed(amount);
        }
        
    }
}
