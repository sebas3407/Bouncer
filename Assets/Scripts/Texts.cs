using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Texts : MonoBehaviour {

	public InputField iField;
	public string myName;
	public Text message;

public void registerName()
	{
		myName = iField.text;            

		if (!myName.Equals(""))
		{
			Debug.Log(myName);
			global.name = myName;			
	SceneManager.LoadScene ("Game");
		}
		
		
		else
		{
			message.text = "To continue enter your initials";
		}
	}
	
}
