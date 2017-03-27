using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {


    public float spawnTimer;
    public bool alive;
    private float time;

    
	// Use this for initialization
	void Start () {
        time = 0;
	}
	
	// Update is called once per frame
	void Update () {

        time++;

        if (!alive || spawnTimer == time)
        {
            Destroy(gameObject);
        }
	}
}
