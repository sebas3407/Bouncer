using UnityEngine;
using System.Collections;

public class objectgenerator: MonoBehaviour {

	public GameObject enemigo;
	public Transform posicionregeneramiento;
	public float tiemporegeneramiento = 3f;
	public float cont = 3f;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("regenerar",tiemporegeneramiento, tiemporegeneramiento);

	}
	
	// Update is called once per frame
	void Update () {
	/*

		cont += Time.deltaTime;
		if(cont>=3){
			InvokeRepeating ("regenerar",tiemporegeneramiento, tiemporegeneramiento);
			tiemporegeneramiento--;
				cont = 0f;
		}
		if(tiemporegeneramiento<=0){
			tiemporegeneramiento=3;
		}

*/

	}




 void regenerar() {

		Instantiate (enemigo, posicionregeneramiento.position, posicionregeneramiento.rotation);

	}

}
