using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    void Start ()
    {
        Time.timeScale = 1f;
    }

	public void Menu ()
    {
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame ()
    {
        Application.Quit();
    }
}
