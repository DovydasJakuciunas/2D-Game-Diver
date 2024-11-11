using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    //All About the Score
    public static ScoreManager Instance;
    public TMP_Text scoreText;
    public TMP_Text highscoreText;
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

           
    }
}
