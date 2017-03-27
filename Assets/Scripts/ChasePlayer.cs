using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasePlayer : MonoBehaviour {

    private GameObject toChase;
    private Transform thisTrans;
    
    public float moveSpeed;
	// Use this for initialization
	void Start () {
        thisTrans = GetComponent<Transform>();
        toChase = GameObject.FindGameObjectWithTag("Player"); // might need to assign this tag to the player collider in the new player prefab 
    }
	
	// Update is called once per frame
	void Update () {
        thisTrans.LookAt(toChase.GetComponent<Transform>().position);
        //Debug.Log(toChase.GetComponent<Transform>().position);
        thisTrans.position += transform.forward * moveSpeed * Time.deltaTime;
        
	}
}
