using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRotation : MonoBehaviour
{
    public float RotateAcceleration;
    public float rotateSpeed;
    private Rigidbody2D rb2D;
    private float speedRotate;
    bool isrotating;


    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        speedRotate -= Input.GetAxisRaw("Horizontal") * RotateAcceleration;

        Debug.Log(Input.GetAxisRaw("Horizontal"));
        if (Input.GetKey(KeyCode.A) && speedRotate <= rotateSpeed)
        {
            //speedRotate += RotateAcceleration;
            isrotating = true;

        }
        else if (Input.GetKey(KeyCode.D) && speedRotate >= -rotateSpeed)
        {
            //speedRotate -= RotateAcceleration;
            isrotating = true;

        }
        else
        {
            isrotating = false;
        }

        if (isrotating == false)
        {
            if (speedRotate > 0)
            {
                speedRotate -= RotateAcceleration;
            }
            if (speedRotate < 0)
            {
                speedRotate += RotateAcceleration;
            }
        }

        rb2D.MoveRotation(rb2D.rotation + speedRotate * Time.fixedDeltaTime);
    }
}
