using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnSheildCollision : MonoBehaviour {
    private GameObject boss;
    public GameObject canDamageThis;
    // Use this for initialization
    void Start () {
        boss = GameObject.FindGameObjectWithTag("Enemy");
    }


    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == canDamageThis.gameObject.tag)
        {
            
            boss.GetComponent<SheildSpawn>().health = boss.GetComponent<SheildSpawn>().health - 1;
            Debug.Log("SHEILD HIT");
        }else
        {

        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
