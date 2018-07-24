using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
public class SplashScreenGame : MonoBehaviour {

	// Use this for initialization
	//public Image splashImage;

	IEnumerator Start()
	{
		//splashImage.canvasRenderer.SetAlpha(0.0f);

	
	//wait 3.5 seconds to load the game
	
		yield return new WaitForSeconds(3.5f);

		
		SceneManager.LoadScene ("Menu");	
	}

	void FadeIn()
	{
	//	splashImage.CrossFadeAlpha(1.0f, 1.5f, false);
	}

	void FadeOut()
	{
	//	splashImage.CrossFadeAlpha(0.0f, 2.5f, false);
	}
}
