using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaytoNightCycle : MonoBehaviour {

    public ParticleSystem partic;
    public Light sun;
    //public Light night;

	// Use this for initialization
	void Start () {

        sun = GetComponent<Light>();
        //night = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {

        if(Time.deltaTime > 5f)
        {
            sun.enabled = !sun.enabled;
            //night.enabled = true;
        }
        /*
        else
        {
            sun.enabled = true;
            night.enabled = false;
        }
        */
        /*
        transform.RotateAround(Vector2.zero, Vector2.right, 5f * Time.deltaTime);
        transform.LookAt(Vector3.zero);
	    */
    }
}
