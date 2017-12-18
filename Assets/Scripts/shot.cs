using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour {

	public Rigidbody rb;
	public GameObject ball;
	public Camera main;
	Player player;
	public int  points;
	public GameObject song;

	void Start() {
		
		player = FindObjectOfType<Player> ();

	}


	public void OnBallClicked() {

		Instantiate (song, transform.position, Quaternion.Euler (-90,0,0));
		player.points += 1;
		Destroy (gameObject);


	}
}
