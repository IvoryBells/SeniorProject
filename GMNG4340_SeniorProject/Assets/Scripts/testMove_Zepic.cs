using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testMove_Zepic : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody rb;
    public Vector3 movement;
    public Text speedText;
    public int num;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        speedText.text = "Speed: " + num;
        num = Mathf.RoundToInt(rb.velocity.magnitude);
    }

    void FixedUpdate()
    {
        moveCharacter(movement);
        if (Input.GetKey(KeyCode.RightShift))
        {
            rb.AddForce(movement * 200);
        }
    }

    void moveCharacter(Vector3 direction)
    {
        rb.AddForce(direction * speed);
    }
}
