using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game1Controller : MonoBehaviour {

	public float maxX;
	public float minY,maxY;
	public Enemy enemyPrefab;
	public static Game1Controller instance;
	// Use this for initialization
	void Start () {
		spawnEnemy();
		instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void spawnEnemy()
	{
		Enemy e = Instantiate(enemyPrefab) as Enemy;
		e.gameObject.transform.position = new Vector3(Random.Range(-maxX,maxX),0,Random.Range(minY,maxY));
		
	}

}
