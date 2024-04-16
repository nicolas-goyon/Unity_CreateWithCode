using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    private float speed = 10.0f;

    [SerializeField]
    private float leftBound = -10.0f;

    [SerializeField]
    private float rightBound = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        Vector3 horizontalDelta = horizontalInput * speed * Time.deltaTime * Vector3.right;

        if (transform.position.x + horizontalDelta.x < rightBound && transform.position.x + horizontalDelta.x > leftBound) {
            transform.Translate(horizontalDelta);
        }
        else if (transform.position.x + horizontalDelta.x > rightBound) {
            transform.position = new Vector3(rightBound, transform.position.y, transform.position.z);
        }
        else if (transform.position.x + horizontalDelta.x < leftBound) { 
            transform.position = new Vector3(leftBound, transform.position.y, transform.position.z);
        }
    }
}
