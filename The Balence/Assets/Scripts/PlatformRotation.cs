using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformRotation : MonoBehaviour
{

    
    
    public float RotateAcceleration;
    public float rotateSpeed;
    bool isrotating;
    private float speedRotate;
    

    // Start is called before the first frame update
    void Start()
    {
        isrotating = false;
    }

    // Update is called once per frame
    void Update()
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

        transform.Rotate(Vector3.forward * speedRotate * Time.deltaTime);
    }
}
