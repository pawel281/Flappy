using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
  

    
  public void OnTriggerEnter2D(Collider2D col)
    {
        GameObject.Find("Main Camera").GetComponent<contrl>().score++;
        GetComponent<BoxCollider2D>().enabled = false;
    }
}
