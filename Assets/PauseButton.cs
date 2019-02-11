using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour {

    public void Pause() {

        if(Time.timeScale == 1)
        {
            Time.timeScale = 0;

        }
        else if(Time.timeScale == 0) 
        {
            Time.timeScale = 1;
        }

    }
}
