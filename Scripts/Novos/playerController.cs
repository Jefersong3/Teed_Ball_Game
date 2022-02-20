using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    [RequireComponent(typeof(Rigidbody2D))]
public class playerController : MonoBehaviour
{
    public float jumForce = 550;
    public Transform groundCheck;
    public float groundRadius = 0.1f;
    public LayerMask groundLayer;
    public AudioSource audioJump;

    [SerializeField]
    private float walkSpeed;

    private Rigidbody2D rb;
    private Vector2 newMoviment;

    private bool facingRight = true;

    private bool jump;
    private bool grounded;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, groundLayer);

    }

    private void FixedUpdate()
    {
        rb.velocity = newMoviment;

        if(jump)
        {
            jump = false;
            // rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * jumForce);
        }
    }

    public void Jump()
    {

        if(grounded)
        {
            jump = true;
            audioJump.Play();
        }

    }

    public void Move(float direction)
    {
        float currentSpeed = walkSpeed;
        newMoviment = new Vector2(direction * currentSpeed, rb.velocity.y);

        if(facingRight && direction < 0)
        {
           Flip();
        }
        else if(!facingRight && direction > 0)
        {
            Flip();
        }
    }

    void Flip()
    {
        facingRight = !facingRight;

        transform.Rotate(0, 180, 0);
    }
}
