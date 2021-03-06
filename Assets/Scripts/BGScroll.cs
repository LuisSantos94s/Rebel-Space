﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroll : MonoBehaviour {

    public float scrollSpeed;

    private Vector3 startPosition;
    private float tileSize;

	// Use this for initialization
	void Start () {
        startPosition = transform.position;
        tileSize = transform.localScale.y;
	}
	
	// Update is called once per frame
	void Update () {
        float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSize);
        transform.position = startPosition + Vector3.up * newPosition;
	}
}
