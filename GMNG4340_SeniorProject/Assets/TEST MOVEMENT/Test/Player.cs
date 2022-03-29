using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public TestControls playerInput;
    public float maxSpeed;
    public float rotationSpeed;

    public GameObject driftObject;


    public Vector2 i_movement;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        playerInput = new TestControls();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
            Debug.Log("Hit max speed");
        }
        
    }

    void Move()
    {
        rb.AddForce(transform.forward * moveSpeed);
    }

    void OnMove(InputValue value)
    {
        i_movement = value.Get<Vector2>();
        Move();
    }

    void OnDrift()
    {
        if (i_movement.x != 0)
        {
            Debug.Log("Can Drift!!!");
            if (i_movement.x < 0)
            {
                this.transform.RotateAround(driftObject.transform.position, -Vector3.up, rotationSpeed);
            }
        }
        else
        {
            Debug.Log("Can't Drift");
        }
    }
}
