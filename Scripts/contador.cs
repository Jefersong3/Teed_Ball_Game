using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class contador : MonoBehaviour
{
    public string lvlName;
    public float tempo;
    public Text tempoTxt;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        tempo = tempo - Time.deltaTime;
        tempoTxt.text = tempo.ToString("f0");
        
        if(tempo <= 0)
        {
            SceneManager.LoadScene(lvlName);
        }
    }

        
    
}
