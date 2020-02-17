using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobaCup : MonoBehaviour
{

    public float speed;
    Rigidbody2D rb;
    public bool isRight;
    Collider2D cd;
    SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        cd = GetComponent<Collider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (isRight == true)
        {
            
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        if (isRight == false)
        {
            
            transform.Translate(-Vector2.right * speed * Time.deltaTime);
        }
    }

   

    private void OnCollisionStay2D(Collision2D collision)
    {
       
            if (collision.gameObject.tag == "Wall")
            {
                Flip();
            }

           
        
    }



    void Flip()
    {
        isRight = !isRight;
    }
}
