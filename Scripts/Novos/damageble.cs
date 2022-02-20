using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class damageble : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;
    public float invencibleTime;
    private bool invencible;
    private bool isDead;

    public Color damageColor;

    private SpriteRenderer spriteRenderer;
    private Color startColor;

    public float noControlTime = 0.1f;

    public Vector2 impactForce;
    private float x;

    public UnityEvent onDeath;
    public UnityEvent onDamage;
    public UnityEvent ReleaseDemage;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        startColor = spriteRenderer.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damageAmount, float xPos = 0)
    {
        if(invencible || isDead)
        {
            return;
        }

        x = xPos;
        onDamage.Invoke();
        invencible = true;
        Invoke("SetInvencible", invencibleTime);
        Invoke("GainControl", noControlTime);
        currentHealth -= damageAmount;

        if(gameObject.CompareTag("Player"))
        {
            uiManager.instance.SetLives(currentHealth);
        }

        if(currentHealth <= 0)
        {
            isDead = true;
           
            onDeath.Invoke();
        }
    }

    void GainControl()
    {
        if(isDead)
        {
            return;
        }

        ReleaseDemage.Invoke();
    }

    public void DamageImpact()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        if(rb != null)
        {
            float dir = 0;
            if(x < transform.position.x)
            {
                dir = 1;
            }
            else
            {
                dir = -1;
            }

            rb.velocity = Vector2.zero;
            rb.AddForce(new Vector2(impactForce.x * dir, impactForce.y), ForceMode2D.Impulse);
        }
    }

    public void SetInvencible()
    {
        invencible = false;
    }

    public void StartDamageSprite()
    {
        StartCoroutine(DamageSprite());
    }

    IEnumerator DamageSprite()
    {
        float timer = 0;
        while(timer < invencibleTime)
        {
            spriteRenderer.color = damageColor;
            yield return new WaitForSeconds(0.1f);
            timer += 0.1f;
            spriteRenderer.color = startColor;
            yield return new WaitForSeconds(0.1f);
            timer += 0.1f;
        }

        spriteRenderer.color = startColor;
    }

    public void Respawn()
    {
        isDead = false;
        currentHealth = 3;
        uiManager.instance.SetLives(currentHealth);
    }
}
