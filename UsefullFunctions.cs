using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UsefullFunctions : MonoBehaviour {
	static public Vector3 mkVector3(Vector2 vec2, float f){
		return new Vector3 (vec2.x, vec2.y, f);
	}
}
