﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandSpawner : MonoBehaviour
{
    public GameObject bullet;
    public float fireRate;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;

    }

    // Update is called once per frame
    void Update()
    {

        timer += 1 * Time.deltaTime;

        if (timer >= fireRate)
        {
            Instantiate(bullet, gameObject.transform.position, gameObject.transform.rotation);
            timer = 0;
        }
    }
}
