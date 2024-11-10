using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/slowDown")]

public class SlowDown : PowerUpEffect
{
    public int amount;

    //Overrides method to its own apply
    public override void Apply(GameObject target)
    {
        //Get things from attributeManager for speed and uses it
        AttributeManager speed = target.GetComponent<AttributeManager>();
        if (speed != null)
        {
            if (speed.getSpeed() != 5){}
            else
            {
                amount = Mathf.Abs(amount) * -1; //Make it so that its always negative
                speed.setSpeed(amount);
            }
        }

    }
}
