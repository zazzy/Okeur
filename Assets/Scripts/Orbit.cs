using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour {

    public float slowDownTo;
    public float speed;
    public GameObject sun;
    private float constantSpeed;
    public float speedReducedBy;
    private ParticleSystem stars;
    public Color starColour;

    public bool nightTime;
    private int days;
    // Use this for initialization
    void Start () {
        constantSpeed = speed;
        Stars();
	}

    void Stars()
    {
        stars = this.gameObject.GetComponentInChildren<ParticleSystem>();
        starColour = stars.main.startColor.color;

        starColour.a = 0;
        stars.startColor = starColour;
    }
	
	// Update is called once per frame
	void Update () {

        if (sun.GetComponent<Transform>().position.y < 0)
        {

            //Debug.Log("night");
            nightTime = true;
            speed = slowDownTo;
            starColour.a += Time.deltaTime * speedReducedBy / 10;
            stars.startColor = starColour;
        }
        else if (sun.GetComponent<Transform>().position.y < 380)
        {//slow down when sun is low

            if (speed >= slowDownTo && sun.GetComponent<Transform>().position.z > 1)
            {

                //star reduction
                starColour.a =0;
                stars.startColor = starColour;

                speed = speed - Time.deltaTime * speedReducedBy;

            }
            if (speed <= constantSpeed && sun.GetComponent<Transform>().position.z < 1)
            {

                starColour.a =0;
                stars.startColor = starColour;

                //speed = speed + Time.deltaTime * speedReducedBy;
            }

        }
        if (sun.GetComponent<Transform>().position.y > 0)
        {
            //Debug.Log("Day");
            nightTime = false;
            days++;
        }



        

        transform.RotateAround(Vector3.zero, Vector3.right, speed * Time.deltaTime);
        transform.LookAt(Vector3.zero);


	}
}
