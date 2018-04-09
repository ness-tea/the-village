using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceCollider : MonoBehaviour {
	
	private CheckpointManager cMan;
	public Collider2D fence;

	// Use this for initialization
	void Start () {
		cMan = FindObjectOfType<CheckpointManager>();
		fence = GetComponent<Collider2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (cMan.cp6)
		{
		    fence.enabled = false;
		    Debug.Log("Collider2D.enabled = " + fence.enabled);
		}
	}
}
