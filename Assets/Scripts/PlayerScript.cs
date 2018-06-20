using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public float speed = 10f;
	private float min_x = -2.55f;
	private float max_x = 2.55f;
	
	// Update is called once per frame
	void Update () {
		MovePlayer();
	}

	void MovePlayer(){
		// -/+ value when pressing 'A' or 'D'
		float h = Input.GetAxis ("Horizontal");
		// Vector2 stores x and y axis of an asset
		// set current_position to value of player object's current axis values (x and y)
		Vector2 current_position = transform.position; // temporary position of player object

		if (h > 0){
			// move player to left side by adding to x-axis
			current_position.x += speed * Time.deltaTime;

		} else if(h < 0){
			// move player to right side by subtracting from x-axis
			current_position.x -= speed * Time.deltaTime;
		}

		if (current_position.x < min_x){
			current_position.x = min_x;
		}
		if (current_position.x > max_x){
			current_position.x = max_x;
		}

		// setting the actual object position to value after changing x-axis
		transform.position = current_position;
	}

	void OnTriggerEnter2D(Collider2D target){
		if(target.tag == "Bomb"){
			// pauses games
			Time.timeScale = 0f;
		}
	}
}
