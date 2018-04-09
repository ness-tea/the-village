using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint5 : MonoBehaviour {

	private Collider2D berryFarm;
	private CheckpointManager cMan;

	// Use this for initialization
	void Start () {
		berryFarm = GetComponent<Collider2D>();
		cMan = FindObjectOfType<CheckpointManager>();
	}
	
	// Update is called once per frame
	void Update () {
		if (cMan.cp4) {
			cMan.cp5 = true;
			berryFarm.enabled = false;
			Debug.Log("Checkpoint5 achieved, Berry Farm Fence disabled");
		}			
	}
}
