using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{

    public float speed;
    public float jumpForce;

    public bool isJumping;
    public bool doubleJump;

    private Rigidbody2D rig;
    private Animator anin;


    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anin = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
        jump();
    }

    void move()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * speed;

        if(Input.GetAxis("Horizontal") > 0f)
        {
            anin.SetBool("walk", true);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }

        if(Input.GetAxis("Horizontal") < 0f)
        {
            anin.SetBool("walk", true);
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        }

        if(Input.GetAxis("Horizontal") == 0f)
        {
            anin.SetBool("walk", false);
        }
        
    }

    void jump()
    {
        if(Input.GetButtonDown("Jump") && !isJumping)
        {
          
                rig.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
                
                anin.SetBool("jump", true);
            
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer ==6)
        {
            isJumping = false;
            anin.SetBool("jump", false);
        }

        if(collision.gameObject.layer ==7)
        {
           Destroy(gameObject);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.layer ==6)
        {
            isJumping = true;
        }
    }

}
