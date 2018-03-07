using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceCollider : MonoBehaviour {
	
	public Collider2D fence;
	public int fenceCount;

	// Use this for initialization
	void Start () {
		fence = GetComponent<Collider2D>();
		fenceCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (fenceCount == 5)
		{
		    fence.enabled = false;
		    Debug.Log("Collider2D.enabled = " + fence.enabled);
		}
	}
}
