using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour {

    [SerializeField] public float timePassed = 0;
    [SerializeField] Text timeText;

	// Use this for initialization
	void Start () {
        
        timeText = GetComponent<Text>();
        
	}
	
	// Update is called once per frame
	void Update () {

        timePassed += Time.deltaTime;
        //timeLeft = timeLeft - 1;

        timeText.text = "" + Mathf.Round(timePassed);

    }
}
