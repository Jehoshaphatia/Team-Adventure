using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBall : MonoBehaviour {

	// Use this for initialization

	Player player;
	public int  points;

	void Start () {
		player = FindObjectOfType<Player> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision)
	{
		
		//Check for a match with the specified name on any GameObject that collides with your GameObject
		if (collision.gameObject.name == "Sphere")
		{
			
			player.points += points;
			Destroy(gameObject);

		}
			
}




}
