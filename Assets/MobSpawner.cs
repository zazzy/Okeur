using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobSpawner : MonoBehaviour {

    public int betweenSpawns;
    public bool spawning;
    private int timer;
    public GameObject portalToInstantiate;
    public GameObject[] spawnPoints;
    
	// Use this for initialization
	void Start () {
        timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (spawning)
        {
            timer++;
            if(timer == betweenSpawns)
            {
                timer = 0;
                Instantiate(portalToInstantiate, spawnPoints[Random.Range(0,spawnPoints.Length)].transform.position, Quaternion.identity);
            }
        }
	}
}
