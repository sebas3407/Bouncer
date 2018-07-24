using UnityEngine;
using System.Collections;

public class global : MonoBehaviour {

	public GUIStyle Score;
	public GUIStyle Contador;
	public GUIStyle Lives;

//the mainly variables
	
	public static float tiemporestante;
	public static int score = 0;
	public static int vidas = 3;
	public static int nivel = 1;
	public static string name = "";
	public static int die = 0;





	void Start () {
	
	}
	
	// Update is called once per frame

	void Update () {
	}
	
		public int getPuntuacion () {
			
			
			return score;
	}
	
	

	void OnGUI() {
		

		GUI.color = Color.white;
		GUILayout.Label ("Score: " + score.ToString (), Score);
		GUILayout.Label (tiemporestante.ToString (), Contador);

	             
		                
		                }

}
