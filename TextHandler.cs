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
		public Sprite image;
	}
	public Character[] characters;

	[System.Serializable]
	public class Dialog
	{
		public string character;
		public string[] lines;
	}
	public Dialog[] dialogs;

	// Use this for initialization
	void Start () {
		textMaker.Print (dialogs[0]);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
