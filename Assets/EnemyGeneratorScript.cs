using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGeneratorScript : MonoBehaviour {

    public GameObject enemyPrefab;

	// Use this for initialization
	void Start () {

        //Instantiate(enemy);
        GameObject enemy = Instantiate(enemyPrefab, new Vector3(0,0,0), Quaternion.identity) as GameObject;
        enemy.transform.parent = transform;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
