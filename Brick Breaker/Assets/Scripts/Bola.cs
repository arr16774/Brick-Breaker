using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour {


	bool gameStart = false;
	public UiManagerScore ui;


	// Use this for initialization
	void Start () {
		ui = GameObject.FindWithTag("ui").GetComponent<UiManagerScore>();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyUp(KeyCode.Space)&& gameStart == false)
		{
			transform.SetParent(null);
			GetComponent<Rigidbody2D>().isKinematic=false;

			GetComponent<Rigidbody2D>().AddForce(transform.up*250);
			GetComponent<Rigidbody2D>().AddForce(transform.right*250);
			gameStart = true;

		}
		
	}

	void OnBecameInvisible()
	{
		ui.DisminuirVidas();
		Destroy(this.gameObject);

	}
}
