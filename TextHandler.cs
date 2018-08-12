using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextHandler : MonoBehaviour {
	public TextMaker textMaker;

	[System.Serializable]
	public class Character
	{
		public string name;
		public Sprite sprite;
	}
	public Character[] characters;

	[System.Serializable]
	public class Dialog
	{
		public string character;
		public string[] lines;
	}
	public Dialog[] dialogs;

	public static TextHandler instance = null;
	void Awake (){
		if (instance == null)
			instance = this;
	}

	// Use this for initialization
	void Start () {
		textMaker.Print (dialogs[0]);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static Character getCharacter(string name){
		foreach (Character charac in instance.characters)
			if (charac.name == name)
				return charac;
		Debug.LogError ("Character not Found : " + name);
		return null;
	}
}
