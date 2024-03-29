﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueLastManager : MonoBehaviour {

	public GameObject dBox;
	public Text dText;

	// keeps track of whether dialogue box is on screen
	public bool dialogueActive;

	// to store multiple dialogue lines
	public string dialogueLine;
	public int currentLine;

	private GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag("Player");
	}

	// Update is called once per frame
	void Update () {
		dText.text = dialogueLine;
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
