using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextStage : MonoBehaviour
{
    public float timeLoad = 5;
    public string lvlName;
    public enum TipoCarreg {Carregamento, timeLoad};
    public TipoCarreg TipoDeCarregamento;

   void OnTriggerEnter2D(Collider2D collider)
   {
       if(collider.gameObject.tag == "Player")
       {
           Destroy(gameObject, 0.39f);
           SceneManager.LoadScene(lvlName);
       }
   }
}
