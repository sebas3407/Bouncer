﻿using System.Collections.Generic;
using System.Linq;
using UnityEngine;
/// Parallax scrolling script that should be assigned to a layer
public class scrolling : MonoBehaviour{
	/// Scrolling velocitat
	public Vector2 velocitat = new Vector2(10, 10);
	/// Moving direccio
	public Vector2 direccio = new Vector2(-1, 0);
	/// Movement should be applied to camera
	public bool isLinkedToCamera = false;

	/// 1 - Background is infinite
	public bool isLooping = false;

	/// 2 - List of children with a renderer.
	private List<SpriteRenderer> backgroundPart;

	// 3 - Get all the children
	void Start(){
		// For infinite background only
		if (isLooping){
			// Get all the children of the layer with a renderer
			backgroundPart = new List<SpriteRenderer>();
			for (int i = 0; i < transform.childCount; i++){
				Transform child = transform.GetChild(i);
				SpriteRenderer r = child.GetComponent<SpriteRenderer>();
				// Add only the visible children
				if (r != null){
					backgroundPart.Add(r);
				}
			}
			// Sort by position.
			// Note: Get the children from left to right.
			// We would need to add a few conditions to handle
			// all the possible scrolling direccios.
			backgroundPart = backgroundPart.OrderBy(
				t => t.transform.position.x
			).ToList();
		}
	}

	void Update(){
		// moviment
		Vector3 moviment = new Vector3(velocitat.x * direccio.x,velocitat.y * direccio.y,0);
		moviment *= Time.deltaTime;
		transform.Translate(moviment);

		// Move the camera
		if (isLinkedToCamera){
			Camera.main.transform.Translate(moviment);
		}

		// 4 - Loop
		if (isLooping){
			// Get the first object.
			// The list is ordered from left (x position) to right.
			SpriteRenderer firstChild = backgroundPart.FirstOrDefault();

			if (firstChild != null){
				// Check if the child is already (partly) before the camera.
				// We test the position first because the IsVisibleFrom
				// method is a bit heavier to execute.
				if (firstChild.transform.position.x < Camera.main.transform.position.x)	{
					// If the child is already on the left of the camera,
					// we test if it's completely outside and needs to be
					// recycled.
					if (firstChild.IsVisibleFrom(Camera.main) == false)	{
						// Get the last child position.
						SpriteRenderer lastChild = backgroundPart.LastOrDefault();

						Vector3 lastPosition = lastChild.transform.position;
						Vector3 lastSize = (lastChild.bounds.max - lastChild.bounds.min);

						// Set the position of the recyled one to be AFTER
						// the last child.
						// Note: Only work for horizontal scrolling currently.
						firstChild.transform.position = new Vector3(lastPosition.x + lastSize.x, firstChild.transform.position.y, firstChild.transform.position.z);

						// Set the recycled child to the last position
						// of the backgroundPart list.
						backgroundPart.Remove(firstChild);
						backgroundPart.Add(firstChild);
					}
				}
			}
		}
	}
}