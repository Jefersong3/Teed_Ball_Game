using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    public float speed;
    public float jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Move()
    {
        Vector3 movement = new Vector3(Input.GetAxis("horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * speed;
    }
}
