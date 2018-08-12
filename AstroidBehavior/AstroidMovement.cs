using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidMovement : MonoBehaviour {
	public Vector2 direction;

	// Use this for initialization
	void Start () {
		Vecotr2 screenWidth = GameHandler.getScreenMax();
		
		Random rand = new Random();
		if (rand.Next(0, 2) == 0)
			transform.position = new Vecotr2(screenWidth.x*Random.value,screenWidth.y -0.5)
		else
			transform.position = new Vecotr2(screenWidth.x*Random.value, -screenWidth.y +0.5)
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y>0)
			transform.position = Vector2.MoveTowards (transform.position, Vector2 (transform.position.x, transform.position.y-0.5, Time.deltaTime * GameHandler.LevelSettings.astroidSpeed));
		else :
			transform.position = Vector2.MoveTowards (transform.position, Vector2 (transform.position.x, transform.position.y+0.5, Time.deltaTime * GameHandler.LevelSettings.astroidSpeed));
	}
}
