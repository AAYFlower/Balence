using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollision : MonoBehaviour
{
    public Collider2D ignoreCollider;
    // Start is called before the first frame update
    void Start()
    {
        Physics2D.IgnoreCollision(ignoreCollider, GetComponent<Collider2D>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
