using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class restartonCollision : MonoBehaviour {

    [SerializeField] GameObject car;
    [SerializeField] Physics2D carphy;
    [SerializeField] Button restartButton;
    [SerializeField] Button quitButton;
    [SerializeField] GameObject CanvasOnCollision;
 
	// Use this for initialization
	void Start () {

        car = GetComponent<GameObject>();
        carphy = GetComponent<Physics2D>();
        restartButton = GetComponent<Button>();
        quitButton = GetComponent<Button>();
        CanvasOnCollision = GetComponent<GameObject>();

        CanvasOnCollision.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        CanvasOnCollision.SetActive(true);
        //Destroy(car);\
        DestroyCar();
    }

    public void ClickRestart()
    {
        SceneManager.LoadScene("carScene");
    }

    public void ClickQuit()
    {
        Application.Quit();
    }
    public void DestroyCar()
    {
        Destroy(car);
    }
}
