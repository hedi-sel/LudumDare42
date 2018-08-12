using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipMovement : MonoBehaviour {
	public Vector2 direction;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		direction = (Vector2) ( Camera.main.ScreenToWorldPoint (Input.mousePosition)- transform.position);

		if (Input.GetButton ("Move")) {
			float moveDist = Time.deltaTime* GameHandler.instance.getCharacterSpeed();

			if (direction.magnitude > GameHandler.instance.cursorReach)
				direction.Normalize ();
			else
				direction = new Vector2 (0, 0);
			transform.position += UsefullFunctions.mkVector3(moveDist * direction, 0);
		}
	}

	Vector2 mouseToPosition(Vector2 mousePos){ //Asumption : centered at 0, 0;
		return mousePos;
	}
}
