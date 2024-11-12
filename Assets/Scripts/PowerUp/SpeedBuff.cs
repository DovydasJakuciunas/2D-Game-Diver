using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(menuName = "Powerups/speedUp")]

public class Speed : PowerUpEffect
{
    public int amount;

     PlayerMovement speed;

    public override void Apply(GameObject target)
    {
        SoundManager.Instance.PlaySound2D("Score");

        speed = target.GetComponent<PlayerMovement>();
        //Get things from attributeManager for speed and uses it
        if (target.CompareTag("Player"))
        {
            if (speed.getSpeed() != 0)
            {
                speed.setSpeed(amount);
                
                if (SceneManager.GetActiveScene().name != "MainMenu") //To make sure in main menu it doesnt count score
                {
                    ScoreManager.Instance.AddPoint(amount);
                }
                    
                
            }
        }
        
        
    }
}
