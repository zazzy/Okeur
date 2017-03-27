using UnityEngine;
using System.Collections;
using System;

public class LeftController : MonoBehaviour {

    private Valve.VR.EVRButtonId triggerButton = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;

    private SteamVR_TrackedObject trackedObject;
    private SteamVR_Controller.Device device;
    private SteamVR_TrackedController controller;
    private Vector3 vel;
    public GameObject projectileBlue;
    public GameObject projectileGreen;
    public GameObject projectileBlack;
    private GameObject myProjectile;
    public GameObject cont;


	// Use this for initialization
	void Start () {
        trackedObject = GetComponent<SteamVR_TrackedObject>();
        controller = GetComponent<SteamVR_TrackedController>();
        controller.PadClicked += Controller_PadClicked; // adds method to delegate. 
        myProjectile = projectileBlue;
	}

    private void Controller_PadClicked(object sender, ClickedEventArgs e)
    {
        if (device.GetAxis().x > 0 && device.GetAxis().y > 0)
        {
            Debug.Log("Top Right");
            myProjectile = projectileGreen;
        }
        if (device.GetAxis().x < 0 && device.GetAxis().y < 0)
        {
            Debug.Log("Bottom Left");
        }
        if (device.GetAxis().x > 0 && device.GetAxis().y < 0)
        {
            Debug.Log("Bottom Right");
            myProjectile = projectileBlack;
        }
        if (device.GetAxis().x < 0 && device.GetAxis().y > 0)
        {
            Debug.Log("Top Left");
            myProjectile = projectileBlue;
        }
    }

    void fireObj()
    {
        device = SteamVR_Controller.Input((int)trackedObject.index);
        vel = device.velocity;
        if (device.GetPressDown(triggerButton))
        {
            Debug.Log("Trigger button pressed(LEFT).");
            float totalVel = device.velocity.x + device.velocity.y + device.velocity.z;
            totalVel = Mathf.Abs(totalVel);
            if (totalVel > 1)
            {
                GameObject project = Instantiate(myProjectile);
                project.transform.position = cont.transform.localToWorldMatrix.GetPosition();

                project.GetComponent<Rigidbody>().velocity = device.velocity * 2;
                //Debug.Log(totalVel);
            }




        }

    }
    // Update is called once per frame
    void Update () {
        fireObj(); // needs fixed veers off to the side


        //Debug.Log(vel);
	}
}
