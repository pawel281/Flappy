using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class contrl : MonoBehaviour
{
    public GameObject Tr;
    public bool activ;
    public GameObject back;
    public int score;
    public GameObject Gscore;
    void Start()
    {
      
        Invoke("Create",1);
        activ = true;

    }


    public void Update()
    {
        Gscore.GetComponent<Text>().text = score+"";
    }

    private void Create()
    {
        Instantiate(Tr,new Vector2(10,-5),Quaternion.identity);
        Invoke("Create", 1);

    }

   
}
