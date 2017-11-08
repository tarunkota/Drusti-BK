using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoScale : MonoBehaviour {

	public float defaultSize=1;

	// Use this for initialization
	void Start () {
		float s = GetScale.scale/defaultSize;
		transform.localScale = new Vector3(s,s,s);	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
