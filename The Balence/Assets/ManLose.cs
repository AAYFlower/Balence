using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManLose : MonoBehaviour
{
    public Sprite deadsprite;
    Animator anim;
    public GameObject blood;
    SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void manLose()
    {
        sr.sprite = deadsprite;
        blood.SetActive(true);
    }
}
