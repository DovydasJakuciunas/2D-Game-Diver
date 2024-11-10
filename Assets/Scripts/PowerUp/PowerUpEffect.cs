using UnityEngine;

public abstract class PowerUpEffect : ScriptableObject
{
    protected PlayerMovement playerSpeed;
    public abstract void Apply(GameObject target);
}
