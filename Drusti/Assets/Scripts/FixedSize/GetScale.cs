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
		int va = PlayerPrefs.GetInt("visualAcuity",0);
		
		int a=800;
		switch (va)
		{
			case 0 :
				a= 800;
				break;
			case 1 :
				a= 400;
				break;
			case 2 :
				a= 200;
				break;
			case 3 :
				a= 100;
				break;
			case 4 :
				a= 80;
				break;
			case 5 :
				a= 60;
				break;
			case 6 :
				a= 40;
				break;
			case 7 :
				a= 30;
				break;
			case 8 :
				a= 25;
				break;
			case 9 :
				a= 20;
				break;
		}

		float acuity = a;
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
		Debug.Log("height in pixels: "+h);
		Debug.Log(w);
		
		Debug.Log("physical Height of screen in cm: "+physicalHeight);

		//for a distance of 40 cm, 20/200 acuity, the size has to be 
		//8.75 cm for 20 feet for 200 acuity
		//
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
