using UnityEngine;

public class AttributeManager : MonoBehaviour
{
    [SerializeField]
    protected int playerHealth;

    [SerializeField]
    protected int playerSpeed =5;


    public void setSpeed(int speed)
    {
        playerSpeed += speed;
    }
    public int getSpeed() { return playerSpeed; }

    public void TakeDamage(int damage)
    {
        playerHealth -= damage;
    }

}
