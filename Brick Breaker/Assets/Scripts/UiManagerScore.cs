using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManagerScore : MonoBehaviour {

	int punteo = 0;
	int vidas = 3;
	public Text texto;
	public Text vidastexto;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(vidas ==0)
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
		
	}

	public void AumentarPunteo()
	{
		punteo=punteo +10;
		texto.text = "Score: " + punteo;
	}

	public void DisminuirVidas()
	{
		vidas = vidas-1;
		vidastexto.text = "Vidas: "  + vidas;
	}
}
