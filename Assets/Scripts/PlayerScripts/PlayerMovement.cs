using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    protected int playerSpeed= 5;

    internal int getSpeed()
    {
        return playerSpeed;
    }

    internal void setSpeed(int amount)
    {
        playerSpeed += amount;
    }
}
