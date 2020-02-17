using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Vector3 offset;
    public Transform followTarget;
    public float smoothspeed;
    private Vector3 playerxpos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        playerxpos = new Vector3(0, followTarget.position.y, 0);

        Vector3 desiredposition = playerxpos + offset;
        Vector3 smoothedposition = Vector3.Lerp(transform.position, desiredposition, smoothspeed * Time.deltaTime);
        transform.position = smoothedposition;
    }
}
