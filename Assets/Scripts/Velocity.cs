using UnityEngine;
using System.Collections;

public class Velocity : MonoBehaviour {

    GameObject prefab;
    private Rigidbody rb;
    public Vector3 controller_velocity;
	// Use this for initialization
	void Start () {
        

	}
	
	// Update is called once per frame
	void Update () {
        rb.velocity = controller_velocity;

	}
}
