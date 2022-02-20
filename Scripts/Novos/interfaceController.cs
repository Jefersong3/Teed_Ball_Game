using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class interfaceController : MonoBehaviour
{
    public AudioSource audioButoon;

    public string nomeDaCena;
    // Start is called before the first frame update
    public void ChangeS()
    {
        SceneManager.LoadScene(nomeDaCena);
        audioButoon.Play();
    }
}
