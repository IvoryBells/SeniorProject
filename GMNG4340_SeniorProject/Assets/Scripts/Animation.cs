using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{

    Animator animate;

    int isDriftLeftHash;
    int isDriftRightHash;
    int isDrivingBackwardsHash;


    // Start is called before the first frame update
    void Start()
    {
        animate = GetComponent<Animator>();
        isDriftLeftHash = Animator.StringToHash("isDriftLeft");
        isDriftRightHash = Animator.StringToHash("isDriftRight");
        isDrivingBackwardsHash = Animator.StringToHash("isDriveBackwards");
    }

    // Update is called once per frame
    void Update()
    {
        bool isDriftLeft = animate.GetBool(isDriftLeftHash);
        bool isDriftRight = animate.GetBool(isDriftRightHash);
        bool isDriveBackwards = animate.GetBool(isDrivingBackwardsHash);
        bool driftPress = Input.GetKey("Shift");
        bool leftPress = Input.GetKey("a");
        bool rightPress = Input.GetKey("d");
        bool backPress = Input.GetKey("s");



        // For Chararcters Drifting left
        if(!isDriftLeft && (driftPress && leftPress))
        {
            animate.SetBool(isDriftLeftHash, true);
        }

        if (isDriftLeft && !(driftPress && leftPress))
        {
            animate.SetBool(isDriftLeftHash, false);
        }

        // For Characrters Drifting Right

        if (!isDriftRight && (driftPress && rightPress))
        {
            animate.SetBool(isDriftRightHash, true);
        }

        if (isDriftRight && !(driftPress && rightPress))
        {
            animate.SetBool(isDriftRightHash, false);
        }

        //For Characters Driving Backwards

        if (!isDriveBackwards && backPress)
        {
            animate.SetBool(isDrivingBackwardsHash, true);
        }

        if (isDriveBackwards && !backPress)
        {
            animate.SetBool(isDrivingBackwardsHash, false);
        }
    }
}
