using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/speedUp")]

public class Speed : PowerUpEffect
{
    public int amount;

    //Overrides method to its own apply
    public override void Apply(GameObject target)
    {
        //Get things from attributeManager for speed and uses it
       AttributeManager speed = target.GetComponent<AttributeManager>();
        if (speed != null)
        {
            speed.setSpeed(amount);
            ScoreManager.Instance.AddPoint(amount);
        }
        
    }
}
