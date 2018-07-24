using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
public class SplashScreenDeveloper : MonoBehaviour {

	// Use this for initialization
	public Image splashImage;

	IEnumerator Start()
	{
		splashImage.canvasRenderer.SetAlpha(0.0f);

		FadeIn();
		yield return new WaitForSeconds(2.0f);
		FadeOut();
		yield return new WaitForSeconds(2.5f);
		SceneManager.LoadScene ("SplashScreenGame");	
	}

	void FadeIn()
	{
		splashImage.CrossFadeAlpha(1.0f, 1.5f, false);
	}

	void FadeOut()
	{
		splashImage.CrossFadeAlpha(0.0f, 2.5f, false);
	}
}
