using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class processor : MonoBehaviour
{
    private SpriteRenderer sr;
    private BoxCollider2D box;

    public GameObject collected;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        box = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
      
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            sr.enabled = false;
            box.enabled = false;
            collected.SetActive(true);

            Destroy(gameObject, 0.34f);
        }
    }
}
