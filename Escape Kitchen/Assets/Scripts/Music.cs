using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    private static Music instance;

    private AudioSource music;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            music = GetComponent<AudioSource>();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlayMusic()
    {
        if (music != null && !music.isPlaying)
        {
            music.Play();
        }
    }

    public void StopMusic()
    {
        if (music != null && music.isPlaying)
        {
            music.Stop();
        }
    }
}
