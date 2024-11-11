using UnityEngine;

public class IncreaseSpeedWithScore : MonoBehaviour
{
    //Enemy Speed Linkage
    public SharedSpeed SharedSpeed;
    //Checking For last checked score
    private int lastScore = -1;
    // Update is called once per frame
    void Update()
    {
        // Checking if the singlton exsists, Checks if its only devisible by 10,Doesn't run if the lastScore is the same
        if (ScoreManager.Instance != null && ScoreManager.Instance.score % 10 == 0 &&
        ScoreManager.Instance.score != lastScore)
        {
            lastScore = ScoreManager.Instance.score;

            // Increase speed for each enemy type
            foreach (EnemyType type in System.Enum.GetValues(typeof(EnemyType)))
            {
                float amount = type switch
                {
                    EnemyType.FAST => 0.4f,
                    EnemyType.NORMAL => 0.3f,
                    EnemyType.SLOW => 0.2f,
                    _ => 0f
                };

                SharedSpeed.IncreaseSpeed(type, amount);
            }
        }
    }
}
