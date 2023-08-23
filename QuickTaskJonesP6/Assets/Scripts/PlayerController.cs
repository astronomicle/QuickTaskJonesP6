using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    private float speed = 10f;
    private float xRange = 21f;
    private Vector3 jump;
    private float jumpForce = 3.0f;
    //Using stackoverflow treasure dev script for jumping
    public bool isGrounded;
    Rigidbody rb;
    Vector3 YAxis;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 3.0f, 0.0f);
        YAxis = new Vector3(0, 0, 0);
        rb.constraints = RigidbodyConstraints.FreezeRotation;
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }

    void Update()
    {
        //Left right movement
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        //x boundaries
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        //Jumping
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }
}
