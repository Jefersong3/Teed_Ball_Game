using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

    [DefaultExecutionOrder(-100)]
public class playerImput : MonoBehaviour
{
    public playerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        playerController.Move(CrossPlatformInputManager.GetAxis("Horizontal"));
        //playerController.Move(Input.GetAxis("Horizontal"));
        

        if(CrossPlatformInputManager.GetButtonDown("Jump"))
        {
            playerController.Jump();
        }
    }
}
