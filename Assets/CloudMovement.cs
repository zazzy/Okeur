using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovement : MonoBehaviour {


    public int moveSpeed;
    private Transform thisTrans;
    public int positionToRemoveAt;
	// Use this for initialization
	void Start () {
        thisTrans = this.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        thisTrans.position += transform.forward * moveSpeed * Time.deltaTime;
        if(thisTrans.position.z >= positionToRemoveAt) //recommend 400
        {
            Destroy(gameObject);
        }
	}
}
