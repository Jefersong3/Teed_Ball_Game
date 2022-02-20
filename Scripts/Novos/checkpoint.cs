using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{
    public Sprite checkpointOn;
    private SpriteRenderer spriteRenderer;
    private checkpointController checkController;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }  

    public void Start()
    {
        checkController = FindObjectOfType<checkpointController>();
    }  

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            checkController.SetPos(transform.position);
            spriteRenderer.sprite = checkpointOn;
        }
    }
}
