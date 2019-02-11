using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyScript : MonoBehaviour {

    public Transform playercar;
    public Text scoreText;
    public static int scoreValue = 0;

    void Start()
    {
        scoreText = GetComponent<Text>();
    }
    // Update is called once per frame
    void Update () {


        Debug.Log(playercar.position.x);

        scoreText.text = "" + scoreValue;

        //scoreValue += scoreValue;

        //money = Int32.Parse(scoreText.text = playercar.position.x.ToString("0"));



	}
    public void Click()
    {
        scoreValue = scoreValue - 30;
    }
}
