using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.UI;


public class SaveSettings : MonoBehaviour {
	public Dropdown screenSize;
	// Use this for initialization
	void Start () {
		int sc = PlayerPrefs.GetInt("screenSize",0);
		screenSize.value=sc;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Save()
	{
		PlayerPrefs.SetInt("screenSize",screenSize.value);
	}

}
