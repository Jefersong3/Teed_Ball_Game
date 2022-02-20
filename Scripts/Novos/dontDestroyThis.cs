using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dontDestroyThis : MonoBehaviour
{
    public string cena1;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject); 
    }

}
