using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endGame : MonoBehaviour
{


    public void EndGame()
    {
        SceneManager.LoadScene("Level_Menu");
    }
}
