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
        PlayerMovement speed = target.GetComponent<PlayerMovement>();
        Debug.Log("Got to Speed Down");
        if (speed != null)
        {
            if (playerSpeed.getSpeed() != 5){}
            else
            {
                amount = Mathf.Abs(amount) * -1; //Make it so that its always negative
                playerSpeed.setSpeed(amount);
            }
        }

    }
}
