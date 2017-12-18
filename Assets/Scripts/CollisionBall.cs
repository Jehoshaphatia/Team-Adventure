using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBall : MonoBehaviour {

	Player player;
	public int  points;
	public GameObject ball;

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
			Instantiate (ball);

		}
			
}




}
