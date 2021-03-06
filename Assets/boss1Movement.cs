﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss1Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float movementSpeed = 0.000005f;
    public bool triggered = false;
    private AudioSource source;
    public AudioClip shootSound;


    void Awake()
    {
        source = GetComponent<AudioSource>();

    }





    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        

        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (triggered && rb.velocity.x<2f)
        {
            //gameObject.transform.position.x += forceIncrement;
            rb.AddForce(Vector3.right * movementSpeed);
            source.PlayOneShot(shootSound, 1f);
        }

        //Debug.Log(triggered);
    }
}
