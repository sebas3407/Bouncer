using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.IO;

public class MaxScore : MonoBehaviour {
	public Text maxScore;

	int count = 1;
	int numero = 1;


	String [] names = new String[500];
	int [] scores = new int [500];
	int iMaxNumber;
 


	void Start () {
		iMaxNumber = scores[0];
	

		string line;  

		// Read the file and display it line by line.  
		System.IO.StreamReader file =   
			new System.IO.StreamReader("scores.txt");  
		while((line = file.ReadLine()) != null)  
		{  


			String[] partes  = line.Split('#');
			names[count] = partes[0];
			scores [count] = int.Parse(partes [1]);

			count++;



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

	for (int x=1;x<scores.Length;x++){
		
		if (scores[x]>iMaxNumber){
   iMaxNumber = scores[x];

} 

maxScore.text = "Max Score: " +iMaxNumber;
		
		
	}


		file.Close();  
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
