using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RacecarController : MonoBehaviour
{
    public InputActionReference steer;
    public InputActionReference gas;
    public InputActionReference drift;
    public InputActionReference boost;
    

    public Rigidbody rb;
    public float maxSpeed;
    public float rotationSpeed;
    public GameObject driftObject;
    public float moveSpeed;
    public float turnSpeed;
    public float rotateTurnSpeed;

    public float timer = 0.0f;
    public float boostTimer = 5000f;
    public bool boosted;

    public float _steer;
    public bool _gas;
    public bool _drift;
    public bool _boost;

    // Start is called before the first frame update
    void Start()
    {
        steer.asset.Enable();
    }

    // Update is called once per frame
    void OnGUI()
    {

        _steer = steer.ToInputAction().ReadValue<float>();
        _gas = gas.ToInputAction().ReadValue<float>() > 0;
        _drift = drift.ToInputAction().ReadValue<float>() > 0;
        _boost = boost.ToInputAction().ReadValue<float>() > 0;

        //GUILayout.Label(_steer.ToString());
        GUILayout.Label(_gas.ToString());
        GUILayout.Label(_drift.ToString());
        GUILayout.Label(_boost.ToString());
    }


    void FixedUpdate()
    {
        //Drift Boost
        if (_drift == false && timer >= 1f)
        {
            rb.AddForce(transform.forward * 1000);
            timer = 0.0f;
        }

        if (_drift == false)
        {
            moveSpeed = 15f;
            timer = 0.0f;
        }



        //Boost and the boost cooldown
        /*if (boosted == true)
        {
            boostTimer -= Time.deltaTime;

            if (boostTimer < 0)
            {
                boostTimer = 5000f;
                boosted = false;
            }
        }

        if (_boost == true && boostTimer == 5000f)
        {
            rb.AddForce(transform.forward * 2000);
            boosted = true;
        }*/



        //This normalizes the speed when you hit the max speed
        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
            Debug.Log("Hit max speed");
        }


        //Gas
        if (_gas == true)
        {
            rb.AddForce(transform.forward * moveSpeed);
        }



        //Drifting
        if (_steer < 0 && _drift == true)
        {
            timer += Time.deltaTime;
            moveSpeed = 7f;
            this.transform.RotateAround(driftObject.transform.position, -Vector3.up, rotationSpeed);
        }
        if (_steer > 0 && _drift == true)
        {
            timer += Time.deltaTime;
            moveSpeed = 7f;
            this.transform.RotateAround(driftObject.transform.position, Vector3.up, rotationSpeed);
        }



        //Turning to the left or right
        if (_steer < 0 && _drift == false)
        {
            this.transform.Translate(Vector3.left * turnSpeed * Time.deltaTime, Space.Self);
            this.transform.RotateAround(driftObject.transform.position, -Vector3.up, rotateTurnSpeed);
        }
        if (_steer > 0 && _drift == false)
        {
            this.transform.Translate(Vector3.right * turnSpeed * Time.deltaTime, Space.Self);
            this.transform.RotateAround(driftObject.transform.position, Vector3.up, rotateTurnSpeed);
        }
    }
}
