using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/speedUp")]

public class Speed : PowerUpEffect
{
    public int amount;

    //Overrides method to its own apply
    public override void Apply(GameObject target)
    {
        //Get things from attributeManager for speed and uses it
       PlayerMovement speed = target.GetComponent<PlayerMovement>();
        Debug.Log("Got to Speed Up");
        if (speed != null)
        {
            playerSpeed.setSpeed(amount);
            ScoreManager.Instance.AddPoint(amount);
        }
        
    }
}
