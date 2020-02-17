using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishBehavior : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    public bool movingright;
    FishBehavior fb;
    Petmanager pm;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        fb = GetComponent<FishBehavior>();
        pm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<Petmanager>();
        pm.addFish();

    }

    // Update is called once per frame
    void Update()
    {
        

        if(movingright == true)
        {
            rb.velocity = transform.right * speed;
        }

        if(movingright == false)
        {
            rb.velocity = -transform.right * speed;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
         if (collision.gameObject.tag == "FishTank")
        {
            movingright = !movingright;
            Vector3 newScale = gameObject.transform.localScale;
            newScale.x *= -1;
            gameObject.transform.localScale = newScale;
        }

         if(collision.gameObject.tag == "Hook")
        {
            rb.velocity = Vector3.zero;
            fb.enabled = false;
            gameObject.transform.parent = collision.gameObject.transform;
            gameObject.transform.position = collision.gameObject.transform.position;
            collision.GetComponent<Hook>().Hooked();
        }

         if(collision.gameObject.tag == "KillFish")
        {
            pm.SubtractFish();
            Destroy(gameObject);
        }
    }

}
