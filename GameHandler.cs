using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameHandler : MonoBehaviour {
	public static GameHandler instance = null;

	//Parameters
	public float textSpeed = 10;

	public float gameSpeed;
	public float characterSpeed;
	public float cursorReach;

	[System.Serializable]
	public class LevelSettings{
		public float spawnRate;
	}

	public LevelSettings[] levels;

	public LevelSettings currentLevel;

	private const float aspect = 1280.0F / 720.0F;
	void Awake (){
		if (instance == null)
			instance = this;
	}
	// Use this for initialization
	void Start () {
//		Debug.Log (Screen.currentResolution);
//
//		int width = Mathf.Min (Screen.width,(int)(Screen.height * aspect));
//		Screen.SetResolution (width, (int)(width / aspect), Screen.fullScreen);
//		Debug.Log (Screen.currentResolution);
		Camera.main.aspect = aspect; //TODO
		//Camera.main.orthographicSize = Mathf.Min (Camera.main.orthographicSize, 720);
	}
	
	// Update is called once per frame
	void Update () {
	}

	public float getCharacterSpeed (){
		return gameSpeed * characterSpeed;
	}
}
