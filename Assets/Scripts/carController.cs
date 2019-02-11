using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class carController : MonoBehaviour {

    public int manats = 0;

    //for mobile input 
    public Joystick joystick;
    public Button buttonSiren;
    public Button buttonlights;

    public WheelJoint2D frontwheel;
	public WheelJoint2D backwheel;

	JointMotor2D motorFront;
	JointMotor2D motorBack;

	public float speedF;
	public float speedB;

	public float torqueF;
	public float torqueB;


	public bool TractionFront = true;
	public bool TractionBack = true;


	public float carRotationSpeed;

    public AudioSource carsound;
   
    public int[] gearratio;
    public int currentgear;
    public float currentspeed;

    public float mingear;
    public float maxgear;

    // Use this for initialization
    void Start () {

        buttonlights = GetComponent<Button>();
        buttonSiren = GetComponent<Button>();
    
	}
	
	// Update is called once per frame
	void Update () {

        EngineSound();

        

        /*
        if(buttonSiren.enabled)
        {
            carsound.Play();
        }
        */
		if (joystick.Horizontal > 0) {


			if (TractionFront) {
				motorFront.motorSpeed = speedF * -1;
				motorFront.maxMotorTorque = torqueF;
				frontwheel.motor = motorFront;
                MoneyScript.scoreValue += (Mathf.RoundToInt(1f));
                currentspeed = motorFront.motorSpeed + torqueF;
			}

			if (TractionBack) {
				motorBack.motorSpeed = speedF * -1;
				motorBack.maxMotorTorque = torqueF;
				backwheel.motor = motorBack;
                currentspeed = motorBack.motorSpeed + torqueB; //works incorrectly 
			}

		} else if (joystick.Horizontal < 0) {


			if (TractionFront) {
				motorFront.motorSpeed = speedB * -1;
				motorFront.maxMotorTorque = torqueB;
				frontwheel.motor = motorFront;
                currentspeed = motorFront.motorSpeed - speedF;
			}

			if (TractionBack) {
				motorBack.motorSpeed = speedB * -1;
				motorBack.maxMotorTorque = torqueB;
				backwheel.motor = motorBack;
                currentspeed = motorBack.motorSpeed - speedB;
			}

		} else {

			backwheel.useMotor = false;
			frontwheel.useMotor = false;

		}




		if (joystick.Horizontal != 0) {

			GetComponent<Rigidbody2D> ().AddTorque (carRotationSpeed * Input.GetAxisRaw ("Horizontal") * -1);

		}

	}
    public void EngineSound()  {
       int i;
       for(i = 0; i < gearratio.Length; i++)
        {

            if(gearratio[i] > currentspeed) 
            {
                currentgear = i;
                break;
            }

        }
       if(i == 0)
            {
            mingear = 0;
            }
       else
        {
            mingear = gearratio[i - 1];
        }
        maxgear = gearratio[4];

    }

    void EngineRatio()
    {
        mingear = gearratio[0];
        maxgear = gearratio[4];

        if(currentspeed > 60)
        {
            
        }


    }
    public void Click()
    {
        carsound.Play();
    }

}
