using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

	public Vector2 adelante = new Vector2 (0, 0);
	public Vector2 jump = new Vector2 (10, 0);
	private bool doublejump = true;
	public Button btscores;
	public Button btplayagain;
 


	// Use this for initialization
	void Start ()
	{
		Time.timeScale = 1;
		btscores.gameObject.SetActive (false);
		btplayagain.gameObject.SetActive (false);
		Score.RestartPoints ();

	
	}
	
	// Update is called once per frame
	void Update ()
	{



		if (Input.GetKeyDown (KeyCode.UpArrow) && doublejump == true) {
			GetComponent<Rigidbody2D> ().AddForce (jump);
			doublejump = false;

		}
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "enemy") {
			
			Morir ();
		}
		
		if (other.gameObject.tag == "suelo") {
			
			doublejump = true;
			
		}
	}
	
	void OnCollisionEnter2D (Collision2D other)
	{


		if (other.gameObject.tag == "enemy") {
			
			Morir ();
		}
		
		if (other.gameObject.tag == "suelo") {
			
			doublejump = true;
	
		}

	}
	
	void Morir ()
	{

	//	SceneManager.LoadScene ("Scores");
		using (System.IO.StreamWriter file = 
		    new System.IO.StreamWriter("scores.txt",true)) {			   
			file.WriteLine (global.name + "#" + global.score);
			btscores.gameObject.SetActive(true);
			btplayagain.gameObject.SetActive(true);
			Time.timeScale = 0;
			global.die = 1;

		}		
	}
}


