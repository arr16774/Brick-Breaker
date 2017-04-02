using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloques : MonoBehaviour {

	public UiManagerScore ui;

	// Use this for initialization
	void Start () {
		ui = GameObject.FindWithTag("ui").GetComponent<UiManagerScore>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.name == "bolaRosa" || col.gameObject.name== "bolaRosa(Clone)")
		{
			ui.AumentarPunteo();
			Destroy(gameObject);
			
			
		}

	}
}
