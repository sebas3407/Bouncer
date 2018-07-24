using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.IO;

public class Ranking : MonoBehaviour {

	public Text message;
	public Text message2;
	int cont = 1;
	int total = 1;
	int number = 1;


	String [] names = new String[500];
	int [] scores = new int[500];


	// Use this for initialization
	void Start () {



		string line;  

		// Read the file and display it line by line.  
		System.IO.StreamReader file =   
			new System.IO.StreamReader("scores.txt");  
		while((line = file.ReadLine()) != null)  
		{  
	
		
			String[] partes  = line.Split('#');
			names[cont] = partes[0];
			scores [cont] = Int32.Parse(partes [1]);

			cont++;



		}  

		int e=0,k=0;

		for( k=0;k< scores.Length;k++) {
			for(e=0;e<scores.Length-1-k;e++) {
				if (scores[e]>scores[e+1]) {

					int auxtiempo;
					auxtiempo=scores[e];
					scores[e]=scores[e+1];
					scores[e+1]=auxtiempo;

					String auxapellido;
					auxapellido=names[e];
					names[e]=names[e+1];
					names[e+1]=auxapellido;
				}
			}
		}

		for (int i = names.Length -1 ; i > 0; i--) {


		
			if (names[i] != null && total <= 5) {

		

					message.text = message.text + number + " - " + names[i] + " "+ scores [i] +"\n";
					number++;
				total++;

			


			}
			
			
			if (names[i] != null && (total > 5 && total <= 10)) {

		

					message2.text = message2.text + number + " - " + names[i] + " "+ scores [i] +"\n";
					number++;
				total++;

			


			}
		}

		file.Close();  
		 
	}


	
	// Update is called once per frame
	void Update () {
	
	}
}
