using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 direction = GetComponentInParent<CharacterControls> ().direction;
		if (direction.magnitude > GameHandler.instance.cursorReach) {
			this.GetComponent<SpriteRenderer> ().enabled = true;
			transform.eulerAngles = new Vector3 (0, 0, Mathf.Atan (direction.y / direction.x) * 180 / Mathf.PI + ((direction.x < 0) ? 180: 0));
		} else {
			this.GetComponent<SpriteRenderer> ().enabled = false;
			transform.eulerAngles = new Vector3 (0, 0, 0);
		}

	}
}
