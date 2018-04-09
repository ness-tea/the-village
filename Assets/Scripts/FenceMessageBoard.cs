using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceMessageBoard : MonoBehaviour {
	
	public Collider2D message;
	public CheckpointManager cMan;

	// Use this for initialization
	void Start () {
	    message = GetComponent<Collider2D>();
	    cMan = FindObjectOfType<CheckpointManager>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (cMan.cp6)
	    {
	         message.enabled = false;  
	    }
	}
}
