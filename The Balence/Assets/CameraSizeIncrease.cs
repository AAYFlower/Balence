using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSizeIncrease : MonoBehaviour
{
    Camera maincamera;
    public float IncreaseRate;
    public float maxCameraSize;
    // Start is called before the first frame update
    void Start()
    {
        maincamera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (maincamera.orthographicSize <= maxCameraSize)
        {
            maincamera.orthographicSize += IncreaseRate * Time.deltaTime;
        }
    }
}
