using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    public float horizontalInput;
    public float forwardInput;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //Move player forward
        //transform.Translate(Vector3.forward * Time.deltaTime * speed);
        // Move player forward control 
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Move player R/L
       // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
       // Move player R/L with rotate
       transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
