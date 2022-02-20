using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class musicContinua : MonoBehaviour
{
    private static musicContinua instance;
    public AudioSource BGM;
    public AudioClip track0;
    public AudioClip track1;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if(SceneManager.GetActiveScene().buildIndex == 0 && SceneManager.GetActiveScene().buildIndex < 1)
        {
            if(BGM.clip != track0)
            {
                 changeBGM(track0);
            }
        }

        if(SceneManager.GetActiveScene().buildIndex >= 1 && SceneManager.GetActiveScene().buildIndex < 8)
        {
            if(BGM.clip != track1)
            {
                changeBGM(track1);
            }
        }

        if(SceneManager.GetActiveScene().buildIndex > 8 && SceneManager.GetActiveScene().buildIndex <= 10)
        {
            if(BGM.clip != track0)
            {
                changeBGM(track0);
            }
        }
    }

    public void changeBGM(AudioClip music)
    {
        BGM.Stop();
        BGM.clip = music;
        BGM.Play();
    }
}
