using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour {

    public GameObject toLookAt;
    private Transform thisTrans;

	// Use this for initialization
	void Start () {
        thisTrans = GetComponent<Transform>();


	}
	
	// Update is called once per frame
	void Update () {
        thisTrans.LookAt(toLookAt.GetComponent<Transform>().position);
	}
}
