using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour {

	public GameObject bombPrefab;

	private float min_x = -2.55f;
	private float max_x = 2.55f;

	// Use this for initialization
	void Start () {
		StartCoroutine(SpawnBombs());
	}

	// a co-routine
	IEnumerator SpawnBombs(){
		// waits 0-1 second before carrying on with code
		yield return new WaitForSeconds(Random.Range(0f, 1f));
		// creates a copy out of a prefab
		Instantiate(bombPrefab, new Vector2(Random.Range(min_x, max_x), 
			transform.position.y), Quaternion.identity);
			// Quaternion position = 0 for every angle (for rotation which has to be passed)
		
		// recursive call to infinitely spawn bombs
		StartCoroutine(SpawnBombs());
	}

}
