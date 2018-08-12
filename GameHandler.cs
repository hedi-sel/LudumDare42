using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameHandler : MonoBehaviour {

	//Parameters
	[Header("General Settings")]
	public float textSpeed = 10;

	[Header("Game Settings")]
	public float gameSpeed;
	public float characterSpeed;
	public float cursorReach;

	[System.Serializable]
	public class LevelSettings{
		public float spawnRate;
	}

	public LevelSettings[] levels;

	[Header("Assignable objects")]
	public GameObject character;

	private int currentLevel;

	public static GameHandler instance = null;
	void Awake (){
		if (instance == null)
			instance = this;
	}

	private const float aspect = 1280.0F / 720.0F;
	void Start () {
//		Debug.Log (Screen.currentResolution);
//
//		int width = Mathf.Min (Screen.width,(int)(Screen.height * aspect));
//		Screen.SetResolution (width, (int)(width / aspect), Screen.fullScreen);
//		Debug.Log (Screen.currentResolution);
		Camera.main.aspect = aspect; //TODO
		//Camera.main.orthographicSize = Mathf.Min (Camera.main.orthographicSize, 720);

		currentLevel = 0;
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void nextLevel(){
		//Activate the ennemy spawner
	}

	public GameObject getCharacter (){
		return character;
	}
	public LevelSettings getCurrentLevel(){
		return levels [currentLevel];
	}
	public float getCharacterSpeed (){
		return gameSpeed * characterSpeed;
	}
}
