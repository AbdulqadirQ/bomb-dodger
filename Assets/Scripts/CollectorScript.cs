using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectorScript : MonoBehaviour {

	public Text score_text;
	private int score = 0;

	void IncreaseScore(){
		score++;
		score_text.text = "Score: " + score;
	}

	void OnTriggerEnter2D(Collider2D target){
		if(target.tag == "Bomb"){
			IncreaseScore();
			target.gameObject.SetActive(false);
		}
	}
}
