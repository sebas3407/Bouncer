using UnityEngine;
using System.Collections;
using UnityEngine.UI;
 
public class Pause : MonoBehaviour
{

	// Use this for initialization
	
	public Button bt;
	public Vector2 atras = new Vector2 (-300, 0);
	public int pausegame = 1;
	public bool die = false;


	void Start ()
	{		


		bt.gameObject.SetActive (false);		
	}

	void Update ()
	{
	
	
		if (global.die == 0) {

			if (Input.GetKeyDown (KeyCode.P)) {

		

				if (pausegame == 1) {
					Time.timeScale = 0;
					bt.gameObject.SetActive (true);
					pausegame = 0;
				} else if (pausegame == 0) {
					pausegame = 1;
					Time.timeScale = 1;
					bt.gameObject.SetActive (false);
				}

			}
		}
	}

	public void pausebutton(){
		Time.timeScale = 1;
		bt.gameObject.SetActive (false);
		pausegame = 1;
		
	}

}
