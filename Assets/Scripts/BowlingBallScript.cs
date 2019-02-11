using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingBallScript : MonoBehaviour {

    [SerializeField] Physics2D ballphysics;
    [SerializeField] DistanceJoint2D distance;
    [SerializeField] GameObject car;
    [SerializeField] GameObject ball;
    [SerializeField] CircleCollider2D circle;

	// Use this for initialization
	void Start () {
        ballphysics = GetComponent<Physics2D>();
        distance = GetComponent<DistanceJoint2D>();
        ball = GetComponent<GameObject>();
        car = GetComponent<GameObject>();
        circle = GetComponent<CircleCollider2D>();
	}

    // Update is called once per frame
    void Update() {

        

	}

    private void OnCollisionEnter2D(Collision2D ball)
    {
        Destroy(car);
    }

}
