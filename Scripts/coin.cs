using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    private SpriteRenderer sr;
    private CircleCollider2D circle;

    public GameObject collected;
    public AudioSource audioCoinCollected;
    public int quantCoin;

    // Start is called before the first frame update
    void Start()
    {
        //processor.SetActive(false);
        sr = GetComponent<SpriteRenderer>();
        circle = GetComponent<CircleCollider2D>();

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            audioCoinCollected.Play();
            sr.enabled = false;
            circle.enabled = false;
            collected.SetActive(true);
            Destroy(gameObject, 0.39f);

        }
    }

}
