using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damager : MonoBehaviour
{
    public int power = 1;

    [Header("Shaker Values")]
    public float powerValue = 100;
    public float duration = 0.05f;

    public AudioSource audioDamage;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        damageble damageble = other.GetComponent<damageble>();
        if(damageble != null)
        {
            damageble.TakeDamage(power, transform.position.x);
            shaker.instance.SetValues(powerValue, duration);

            audioDamage.Play();
        }
    }
   
}
