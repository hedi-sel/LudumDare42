using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControls : MonoBehaviour {
	public Vector2 direction;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector2.MoveTowards (transform.position, new Vector2 (transform.position.x, GameHandler.instance.character.transform.position.y), Time.deltaTime * 3);
	}
}
