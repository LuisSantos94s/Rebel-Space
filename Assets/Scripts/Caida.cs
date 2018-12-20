using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caida : MonoBehaviour {

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
