using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attachBody : MonoBehaviour {

    public GameObject head;
    private Transform thisTransform;
    // Use this for initialization
    void Start () {
        thisTransform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        thisTransform.rotation =new Quaternion(0,head.GetComponent<Transform>().rotation.y, 0, head.GetComponent<Transform>().rotation.w);
        thisTransform.position = new Vector3(head.GetComponent<Transform>().position.x, head.GetComponent<Transform>().position.y-1, head.GetComponent<Transform>().position.z);
    }
}
