using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public float thrust, maxVelocity;
    public float turnSpeed;

    Rigidbody2D rb;

    void forwardMovement() {
        //transform.position += transform.up * Time.deltaTime * moveSpeed;
        rb.velocity = Vector2.ClampMagnitude(rb.velocity, maxVelocity);
        rb.AddForce(transform.up * thrust * Time.deltaTime);
    }
    
    void turnLeft() {        
        transform.Rotate(0f, 0f, turnSpeed*Time.deltaTime, Space.Self);
    }

    void turnRight() {
        transform.Rotate(0f, 0f, -turnSpeed*Time.deltaTime, Space.Self); // turnSpeed negative to turn right
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") > 0 || Input.GetKey(KeyCode.W))
            forwardMovement();
        if (Input.GetAxis("Horizontal") < 0 || Input.GetKey(KeyCode.A))
            turnLeft();
        if (Input.GetAxis("Horizontal") > 0 || Input.GetKey(KeyCode.D))
            turnRight();
        // if (Input.GetKey(KeyCode.W)) 
        //     forwardMovement();
        // if (Input.GetKey(KeyCode.A))
        //     turnLeft();
        // if (Input.GetKey(KeyCode.D))       
        //     turnRight();
        // Debug.Log(rb.velocity.magnitude);
    }
}
