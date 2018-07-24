using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class enemy : MonoBehaviour
{

	// Use this for initialization
	

		public Vector2 atras  = new Vector2(-600,0);

	
	void Start ()
	{

	}


	
	// Update is called once per frame
	void Update ()
	{

		GetComponent<Rigidbody2D> ().AddForce (atras);
		GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
		Vector2 posicion;
		posicion = Camera.main.WorldToScreenPoint (transform.position);

	if (posicion.x < 0 ) {


//if the gameObject is a enemy, then destroy it and add 10 points
	
			if (this.gameObject.tag == "enemy") {
				Destroy (this.gameObject);
					Score.AddPoints (10);

		}
		//
		}

	}

	void OnBecameInvisible ()
	{
	
	}
}
