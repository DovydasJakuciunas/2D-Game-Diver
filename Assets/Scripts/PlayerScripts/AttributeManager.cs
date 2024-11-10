using UnityEngine;

public class AttributeManager : MonoBehaviour
{
    
    protected int playerHealth ;

    [SerializeField]
    protected int playerSpeed =5;


    public void setSpeed(int speed)
    {
        playerSpeed += speed;
    }
    public int getSpeed() { return playerSpeed; }

    public int getHealth( ) { return playerHealth; }
    public void setHealth(int health) { playerHealth = health; }
}
