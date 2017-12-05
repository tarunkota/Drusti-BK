using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.UI;


public class SaveSettings : MonoBehaviour {
	public Dropdown screenSize;
	public Dropdown visualAcuity;

	public Slider music;
	public Slider sound;

	// Use this for initialization
	void Start () {
		int sc = PlayerPrefs.GetInt("screenSize",0);
		int va = PlayerPrefs.GetInt("visualAcuity",0);
		int mu = PlayerPrefs.GetInt("music",1);
		int so = PlayerPrefs.GetInt("sound",1);



		screenSize.value=sc;
		visualAcuity.value = va;
		music.value = mu;
		sound.value = so;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Save()
	{
		PlayerPrefs.SetInt("screenSize",screenSize.value);
		PlayerPrefs.SetInt("visualAcuity",visualAcuity.value);
		int m=0;
		if(music.value>0.5f)
			m=1;
		int s=0;
		if(sound.value>0.5f)
			s=1;
		PlayerPrefs.SetInt("music",m);
		PlayerPrefs.SetInt("sound",s);

		



	}

}
