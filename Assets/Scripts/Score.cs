using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {



	Text text;


	void Start () {
	

		text = GetComponent <Text> ();
	
	}
	
	void Update () {

	
		if (global.score < 0) 

			global.score = 0;

		text.text = "" + global.score;



	
	}


	public static void AddPoints ( int pointsToAdd) {


		global.score += pointsToAdd;

	}

	public static void RestartPoints() {

		global.score = 0;
	


	}


}