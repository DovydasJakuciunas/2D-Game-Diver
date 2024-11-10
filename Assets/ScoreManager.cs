using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public TMP_Text scoreText;
    public TMP_Text highscoreText;
    public SharedSpeed SharedSpeed;

    public int score = 0;
    public int highscore = 0;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = score.ToString() + " POINTS";
        highscoreText.text = "HIGHSCORE: " + highscore.ToString();
        PlayerPrefs.DeleteKey("highscore");
    }

    public void AddPoint(int amount)
    {
        score += amount;
        scoreText.text = score.ToString() + " POINTS";
        if (highscore < score)
        {
            PlayerPrefs.SetInt("highscore", score);
        }

        foreach (EnemyType type in System.Enum.GetValues(typeof(EnemyType)))
        {
            float increment = type switch
            {
                EnemyType.FAST => 0.1f,
                EnemyType.NORMAL => 0.5f,
                EnemyType.SLOW => 0.2f,
                _ => 0f
            };
            SharedSpeed.IncreaseSpeed(type, increment);
        }     
    }
}
