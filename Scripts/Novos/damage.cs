using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class damage : MonoBehaviour
{
    public int maxHealth;
    public float invincibleTime;

    public UnityEvent OnDeath;
    public UnityEvent OnDamage;
    public UnityEvent RealeseDamage;

    private int currentHealth;
    private bool invincible;
    private bool isDead;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damageAmount)
    {
        if(invincible || isDead)
        {
            return;
        }

        OnDamage.Invoke();
        invincible = true;
        Invoke("SetInvincible", invincibleTime);
        currentHealth -= damageAmount;

        if(currentHealth <= 0)
        {
            isDead = true;
            OnDeath.Invoke();
        }

    }

    void SetInvincible()
    {
        invincible = false;
    }
}
