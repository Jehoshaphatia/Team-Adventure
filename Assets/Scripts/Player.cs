using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public int points; 
	public GameObject Win;


	void Update () {

		if (points == 10) {

			Win.SetActive(true);
		}
	}
		

	void start () {
		


	}



}
