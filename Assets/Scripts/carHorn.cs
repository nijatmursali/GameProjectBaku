using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carHorn : MonoBehaviour {

    [SerializeField] AudioSource hornsound;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Click()
    {
        hornsound.Play();
    }
}
