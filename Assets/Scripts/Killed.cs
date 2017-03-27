using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killed : MonoBehaviour {

    public GameObject[] canBeKilledBy;
    // Use this for initialization
    void Start () {
		
	}

    private void OnCollisionEnter(Collision collision) // check is the mob attached to this script is hit by anything that can kill it eh swordo or spell, if so then the mod is destroyed.
    {

        for (int i = 0;i< canBeKilledBy.Length; i++)
        {
            //Debug.Log("hell0o" + canBeKilledBy[i].tag);
            //Debug.Log("hello" + collision.gameObject.tag);
            if (collision.gameObject.tag == canBeKilledBy[i].tag)
            {
                Destroy(this.gameObject);
                
            }
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
