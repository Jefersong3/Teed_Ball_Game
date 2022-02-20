using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiManager : MonoBehaviour
{
    public static uiManager instance;
    public GameObject [] lives;

    public void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetLives(int amount)
    {
        for (int i = 0; i < lives.Length; i++)
        {
            lives[i].SetActive(false);
        }

        for (int i = 0; i < amount; i++)
        {
            lives[i].SetActive(true);
        }
    }
}
