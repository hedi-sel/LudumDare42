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
		public Image image;
	}

	public Character[] characters;

	public string[][] dialogs;

	// Use this for initialization
	void Start () {
		textMaker.Print (dialogs [0]);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
