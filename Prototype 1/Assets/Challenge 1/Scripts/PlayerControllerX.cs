using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    [SerializeField]
    private float speed = 10.0f;

    [SerializeField]
    private float rotationSpeed = 40f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        var verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(speed * Time.deltaTime * Vector3.forward);

        // tilt the plane up/down based on up/down arrow keys
        if (verticalInput != 0)
            transform.Rotate(verticalInput * rotationSpeed * Time.deltaTime * Vector3.right);
    }
}
