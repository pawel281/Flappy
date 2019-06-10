using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class bird : MonoBehaviour
{
    private bool active;
    public float speed;
    private Rigidbody2D rg;
    void Start()
    {
        rg= GetComponent<Rigidbody2D>();
        active = true;
    }

   

    void  Update()
    {
        if(active)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rg.velocity = Vector3.zero;
                rg.AddForce(Vector3.up * speed, ForceMode2D.Impulse);


            }
        }
        rg.MoveRotation(rg.velocity.y * speed);
        Vector2 pos = Camera.main.WorldToScreenPoint(transform.position);
        if (pos.y>Screen.height || pos.y < 0) {
            Dead();
        }

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Dead();
    }

    private void Restart() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    private void Dead()
    {
        GameObject.Find("Main Camera").GetComponent<contrl>().activ = false;
        GameObject.Find("Main Camera").GetComponent<contrl>().back.GetComponent<Animator>().enabled = false;

        Invoke("Restart", 2f);
        active = false;

    }



}



