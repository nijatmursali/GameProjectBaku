using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PoliceOnTrigger : MonoBehaviour {

    [SerializeField] Physics2D policephysics;
    [SerializeField] GameObject car;
    [SerializeField] GameObject police;

    [SerializeField] GameObject secondCanvas;

    // Use this for initialization
    void Start()
    {
        policephysics = GetComponent<Physics2D>();
        police = GetComponent<GameObject>();
        car = GetComponent<GameObject>();
        secondCanvas = GetComponent<GameObject>();

        secondCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D police)
    {

        secondCanvas.SetActive(true);
        //Destroy(car);
        Debug.Log("beng");
    }
    void Click()
    {

    }
}
