using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void Start()
    {
        MusicManager.Instance.PlayMusic("MainMenu");
    }
    public void Play()
    {
        SceneManager.LoadScene("Playing");
        MusicManager.Instance.PlayMusic("Playing");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
