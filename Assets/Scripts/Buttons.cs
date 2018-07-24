 using UnityEngine;
 using UnityEngine.UI;
 using System.Collections;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {

    
	 
	// Use this for initialization
	void Start () {
	
	}
	
	
	// Update is called once per frame
	void Update () {
	


	}
	
	
	
//Do the function of all buttons

	public void Play(){
	SceneManager.LoadScene ("Game");	
	}
	public void GoMenu(){
		SceneManager.LoadScene ("Menu");	
	}

	public void Instructions(){
	SceneManager.LoadScene ("Instructions");
	}

	public void Scores(){
	SceneManager.LoadScene ("Scores");
	}
	
	public void Register(){
	SceneManager.LoadScene ("Register");
	}


}