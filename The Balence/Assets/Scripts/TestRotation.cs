﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRotation : MonoBehaviour
{
    public float RotateAcceleration;
    public float rotateSpeed;
    private Rigidbody2D rb2D;
    private float speedRotate;
    bool isrotating;
   // public AudioSource sound;
    //public AudioClip platformSfx;

    // AudioSource audioData;

    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();

        //audioData = GetComponent<AudioSource>;
        //audioData.Play(0);
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
            // audioData.Play(1);
           // sound.PlayOneShot(platformSfx);

        }
        else if (Input.GetKey(KeyCode.D) && speedRotate >= -rotateSpeed)
        {
            //speedRotate -= RotateAcceleration;
            isrotating = true;
            //audioData.Play(1);
            //sound.PlayOneShot(platformSfx);

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
