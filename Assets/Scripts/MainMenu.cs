using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Playing");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
