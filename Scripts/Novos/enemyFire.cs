using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFire : MonoBehaviour
{
    public Rigidbody2D bulletPrefab;
    public Transform shotSpawn;
    public Vector2 shotImpulse; 
    public float timeBetween;
    public AudioSource audioFire;

    // Update is called once per frame
    void Update()
    {
        if(timeBetween <= 0)
        {
             Fire();
             timeBetween = 3f;
        }
        else
        {
            timeBetween -= Time.deltaTime;
        }
      
    }

    public void Fire()
    {
        Rigidbody2D newBullet = Instantiate(bulletPrefab, shotSpawn.position, transform.rotation);
        newBullet.AddForce(shotImpulse, ForceMode2D.Impulse);
        audioFire.Play();
        Destroy(newBullet.gameObject, 5f);
    }
}
