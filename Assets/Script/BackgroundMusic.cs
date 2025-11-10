using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public static BackgroundMusic bgmusic;
    AudioSource audioSource;

    void Awake()
    {
        if (bgmusic == null)
        {
            bgmusic = this;
            DontDestroyOnLoad(gameObject);
            audioSource = GetComponent<AudioSource>();
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void PauseMusic()
    {
        if (audioSource != null) audioSource.Pause();
    }

    public void ResumeMusic()
    {
        if (audioSource != null) audioSource.UnPause(); // resumes from Pause()
    }

    public void RestartMusic()
    {
        if (audioSource != null)
        {
            audioSource.Stop();  // stop current playback
            audioSource.Play();  // restart from beginning
        }
    }


    


}
