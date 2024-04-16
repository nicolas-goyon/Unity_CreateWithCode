using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleMovements : MonoBehaviour
{

    [SerializeField] 
    private float speed = 20f;

    [SerializeField]
    private float turnSpeed = 20f;

    private float horizontalAxis;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       // Move the vehicle forward
       var forwardInput = Input.GetAxis("Vertical");
        transform.Translate(forwardInput * speed * Time.deltaTime * Vector3.forward);
        
        // Turn the vehicle left and right
        horizontalAxis = Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.up, horizontalAxis * turnSpeed * Time.deltaTime);
    }
}
