using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachHead : MonoBehaviour {


    public GameObject cam;
    private Transform thisTransfo;
	// Use this for initialization
	void Start () {
        thisTransfo = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        thisTransfo.position = cam.GetComponent<Transform>().position;
        thisTransfo.rotation = cam.GetComponent<Transform>().rotation;
        thisTransfo.position = cam.GetComponent<Transform>().position;
    }
}
