using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Temporizador : MonoBehaviour {

    public float tiempo = 60f;
    public Text time;

    public GameObject NextLvlImage;
    private bool NextLvl;

    public GameObject NextButton;
    private bool NextB;

    // Use this for initialization
    void Start () {
        Time.timeScale = 1f;
        NextLvl = false;
        NextLvlImage.SetActive(false);
        NextB = false;
        NextButton.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {

        if (NextB && Input.GetKeyDown(KeyCode.N))
        {
            NextLevel();
        }

        tiempo -= Time.deltaTime;
        time.text = "Time: " + tiempo.ToString("f0");

        if (tiempo <= 0)
        {
            Time.timeScale = 0f;
            NextLvl = true;
            NextLvlImage.SetActive(true);
            NextB = true;
            NextButton.SetActive(true);
        }
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
