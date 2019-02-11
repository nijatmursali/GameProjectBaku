using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lampEnabled : MonoBehaviour {

    public Light frontwheel;

 
    public void Click()
    {
        frontwheel.enabled = !frontwheel.enabled;

    }
}
