using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyAfter : MonoBehaviour {
    private int timer;
	// Use this for initialization
	void Start () {
        timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
        timer++;
		if (timer >= 7500)
        {
            Destroy(gameObject);
        }
	}
}
