using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, yMin, yMax;
}
public class PlayerController : MonoBehaviour {
    
    private Rigidbody rb;

    [Header("Movement")]
    public float Speed;
    public float tilt;
    public Boundary boundary;

    [Header("Shooting")]
    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    private float nextFire;

	void Awake () {

        rb = GetComponent<Rigidbody>();
		
	}

    void Update()
    {
        if (CrossPlatformInputManager.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, Quaternion.identity);
        }
    }

	void FixedUpdate () {
        float InputX = CrossPlatformInputManager.GetAxis("Horizontal");
        float InputY = CrossPlatformInputManager.GetAxis("Vertical");

        Vector3 movement = new Vector3(InputX, InputY, 0);
        rb.velocity = movement * Speed;
        rb.position = new Vector3(Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax), Mathf.Clamp(rb.position.y, boundary.yMin, boundary.yMax),0);
        rb.rotation = Quaternion.Euler(-90, rb.velocity.x * -tilt, 0f);
	}
}
