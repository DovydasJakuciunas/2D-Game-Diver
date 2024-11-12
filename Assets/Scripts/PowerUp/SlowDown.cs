using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/slowDown")]

public class SlowDown : PowerUpEffect
{
    public int amount;
    private PlayerMovement speed;

    //Overrides method to its own apply
    public override void Apply(GameObject target)
    {
        

        if (target.CompareTag("Player"))
        {
            speed = target.GetComponent<PlayerMovement>();
            if (speed.getSpeed() <= 7){}
            else
            {
                SoundManager.Instance.PlaySound2D("Score");
                amount = Mathf.Abs(amount) * -1; //Make it so that its always negative
                speed.setSpeed(amount);
            }

            
        }

    }
}
