using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placement : MonoBehaviour {

	//we know the height of screen is 70
	public GameObject randomCharacter;
	

	// Use this for initialization
	void Start () {

	}
	

	public int place(int target)
	{
		int counter =0;
		float s = GetScale.scale;
		int numberOfRows = (int)(140/s)-1;
		int numberOfColumns = (int)(numberOfRows*1.6f);
		Debug.Log("no: "+numberOfRows);
		//
		int n = numberOfRows/2;
		int m = numberOfColumns/2 ;
		for(int i=0;i<numberOfRows;i++)
		{
			for(int j=0;j<numberOfColumns+1;j++)
			{	GameObject g = Instantiate(randomCharacter);
				g.transform.position = new Vector3(j*s-m*s,i*s-n*s,0);
				if(target==g.GetComponent<AssignChar>().value)
					counter++;
			}
		}
		return counter;
	}

	// Update is called once per frame
	void Update () {
	}
}
