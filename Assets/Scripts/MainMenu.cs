using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void Start()
    {
        MusicManager.Instance.PlayMusic("Main Menu");
    }
    public void Play()
    {
        SceneManager.LoadScene("Playing");
        MusicManager.Instance.PlayMusic("MainMenu");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
