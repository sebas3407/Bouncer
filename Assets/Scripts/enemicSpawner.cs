using UnityEngine;
using System.Collections;

public class enemicSpawner : MonoBehaviour {

	public GameObject enemic;

	float maxSpawnRateInSeconds = 5;

	// Use this for initialization
	void Start () {
		Invoke ("spawnEnemic", maxSpawnRateInSeconds);

		//incrementar generacio de enemics cada 10 segons
		InvokeRepeating ("incrementaGeneracioEnemics", 0, 10);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void spawnEnemic(){
		Vector2 min = Camera.main.ViewportToWorldPoint (new Vector2 (0, 0));
		Vector2 max = Camera.main.ViewportToWorldPoint (new Vector2 (1, 0));

		GameObject newEenemic = (GameObject)Instantiate (enemic);
		newEenemic.transform.position = new Vector2 (0,0  );
	
		nouEnemic ();

	}

	void nouEnemic(){
		float spawnInSeconds;

		if (maxSpawnRateInSeconds > 1) {
			spawnInSeconds = Random.Range (1, maxSpawnRateInSeconds);
		} else {
			spawnInSeconds = 1;
		}

		Invoke ("spawnEnemic", spawnInSeconds);
	}


	void incrementaGeneracioEnemics(){
		if (maxSpawnRateInSeconds > 1) {
			maxSpawnRateInSeconds--;
		}
		if (maxSpawnRateInSeconds == 1) {
			CancelInvoke ("incrementaGeneracioEnemics");
		}
	}
}
