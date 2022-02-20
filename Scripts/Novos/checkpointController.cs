using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class checkpointController : MonoBehaviour
{

    public Transform player;

    private Vector3 respawnPosition;

    public UnityEvent onRestart;

    public string lvlName;

    public void SetPos(Vector3 pos)
    {
        respawnPosition = pos;
    }

    public void GameOver()
    {
        
        SceneManager.LoadScene(lvlName);
        
    }

    public void Restart()
    {
        player.position = respawnPosition;
        onRestart.Invoke();
    }
    
}
