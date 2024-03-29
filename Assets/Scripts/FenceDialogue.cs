﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceDialogue : MonoBehaviour {

	private DialogueManager dMan;
	private DialogueLastManager lMan;
	private CheckpointManager cMan;

	public string[] dialogueLines;
	public string dialogueLine;
	public int count;


	// Use this for initialization
	void Start () {
		dMan = FindObjectOfType<DialogueManager>();
		lMan = FindObjectOfType<DialogueLastManager>();
		cMan = FindObjectOfType<CheckpointManager>();
		count = 0;
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerStay2D(Collider2D other) {
		if (other.gameObject.name == "Player") {
			if (count == 0) {
				//dMan.ShowBox(dialogue);

				if (!dMan.dialogueActive) {
					dMan.dialogueLines = dialogueLines;
					dMan.currentLine = 0;
					dMan.ShowDialogue();
				}
				count += 1;
			}
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (count == 1 || !cMan.cp6) {
			if (!lMan.dialogueActive) {
				lMan.dialogueLine = dialogueLine;
				lMan.ShowDialogue();
			}
		}
	}

	void OnTriggerExit2D(Collider2D other) {
		lMan.dialogueActive = false;
	}
}
