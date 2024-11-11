using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/healing")]

public class HealthScript : PowerUpEffect
{
    public int amount;
    //Overrides method to its own apply
    public override void Apply(GameObject target)
    {
        //Get things from attributeManager for speed and uses it
        HealthSystem healing = target.GetComponent<HealthSystem>();
        if (healing != null)
        {
            SoundManager.instance.PlaySound2D("Heart");
            healing.Heal(amount);
            
        }

    }
}
