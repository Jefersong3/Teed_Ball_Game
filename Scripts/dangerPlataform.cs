using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dangerPlataform : MonoBehaviour
{
    public float plataformTime;

    private TargetJoint2D target;
    private BoxCollider2D boxColl;

    // Start is called before the first frame update
    void Start()
    {
        target = GetComponent<TargetJoint2D>();
        boxColl = GetComponent<BoxCollider2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Invoke("Action", plataformTime);
        }
 
    }

     void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.layer == 7)
        {
            Destroy(gameObject);
            
        }
    }

    void Action()
    {
        target.enabled = false;
        boxColl.isTrigger = true;
    }

}
