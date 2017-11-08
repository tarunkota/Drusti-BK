using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.UI;

public class GetScale : MonoBehaviour {

	

	public float screenSize;
	public static float scale;


	public  void  getScreenSize()
	{
		int sc = PlayerPrefs.GetInt("screenSize",0);
		float acuity = PlayerPrefs.GetInt("currentAcuity",200);
		acuity = 200/acuity;
		if(sc==0)
			screenSize=13.3f;
		if(sc==1)
			screenSize=14f;
		if(sc==2)
			screenSize=15.6f;
		screenSize = screenSize*2.54f;
		
		//we got the screen size
		float h = (float) Screen.height;
		float w = (float) Screen.width;
		float d = Mathf.Sqrt(h*h+w*w);
		float physicalHeight = (h*screenSize/d);
		Debug.Log(h);
		Debug.Log(w);
		
		Debug.Log(physicalHeight);

		//for a distance of 40 cm, 20/200 acuity, the size has to be 
		float yo = 87.5f/15.0f;
		scale = yo/physicalHeight*70.0f;
		scale =scale/acuity;
		Debug.Log(scale);
		
	}

	void Awake()
	{
				getScreenSize();
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
