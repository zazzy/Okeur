using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheildSpawn : MonoBehaviour {


    public GameObject[] sheilds;
    public int timeBetweenChanges;
    private int timer;
    private int currentSheild;
    public int health;
    private bool active;

	// Use this for initialization
	void Start () {
        timer = 0;
        currentSheild = 0;
        NewSheild();
        active = true;
    }
	
	// Update is called once per frame
	void Update () {
        checkHealth();
        timer++;
        if(timer >= timeBetweenChanges)
        {
            Debug.Log(health);
            if (active)
            {
               
                NewSheild();
            }

            timer = 0;
        }
        
	}


    void checkHealth()
    {
        if(health <= 0)
        {
            active = false;
            Debug.Log("DEAD");
        }
        if (!active)
        {
            DestroyObject(GameObject.FindGameObjectWithTag("Sheild"));
        }
    }
    void NewSheild()
    {
        int randomNumber = Random.Range(0, sheilds.Length);
        if (randomNumber != currentSheild)
        {
            DestroyObject(GameObject.FindGameObjectWithTag("Sheild"));
            Instantiate(sheilds[randomNumber]);
            currentSheild = randomNumber;
            Debug.Log("The current sheild is: " + currentSheild);
        }
        else
        {
            NewSheild();
        }
    }
}
