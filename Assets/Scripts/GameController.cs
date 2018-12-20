using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {


    public GameObject[] items;
    public Vector3 spawnValues;
    public int itemCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;

    public int score;
    public Text scoreText;

    public GameObject gameOverImg;
    public GameObject restartGameObject;
    public GameObject menuGameObject;
    private bool restart;
    private bool gameOver;
    private bool menu;

    void Start () {

        restart = false;
        restartGameObject.SetActive(false);
        menu = false;
        menuGameObject.SetActive(false);
        gameOver = false;
        gameOverImg.SetActive(false);
        score = 0;
        UpdateScore();
        StartCoroutine(SpawnWaves());
		
	}

    void Update()
    {
        if(restart && Input.GetKeyDown(KeyCode.R))
        {
            Restart();
        }

        if (menu && Input.GetKeyDown(KeyCode.M))
        {
            Menu();
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < itemCount; i++)
            {
                GameObject item = items[Random.Range(0, items.Length)]; 
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Instantiate(item, spawnPosition, Quaternion.identity);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);

            if (gameOver)
            {
                restartGameObject.gameObject.SetActive(true);
                restart = true;
                menuGameObject.gameObject.SetActive(true);
                menu = true;
                break;
            }
        }
    }

    public void AddScore(int value)
    {
        score += value;
        UpdateScore();
    }


    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        gameOverImg.SetActive(true);
        gameOver = true;
    }
}
