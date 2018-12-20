using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {

	int contador1;
	int contador2;
	public Text Score1;
	public Text Score2;
	public Text contador;

	private float tiempo = 150f;

	void Start () {
		contador.text = " " + tiempo;
	}

	// Update is called once per frame
	void Update () {
		tiempo -= Time.deltaTime;
		contador.text = " " + tiempo.ToString ("f0");

		if (tiempo <= 0) { 

			PlayerWins ();

		} 

	}

	public void OnTriggerEnter(Collider Porteria)
	{
		if (Porteria.gameObject.tag == "Porteria1") {
			contador1 = contador1 + 1;
			Score1.text = " " + contador1;
		}

		if (Porteria.gameObject.tag == "Porteria2") {
			contador2 = contador2 + 1;
			Score2.text = " " + contador2;
		}
	}

	public void Awake()
	{
		contador1 = 0;
		Score1.text = " " + contador1;
		contador2 = 0;
		Score2.text = " " + contador2;
	}
	
	public void PlayerWins () {

		if (contador1 > contador2) {
			SceneManager.LoadScene ("Player1Wins");
		} else if (contador1 < contador2) {
			SceneManager.LoadScene ("Player2Wins");
		} else if (contador1 == contador2) {
			SceneManager.LoadScene ("Empate");
		}
	}
}
