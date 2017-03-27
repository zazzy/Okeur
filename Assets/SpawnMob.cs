using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMob : MonoBehaviour {

    public GameObject mob;
    public int spawnFrequency;
    private int timer;
    public int destroyAfter;
    private int destroyCheck;
	// Use this for initialization
	void Start () {
        destroyCheck = 0;
	}
	
	// Update is called once per frame
	void Update () {
        timer++;
        if (timer * 3 >= spawnFrequency)
        {
            if (destroyCheck == destroyAfter)
            {
                Destroy(gameObject);
            }

        }
        if (timer >= spawnFrequency)
        {

            Instantiate(mob,GetComponent<Transform>().position,Quaternion.identity);
            destroyCheck++;
            timer = 0;
        }

	}
}
