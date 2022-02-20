using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameController : MonoBehaviour
{

    public int totalQuantCoin;
    public Text quantText;

    
    public static gameController instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

   
    public void updateQuantText()
    {
        quantText.text = totalQuantCoin.ToString();
    }

}
