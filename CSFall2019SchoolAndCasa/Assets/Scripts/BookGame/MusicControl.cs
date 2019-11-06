using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;

public class MusicControl : MonoBehaviour
{
    private AudioSource audioSourceMusic;

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        audioSourceMusic = GetComponent<AudioSource>();
    }
    
    public void PlayMusic()
    {
        if (audioSourceMusic.isPlaying) return;
        audioSourceMusic.Play();
    }

    public void StopMusic()
    {
        audioSourceMusic.Stop();
    }
}