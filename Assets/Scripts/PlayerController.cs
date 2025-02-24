using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{ 
    private float speed = 15.0f;
    private float turnSpeed =25.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      // this is where we get the user input
      horizontalInput = Input.GetAxis("Horizontal");
      forwardInput = Input.GetAxis("Vertical");
      // move the vehicle forward
      transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
      //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
      
      //this turn the vehicle
      transform.Rotate(Vector3.up, turnSpeed * horizontalInput* Time.deltaTime);

    }
}
