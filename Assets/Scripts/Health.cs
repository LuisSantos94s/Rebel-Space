using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public float health = 50f;
    public GameObject explosion;
    public GameObject gameOverImg;
    private bool gameOver;


    void Start()
    {
        gameOver = false;
        gameOverImg.SetActive(false);
    }

    public void RemoveHealth (float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Instantiate(explosion, transform.position, transform.rotation);
            gameOver = false;
            gameOverImg.SetActive(false);
            Destroy(gameObject);
        }
    }
}
