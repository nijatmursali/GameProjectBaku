using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarStartSound : MonoBehaviour {

    public AudioSource carStart;


	// Use this for initialization
	void Start () {
        
	}

    // Update is called once per frame
     void Update()
    {
        carStart.Play();
    }

}
