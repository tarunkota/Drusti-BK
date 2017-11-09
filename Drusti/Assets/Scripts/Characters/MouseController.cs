using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseController : MonoBehaviour {


	public AssignChar characterPrefab;
	public int target;
	public Text heading;
	public Placement placement;
	public GameObject charExplosion;


	public int noOfTargets;
	// Use this for initialization
	void Start () {
		target = Random.Range(0,characterPrefab.sprites.Count);
		heading.text = "Find "+target;
		noOfTargets =placement.place(target);

	}
	
	 void Update()
		{
			if (Input.GetMouseButtonDown(0))
			{
				
				RaycastHit hitInfo = new RaycastHit();
				bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
				if (hit) 
				{
		//			Debug.Log("Hit " + hitInfo.transform.gameObject.name);
					if (hitInfo.transform.gameObject.tag == "Character")
					{
		//				Debug.Log ("It's working!");
						AssignChar ac= hitInfo.transform.gameObject.GetComponent<AssignChar>();
						if(ac.value==target)
						{
							GameObject g = Instantiate(charExplosion);
							g.transform.position = hitInfo.transform.gameObject.transform.position;
							Destroy(hitInfo.transform.gameObject);
							
							Destroy(g,5);
							noOfTargets--;
							if(noOfTargets==0)
								gameOver();
						}

					} else {
		//				Debug.Log ("nopz");
					}
				} else {
		//			Debug.Log("No hit");
				}
		//		Debug.Log("Mouse is down");
			} 
		}


	void gameOver()
	{
		Debug.Log("GameOver");
	}
}
