using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 40.0f;
    private float horizontalInput; 
    private float forwardInput;
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Move the vehicle forward
        //the vehicle moves in: x, y, z  
        //transform.Translate(0, 0, 1);
        // A more anderstandeble version of the privius line.
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Turnes the vihecle right for the positive numbers and left for negative numbers.
        //transform.Translate(Vector3.right * Time.deltaTime * TurnSpeed * horizontalInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }
}
