using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public string verticalAxisName = "Vertical";
    public string horizontalAxisName = "Horizontal";
    public string brakingKey = "Brake";


    [HideInInspector] public float thruster;
    [HideInInspector] public float rudder;
    [HideInInspector] public bool isBraking;


    // Update is called once per frame
    void Update()
    {
        //Exit game once Escape kay is pressed.
        if (Input.GetButtonDown("Cancel") && !Application.isEditor)
            Application.Quit();
        /*
        if(GameManager.instace != null && !GameManager.instance.isActiveGame())
        {

            thruster = rudder = 0f;
            isBraking = false;
            return;

        }
        */

        thruster = Input.GetAxis(verticalAxisName);
        rudder = Input.GetAxis(horizontalAxisName);
        isBraking = Input.GetButton(brakingKey);






    }
}
