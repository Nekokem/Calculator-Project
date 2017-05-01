using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EndCollision : MonoBehaviour {

	public Text gameOverText;


	void Start () 
	{
		gameOverText.text = "";
	}

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.name == "Plane") 
		{
			gameOverText.text = "Game Over!";
		}
	}
		
}