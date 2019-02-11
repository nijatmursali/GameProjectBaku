using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frontwheellight : MonoBehaviour {

    public Light frontwheel;

	// Use this for initialization
	void Start () {
        frontwheel = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
		
        
        if(Input.GetKeyUp(KeyCode.E))
        {
            frontwheel.enabled = !frontwheel.enabled;
        }
        

	}
}
