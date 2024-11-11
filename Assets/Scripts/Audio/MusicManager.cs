using System.Collections;
using UnityEngine;

public class MusicManager : MonoBehaviour
{

    public static MusicManager Instance;

    [SerializeField]
    private MusicLibrary musicLibrary;
    [SerializeField]
    private AudioSource musicSource;

    private void Awake()
    {
        if(Instance != null )
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void PlayMusic(string trackName, float fadeDuration = 0.5f)
    {
        StartCoroutine(AnimateMusicCrossfade(musicLibrary.GetClipFromName(trackName), fadeDuration));
    }

    //https://www.youtube.com/watch?v=Q-bKHocRvE0 : got the fade method from this video at 3:01
    IEnumerator AnimateMusicCrossfade(AudioClip nextTrack, float fadeDuration = 0.5f)    
    {
        float percent = 0;      //temp 
        while (percent < 1)     
        {
            percent += Time.deltaTime * 1 / fadeDuration;   
            musicSource.volume = Mathf.Lerp(1f,0 , percent);    //Fade out music
            yield return null;
        }

        musicSource.clip = nextTrack;   //new track
        musicSource.Play();

        percent = 0;        //reset percentage and do it all again
        while(percent < 1)
        {
            percent += Time.deltaTime * 1 / fadeDuration;
            musicSource.volume = Mathf.Lerp(-1f,0 , percent);
            yield return null;
        }
    }
}
