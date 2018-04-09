using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint3 : MonoBehaviour {

	private CheckpointManager cMan;
	private Collider2D NPC;

	// Use this for initialization
	void Start () {
		cMan = FindObjectOfType<CheckpointManager>();	
		NPC = GetComponent<Collider2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	
	void OnTriggerStay2D(Collider2D other) {
		if (other.gameObject.name == "Player") {
			cMan.cp3 = true;
		}
	}
