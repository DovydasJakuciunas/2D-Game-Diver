using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SharedSpeed", menuName = "GameSettings/SharedSpeed")]

public class SharedSpeed : ScriptableObject
{
    public Dictionary<EnemyType, float> enemySpeeds = new Dictionary<EnemyType, float> //Created a hash map to link <String , int> returning the int 
    {
        { EnemyType.FAST, 4.5f },
        { EnemyType.NORMAL, 3.0f },
        { EnemyType.SLOW, 2.5f }
    };

    public float GetSpeed(EnemyType type)
    {
        return enemySpeeds.ContainsKey(type) ? enemySpeeds[type] : 0.0f;
    }

    public void IncreaseSpeed(EnemyType type, float increment)
    {
        if (enemySpeeds.ContainsKey(type))
        {
            enemySpeeds[type] += increment;
        }
    }
}



