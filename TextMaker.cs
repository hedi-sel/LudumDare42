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
		text = this.GetComponent<Text> ();
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
				if (textQueue.Count > 0) {
					curPrinting = textQueue.Dequeue ();
					printIndex = 0;
				} else {
					closeDialog ();
				}
			}
		}
	}

	public void Print(string[] printMe){
		Debug.Assert (textQueue.Count == 0 && isPrinting == false);
		foreach (string str in printMe) {
			textQueue.Enqueue(str);
		}
		isPrinting = true;
		printerTime = 0;
		GetComponent<Renderer> ().enabled = true;
	}

	public void Continue(){
		isPrinting = true;
	}

	private void printChar(char c){
		text.text += c;
	}	

	private void clearText(){
		text.text = "";
	}

	private void closeDialog (){
		GetComponentInParent<Image> ().enabled = false;
	}
}
