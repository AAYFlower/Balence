using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelSelectSnap : MonoBehaviour
{
    public Transform Container;
    public float lerpTime;
    public Vector3 NewLocation;
    bool isMoving;
    public Transform centerButton;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //myScrollRect.horizontalNormalizedPosition += 0.5f;
        if (Container.position != NewLocation && isMoving)
            Container.position = Vector3.Lerp(Container.position, NewLocation, lerpTime * Time.deltaTime);
        if(Vector3.Distance(Container.position,NewLocation) < 0.1f)
        {
            Container.position = NewLocation;
            isMoving = false;
        }
    }

    public void ScrollRight()
    {
        //NewLocation = transform.position + new Vector3(200f, 0, 0);

    }
    public void Scrollleft(){

    }
}
