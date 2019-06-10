using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pip : MonoBehaviour
{
    public float speed;
    public contrl contrl;
    void Start()
    {
        transform.position += new Vector3(0, Random.Range(-1f, 1f),0);
        
            Destroy(gameObject, 6);

        contrl = GameObject.Find("Main Camera").GetComponent<contrl>();
    }

   
    void Update()
    {
        if(contrl.activ)
        {
            transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);

        }
       
    }

    


}
