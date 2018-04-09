using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint6 : MonoBehaviour {

	private DialogueManager dMan;
	private CheckpointManager cMan;

	public string[] dialogueLines;
	public int count = 0;

	private Collider2D NPC;

	// Use this for initialization
	void Start () {
		dMan = FindObjectOfType<DialogueManager>();
		cMan = FindObjectOfType<CheckpointManager>();
		NPC = GetComponent<Collider2D>();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerStay2D(Collider2D other) {
		if (other.gameObject.name == "Player") {
			if (count == 0) {

				if (!dMan.dialogueActive) {
					dMan.dialogueLines = dialogueLines;
					dMan.currentLine = 0;
					dMan.ShowDialogue();
				}
				cMan.cp6 = true;
				count += 1;
			}
		}
	}
}
