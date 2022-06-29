//link to youtube video https://www.youtube.com/watch?v=-on5HRW8v1A
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniBossPirate : MonoBehaviour 
{
	//private int nextSceneToLoad;

	public Rigidbody2D rb; //reference to itself

	public float moveSpeed = 15.0f; //default move speed of the enemy

	public bool changeDirection = false; //by default set the bool to false

	// Use this for initialization
	void Start () 
	{
		//nextSceneToLoad = (2);

		rb = this.gameObject.GetComponent<Rigidbody2D>(); //make the connection to the reference
	}
	
	// Update is called once per frame
	void Update () {
		moveEnemy ();
	}

	public void moveEnemy()
	{
		if (changeDirection == true) {
			rb.velocity = new Vector2 (1, 0) * -1 * moveSpeed; //get the enemy to move left
		} 
		else if (changeDirection == false) 
		{
			rb.velocity = new Vector2 (1, 0) * moveSpeed; //get the enemy to move right
		}
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.name == "RightWall") 
		{
			changeDirection = true;
		}

		if (col.gameObject.name == "LeftWall") 
		{
			changeDirection = false;
		}
	}
}
