using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class audioManager : MonoBehaviour
{
    public string nomeDaCena;
    // Start is called before the first frame update
    void Start()
    {
        GameObject audioSourceGameObject = GameObject.Find("AudioController");

        AudioSource source = audioSourceGameObject.GetComponent<AudioSource>();

        source.Play();
        source.Stop();
        source.UnPause();
        source.Pause();

        if(SceneManager.GetActiveScene().name == nomeDaCena)
        {
            source.Play();
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            source.Stop();
        }
    }


   
}
