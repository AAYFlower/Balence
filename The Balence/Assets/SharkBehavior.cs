using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkBehavior : MonoBehaviour
{

    public float[] forceRange;
    public float timer;
    private float time;
    int randomRotate;
    Rigidbody2D rb;
    bool random;

    // Start is called before the first frame update
    void Start()
    {
        random = false;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(random == true)
        {
            randomRotate = 0;
        }

        if(random == false)
        {
            randomRotate = 1;
        }
        time += 1 * Time.deltaTime;

        if(time >= timer)
        {

            rb.AddTorque(forceRange[randomRotate]);
            random = !random;
            time = 0;
        }

        

        
    }
}
