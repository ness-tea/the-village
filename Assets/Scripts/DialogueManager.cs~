using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnitySampleAssets._2D;

public class DialogueManager : MonoBehaviour {

	public GameObject dBox;
	public Text dText;

	// keeps track of whether dialogue box is on screen
	public bool dialogueActive;

	// to store multiple dialogue lines
	public string[] dialogueLines;
	public int currentLine;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (dialogueActive && Input.GetKeyDown(KeyCode.Return)) {
			//dBox.SetActive(false);
			//dialogueActive = false;
			currentLine++;
		}
		if (currentLine >= dialogueLines.Length) {
			dBox.SetActive(false);
			dialogueActive = false;

			currentLine = 0;
		}

		dText.text = dialogueLines[currentLine];

	}

	public void ShowBox(string dialogue) {
		dialogueActive = true;
		dBox.SetActive(true);
		dText.text = dialogue;
	}

	public void ShowDialogue() {
		dialogueActive = true;
		dBox.SetActive(true);
	}

}
