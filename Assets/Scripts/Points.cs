using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour {

	Player player;
	public Text pointstext;

	// Use this for initialization
	void Start () {

		player = FindObjectOfType<Player> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		pointstext.text = ("Points: " + player.points);
		
	}
}
