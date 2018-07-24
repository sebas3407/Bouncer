using UnityEngine;
using System.Collections;

public class EnemyGenerator: MonoBehaviour {

	public GameObject enemy;
	public Transform regenerationposition;
	float regenerationtime = 3f;
	public float cont = 3f;
	// Use this for initialization
	void Start () {
	InvokeRepeating ("regenerar",regenerationtime, regenerationtime);
	}
	
	// Update is called once per frame
	void Update () {

		/*
		cont += Time.deltaTime;
		if(cont>=3){
			InvokeRepeating ("regenerar",regenerationtime, regenerationtime);
			regenerationtime--;
				cont = 0f;
		}
		if(regenerationtime<=0){
			regenerationtime=3;
		}
		*/

	}

 void regenerar() {

		Instantiate (enemy, regenerationposition.position, regenerationposition.rotation);

	}

}
