using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/speedUp")]

public class Speed : PowerUpEffect
{
    public int amount;

     PlayerMovement speed;

    public override void Apply(GameObject target)
    {
        speed = target.GetComponent<PlayerMovement>();
        //Get things from attributeManager for speed and uses it
        if (target.CompareTag("Player"))
        {
            if (speed.getSpeed() != 0)
            {
                speed.setSpeed(amount);
                ScoreManager.Instance.AddPoint(amount);
                
            }
        }
        
        
    }
}
