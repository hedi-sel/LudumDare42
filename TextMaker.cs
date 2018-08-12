using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextMaker : MonoBehaviour {
	
	private Text text;
	private Queue<string> textQueue = new Queue<string> ();
	private string curPrinting = "";
	private int printIndex = 0;
	private bool isPrinting = false;
	private float printerTime;

	void Awake(){
		text = this.GetComponentsInChildren<Text> ()[0];
	}

	void Update (){
		if (isPrinting) {
			printerTime += Time.deltaTime;
			while (printerTime > 0 && curPrinting.Length > printIndex) {
				printChar(curPrinting [printIndex]);
				printerTime -= 1 / GameHandler.instance.textSpeed;
				printIndex += 1;
			}
			if (curPrinting.Length <= printIndex) {
				isPrinting = false;
				if (textQueue.Count == 0)
					closeDialog ();
			}
		}

		if (Input.GetButtonDown ("Move"))
			Continue ();
	}

	public void Print(TextHandler.Dialog printMe){
		Debug.Assert (textQueue.Count == 0 && isPrinting == false);
		foreach (string str in printMe.lines) {
			textQueue.Enqueue(str);
		}

		isPrinting = true;
		printerTime = 0;

		this.GetComponentInChildren<Image> ().enabled = true;
		this.GetComponentInChildren<SpriteRenderer> ().enabled = true;
		this.GetComponentInChildren<SpriteRenderer> ().sprite = TextHandler.getCharacter(printMe.character).sprite;
	}

	public void Continue(){
		if (!isPrinting && textQueue.Count > 0) {
			curPrinting = textQueue.Dequeue ();
			printIndex = 0;
			isPrinting = true;
		} else {
			text.text = curPrinting;
			curPrinting = "";
		}
	}

	private void printChar(char c){
		text.text += c;
	}	

	private void clearText(){
		text.text = "";
	}

	private void closeDialog (){
		GetComponentInChildren<Image> ().enabled = false;
		GetComponentInChildren<SpriteRenderer> ().enabled = false;
		GameHandler.instance.nextLevel ();
	}
}
