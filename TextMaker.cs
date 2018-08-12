using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextMaker : MonoBehaviour {
	private Queue<string> textQueue;
	private string curPrinting;
	private bool isPrinting = false;
	void Update (){
		if (isPrinting)
			return;
	}
	void Print(Queue<string> printMe){
		textQueue = printMe;
	}
}
