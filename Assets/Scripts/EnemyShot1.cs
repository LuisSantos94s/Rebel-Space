﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot1 : MonoBehaviour {

    public float speed;

    private Rigidbody rb;
	
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        rb.velocity = transform.up * speed;
    }
	
	
	void Update () {
		
	}
}
