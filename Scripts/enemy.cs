using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    private Rigidbody2D rig;
    private Animator anin;


    public float speed;
    public float distance;

    bool isRight = true;

    public Transform groundCheck;

    public BoxCollider2D boxCollider2D;
    public CircleCollider2D circleCollider2D;


    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anin = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        

        RaycastHit2D ground = Physics2D.Raycast(groundCheck.position, Vector2.down, distance);
        

        if(ground.collider == false)
        {
            if(isRight == true)
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                isRight = false;
            }else
            {
                transform.eulerAngles = new Vector3(0, 180, 0);
                isRight = true;
            }

        }
    }

    private void DestryBody()
    {
        Destroy(gameObject);
    }

    /*void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            float height = col.contacts[0].point.y - headPoint.position.y;

            if(height > 0)
            {
                col.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 15, ForceMode2D.Impulse);
                speed = 0;
                anin.SetTrigger("die");
                boxCollider2D.enabled = false;
                circleCollider2D.enabled = false;
                rig.bodyType = RigidbodyType2D.Kinematic;
                Destroy(gameObject, 0.15f);
            } 
        }
    } */
}
