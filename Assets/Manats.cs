using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manats : MonoBehaviour {

    public int gems = 1;
    // Use this for initialization
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            carController player = collision.GetComponent<carController>();

            if (player != null)
            {
                player.manats += gems;
                Destroy(this.gameObject);
            }
        }
    }
}
