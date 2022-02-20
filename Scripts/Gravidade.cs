using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravidade : MonoBehaviour
{
    public GameObject[] planet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        planet = GameObject.FindGameObjectsWithTag("Planet");
        foreach(GameObject p in planet)
        {
           if(Vector3.Distance(p.transform.position, transform.position) < 5)
           {
               transform.position += (p.transform.position - transform.position) * 5 * Time.deltaTime;
           }
        }
    }   
}
