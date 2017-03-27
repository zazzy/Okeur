using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour {


    public GameObject cloudsToSpawn;
    private int spawnTimer;
    public int toReach;
    private bool started;
    private float myTimer;
	// Use this for initialization
	void Start () {
        spawnTimer = 1;
        started = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (myTimer >= 700 && started == false)
        {
            Instantiate(cloudsToSpawn);
            started = true;
        }
        else if (myTimer >= toReach)
        {
            Instantiate(cloudsToSpawn);
            myTimer = 0;
        }
        myTimer += spawnTimer + Time.deltaTime;
        //Debug.Log(myTimer);
	}
}
