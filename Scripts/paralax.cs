using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paralax : MonoBehaviour
{
    private float length;
    private float startPos;
    private Transform can;

    public float paralaxEffect;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
        can = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        float restarPos = can.transform.position.x * (1 - paralaxEffect);
        float distance = can.transform.position.x * paralaxEffect;

        transform.position = new Vector3(startPos + distance, transform.position.y, transform.position.z);

        if(restarPos > startPos + length)
        {
            startPos += length;
        }
        else if(restarPos < startPos - length)
        {
            startPos -= length;
        }
    }
}
