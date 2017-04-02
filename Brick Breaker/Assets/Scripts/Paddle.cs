using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	Vector2 paddle;
	float factorVel;
	public GameObject bola;

	// Use this for initialization
	void Start () 
	{

		paddle = new Vector2(0.0f,0.0f);
		factorVel = 20.0f;
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		paddle.x = 0;

		if(Input.GetKey(KeyCode.RightArrow))
			{
				paddle.x= factorVel * Time.deltaTime;
				transform.Translate(paddle);
			}
			
		if(Input.GetKey(KeyCode.LeftArrow))
			{
				paddle.x= -1*factorVel * Time.deltaTime;
				transform.Translate(paddle);
			}

		if(Input.GetKeyUp(KeyCode.R))
			{
				Instantiate(bola,transform.position,Quaternion.identity);
			}
	}
}
