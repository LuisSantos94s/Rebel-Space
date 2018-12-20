﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotate : MonoBehaviour {

    public float tumble;
    private Rigidbody rb;

    void Awake ()
    {
        rb = GetComponent<Rigidbody>();
    }

	void Start () {
        Vector3 angularVelocity = new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), Random.Range(-1, 1)).normalized;
            rb.angularVelocity = angularVelocity * tumble;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
