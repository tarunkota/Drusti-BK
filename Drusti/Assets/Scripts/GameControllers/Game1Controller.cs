using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Game1Controller : MonoBehaviour {

	public float maxX;
	public float minY,maxY;
	public Enemy enemyPrefab;
	public static Game1Controller instance;
	public int missilesLaunched;
	public Text scoreBoard;
	public Text gameOverText;
	public Text accuracyText;

	int counter;
	int maxCounter;
	
	// Use this for initialization
	void Start () {
		maxCounter = PlayerPrefs.GetInt("game1no",11);
	
		counter=0;
	
		spawnEnemy();
		instance = this;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void spawnEnemy()
	{
		if(counter==maxCounter)
			{
				gameComplete();
				return;
			}
		Enemy e = Instantiate(enemyPrefab) as Enemy;
		e.gameObject.transform.position = new Vector3(Random.Range(-maxX,maxX),0,Random.Range(minY,maxY));
		scoreBoard.text = "Score: "+counter;
		
		counter++;	
		
	}

	public void gameComplete()
	{
		int n = missilesLaunched-maxCounter;
		float accuracy = ((maxCounter-n)*100.0f)/maxCounter;
		Debug.Log(accuracy);
		gameOverText.gameObject.SetActive(true);
		accuracyText.gameObject.SetActive(true);
		int a = (int) accuracy;
		accuracyText.text = "Accuracy: "+ a;
	}

}
